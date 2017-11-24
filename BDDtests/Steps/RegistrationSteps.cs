using System;
using PortableUI;
using TechTalk.SpecFlow;

namespace BDDtests.Steps
{
    [Binding]
    public class RegistrationSteps : StepBase
    {
        [Given(@"I press SignUp on authorization")]
        public void GivenIPressSignUpOnAuthorization()
        {
            App.Tap(Resources.Screen.Authorize.Btn_Registr_From_Login);
        }


        [Given(@"I have entered a valid email adress in registration")]
        public void GivenIHaveEnteredAValidEmailAdressInRegistration()
        {
            App.Tap(Resources.Screen.Register.EmailField);
            var key = Guid.NewGuid().ToString();
            App.EnterText("fufel"+key+"@i.ua");
        }
        
        [Given(@"I have entered a valid phone number in registration")]
        public void GivenIHaveEnteredAValidPhoneNumberInRegistration()
        {
            App.Tap(Resources.Screen.Register.PhoneField);
            App.EnterText("123456");
        }
        
        [Given(@"I have entered valid names in registration")]
        public void GivenIHaveEnteredValidNamesInRegistration()
        {
            App.Tap(Resources.Screen.Register.FirstNameField);
            App.EnterText("fufel");
            App.Tap(Resources.Screen.Register.LastNameField);
            App.EnterText("fufel");
        }
        
        [Given(@"I have entered valid password in registration")]
        public void GivenIHaveEnteredValidPasswordInRegistration()
        {
            App.Tap(Resources.Screen.Register.PasswordField);
            App.EnterText("q12345");
            App.Tap(Resources.Screen.Register.ConfirmPasswordField);
            App.EnterText("q12345");
        }
        
        [Given(@"I have entered invalid email adress in registration")]
        public void GivenIHaveEnteredInvalidEmailAdressInRegistration()
        {
            App.Tap(Resources.Screen.Register.EmailField);
            App.EnterText("d@l.dd.d");
        }
        
     
        [When(@"I press NEXT from email")]
        public void WhenIPressNEXTFromEmail()
        {
            App.Tap(Resources.Screen.Register.EmailNextBtn);
        }

        [Given(@"I press NEXT from phone")]
        public void GivenIPressNEXTFromPhone()
        {
            App.Tap(Resources.Screen.Register.PhoneNextBtn);
        }


        [When(@"I press NEXT from names")]
        public void WhenIPressNEXTFromNames()
        {
            App.Tap(Resources.Screen.Register.NameNextBtn);
        }

        [Given(@"I press NEXT from email")]
        public void GivenIPressNEXTFromEmail()
        {
            App.Tap(Resources.Screen.Register.EmailNextBtn);
        }

        [Given(@"I press NEXT from names")]
        public void GivenIPressNEXTFromNames()
        {
            App.Tap(Resources.Screen.Register.NameNextBtn);
        }

        [Given(@"I have entered an ivalid phone number in registration")]
        public void GivenIHaveEnteredAnIvalidPhoneNumberInRegistration()
        {
            App.Tap(Resources.Screen.Register.PhoneField);
            App.EnterText("12ddd");
        }
        
        [Given(@"I have entered invalid names in registration")]
        public void GivenIHaveEnteredInvalidNamesInRegistration()
        {
            App.Tap(Resources.Screen.Register.FirstNameField);
            App.EnterText("fufel1");
            App.Tap(Resources.Screen.Register.LastNameField);
            App.EnterText("fufel1");
        }
        
        [When(@"I press Sign UP")]
        public void WhenIPressSignUP()
        {
            App.Tap(Resources.Screen.Register.SignUp);
        }
        
        [When(@"I press NEXT from phone")]
        public void WhenIPressNEXT()
        {
            App.Tap(Resources.Screen.Register.PhoneNextBtn);
        }
        
        [Then(@"the result should be message about successful registration")]
        public void ThenTheResultShouldBeMessageAboutSuccessfulRegistration()
        {
            Helper.WaitForElementWithTime(c=>c.Marked(Resources.Screen.Localization.SuccessfulRegistrationMessage),60);
        }
        
        [Then(@"the result should be favorites page")]
        public void ThenTheResultShouldBeFavoritesPage()
        {
            App.Tap(c=>c.Marked("OK"));
            Helper.WaitForElementWithTime(Resources.Screen.Favorites.Card,60);
        }
        
        [Then(@"the result should be email page \(no transition\)")]
        public void ThenTheResultShouldBeEmailPageNoTransition()
        {
           Helper.WaitForElementWithTime(Resources.Screen.Register.EnterEmailStr, 10);
        }
        
        [Then(@"the result should be phone page \(no transition\)")]
        public void ThenTheResultShouldBePhonePageNoTransition()
        {
            Helper.WaitForElementWithTime(Resources.Screen.Register.EnterPhoneStr, 10);
        }
        
        [Then(@"the result should be names page \(no transition\)")]
        public void ThenTheResultShouldBeNamesPageNoTransition()
        {
            Helper.WaitForElementWithTime(Resources.Screen.Register.EnterNamesStr, 10);
        }
        
        [Then(@"the result should be password page \(no transition\)")]
        public void ThenTheResultShouldBePasswordPageNoTransition()
        {
            Helper.WaitForElementWithTime(Resources.Screen.Register.EnterPassStr, 10);
        }
    }
}
