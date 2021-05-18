using OpenQA.Selenium;
using System;

namespace HerokuappExamples
{
    internal class AdEntryPO : BaseApplicationPage
    {
        public AdEntryPO(IWebDriver driver) : base(driver) { }

        /********************
         * Page Objects Below
         ********************/

        public IWebElement EntryAdLinkText => Driver.FindElement(By.LinkText("Entry Ad"));
        public IWebElement ModalDialog => Driver.FindElement(By.Id("modal"));
        public IWebElement ModalClose => Driver.FindElement(By.XPath("//div[@class='modal-footer']/p"));

        /***************
         * Methods Below
         * *************/
        internal void LaunchPageAndAcceptModal()
        {
            EntryAdLinkText.Click();
            System.Threading.Thread.Sleep(2000); //remove wait
            ModalDialog.Click();
            System.Threading.Thread.Sleep(4000); //this hard coded wait needs to be changed
            ModalClose.Click();
        }
    }
}