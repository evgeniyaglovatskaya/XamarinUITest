using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace PortableUI
{
   public class IosLimitOrder : ILimitOrderScreen
   {
       public Func<AppQuery, AppQuery> InstrName { get; } = c => c.Class("UILabel").Marked("InstrName");
        public Func<AppQuery, AppQuery> DealType { get; } = c => c.Class("UILabel").Marked("DealType");
        public Func<AppQuery, AppQuery> CurrentPrice { get; } = c => c.Class("UILabel").Marked("CurrPrice");
        public Func<AppQuery, AppQuery> LimitPrice { get; } = c => c.Class("UILabel").Marked("LimitPrice");
        public Func<AppQuery, AppQuery> StopLossLbl { get; } = c => c.Class("UILabel").Marked("SL");
        public Func<AppQuery, AppQuery> TakeProfitLbl { get; } = c => c.Class("UILabel").Marked("TP");
        public Func<AppQuery, AppQuery> CancelBtn { get; } = c => c.Class("UIButton").Marked("Cancel");
    }
}
