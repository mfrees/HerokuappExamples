using NUnit.Framework;
using OpenQA.Selenium;

namespace HerokuappExamples
{
    [Category("Regression Tests"), Category("Smoke Tests")]
    [Parallelizable]
    [Author("Mike Rees")]
    [Description("This class tests the login combinations covering username and password combinations.")]
    [TestFixture]
    public class DigestAuthentication : BaseTest
    {
        internal DigestAuthPO DigestAuthPO { get; private set; } //Property for creating the DigestAuthPO page in the setup
        [Description("Valid login to the digest page.")]
        [Test]
        public void SuccessfulLogin()
        {
            DigestAuthPO.SuccessfulLogin();

            string matching_text = "Congratulations! You must have the proper credentials.";
            Assert.IsTrue(Driver.FindElement(By.TagName("body")).Text.Contains(matching_text));
        }
        [Description("Invalid username and password entered.")]
        [Test]
        public void InvalidUsernameAndPassword()
        {
            DigestAuthPO.InvalidUsernameAndPassword();

            string matching_text = "Congratulations! You must have the proper credentials.";
            Assert.IsFalse(Driver.FindElement(By.TagName("body")).Text.Contains(matching_text));
        }
        [Description("Valid username and invalid password entered.")]
        [Test]
        public void ValidUsernameAndInvalidPassword()
        {
            DigestAuthPO.ValidUsernameAndInvalidPassword();

            string matching_text = "Congratulations! You must have the proper credentials.";
            Assert.IsFalse(Driver.FindElement(By.TagName("body")).Text.Contains(matching_text));
        }
        [Description("Invalid username and valid password entered.")]
        [Test]
        public void InvalidUsernameAndValidPassowrd()
        {
            DigestAuthPO.InvalidUsernameAndValidPassword();

            string matching_text = "Congratulations! You must have the proper credentials.";
            Assert.IsFalse(Driver.FindElement(By.TagName("body")).Text.Contains(matching_text));
        }
        [SetUp]
        public void RunsBeforeEachTest()
        {
            DigestAuthPO = new DigestAuthPO(Driver);
        }
    }
}
