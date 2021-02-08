using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;

namespace HerokuappExamples
{
    [Description("Sauce Labs Testing")]
    [Category("Sauce Labs Testing!")]
    [TestFixture]
    public class AddRemoveElement : SauceBaseTest
    {
        internal AddAndRemoveElementPO AddAndRemoveElementPO { get; private set; } //Property for creating the AddAndRemoveElementPO in the setup

        [Test]
        [Category("Sauce Labs Test 1")]
        public void AddAndRemoveElement()
        {
            AddAndRemoveElementPO.AddAndRemoveElements();
        }

        [SetUp]
        public void ActionsRunBeforeTest()
        {
            AddAndRemoveElementPO = new AddAndRemoveElementPO(Driver); //We are creating the AddAndRemoveElementPO here once rather than in evry test.


        }
        [TearDown]
        public void ActionsRunAfterEachTest()
        {
            var passed = TestContext.CurrentContext.Result.Outcome.Equals(ResultState.Success);
            try
            {
                // Logs the result to Sauce Labs
                ((IJavaScriptExecutor)Driver).ExecuteScript("sauce:job-result=" + (passed ? "passed" : "failed"));
            }
            finally
            {
                // Terminates the remote webdriver session
                Driver?.Quit();
            }
        }
    }
}
