using System;
using Xamarin.UITest.Queries;

namespace PortableUI.ScreenObjectModel.Deposit
{
    public class OnlineWireTransfer
    {
        //Online wire transfer
        public Func<AppQuery, AppWebQuery> Currency { get; } =
            c => c.WebView().Css("#purse");
        public Func<AppQuery, AppWebQuery> USD { get; } =
            c => c.WebView().Css("#ddlCurrency > li:nth-child(1) > a:nth-child(1)");
        public Func<AppQuery, AppWebQuery> AED { get; } =
            c => c.WebView().Css("#ddlCurrency > li:nth-child(2) > a:nth-child(1)");
        public Func<AppQuery, AppWebQuery> Amount { get; } =
            c => c.WebView().Css("#amount");
        public Func<AppQuery, AppWebQuery> Send { get; } =
            c => c.WebView().Css("#btnWireSubmit");

    }
}
