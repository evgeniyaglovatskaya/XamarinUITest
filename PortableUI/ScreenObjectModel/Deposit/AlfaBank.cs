using System;
using Xamarin.UITest.Queries;

namespace PortableUI.ScreenObjectModel.Deposit
{
    public class AlfaBank
    {
        //Alfa BANK
        public Func<AppQuery, AppWebQuery> Amount { get; } =
            c => c.WebView().Css("#alfaBankAmount");
        public Func<AppQuery, AppWebQuery> Send { get; } =
            c => c.WebView().Css("#btnAlfaBankSubmit");
    }
}
