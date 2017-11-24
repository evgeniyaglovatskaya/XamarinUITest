using System;
using Xamarin.UITest.Queries;

namespace PortableUI
{
    public class AndroidFavorites : IFavoritesScreen
    {
        public Func<AppQuery, AppQuery> InfoPanel { get; } = c => c.Id("inflated_frMainTable_header_stub");
        public Func<AppQuery, AppQuery> InfoPanelName { get; } = c => c.Id("header_name");
        public Func<AppQuery, AppQuery> InfoPanelTrend { get; } = c => c.Id("header_trend");
        public Func<AppQuery, AppQuery> InfoPanelSell { get; } = c => c.Id("header_bid");
        public Func<AppQuery, AppQuery> InfoPanelBuy { get; } = c => c.Id("header_ask");
        public Func<AppQuery, AppQuery> Recycler { get; } = c => c.Id("mainTable_relativeLayout");

        //-----------------------  Instrumental card ---------------//
        public Func<AppQuery, AppQuery> Card { get; } = c => c.Id("card_view");
        public Func<AppQuery, AppQuery> InstrName { get; } = c => c.Id("instrument_name_tv");
        public Func<AppQuery, AppQuery> ChartCardLayout { get; } = c => c.Id("chartViewD");
        public Func<AppQuery, AppQuery> SellCard { get; } = c => c.Id("instrument_bid_tv");
        public Func<AppQuery, AppQuery> BuyCard { get; } = c => c.Id("instrument_ask_tv");
    }


}