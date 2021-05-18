using NUnit.Framework;
using OpenQA.Selenium;

namespace HerokuappExamples
{
    [Category("Regression Tests")]
    [Parallelizable]
    [TestFixture]
    public class ABTestControl : BaseTest
    {
        internal ABTestControlPO ABTestControlPO { get; private set; } //Property for creating the ABTestControlPO in the setup

        [Test]
        public void ABTestControlVerifyText()
        {
            ABTestControlPO.VerifyText();

            string matching_text = "Also known as split testing. This is a way in which businesses are able to simultaneously test and learn different versions of a page to see which text and/or functionality works best towards a desired outcome (e.g. a user action such as a click-through).";
            Assert.IsTrue(Driver.FindElement(By.TagName("body")).Text.Contains(matching_text));
        }
        [SetUp]
        public void ActionsRunBeforeTest()
        {
            ABTestControlPO = new ABTestControlPO(Driver);
        }

    }
}
