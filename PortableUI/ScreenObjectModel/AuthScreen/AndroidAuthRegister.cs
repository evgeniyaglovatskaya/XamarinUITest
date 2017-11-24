using System;
using Xamarin.UITest.Queries;


namespace PortableUI
{
    public class AndroidAuthRegister : IAuthRegisterScreen
    {
        public Func<AppQuery, AppQuery> Email { get; } = c => c.Id("AuthFragment_ValidTextFieldView_Login").Child().Child().Child(0);
        public Func<AppQuery, AppQuery> Password { get; } = c => c.Id("AuthFragment_ValidTextFieldView_Password").Child().Child().Child(0);
        public Func<AppQuery, AppQuery> Login_Btn { get; } = c => c.Id("AuthFragment_Button_Login");
        public Func<AppQuery, AppQuery> Btn_Registr_From_Login { get; } = c => c.Id("AuthFragment_Button_Register");
        public Func<AppQuery, AppQuery> Forgot_Pass { get; } = c => c.Id("AuthFragment_TextView_ForgotPass");
    }


}
