using System;
using Xamarin.UITest.Queries;

namespace PortableUI
{
    class AndroidTools : ITools
    {
        public Func<AppQuery, AppQuery> DepositBalance { get; } = c => c.Id("toolbar_deposit_balance_tv");
        public Func<AppQuery, AppQuery> Deposit_Btn { get; } = c => c.Id("toolbar_deposit_tv");
        public Func<AppQuery, AppQuery> Deposit_Web_View { get; } = c => c.Id("depositWebView");
        public Func<AppQuery, AppQuery> FreeBalance { get; } = c => c.Id("balancePanel_TextView_BalanceField");
        public Func<AppQuery, AppQuery> PL { get; } = c => c.Id("balancePanel_TextView_PnlField");
        public Func<AppQuery, AppQuery> ToolbarTitle { get; } = c => c.Id("toolbar_title");
        public Func<AppQuery, AppQuery> Eguity { get; }
        public Func<AppQuery, AppQuery> Balance { get; }
        public Func<AppQuery, AppQuery> Balances_Panel { get; }
    }
}