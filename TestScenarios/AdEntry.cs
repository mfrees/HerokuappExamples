using NUnit.Framework;
using System;

namespace HerokuappExamples
{
    [Category("Regression Test"), Category("Ad Entry Modal Example")]
    [Parallelizable]
    [TestFixture]
    public class AdEntry : BaseTest
    {
        internal AdEntryPO AdEntryPO { get; private set; }

        [Author("Michael Rees")]
        [Description("Accept a Ad Entry modal dialog.")]
        [Test]
        public void LaunchPageAndAcceptModal()
        {
            AdEntryPO.LaunchPageAndAcceptModal();
        }
        [SetUp]
        public void RunsBeforeEachTest()
        {
            AdEntryPO = new AdEntryPO(Driver);
        }
    }
}
