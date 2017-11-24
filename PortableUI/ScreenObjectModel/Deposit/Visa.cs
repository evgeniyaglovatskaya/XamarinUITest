using System;
using Xamarin.UITest.Queries;

namespace PortableUI.ScreenObjectModel.Deposit
{

    public class Visa
    {
        public Func<AppQuery, AppWebQuery> Currency { get; } =
            c => c.WebView().Css("#purse");
        public Func<AppQuery, AppWebQuery> USD { get; } =
            c => c.WebView().Css("#ddlCurrency > li:nth-child(1) > a:nth-child(1)");
        public Func<AppQuery, AppWebQuery> EUR { get; } =
            c => c.WebView().Css("#ddlCurrency > li:nth-child(2) > a:nth-child(1)");
        public Func<AppQuery, AppWebQuery> GBP { get; } =
            c => c.WebView().Css("#ddlCurrency > li:nth-child(3) > a:nth-child(1)");
        public Func<AppQuery, AppWebQuery> RUB { get; } =
            c => c.WebView().Css("#ddlCurrency > li:nth-child(4) > a:nth-child(1)");
        public Func<AppQuery, AppWebQuery> Amount { get; } =
            c => c.WebView().Css("#aonpayAmount");
        public Func<AppQuery, AppWebQuery> FirstName { get; } =
            c => c.WebView().Css("#aonpayBillingFirstName");
        public Func<AppQuery, AppWebQuery> LastName { get; } =
            c => c.WebView().Css("#aonpayBillingLastName");
        public Func<AppQuery, AppWebQuery> Email { get; } =
            c => c.WebView().Css("#aonpayBillingEmail");
        public Func<AppQuery, AppWebQuery> Phone { get; } =
            c => c.WebView().Css("#aonpayBillingPhone");
        public Func<AppQuery, AppWebQuery> Country { get; } =
            c => c.WebView().Css("#aonpayBillingCountry");
        public Func<AppQuery, AppWebQuery> City { get; } =
            c => c.WebView().Css("#aonpayBillingCity");
        public Func<AppQuery, AppWebQuery> Adress { get; } =
            c => c.WebView().Css("#aonpayBillingAddress");
        public Func<AppQuery, AppWebQuery> PostIndex { get; } =
            c => c.WebView().Css("#aonpayBillingZip");
        public Func<AppQuery, AppWebQuery> Send { get; } =
            c => c.WebView().Css("#btnAonpaySubmit");
    }
}
