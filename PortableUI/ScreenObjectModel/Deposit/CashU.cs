using System;
using Xamarin.UITest.Queries;

namespace PortableUI.ScreenObjectModel.Deposit
{
    public class CashU
    {
        //Cash U
        public Func<AppQuery, AppWebQuery> Amount { get; } =
            c => c.WebView().Css("#amount");
        public Func<AppQuery, AppWebQuery> Send { get; } =
            c => c.WebView().Css("#btnCashUSubmit");

    }
}
