using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace HerokuappExamples
{
    internal class DynamicLoadingPO :BaseApplicationPage
    {
        public DynamicLoadingPO(IWebDriver driver) : base(driver) { }

        public IWebElement DynamicLoadingLinkText => Driver.FindElement(By.LinkText("Dynamic Loading"));
        public IWebElement ExampleOneLinkText => Driver.FindElement(By.LinkText("Example 1: Element on page that is hidden"));
        public IWebElement ExampleTwoLinkText => Driver.FindElement(By.LinkText("Example 2: Element rendered after the fact"));
        public IWebElement StartButton => Driver.FindElement(By.XPath("//div[@id=\'start\']/button"));

        public IWebElement HelloWorldText => Driver.FindElement(By.XPath("//div[@id='finish']/h4"));


        internal void HiddenElement()
        {
            DynamicLoadingLinkText.Click();
            ExampleOneLinkText.Click();
            StartButton.Click();
            System.Threading.Thread.Sleep(5000);
           
        }

        internal void ElementRenderedAfterFact()
        {
            DynamicLoadingLinkText.Click();
            ExampleTwoLinkText.Click();
            StartButton.Click();
            System.Threading.Thread.Sleep(5000);
        }

        public bool HelloWorldTextDisplayed()
        {
            try
            {
                return HelloWorldText.Displayed;
            }
            catch (OpenQA.Selenium.NoSuchElementException)
            {
                return false;

            }
        }
      
    }
}