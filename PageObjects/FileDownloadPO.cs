using OpenQA.Selenium;
using System;

namespace HerokuappExamples
{
    internal class FileDownloadPO : BaseApplicationPage
    {
        public FileDownloadPO(IWebDriver driver) : base(driver) { }



        /***************************************
         * Page Objects Below This Point!
         * *************************************/
        public IWebElement FileToDownload => Driver.FindElement(By.LinkText("some-file.txt"));


        /***************************************
         * Methods Below This Point!
         ***************************************/

        internal void DownloadFile()
        {
            FileToDownload.Click();
            System.Threading.Thread.Sleep(3000); //Wait to let the download finish.
           //need to implement a assertions to verify the download has actually worked.
        }

    }
}