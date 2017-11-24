using System;
using Xamarin.UITest.Queries;


namespace PortableUI
{
    public interface IAuthRegisterScreen
    {
        //-----------------------Authorize---------------------//

         Func<AppQuery, AppQuery> Email { get; } //Поле электронная почта
         Func<AppQuery, AppQuery> Password { get; } // Поле пароль
         Func<AppQuery, AppQuery> Login_Btn { get; } // Кнопка "Войти"
         Func<AppQuery, AppQuery> Btn_Registr_From_Login { get; }
         Func<AppQuery, AppQuery> Forgot_Pass { get; }
    }
}
