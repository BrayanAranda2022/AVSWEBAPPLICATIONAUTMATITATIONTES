using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Reflection;
using TechTalk.SpecFlow;

namespace Aranda.Avs.Automatization.WebApplication.Test.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        [Given(@"\[context]")]
        public void GivenContext()
        {
            var router = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string route = Path.Combine(router, "Drivers");
            IWebDriver webDriver = new ChromeDriver(route);
            webDriver.Navigate().GoToUrl("http://avs-web-dev.azurewebsites.net/");
            webDriver.Manage().Window.Maximize();
        }

        [When(@"\[action]")]
        public void WhenAction()
        {
        }

    }
}
