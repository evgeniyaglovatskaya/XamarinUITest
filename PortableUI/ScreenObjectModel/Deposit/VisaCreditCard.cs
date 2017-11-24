using System;
using Xamarin.UITest.Queries;

namespace PortableUI.ScreenObjectModel.Deposit
{
    public class VisaCreditCard
    {
        // Visa Credit Card, 3D secure
        public Func<AppQuery, AppWebQuery> DepositAmount { get; } =
            c => c.WebView().Css("#deposit-amount");
        public Func<AppQuery, AppWebQuery> CardNumberPart1 { get; } =
            c => c.WebView().Css("#card-number-1");
        public Func<AppQuery, AppWebQuery> CardNumberPart2 { get; } =
            c => c.WebView().Css("div.col-xs-3:nth-child(2) > input:nth-child(1)");
        public Func<AppQuery, AppWebQuery> CardNumberPart3 { get; } =
            c => c.WebView().Css("div.col-xs-3:nth-child(3) > input:nth-child(1)");
        public Func<AppQuery, AppWebQuery> CardNumberPart4 { get; } =
            c => c.WebView().Css("div.col-xs-3:nth-child(4) > input:nth-child(1)");
        public Func<AppQuery, AppWebQuery> CardOwnerName { get; } =
            c => c.WebView().Css("#holder");
        public Func<AppQuery, AppWebQuery> CardMonth { get; } =
            c => c.WebView().Css("#expirationMonth");
        public Func<AppQuery, AppWebQuery> CardYear { get; } =
            c => c.WebView().Css("#expirationYear");
        public Func<AppQuery, AppWebQuery> CardCVV { get; } =
            c => c.WebView().Css("#cardCvv");
        public Func<AppQuery, AppWebQuery> BtnContinue { get; } =
            c => c.WebView().Css("button.btn:nth-child(2)");
        public Func<AppQuery, AppWebQuery> BtnBack { get; } =
            c => c.WebView().Css("a.btn");

    }
}
