using NUnit.Framework;
using System;

namespace HerokuappExamples
{
    [Description("Scenarios to verify the dropdown list functionality.")]
    [Category("Smoke Tests"), Category("Regression Tests")]
    [Parallelizable]
    [TestFixture]
    public class DropdownListTest : BaseTest
    {
        internal DropdownListPO DropdownListPO { get; private set; } //Property for creating the DropdownListPO in the setup

        [Author("Michael Rees")]
        [Description("Selects from a dropdown list using value.")]
        [Test]
        public void SelectOptionOne()
        {
            DropdownListPO.SelectOptionOneByValue();
        }
        [Author("Michael Rees")]
        [Description("Selects from a dropdown list using index.")]
        [Test]
        public void SelectOptionTwo()
        {
            DropdownListPO.SelectOptionTwoByIndex();
        }
        [Author("Michael Rees")]
        [Description("Select's all options by iteration!")]
        [Test]
        public void SelectOptionsByIteratingAllOptions()
        {
            DropdownListPO.SelectByIteratingAllOptions();
        }

        [SetUp]
        public void RunsBeforeEachTest()
        {
            DropdownListPO = new DropdownListPO(Driver);
        }
    }
}
