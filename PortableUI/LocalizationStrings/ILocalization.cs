using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortableUI
{
    public interface ILocalization
    {
        //Authorization
        string Email { get; }
        string Password { get; }
        string LoginButton { get; }
        string NoAccount { get; }

        //Registration
        string NextButton { get; }
        string EnterEmail { get; }
        string SloganEmail { get; }
        string EnterPhone { get; }
        string Phone { get; }
        string SloganPhone { get; }
        string EnterNames { get; }
        string FirstName { get; }
        string LastName { get; }
        string SloganNames { get; }
        string EnterPass { get; }
        string ConfirmPassword { get; }
        string UserAgreement { get; }
        string SignUpButton { get; }
        string SloganPass { get; }

        //Password Recovery
        string RecoverPassButton { get; }
        string SloganRecoverPass { get; }


        string SuccessfulRegistrationMessage { get; }
        string IncorrectEmailPassMessage { get; }
        //Favorites screen

        string ToolbarTitleOnFavorites { get; }
        string DepositBtn { get; }
        string FreeBalance { get; }
        string BalancePL { get; }
        string InfoPanelName { get; }
        string InfoPanelTrend { get; }
        string InfoPanelSell { get; }
        string InfoPanelBuy { get; }
        string DealTypeSell { get; }
        string DealTypeBuy { get; }

        //Drawer

        string DrawerDeposit { get; }
        string DrawerBalances { get; }
        string DrawerFavorites { get; }
        string DrawerTools { get; }
        string DrawerOpenDeals { get; }
        string DrawerLimitOrders { get; }
        string DrawerClosedDeals { get; }
        string DrawerDetailMode { get; }

        //Open deal dialog
        string LimitOrderBtn { get; }
        string TickerContracts { get; }
        string TickerStocks { get; }
        string BuyBtn { get; }
        string SellBtn { get; }
        string Today { get; }
        string Margin { get; }
        string InvalidAmount { get; }

        //Opened Deals screen
        string CloseDealBtn { get; }
        string SL { get; }
        string TP { get; }
        string ToolbarTitleOnOpenedDeals { get; }

        //Closed Deals screen
        string ToolbarTitleOnClosedDeals { get; }

        //Help
        string Yes { get; }
    }

}
