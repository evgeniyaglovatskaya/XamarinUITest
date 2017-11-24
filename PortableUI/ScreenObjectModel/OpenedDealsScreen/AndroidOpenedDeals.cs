using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace PortableUI
{
    public class AndroidOpenedDeals : IOpenedDealsScreen
    {

        //-------------------Open-deal card--------------------------//
        public Func<AppQuery, AppQuery> Card { get; } = c => c.Class("android.widget.RelativeLayout").Index(0);
        public Func<AppQuery, AppQuery> InstrName { get; } = c => c.Id("openDeals_Card_TextView_InstrumentName");// Название инструмента на карточке сделки
        public Func<AppQuery, AppQuery> DealType { get; } = c => c.Id("closedDeals_Card_TextView_BuySell");//   
        public Func<AppQuery, AppQuery> Amount { get; } = c => c.Id("openDeals_Card_TextView_DealAmount");
        public Func<AppQuery, AppQuery> DealPrice { get; } = c => c.Id("openDeals_Card_TextView_DealPrice");
        public Func<AppQuery, AppQuery> MarketPrice { get; } = c => c.Id("openDeals_Card_TextView_MarketPrice");
        public Func<AppQuery, AppQuery> StopLoss { get; } = c => c.Id("openDeals_Card_TextView_SL");//
        public Func<AppQuery, AppQuery> TakeProfit { get; } = c => c.Id("openDeals_Card_TextView_TP");//
        public Func<AppQuery, AppQuery> CloseBtn { get; } = c => c.Id("openDeals_Card_TextView_CloseDeal");//
        public Func<AppQuery, AppQuery> PnLOnBtn { get; } = c => c.Id("openDeals_Card_TextView_PnL");//

        //-------------------Close all panel-----------------------//
        public Func<AppQuery, AppQuery> CloseAllBlueBtn { get; } = c => c.Id("CloseAllBtn");//Close all
        public Func<AppQuery, AppQuery> CloseAllRedBtn { get; } = c => c.Id("CloseAllNegativeBtn");//Close unprofitable
        public Func<AppQuery, AppQuery> CloseAllGreenBtn { get; } = c => c.Id("CloseAllPositiveBtn");//Close profitable
    }


}