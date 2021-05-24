using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Threading;

namespace HerokuappExamples
{
    [TestFixture]
    public class FileDownload : BaseTest
    {
        internal FileDownloadPO FileDownloadPO { get; private set; } //Property for creating the FileDownloadPO in the setup

        [Test]
        public void DownloadFileAndVerifyDownload()
        {
            FileDownloadPO.DownloadFile();
        }

        [SetUp]
        public void ActionsRunBeforeEachTest()
        {
            FileDownloadPO = new FileDownloadPO(Driver);
            Driver.FindElement(By.LinkText("File Download")).Click();
        }
    }
}
