using System;
using Xamarin.UITest.Queries;

namespace PortableUI.ScreenObjectModel.Deposit
{
    public class Neteller
    {
        //Neteller
        public Func<AppQuery, AppWebQuery> Amount { get; } =
            c => c.WebView().Css("#neteller-Amount");
        public Func<AppQuery, AppWebQuery> Send { get; } =
            c => c.WebView().Css("#btnNetellerSubmit");
    }
}
