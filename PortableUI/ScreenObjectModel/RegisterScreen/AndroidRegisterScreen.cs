using System;
using Xamarin.UITest.Queries;

namespace PortableUI.ScreenObjectModel.RegisterScreen
{
    public class AndroidRegisterScreen: IRegisterScreen
    {
        public Func<AppQuery, AppQuery> EnterEmailStr { get; } = c => c.Id("EmailRegFragment_TextView_InputData");
        public Func<AppQuery, AppQuery> EmailField { get; } = c => c.Id("EmailRegFragment_ValidTextFieldView_Email").Child().Child().Child();
        public Func<AppQuery, AppQuery> EmailNextBtn { get; } = c => c.Id("EmailRegFragment_Button_Next");
        public Func<AppQuery, AppQuery> EmailSloganStr { get; } = c => c.Id("EmailRegFragment_TextView_Tips");

        public Func<AppQuery, AppQuery> EnterPhoneStr { get; } = c => c.Id("PhoneRegFragment_TextView_InputData"); 
        public Func<AppQuery, AppQuery> CountryCode { get; } = c => c.Id("PhoneRegFragment_TextView_CountryCode");
        public Func<AppQuery, AppQuery> PhoneField { get; } = c => c.Id("PhoneRegFragment_ValidTextFieldView_Phone").Child().Child().Child();
        public Func<AppQuery, AppQuery> PhoneNextBtn { get; } = c => c.Id("PhoneRegFragment_Button_Next");
        public Func<AppQuery, AppQuery> PhoneSloganStr { get; } = c => c.Id("PhoneRegFragment_TextView_Tips");

        public Func<AppQuery, AppQuery> EnterNamesStr { get; } = c => c.Id("FirstLastNameFragment_TextView_InputData");
        public Func<AppQuery, AppQuery> FirstNameField { get; } = c => c.Id("FirstLastNameFragment_ValidTextFieldView_FirstName").Child().Child().Child();
        public Func<AppQuery, AppQuery> LastNameField { get; } = c => c.Id("FirstLastNameFragment_ValidTextFieldView_LastName").Child().Child().Child();
        public Func<AppQuery, AppQuery> NameNextBtn { get; } = c => c.Id("FirstLastNameFragment_Button_Next");
        public Func<AppQuery, AppQuery> NamesSloganStr { get; } = c => c.Id("FirstLastNameFragment_TextView_Tips");

        public Func<AppQuery, AppQuery> EnterPassStr { get; } = c => c.Id("PasswordRegFragment_TextView_InputData");
        public Func<AppQuery, AppQuery> PasswordField { get; } = c => c.Id("PasswordRegFragment_ValidTextFieldView_Password").Child().Child().Child();
        public Func<AppQuery, AppQuery> ConfirmPasswordField { get; } = c => c.Id("PasswordRegFragment_ValidTextFieldView_ConfirmPassword").Child().Child().Child();
        public Func<AppQuery, AppQuery> UsersAgreement { get; } = c => c.Id("PasswordRegFragment_TextView_Agreement");
        public Func<AppQuery, AppQuery> SignUp { get; } = c => c.Id("PasswordRegFragment_Button_Register");
        public Func<AppQuery, AppQuery> PassSloganStr { get; } = c => c.Id("PasswordRegFragment_TextView_Tips");
    }
}
