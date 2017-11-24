using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace PortableUI.ScreenObjectModel.RegisterScreen
{
    public interface IRegisterScreen
    {
        //Email
        Func<AppQuery, AppQuery> EnterEmailStr { get; }
        Func<AppQuery, AppQuery> EmailField { get; }
        Func<AppQuery, AppQuery> EmailNextBtn { get; }
        Func<AppQuery, AppQuery> EmailSloganStr { get; }

        //Phone
        Func<AppQuery, AppQuery> EnterPhoneStr { get; }
        Func<AppQuery, AppQuery> CountryCode { get; }
        Func<AppQuery, AppQuery> PhoneField { get; }
        Func<AppQuery, AppQuery> PhoneNextBtn { get; }
        Func<AppQuery, AppQuery> PhoneSloganStr { get; }

        //Name
        Func<AppQuery, AppQuery> EnterNamesStr { get; }
        Func<AppQuery, AppQuery> FirstNameField { get; }
        Func<AppQuery, AppQuery> LastNameField { get; }
        Func<AppQuery, AppQuery> NameNextBtn { get; }
        Func<AppQuery, AppQuery> NamesSloganStr { get; }

        //Phone
        Func<AppQuery, AppQuery> EnterPassStr { get; }
        Func<AppQuery, AppQuery> PasswordField { get; }
        Func<AppQuery, AppQuery> ConfirmPasswordField { get; }
        Func<AppQuery, AppQuery> UsersAgreement { get; }
        Func <AppQuery,AppQuery> SignUp { get; }
        Func<AppQuery, AppQuery> PassSloganStr { get; }
    }
}
