using NUnit.Framework;
using OpenQA.Selenium;

namespace HerokuappExamples
{
    [Category("Context Menu")]
    [TestFixture]
    public class ContextMenu : BaseTest
    {
        internal ContextMenuPO ContextMenuPO { get; private set; } //Property for creating the CheckboxesPO in the setup

        [Description("Verifies the page sub header!")]
        [Author("Michael Rees")]
        [Test]
        public void VerifyPageSubHeader()
        {
            ContextMenuPO.VerifyPageSubHeader();
            string matching_string = "Context Menu";
            Assert.IsTrue(Driver.FindElement(By.TagName("Body")).Text.Contains(matching_string));
        }
        [Description("Right click in hotspot which triggers JavaScript Alert! ")]
        [Author("Michael Rees")]
        [Test]
        public void RightClickInHotSpot()
        {
            ContextMenuPO.RightClickInHotSpotToTriggerAlert();

        }
        [SetUp]
        public void ActionsRunBeforeTest()
        {
            ContextMenuPO = new ContextMenuPO(Driver);
        }
    }
}
