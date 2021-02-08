using OpenQA.Selenium;
using System;

namespace HerokuappExamples
{
    internal class CheckboxesPO : BaseApplicationPage
    {
        public CheckboxesPO(IWebDriver driver) : base(driver) { }

        //Page Objects Below
        public IWebElement CheckboxesLink => Driver.FindElement(By.LinkText("Checkboxes"));
        public IWebElement CheckboxOne => Driver.FindElement(By.XPath("//*[@type='checkbox'][1]"));
        public IWebElement CheckboxTwo => Driver.FindElement(By.XPath("//*[@type='checkbox'][2]"));


        internal void VerifyPageSubHeader()
        {
            CheckboxesLink.Click();
        }


        //Methods Below
        internal void VerifyDefaultCheckboxSelected()
        {
            CheckboxesLink.Click();
        }

        internal void CheckCheckboxOneAndUncheckCheckboxTwo()
        {
            CheckboxesLink.Click();
            CheckboxOne.Click();
            CheckboxTwo.Click();
        }
    }
}