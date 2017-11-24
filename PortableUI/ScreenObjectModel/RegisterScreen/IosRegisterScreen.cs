using System;
using Xamarin.UITest.Queries;

namespace PortableUI.ScreenObjectModel.RegisterScreen
{
    public class IosRegisterScreen:IRegisterScreen
    {
        //Email
        public Func<AppQuery, AppQuery> EnterEmailStr { get; } = c => c.Class("UILabel").Marked("EnterEmail");
        public Func<AppQuery, AppQuery> EmailField { get; } = c => c.Class("ValidTextFieldView").Marked("EmailReg");
        public Func<AppQuery, AppQuery> EmailNextBtn { get; } = c => c.Class("UIButton").Marked("NextFromEmail");
        public Func<AppQuery, AppQuery> EmailSloganStr { get; } = c => c.Class("UILabel").Marked("EmailSlogan");

        //Phone
        public Func<AppQuery, AppQuery> EnterPhoneStr { get; } = c => c.Class("UILabel").Marked("EnterPhone");
        public Func<AppQuery, AppQuery> CountryCode { get; } = c => c.Class("UIButton").Marked("CountryCode");
        public Func<AppQuery, AppQuery> PhoneField { get; } = c => c.Class("ValidTextFieldView").Marked("Phone");
        public Func<AppQuery, AppQuery> PhoneNextBtn { get; } = c => c.Class("UIButton").Marked("NextFromPhone");
        public Func<AppQuery, AppQuery> PhoneSloganStr { get; } = c => c.Class("UILabel").Marked("PhoneSlogan");

        //Name
        public Func<AppQuery, AppQuery> EnterNamesStr { get; } = c => c.Class("UILabel").Marked("EnterNames");
        public Func<AppQuery, AppQuery> FirstNameField { get; } = c => c.Class("ValidTextFieldView").Marked("FirstName");
        public Func<AppQuery, AppQuery> LastNameField { get; } = c => c.Class("ValidTextFieldView").Marked("LastName");
        public Func<AppQuery, AppQuery> NameNextBtn { get; } = c => c.Class("UIButton").Marked("NextFromName");
        public Func<AppQuery, AppQuery> NamesSloganStr { get; } = c => c.Class("UILabel").Marked("NamesSlogan");

        //Pass
        public Func<AppQuery, AppQuery> EnterPassStr { get; } = c => c.Class("UILabel").Marked("EnterPass");
        public Func<AppQuery, AppQuery> PasswordField { get; } = c => c.Class("ValidTextFieldView").Marked("Password");
        public Func<AppQuery, AppQuery> ConfirmPasswordField { get; } = c => c.Class("ValidTextFieldView").Marked("ConfirmPassword");
        public Func<AppQuery, AppQuery> UsersAgreement { get; } = c => c.Class("UILabel").Marked("UsersAgreement");
        public Func<AppQuery, AppQuery> SignUp { get; } = c => c.Class("UIButton").Marked("SignUp");
        public Func<AppQuery, AppQuery> PassSloganStr { get; } = c => c.Class("UILabel").Marked("PassSlogan");
    }
}
