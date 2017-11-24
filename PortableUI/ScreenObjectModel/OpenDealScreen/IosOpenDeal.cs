using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace PortableUI
{
    class IosOpenDeal: IOpenDealScreen
    {
        //-------------------Create open deal window------------------//


        public Func<AppQuery, AppQuery> InstName { get; }
        public Func<AppQuery, AppQuery> AmountField { get; } = c => c.Class("FormattedTextFieldView").Marked("Amount");
        public Func<AppQuery, AppQuery> ToggleChartType { get; } = c => c.Class("").Marked("");
        public Func<AppQuery, AppQuery> SellBtn { get; } = c => c.Class("UILabel").Index(0).Marked("SellBuy");
        public Func<AppQuery, AppQuery> BuyBtn { get; } = c => c.Class("UILabel").Index(0).Marked("SellBuy");
        public Func<AppQuery, AppQuery> Chart { get; } = c => c.Class("ChartConteinerView").Marked("Chart");
        public Func<AppQuery, AppQuery> LimitOrderBtn { get; } = c => c.Class("UILabel").Marked("LimitOrder");
        public Func<AppQuery, AppQuery> DealInstrAmount { get; } = c => c.Class("InstrumentNameView").Marked("Picker");
        public Func<AppQuery, AppQuery> Price { get; } = c => c.Class("UILabel").Marked("Price");
        public Func<AppQuery, AppQuery> FavoritesBtn { get; } = c => c.Class("").Marked("");
        public Func<AppQuery, AppQuery> Margin { get; } = c => c.Class("MarginFieldView").Marked("Margin");
        public Func<AppQuery, AppQuery> Today { get; } = c => c.Class("UILabel").Marked("DiffPerc");
    }
}
