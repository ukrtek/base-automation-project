using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using Serilog;
using Xunit;

namespace base_automation_project.utils
{
    public class ActionsWithElements
    {
        protected RemoteWebDriver WebDriver;
        protected LoggerManager LoggerManager;
        protected ILogger Logger;

        public ActionsWithElements(RemoteWebDriver webDriver)
        {
            WebDriver = webDriver;
            LoggerManager = new LoggerManager();
            Logger = LoggerManager.buildLogger();
        }

        public void InputTextIntoElement(IWebElement webElement, string text)
        {
            try
            {
                webElement.Clear();
                webElement.SendKeys(text);
                Logger.Information("{0} was entered into element", text);
            }
            catch (Exception e)
            {
                PrintErrorAndStopTest();
            }
        }

        public void ClickOnElement(IWebElement webElement)
        {
            try
            {
                webElement.Click();
                Logger.Information("element was clicked");
            }
            catch (NoSuchElementException)
            {
                PrintErrorAndStopTest();
            }
            catch (Exception e)
            {
                PrintErrorAndStopTest();
            }
        }

        private void PrintErrorAndStopTest()
        {
            var msg = "cannot work with element";
            Logger.Error(msg);
            Assert.True(false, msg);
        }

        public bool IsElementPresent(IWebElement webElement)
        {
            try
            {
                return webElement.Displayed && webElement.Enabled;
            }
            catch (Exception e)
            {
                PrintErrorAndStopTest();
            }

            return false;
        }

        public void SelectValueInDropdown(IWebElement webElement, String textValue)
        {
            try
            {
                SelectElement select = new SelectElement(webElement);
                //or use selectByValue(object value) method???
                select.SelectByText(textValue);
                Logger.Information("{0} was selected in dropdown", textValue);
            }
            catch (Exception e)
            {
                PrintErrorAndStopTest();
            }
        }

        private bool IsCheckedCheckbox(IWebElement webElement)
        {
            try
            {
                return webElement.Selected;
            }
            catch (Exception e)
            {
                PrintErrorAndStopTest();
                return false;
            }
        }

        public void SetCheckboxToNeededState(IWebElement webElement, string neededState)
        {
            try
            {
                if (!IsCheckedCheckbox(webElement) & neededState.Equals("checked"))
                {
                    webElement.Click();
                }
                else if (IsCheckedCheckbox(webElement) & neededState.Equals("unchecked"))
                {
                    webElement.Click();
                }
            }
            catch (Exception e)
            {
                PrintErrorAndStopTest();
            }

            
        }

        public void AlertAccept()
        {
            try
            {
                WebDriver.SwitchTo().Alert().Accept();
            }
            catch (NoAlertPresentException e)
            {
                PrintErrorAndStopTest();
            }
        }

        public void MoveToElement(IWebElement webElement)
        {
            ((IJavaScriptExecutor) WebDriver).ExecuteScript("arguments[0].scrollIntoView();", webElement);
        }

        public bool IsElementInList(string locator)
        {
            try
            {
                var listOfElements = WebDriver.FindElements(By.XPath(locator));
                if (listOfElements.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                PrintErrorAndStopTest();
                return false;
            }
        }
    }
}