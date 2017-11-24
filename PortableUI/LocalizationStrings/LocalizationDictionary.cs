using System.Collections.Generic;
namespace PortableUI
{
    public static class LocalizationDictionary
    {
        public static Dictionary<string, string> DrawerLocalizedStrings;
        public static Dictionary<string, string> ToolsStrings;
        public static Dictionary<string, string> FavoritesStrings;
        public static Dictionary<string, string> OpenDealDialogStrings;
        public static Dictionary<string, string> OpenedDealsListStrings;
        public static Dictionary<string, string> ClosedDealsListStrings;

        public static void Init(ScreenInit screen)
        {
            DrawerLocalizedStrings = new Dictionary<string, string>
            {

                {"DrawerDeposit", screen.Localization.DrawerDeposit },
                {"DrawerBalances", screen.Localization.DrawerBalances },
                {"DrawerFavorites", screen.Localization.DrawerFavorites },
                {"DrawerTools", screen.Localization.DrawerTools },
                {"DrawerOpenDeals", screen.Localization.DrawerOpenDeals },
                {"DrawerLimitOrders", screen.Localization.DrawerLimitOrders },
                {"DrawerClosedDeals", screen.Localization.DrawerClosedDeals },
                {"DrawerDetailMode", screen.Localization.DrawerDetailMode },
            };

            ToolsStrings = new Dictionary<string, string>
            {
                {"DepositStr", screen.Localization.DepositBtn},
                {"FreeBalance", screen.Localization.FreeBalance },
                {"BalancePL", screen.Localization.BalancePL }
            };

            FavoritesStrings = new Dictionary<string, string>
            {
                
                {"InfoPanelName",screen.Localization.InfoPanelName},
                {"InfoPanelTrend",screen.Localization.InfoPanelTrend},
                {"InfoPanelSell",screen.Localization.InfoPanelSell},
                {"InfoPanelBuy",screen.Localization.InfoPanelBuy}
            };

            OpenDealDialogStrings = new Dictionary<string, string>
            {
                {"OpenDealDialogLimitOrder",screen.Localization.LimitOrderBtn }
            };

            OpenedDealsListStrings = new Dictionary<string, string>
            {
                {"OpenedDealsListSL", screen.Localization.SL },
                {"OpenedDealsListTP", screen.Localization.TP },
                {"OpenedDealsListCloseDealBtn", screen.Localization.CloseDealBtn },
               
            };

            ClosedDealsListStrings = new Dictionary<string, string>
            {
               
            };
        }
    }
}
