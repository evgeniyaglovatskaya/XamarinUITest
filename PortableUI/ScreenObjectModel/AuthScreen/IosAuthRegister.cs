using System;

using Xamarin.UITest;
using Xamarin.UITest.Queries;


namespace PortableUI
{
    public class IosAuthRegister : IAuthRegisterScreen
    {
        public Func<AppQuery, AppQuery> Email { get; } = c => c.Class("ValidTextFieldView").Marked("Email");
        public Func<AppQuery, AppQuery> Password { get; } = c => c.Class("ValidTextFieldView").Marked("Password");
        public Func<AppQuery, AppQuery> Login_Btn { get; } = c => c.Class("UIButton").Marked("Login");
        public Func<AppQuery, AppQuery> Btn_Registr_From_Login { get; } = c => c.Class("UIButton").Marked("Signup");
        public Func<AppQuery, AppQuery> Forgot_Pass { get; } = c => c.Class("UIButton").Marked("Forgotpass");
    }


}
