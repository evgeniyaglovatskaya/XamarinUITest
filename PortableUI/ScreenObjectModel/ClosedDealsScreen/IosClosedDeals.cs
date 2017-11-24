using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace PortableUI
{
    public class IosClosedDeals : IClosedDealsScreen
    {
        public Func<AppQuery, AppQuery> PLPanel { get; }
        public Func<AppQuery, AppQuery> NegativePL { get; }
        public Func<AppQuery, AppQuery> PositivePL { get; }
        public Func<AppQuery, AppQuery> TotalPL { get; }
        public Func<AppQuery, AppQuery> InstrNameOnClosedDealCard { get; } = c => c.Class("UILabel").Marked("InstrName");
        public Func<AppQuery, AppQuery> DealTypeBtnOnClosedDealCard { get; } = c => c.Class("UILabel").Marked("DealType");
        public Func<AppQuery, AppQuery> OpenPriceBtnOnClosedDealCard { get; } = c => c.Class("UILabel").Marked("OpenPrice");
        public Func<AppQuery, AppQuery> ClosePriceOnClosedDealCard { get; } = c => c.Class("UILabel").Marked("ClosePrice");
        public Func<AppQuery, AppQuery> PlOnOpenClosedCard { get; } = c => c.Class("UILabel").Marked("PnL");
        public Func<AppQuery, AppQuery> AmountOnClosedCardCard { get; } = c => c.Class("UILabel").Marked("Amount");
    }
}
