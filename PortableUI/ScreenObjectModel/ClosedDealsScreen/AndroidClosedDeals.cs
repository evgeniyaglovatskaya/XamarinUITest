using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace PortableUI
{
    public class AndroidClosedDeals : IClosedDealsScreen
    {
        public Func<AppQuery, AppQuery> PLPanel { get; }
        public Func<AppQuery, AppQuery> NegativePL { get; }
        public Func<AppQuery, AppQuery> PositivePL { get; }
        public Func<AppQuery, AppQuery> TotalPL { get; }
        public Func<AppQuery, AppQuery> InstrNameOnClosedDealCard { get; }
        public Func<AppQuery, AppQuery> DealTypeBtnOnClosedDealCard { get; }
        public Func<AppQuery, AppQuery> OpenPriceBtnOnClosedDealCard { get; }
        public Func<AppQuery, AppQuery> ClosePriceOnClosedDealCard { get; }
        public Func<AppQuery, AppQuery> PlOnOpenClosedCard { get; }
        public Func<AppQuery, AppQuery> AmountOnClosedCardCard { get; }
    }
}
