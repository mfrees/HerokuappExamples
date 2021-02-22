using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace HerokuappExamples
{
    internal class DropdownListPO : BaseApplicationPage
    {
        public DropdownListPO(IWebDriver driver) : base(driver) { }

        //Page objects below

        public IWebElement DropdownLinkText => Driver.FindElement(By.LinkText("Dropdown"));
        public IWebElement DropdownField => Driver.FindElement(By.Id("dropdown"));


        internal void SelectOptionOneByValue()
        {
            DropdownLinkText.Click();
            IWebElement element = DropdownField;
            SelectElement select = new SelectElement(element);
            select.SelectByValue("1");
        }

        internal void SelectOptionTwoByIndex()
        {
            DropdownLinkText.Click();
            IWebElement element = DropdownField;
            SelectElement select = new SelectElement(element);
            select.SelectByIndex(2); //0 based index
        }

        internal void SelectByIteratingAllOptions()
        {
            DropdownLinkText.Click();
            IWebElement selectElement = DropdownField;
            foreach (IWebElement option in selectElement.FindElements(By.TagName("option")))
            {
                if (option.Text.Equals("Option 2"))
                {
                    option.Click();
                }
            }
        }
    }
}