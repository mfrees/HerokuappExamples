using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace HerokuappExamples
{
    [Description("Dynamic controls changed asynchronously")]
    [Author("Michael Rees")]
    [Category("Regression Tests")]
    [TestFixture]
    public class DynamicControls :BaseTest
    {
        //Property for creating the DynamicControlsPO in the setup
        internal DynamicControlsPO DynamicControlsPO { get; private set; } 

        [Description("Remove checkbox and verify message displayed!")]
        [Test]
        public void RemoveCheckbox()
        {
            DynamicControlsPO.RemoveCheckbox();
            System.Threading.Thread.Sleep(5000);

            string matching_text = "It's gone!";
            Assert.IsTrue(Driver.FindElement(By.TagName("body")).Text.Contains(matching_text));

            //Assert.That(Driver.FindElement(By.Id("checkbox")).Displayed);
            //Assert.IsTrue(Driver.FindElement(By.XPath("//*[@id='message']")).Displayed);
        }
        [Description("Clicks the Add button and verifies the 'It's back!' text is displayed!")]
        [Test]
        public void AddCheckbox()
        {
            DynamicControlsPO.AddCheckbox();

            string matching_text = "It's back!";
            Assert.IsTrue(Driver.FindElement(By.TagName("body")).Text.Contains(matching_text));
            Assert.IsTrue(Driver.FindElement(By.Id("checkbox")).Displayed);
        }
        [Description("Verify the enabled/disabled text box is disabled as default! ")]
        [Test]
        public void VerifyEnableTextBoxDefaultState()
        {
            DynamicControlsPO.EnableDisableTextBoxDefaultState();

            Assert.IsFalse(Driver.FindElement(By.XPath("//*[@type='text']")).Enabled);
        }
        [Description("Click the enable button, wait for the text field to become enable then enter text!")]
        [Test]
        public void ClickEnableButtonAndEnterText()
        {
            DynamicControlsPO.ClickEnableAndEnterText();
        }


        [SetUp]
        public void RunsBeforeEachTest()
        {
            DynamicControlsPO = new DynamicControlsPO(Driver);
        }
    }
}
