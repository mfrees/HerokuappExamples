using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;

namespace HerokuappExamples
{
    [Parallelizable]
    [TestFixture]
    public class ExitIntentModal :BaseTest
    {
        internal ExitIntentModalPO ExitIntentModalPO { get; private set; }

        [Test]
        public void AcceptExitIntentModal()
        {
            ExitIntentModalPO.AcceptExitIntentModal();
        }
        [SetUp]
        public void RunsBeforeEachTest()
        {
            ExitIntentModalPO = new ExitIntentModalPO(Driver);
        }
    }
}
