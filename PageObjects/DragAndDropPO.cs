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
            //WebElement on which drag and drop operation needs to be performed
            IWebElement fromElement = Driver.FindElement(By.Id("column-a"));

            //WebElement to which the above object is dropped
            IWebElement toElement = Driver.FindElement(By.Id("column-b"));

            //Creating object of Actions class to build composite actions
            Actions builder = new Actions(Driver);

            //Building a drag and drop action
             IAction dragAndDrop = builder.ClickAndHold(fromElement)
            .MoveToElement(toElement)
            .Release(toElement)
            .Build();

            //Performing the drag and drop action
            dragAndDrop.Perform();



            //Actions action = new Actions(Driver);
            //action.DragAndDrop(Driver.FindElement(By.Id(fromElement)), Driver.FindElement(By.Id("column-b"))).Build().Perform();
        }
    }
}