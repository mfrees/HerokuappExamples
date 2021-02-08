using OpenQA.Selenium;
using System;

namespace HerokuappExamples
{
    internal class BasicAuthPO : BaseApplicationPage
    {
        public BasicAuthPO(IWebDriver driver) : base(driver) { }
        internal void SuccessLoginBasicAuthDialogBox()
        {
            Driver.Navigate().GoToUrl("http://admin:admin@the-internet.herokuapp.com/basic_auth"); //We are passing in the username and password as part of the URL.
        }
    }
}