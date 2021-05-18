using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;

namespace HerokuappExamples
{
    [Parallelizable]
    [Category("Regression Tests"), Category("Exit Intent Modal")]
    [TestFixture]
    public class ExitIntentModal :BaseTest
    {
        internal ExitIntentModalPO ExitIntentModalPO { get; private set; }

        [Test]
        public void AcceptExitIntentModal()
        {
            ExitIntentModalPO.ClickExitIntentLinkText();
            //ExitIntentModalPO.AcceptExitIntentModal();
        }
        [SetUp]
        public void RunsBeforeEachTest()
        {
            ExitIntentModalPO = new ExitIntentModalPO(Driver);
        }
    }
}
