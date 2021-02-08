using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace HerokuappExamples
{
    [TestFixture]
    public class BasicAuth : BaseTest
    {
        internal BasicAuthPO BasicAuthPO { get; private set; } //Property for creating the BasicAuth in the setup

        [Test]
        public void BasicAuthDialogBox()
        {
            BasicAuthPO.SuccessLoginBasicAuthDialogBox();
            Assert.That(Driver.FindElement(By.XPath("//*[@class='example']/p")).Displayed);
        }
        [SetUp]
        public void ActionsRunBeforeTest()
        {
            BasicAuthPO = new BasicAuthPO(Driver);
        }
    }
}
