using System;
using Xamarin.UITest.Queries;

namespace PortableUI
{
    public class IosFavorites : IFavoritesScreen
    {
        public Func<AppQuery, AppQuery> InfoPanel { get; } = c => c.Class("TableHeaderPanel").Marked("Table");
        public Func<AppQuery, AppQuery> InfoPanelName { get; } = c => c.Class("UILabel").Marked("InfoPanelName");
        public Func<AppQuery, AppQuery> InfoPanelTrend { get; } = c => c.Class("UILabel").Marked("InfoPanelTrend");
        public Func<AppQuery, AppQuery> InfoPanelSell { get; } = c => c.Class("UILabel").Marked("InfoPanelSell");
        public Func<AppQuery, AppQuery> InfoPanelBuy { get; } = c => c.Class("UILabel").Marked("InfoPanelBuy");
        public Func<AppQuery, AppQuery> Recycler { get; } = c => c.Id("mainTable_relativeLayout");

        //-----------------------  Instrumental card ---------------//
        public Func<AppQuery, AppQuery> Card { get; } = c => c.Class("UIView").Marked("Card");
        public Func<AppQuery, AppQuery> InstrName { get; } = c => c.Class("UIView").Marked("Card");
        public Func<AppQuery, AppQuery> ChartCardLayout { get; } = c => c.Class("ChartConteinerView").Marked("Chart");
        public Func<AppQuery, AppQuery> SellCard { get; } = c => c.Class("UIView").Marked("Sell");
        public Func<AppQuery, AppQuery> BuyCard { get; } = c => c.Class("UIView").Marked("Buy");

    }

}