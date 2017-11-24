using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortableUI
{
    class ENStrings:ILocalization
    {
        public string Email { get; } = "Email";
        public string Password { get; } = "Password";
        public string LoginButton { get; } = "LOGIN";
        public string NoAccount { get; } = "Don't have an account?";

        public string NextButton { get; } = "NEXT";

        public string EnterEmail { get; } = "Enter your email";
        public string SloganEmail { get; } = "Customer Support 24/7";

        public string EnterPhone { get; } = "Enter your phone";
        public string Phone { get; } = "Phone number";
        public string SloganPhone { get; } = "Actual quotes\n from reliable providers";

        public string EnterNames { get; } = "Enter your first and last name";
        public string FirstName { get; } = "First name";
        public string LastName { get; } = "Last name";
        public string SloganNames { get; } = "170 trading assets for your profit!";

        public string EnterPass { get; } = "Create a password";
        public string ConfirmPassword { get; } = "Confirm password";
        public string UserAgreement { get; } = "By clicking \"Sign Up\", you agree to our Users Agreement.";
        public string SignUpButton { get; } = "SIGN UP";
        public string SloganPass { get; } = "Заработок без скрытых комиссий!";
        public string RecoverPassButton { get; } = "RECOVER PASSWORD";
        public string SloganRecoverPass { get; } = "Earn, wherever you are!";

        public string SuccessfulRegistrationMessage { get; } = "Registration completed successfully!";
        public string IncorrectEmailPassMessage { get; } = "Incorrect email address or password.";

//Favorites screen
        public string ToolbarTitleOnFavorites { get; } = "Favorites";
        public string DepositBtn { get; } = "DEPOSIT";
        public string FreeBalance { get; } = "Free Balance:";
        public string BalancePL { get; } = "P&L:";
        public string InfoPanelName { get; } = "Name";
        public string InfoPanelTrend { get; } = "Trend";
        public string InfoPanelSell { get; } = "Sell";
        public string InfoPanelBuy { get; } = "Buy";
        public string DealTypeSell { get; } = "SELL";
        public string DealTypeBuy { get; } = "BUY";

        //Drawer
        public string DrawerDeposit { get; } = "Deposit";
        public string DrawerBalances { get; } = "Balances";
        public string DrawerFavorites { get; } = "Favorites";
        public string DrawerTools { get; } = "Tools";
        public string DrawerOpenDeals { get; } = "Open Deals";
        public string DrawerLimitOrders { get; } = "Limit Orders";
        public string DrawerClosedDeals { get; } = "Closed Deals";
        public string DrawerDetailMode { get; } = "Detail Mode";

        //Open deal dialog
        public string LimitOrderBtn { get; } = "Limit\nOrder";

        public string TickerContracts { get; } = "Contr.";
        public string TickerStocks { get; } = "Stocks";
        public string BuyBtn { get; } = "BUY";
        public string SellBtn { get; } = "SELL";
        public string Today { get; } = "today";
        public string Margin { get; } = "Margin";

        public string InvalidAmount { get; } = "Order's quantity is not in allowable interval.";
        //Opened Deals screen
        public string CloseDealBtn { get; } = "CLOSE DEAL";

        public string SL { get; } = "SL";
        public string TP { get; } = "TP";
        public string ToolbarTitleOnOpenedDeals { get; } = "Opened Deals";

        //Closed deals
        public string ToolbarTitleOnClosedDeals { get; } = "Closed Deals";

        public string Yes { get; } = "Yes";
    }
}
