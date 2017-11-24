using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace PortableUI
{
    public class AndroidLimitOrder : ILimitOrderScreen
    {
        public Func<AppQuery, AppQuery> InstrName { get; }
        public Func<AppQuery, AppQuery> DealType { get; }
        public Func<AppQuery, AppQuery> CurrentPrice { get; }
        public Func<AppQuery, AppQuery> LimitPrice { get; }
        public Func<AppQuery, AppQuery> StopLossLbl { get; }
        public Func<AppQuery, AppQuery> TakeProfitLbl { get; }
        public Func<AppQuery, AppQuery> CancelBtn { get; }
    }
}
