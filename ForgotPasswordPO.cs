using OpenQA.Selenium;
using System;

namespace HerokuappExamples
{
    internal class ForgotPasswordPO : BaseApplicationPage
    {
        public ForgotPasswordPO(IWebDriver driver) : base(driver) { }

        //PAGE OBJECTS BELOW
        public IWebElement ForgotPasswordLink => Driver.FindElement(By.LinkText("Forgot Password"));
        public IWebElement RetrievePasswordButton => Driver.FindElement(By.Id("form_submit"));
        public IWebElement EmailTextBox => Driver.FindElement(By.Id("email"));



        internal void ClickRetrieveButtonWithNoEmail()
        {
            ForgotPasswordLink.Click();
            RetrievePasswordButton.Click();
        }

        internal void VerifyPageTitle()
        {
            ForgotPasswordLink.Click();
        }

        internal void EnterEmailAndClickButton()
        {
            ForgotPasswordLink.Click();
            EmailTextBox.SendKeys("test@aol.co.uk");
            RetrievePasswordButton.Click();
        }
    }
}