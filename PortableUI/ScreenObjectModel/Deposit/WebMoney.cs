using System;
using Xamarin.UITest.Queries;

namespace PortableUI.ScreenObjectModel.Deposit
{
    public class WebMoney
    {
        //Web money
        public Func<AppQuery, AppWebQuery> Currency { get; } =
            c => c.WebView().Css("#currency");
        public Func<AppQuery, AppWebQuery> USD { get; } =
            c => c.WebView().Css("#ddlCurrency > li:nth-child(1) > a:nth-child(1)");
        public Func<AppQuery, AppWebQuery> RUB { get; } =
            c => c.WebView().Css("#ddlCurrency > li:nth-child(2) > a:nth-child(1)");
        public Func<AppQuery, AppWebQuery> Amount { get; } =
            c => c.WebView().Css("#accentpayAmount");
        public Func<AppQuery, AppWebQuery> Send { get; } =
            c => c.WebView().Css("#btnAccentpaySubmit");
    }
}
