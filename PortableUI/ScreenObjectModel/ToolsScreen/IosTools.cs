using System;
using Xamarin.UITest.Queries;

namespace PortableUI
{
    public class IosTools : ITools
    {
        public Func<AppQuery, AppQuery> DepositBalance { get; } = c => c.Class("").Marked("");
        public Func<AppQuery, AppQuery> Deposit_Btn { get; } = c => c.Class("UILabel").Marked("Deposit");
        public Func<AppQuery, AppQuery> Deposit_Web_View { get; }
        public Func<AppQuery, AppQuery> FreeBalance { get; } = c => c.Class("UILabel").Marked("FreeBalance");
        public Func<AppQuery, AppQuery> PL { get; } = c => c.Class("UILabel").Marked("PnL");

        public Func<AppQuery, AppQuery> ToolbarTitle { get; } = c => c.Class("UINavigationItem").Marked("Title");
        public Func<AppQuery, AppQuery> Eguity { get; }
        public Func<AppQuery, AppQuery> Balance { get; }
        public Func<AppQuery, AppQuery> Balances_Panel { get; }
        public Func<AppQuery, AppQuery> Confirmation { get; }
    }



}