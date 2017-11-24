using System;
using Xamarin.UITest.Queries;

namespace PortableUI.ScreenObjectModel.Deposit
{
    public class Promsvyazbank
    {
        //Promsvyazbank
        public Func<AppQuery, AppWebQuery> Amount { get; } =
            c => c.WebView().Css("#promsvyazbankAmount");
        public Func<AppQuery, AppWebQuery> Send { get; } =
            c => c.WebView().Css("#btnPromsvyazBankSubmit");
    }
}
