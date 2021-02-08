using OpenQA.Selenium;
using System;

namespace HerokuappExamples
{
    internal class AddAndRemoveElementPO : BaseApplicationPage
    {
        public AddAndRemoveElementPO(IWebDriver driver) : base(driver) { }

        //Page objects below
        public IWebElement AddRemoveElementLink => Driver.FindElement(By.LinkText("Add/Remove Elements"));
        public IWebElement AddElementButton => Driver.FindElement(By.XPath("//*[@onclick='addElement()']"));
        public IWebElement SecondDeleteButton => Driver.FindElement(By.XPath("//*[@onclick='deleteElement()'][1]"));
        public IWebElement DeleteButtonOriginal => Driver.FindElement(By.XPath("//*[@onclick='deleteElement()']"));

        //Methods below this point
        internal void AddAndRemoveElements()
        {
            AddRemoveElementLink.Click();
            AddElementButton.Click();
            AddElementButton.Click();
            SecondDeleteButton.Click();
            DeleteButtonOriginal.Click();
        }
    }
}