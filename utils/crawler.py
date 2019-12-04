import requests
import time
import sys
from bs4 import BeautifulSoup


class Link:
    def __init__(self, url, internal=False):
        self.url = url
        self.internal = internal
        self.status_code = 0
        self.content = ''
        self.processed = False

    def __str__(self):
        return f'{self.status_code} {self.url}'

    def valid(self) -> bool:
        return 200 <= self.status_code < 400 or self.status_code == 0


class LinkStorage:
    def __init__(self, root):
        self.links = []
        self.root = root

    def __str__(self):
        return '\n'.join(str(link) for link in self.links)

    def link(self) -> Link:
        for link in self.links:
            if not link.processed:
                return link

    def add(self, link: Link):
        if not any(l.url == link.url for l in self.links):
            # print(f'Adding link: {link.url}')
            self.links.append(link)

    def processed(self) -> bool:
        return all(link.processed for link in self.links)

    def report(self) -> str:
        invalid_links = [link for link in self.links if not link.valid()]

        report = ""
        report += f'Total: {len(self.links)} links\n'
        report += f'Invalid: {len(invalid_links)} links\n'
        report += '\n\n'
        report += 'Invalid links\n'
        report += ('\n'.join(str(link) for link in invalid_links))
        report += '\n\n'
        report += 'All links\n'
        report += ('\n'.join(str(link) for link in self.links))

        return report

    def save(self):
        filename = self.root.replace(".", "_").replace("http://", "").replace("https://", "")
        file = open(f'{filename}.txt', "w+")
        file.write(self.report())
        file.close()


# get list of "<a href>"s
def get_refs_from_page(page_text) -> list:
    soup = BeautifulSoup(page_text, 'html.parser')
    return [a.get('href') for a in soup.find_all("a")]


# our custom filters
def ref_invalid(ref: str) -> bool:
    return not ref \
           or len(ref) < 2 \
           or ref.startswith('#') \
           or ref.startswith('?')


def link_from_ref(root: str, ref: str) -> Link:
    if ref.startswith('/'):
        return Link(f'{root}{ref}', internal=True)
    else:
        return Link(ref, internal=False)


def download(link: Link):
    try:
        response = requests.get(link.url)
    except IOError:
        print(f'Invalid link: {link.url}')
        link.processed = True
        return

    link.status_code = response.status_code
    link.content = response.content

    return


def process_link(link_storage: LinkStorage, link: Link):
    download(link)

    if not (link.valid() or link.internal):
        link.processed = True
        return

    refs = get_refs_from_page(link.content)

    for ref in refs:
        if ref_invalid(ref):
            continue

        new_link = link_from_ref(link_storage.root, ref)
        link_storage.add(new_link)

    link.processed = True
    return


def crawl(url):
    link_storage = LinkStorage(url)
    link_storage.add(Link(url, internal=True))

    while not link_storage.processed():
        link = link_storage.link()
        # print(f'Processing link: {link.url}')
        process_link(link_storage, link)

        link_storage.save()
        time.sleep(1)


crawl(sys.argv[1])
