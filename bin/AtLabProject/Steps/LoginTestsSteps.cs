using ATLabProject.PageObjects.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace ATLabProject.Steps
{
    /// <summary>
    /// Class contains 
    /// steps of login page tests 
    /// and steps of login page tests with different login names
    /// </summary>
    
    [Binding]
    public sealed class LoginTestsSteps
    { 
        
        public LoginPage LoginPage = new LoginPage();

        [Then(@"Login page is opened")]
        public void LoginPageIsOpened()
        {
            Assert.IsTrue(LoginPage.IsOpened(), "Page is not opened");
        }

        [When(@"I type correct '([^']*)' and password")]
        public void WhenITypeCorrectAndPassword(string p0)
        {
            LoginPage.Login(p0, "secret_sauce");
        }

        HomePage HomePage = new();
        [Then(@"Homepage is opened")]
       
        public void ThenHomePageIsOpened()
        {
            Assert.IsTrue(HomePage.IsOpened(), "Page is not opened");
        }       
    }
    }
