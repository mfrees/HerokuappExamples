using OpenQA.Selenium;
using System;

namespace HerokuappExamples
{
    internal class DynamicControlsPO : BaseApplicationPage
    {
        public DynamicControlsPO(IWebDriver driver) : base(driver) { }

        //Page Objects Below
        public IWebElement DynamicControlsLinkText => Driver.FindElement(By.LinkText("Dynamic Controls"));
        public IWebElement AddRemoveCheckboxButton => Driver.FindElement(By.XPath("//*[@onclick='swapCheckbox()']"));
        public IWebElement EnabledDisabledTextBox => Driver.FindElement(By.XPath("//*[@type='text']"));
        public IWebElement EnabledDisableButton => Driver.FindElement(By.XPath("//*[@onclick='swapInput()']"));


        //Methods below

        internal void RemoveCheckbox()
        {
            DynamicControlsLinkText.Click();
            AddRemoveCheckboxButton.Click();
        }

        internal void AddCheckbox()
        {
            DynamicControlsLinkText.Click();
            AddRemoveCheckboxButton.Click();
            System.Threading.Thread.Sleep(4000);
            AddRemoveCheckboxButton.Click();
            System.Threading.Thread.Sleep(4000);
        }

        internal void EnableDisableTextBoxDefaultState()
        {
            DynamicControlsLinkText.Click();
            
        }

        internal void ClickEnableAndEnterText()
        {
            DynamicControlsLinkText.Click();
            EnabledDisableButton.Click();
            System.Threading.Thread.Sleep(5000);
            EnabledDisabledTextBox.SendKeys("Testing Text 123!");
        }
    }
}