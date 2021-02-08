using OpenQA.Selenium;
using System;

namespace HerokuappExamples
{
    internal class DigestAuthPO : BaseApplicationPage
    {
        public DigestAuthPO(IWebDriver driver) : base(driver) { }
        internal void SuccessfulLogin()
        {
            Driver.Navigate().GoToUrl("http://admin:admin@the-internet.herokuapp.com/digest_auth"); //We are passing in the username and password as part of the URL.
        }

        public void InvalidUsernameAndPassword()
        {
            Driver.Navigate().GoToUrl("http://test:test@the-internet.herokuapp.com/digest_auth");
        }
        public void ValidUsernameAndInvalidPassword()
        {
            Driver.Navigate().GoToUrl("http://admin:wrongpassword@the-internet.herokuapp.com/digest_auth");
        }
        public void InvalidUsernameAndValidPassword()
        {
            Driver.Navigate().GoToUrl("http://wrongusername:admin@the-internet.herokuapp.com/digest_auth");
        }
    }
}