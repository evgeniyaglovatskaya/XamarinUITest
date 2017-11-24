using System;
using Xamarin.UITest.Queries;

namespace PortableUI.ScreenObjectModel.Deposit
{
    public class YandexMoney
    {
        //Yandex Money
        public Func<AppQuery, AppWebQuery> Amount { get; } =
            c => c.WebView().Css("#MNT_AMOUNT");
        public Func<AppQuery, AppWebQuery> Send { get; } =
            c => c.WebView().Css("#btnYandexSubmit");

    }
}
