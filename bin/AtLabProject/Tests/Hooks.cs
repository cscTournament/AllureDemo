using TechTalk.SpecFlow;
using static ATLabProject.Helpers.BrowserHelper;

namespace ATLabProject.Tests
{
    [Binding]
    public sealed class Hooks
    {
        [BeforeScenario]
        public static void BeforeScenarioRun()
        {
            OpenBrowser();
            ClearBrowserCookies();
            GoToUrl("https://www.saucedemo.com/");
        }

        [AfterScenario]
        public static void AfterScenarioRun()
        {
            CloseBrowser();
        }
    }
}