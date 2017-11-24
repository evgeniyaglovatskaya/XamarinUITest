using System;
using BDDtests.Steps;
using PortableUI;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace BDDtests
{
    [Binding]
    public class AuthorizationSteps:StepBase
    { 

        [Given(@"I have entered valid and existing email to email field")]
        public void GivenIHaveEnteredValidAndExistingEmailToEmailField()
        {
            App.Tap(Resources.Screen.Authorize.Email);
            App.EnterText("tvma@i.ua");
            
        }
        
        [Given(@"I have entered correct password into password field")]
        public void GivenIHaveEnteredCorrectPasswordIntoPasswordField()
        {
            App.Tap(Resources.Screen.Authorize.Password);
            App.EnterText("123qwe");
        }
        [Given(@"I have entered invalid and existing email to email field")]
        public void GivenIHaveEnteredInValidAndExistingEmailToEmailField()
        {
            App.Tap(Resources.Screen.Authorize.Email);
            App.EnterText("1");

        }

        [Given(@"I have entered incorrect password into password field")]
        public void GivenIHaveEnteredInCorrectPasswordIntoPasswordField()
        {
            App.Tap(Resources.Screen.Authorize.Password);
            App.EnterText("123q");
        }


        [When(@"I press log in")]
        public void WhenIPressLogIn()
        {
            App.Tap(Resources.Screen.Authorize.Login_Btn);
        }
     

        [Then(@"the result I should see is favorites screen")]
        public void ThenTheResultIShouldSeeIsFavoritesScreen()
        {
           Helper.WaitForElementWithTime(Resources.Screen.Favorites.Card,60);
        }
        [Then(@"the result I should see authorization page")]
        public void ThenTheResultIShouldSeeIsErrorMessage()
        {
            Helper.WaitForElementWithTime(c=>c.Marked(Resources.Screen.Localization.IncorrectEmailPassMessage), 10);
        }

    }
}
