using System;
using TechTalk.SpecFlow;

namespace ATLabProject
{
    [Binding]
    public class ValidateUseStepDefinitions
    {
        [Given(@"setup is done")]
        public void GivenSetupIsDone()
        {
            throw new PendingStepException();
        }

        [When(@"user is created")]
        public void WhenUserIsCreated()
        {
            throw new PendingStepException();
        }

        [Then(@"validate user info")]
        public void ThenValidateUserInfo()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
