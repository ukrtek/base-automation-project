using System;
using base_automation_project.utils;
using base_automation_project.utils.Models;
using base_automation_project.utils.WebDriverBuilder;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using Xunit;
using Xunit.Abstractions;

namespace base_automation_project.tests
{
    public class EnoTestSuite : BaseTest
    {

        public EnoTestSuite(TestFixture fixture) : base(fixture)
        {
            
        }

        // do the checks here
        //todo

        [Fact]
        public void DemoTest()
        {
            Logger.Error("test msg");
        }

        //home page tests
        
        [Fact]
        public void openMenu()
        {
            //verify user is on home page
            //open menu
        }

        [Fact]
        public void LearnMoreButtonsRouteToAboutPage()
        {
            
        }
        
        [Fact]
        public void LetsGetStartedButtonTakesToContactPage()
        {}

        [Fact]
        public void VerifyPhoneLinks()
        {
            
        }
        
        //services page tests

        [Fact]
        public void IndustriesFederalStateGovernmentHoverPopup()
        {
            
        }
        
        //news page tests
        
        [Fact]
        public void ReadMoreButtonTopPostLink()
        {
            
        }

        [Fact]
        public void MainSectionPostLink()
        {
            
        }

        [Fact]
        public void TrendingPostsLink()
        {
            
        }
        
        
        
        
    }     
}



















