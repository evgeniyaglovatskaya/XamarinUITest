using System;
using System.Collections.Generic;
using Xamarin.UITest.Queries;

namespace PortableUI
{
    public static class ElemDictionary
    {

        public static Dictionary<string, Func<AppQuery, AppQuery>> DrawerQueriesLocalized;
        public static Dictionary<string, Func<AppQuery, AppQuery>> ToolsQueriesLocalized;
        public static Dictionary<string, Func<AppQuery, AppQuery>> FavoritesQueriesLocalized;
        public static Dictionary<string, Func<AppQuery, AppQuery>> OpenDealDialogQueriesLocalized;
        public static Dictionary<string, Func<AppQuery, AppQuery>> OpenedDealsListQueriesLocalized;
        public static Dictionary<string, Func<AppQuery, AppQuery>> ClosedDealsListQueriesLocalized;
        //public static Dictionary<string, Action<BaseTest>> TransitionMethods;

        //public static Action<BaseTest> GoToDepositAction = a => a.GoToDeposit();

        public static void Init(ScreenInit screen)
        {


            DrawerQueriesLocalized = new Dictionary<string, Func<AppQuery, AppQuery>>
            {
                {"DrawerDeposit", screen.Drawer.Deposit },
                {"DrawerBalances", screen.Drawer.Balances },
                {"DrawerFavorites", screen.Drawer.Favorites },
                {"DrawerTools", screen.Drawer.Tools },
                {"DrawerOpenDeals", screen.Drawer.Open_Deals },
                {"DrawerLimitOrders", screen.Drawer.Limit_Orders },
                {"DrawerClosedDeals", screen.Drawer.Closed_Deals },
                {"DrawerDetailMode", screen.Drawer.Detail_Mode },
            };
            ToolsQueriesLocalized = new Dictionary<string, Func<AppQuery, AppQuery>>
            {
                {"ToolsDeposit", screen.Tools.Deposit_Btn },
                {"ToolsFreeBalance", screen.Tools.FreeBalance},
                {"ToolsPL", screen.Tools.PL},
            };
            FavoritesQueriesLocalized = new Dictionary<string, Func<AppQuery, AppQuery>>
            {
                
                {"FavoritesInfoPanelName", screen.Favorites.InfoPanelName },
                {"FavoritesInfoPanelTrend", screen.Favorites.InfoPanelTrend },
                {"FavoritesInfoPanelSell", screen.Favorites.InfoPanelSell },
                {"FavoritesInfoPanelBuy", screen.Favorites.InfoPanelBuy }

            };
            OpenDealDialogQueriesLocalized = new Dictionary<string, Func<AppQuery, AppQuery>>
            {
                {"OpenDealDialogLimitOrder",screen.OpenDeal.LimitOrderBtn }
            };

            OpenedDealsListQueriesLocalized = new Dictionary<string, Func<AppQuery, AppQuery>>
            {
                {"OpenedDealsListSL", screen.OpenedDeal.StopLoss },
                {"OpenedDealsListTP", screen.OpenedDeal.TakeProfit },
                {"OpenedDealsListCloseDealBtn", screen.OpenedDeal.CloseBtn },
               
            };

            ClosedDealsListQueriesLocalized = new Dictionary<string, Func<AppQuery, AppQuery>>
            {
               
            };
            //TransitionMethods = new Dictionary<string, Action<BaseTest>>
            //{
            //    {"GoToDeposit", GoToDepositAction},
            //};
        }
    }
}
