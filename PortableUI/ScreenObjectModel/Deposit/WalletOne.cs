using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace PortableUI.ScreenObjectModel.Deposit
{
    public class WalletOne
    {
        public Func<AppQuery, AppWebQuery> Amount { get; } =
            c => c.WebView().Css("#wallet-one-amount");
        public Func<AppQuery, AppWebQuery> Send { get; } =
            c => c.WebView().Css("#btn-wallet-one-submit");
    }
}
