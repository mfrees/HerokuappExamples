using AutomationResources;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;

namespace HerokuappExamples
{
    public class SauceBaseTest
    {
        public IWebDriver Driver { get; set; }

        //This class holds the setup and teardown which can be used by each test class.
        [Description("Everything which runs before the tests get executed.")]
        [Author("Michael Rees")]
        [SetUp]
        public void SetupForEverySingleTestMethod()
        {
            
            DesiredCapabilities caps = new DesiredCapabilities();
            caps.SetCapability("browserName", "Chrome");
            caps.SetCapability("platform", "Windows 8.1");
            caps.SetCapability("version", "62.0");
            caps.SetCapability("screenResolution", "1024x768");
            caps.SetCapability("username",

            Environment.GetEnvironmentVariable("SAUCE_USERNAME", EnvironmentVariableTarget.User));
            caps.SetCapability("accessKey",
                Environment.GetEnvironmentVariable("SAUCE_ACCESS_KEY", EnvironmentVariableTarget.User));
            Driver = new RemoteWebDriver(new Uri("https://mfrees27:142e6c521a4845a1a5268a709170b250@ondemand.eu-central-1.saucelabs.com:443/wd/hub"),
                caps, TimeSpan.FromSeconds(600));
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");

        }
        [Description("Everything which runs after the test has executed.")]
        [Author("Michael Rees")]
        [TearDown]
        public void CleanUpAfterEveryTestMethod()
        {
            Driver.Quit();
            Driver.Close();
        }
    }
}