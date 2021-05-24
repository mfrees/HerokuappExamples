using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace HerokuappExamples
{
    [TestFixture]
    public class ForgotPassword : BaseTest

    {
        internal ForgotPasswordPO ForgotPasswordPO { get; private set; } //Property for creating the ForgotPasswordPO in the setup

        [Test]
        public void ClickRetrieveButtonWithNoEmail()
        {
            ForgotPasswordPO.ClickRetrieveButtonWithNoEmail();

            string matching_string = "Internal Server Error";
            Assert.IsTrue(Driver.FindElement(By.TagName("Body")).Text.Contains(matching_string));
        }

        [Test]
        public void VerifyPageTitle()
        {
            ForgotPasswordPO.VerifyPageTitle();

            string matching_string = "Forgot Password";
            Assert.IsTrue(Driver.FindElement(By.TagName("Body")).Text.Contains(matching_string));
        }

        [Test]
        public void EnterEmailAndClickRetrievePasswordButton()
        {
            ForgotPasswordPO.EnterEmailAndClickButton();

            string matching_string = "Internal Server Error";
            Assert.IsTrue(Driver.FindElement(By.TagName("Body")).Text.Contains(matching_string));
        }

        [SetUp]
        public void ActionsRunBeforeEachTest()
        {
            ForgotPasswordPO = new ForgotPasswordPO(Driver);
        }
    }
}
