using NUnit.Framework;
using OpenQA.Selenium;

namespace HerokuappExamples
{
    [Category("CheckBoxes")]
    [TestFixture]
    public class Checkboxes : BaseTest
    {
        internal CheckboxesPO CheckboxesPO { get; private set; } //Property for creating the CheckboxesPO in the setup

        [Description("Verifies the Checkboxes page sub header!")]
        [Author("Michael Rees")]
        [Test]
        public void VerifyPageSubHeader()
        {
            CheckboxesPO.VerifyPageSubHeader();

            string matching_string = "Checkboxes";
            Assert.IsTrue(Driver.FindElement(By.TagName("Body")).Text.Contains(matching_string));
        }
        [Description("Verifies the default checkbox which is selected!")]
        [Author("Michael Rees")]
        [Test]
        public void VerifyDefaultCheckboxSelected()
        {
            CheckboxesPO.VerifyDefaultCheckboxSelected();
            Assert.That(Driver.FindElement(By.XPath("//*[@type='checkbox'][2]")).Selected);
        }
        [Description("Checks checkbox 1 and unchecks checkbox 2!")]
        [Author("Michael Rees")]
        [Test]
        public void SelectCheckboxOneAndUnselectCheckboxTwo()
        {
            CheckboxesPO.CheckCheckboxOneAndUncheckCheckboxTwo();
            Assert.That(Driver.FindElement(By.XPath("//*[@type='checkbox'][1]")).Selected);
            Assert.IsFalse(Driver.FindElement(By.XPath("//*[@type='checkbox'][2]")).Selected);
        }
        [Description("Actions in here are run after the Base class but before a test is executed. We are instantiating the CheckboxesPO page.")]
        [SetUp]
        public void ActionsRunBeforeTest()
        {
            CheckboxesPO = new CheckboxesPO(Driver);
        }
    }
}
