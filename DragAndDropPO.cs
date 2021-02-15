using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;

namespace HerokuappExamples
{
    internal class DragAndDropPO : BaseApplicationPage
    {
        public DragAndDropPO(IWebDriver driver) : base(driver) { }

        internal void DragAOverB()
        {

            Actions actions = new Actions(Driver);
            actions.DragAndDrop(Driver.FindElement(By.Id("column-a")),
                Driver.FindElement(By.Id("column-b")))
                .Build()
                .Perform();
        }
    }
}