using System;
using Xamarin.UITest.Queries;

namespace PortableUI.ScreenObjectModel.Deposit
{
    public class DepositScreen
    {
        public Func<AppQuery,AppWebQuery> EmailAuth { get; } = c => c.WebView().Css("#email");
        public Func<AppQuery, AppWebQuery> PassAuth { get; } = c => c.WebView().Css("#password");
        public Func<AppQuery, AppWebQuery> LoginBtnAuth { get; } = c => c.WebView().Css(".btn");

        //Deposit payment methods
        public Func<AppQuery, AppWebQuery> VisaCreditCard { get; } =
            c => c.WebView().Css("div.b-payment-item:nth-child(2) > a:nth-child(1)");
        public Func<AppQuery, AppWebQuery> Visa3dSecure { get; } =
            c => c.WebView().Css("div.b-payment-item:nth-child(3) > a:nth-child(1)");
        public Func<AppQuery, AppWebQuery> WireTransfer { get; } =
            c => c.WebView().Css(".i-wire");
        public Func<AppQuery, AppWebQuery> OnlineWireTransfer { get; } =
            c => c.WebView().Css(".i-onlinewire");
        public Func<AppQuery, AppWebQuery> CASHU { get; } =
            c => c.WebView().Css(".i-cashu");
        public Func<AppQuery, AppWebQuery> Neteller { get; } =
            c => c.WebView().Css(".i-neteller");
        public Func<AppQuery, AppWebQuery> YandexMoney { get; } =
            c => c.WebView().Css(".i-yandex");
        public Func<AppQuery, AppWebQuery> WalletOne { get; } =
            c => c.WebView().Css(".i-wallet-one");
        public Func<AppQuery, AppWebQuery> QiwiWallet { get; } =
            c => c.WebView().Css(".i-qiwi");
        public Func<AppQuery, AppWebQuery> WebMoney { get; } =
            c => c.WebView().Css(".i-webmoney");
        public Func<AppQuery, AppWebQuery> YuuPay { get; } =
            c => c.WebView().Css(".i-yuupay");
        public Func<AppQuery, AppWebQuery> MonetaRu { get; } =
            c => c.WebView().Css(".i-monetaru");
        public Func<AppQuery, AppWebQuery> BoletoBankario { get; } =
            c => c.WebView().Css(".i-boleto");
        public Func<AppQuery, AppWebQuery> Astropay { get; } =
            c => c.WebView().Css(".i-astropay");
        public Func<AppQuery, AppWebQuery> AlfaBank { get; } =
            c => c.WebView().Css(".i-alfabank");
        public Func<AppQuery, AppWebQuery> Promsvyazbank { get; } =
            c => c.WebView().Css(".i-promsvyazbank");
        public Func<AppQuery, AppWebQuery> Aonpay { get; } =
            c => c.WebView().Css(".i-aonpay");
      

    }
}
