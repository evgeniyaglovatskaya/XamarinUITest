using System;
using Xamarin.UITest.Queries;

namespace PortableUI.ScreenObjectModel.Deposit
{
    public class Astropay
    {
        //Astropay BANK
        public Func<AppQuery, AppWebQuery> Amount { get; } =
            c => c.WebView().Css("#astropayAmount");
        public Func<AppQuery, AppWebQuery> Send { get; } =
            c => c.WebView().Css("#btnAstropaySubmit");
    }
}
