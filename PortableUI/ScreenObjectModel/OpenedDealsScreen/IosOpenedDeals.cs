using System;
using Xamarin.UITest.Queries;

namespace PortableUI
{
    public class IosOpenedDeals : IOpenedDealsScreen
    {
        //-------------------Open-deal card--------------------------//
        public Func<AppQuery, AppQuery> Card { get; } = c => c.Class("UIView").Marked("Card");
        public Func<AppQuery, AppQuery> InstrName { get; } = c => c.Class("UILabel").Marked("InstrName");
        public Func<AppQuery, AppQuery> DealType { get; } = c => c.Class("UILabel").Marked("DealType");
        public Func<AppQuery, AppQuery> Amount { get; } = c => c.Class("UILabel").Marked("Amount");
        public Func<AppQuery, AppQuery> DealPrice { get; } = c => c.Class("UILabel").Marked("DealPrice");
        public Func<AppQuery, AppQuery> MarketPrice { get; } = c => c.Class("UILabel").Marked("MarketPrice");
        public Func<AppQuery, AppQuery> StopLoss { get; } = c => c.Class("UILabel").Marked("SL");
        public Func<AppQuery, AppQuery> TakeProfit { get; } = c => c.Class("UILabel").Marked("TP");
        public Func<AppQuery, AppQuery> CloseBtn { get; } = c => c.Class("UILabel").Marked("CloseDeal");
        public Func<AppQuery, AppQuery> PnLOnBtn { get; } = c => c.Class("UILabel").Marked("PnL");
        //-------------------Close all panel-----------------------//
        public Func<AppQuery, AppQuery> CloseAllBlueBtn { get; } = c => c.Class("UILabel").Marked("Label");//Close all
        public Func<AppQuery, AppQuery> CloseAllRedBtn { get; } = c => c.Class("UILabel").Marked("Label");//Close unprofitable
        public Func<AppQuery, AppQuery> CloseAllGreenBtn { get; } = c => c.Class("UILabel").Marked("Label");//Close profitable


    }


}