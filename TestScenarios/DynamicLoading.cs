using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace HerokuappExamples
{
    [Category("Regression Tests")]
    [Parallelizable]
    [TestFixture]
    public class DynamicLoading :BaseTest
    {
        internal DynamicLoadingPO DynamicLoadingPO { get; private set; }

        [Author("Michael Rees")]
        [Description("Example 1 - Element on a page that is hidden!")]
        [Test]
        public void HiddenElement()
        {
            DynamicLoadingPO.HiddenElement();

            Assert.That(DynamicLoadingPO.HelloWorldTextDisplayed);
        }
        [Author("Michael Rees")]
        [Description("Example 2: Element rendered after the fact!")]
        [Test]
        public void ElementRenderedAfterFact()
        {
            DynamicLoadingPO.ElementRenderedAfterFact();

            Assert.That(DynamicLoadingPO.HelloWorldTextDisplayed);
        }

        [SetUp]
        public void RunsBeforeEachTest()
        {
            DynamicLoadingPO = new DynamicLoadingPO(Driver);
        }
    }
}
