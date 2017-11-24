using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace PortableUI
{
    class IosEditOpenDeal : IEditOpenDealScreen
    {

        //-------------------Edit open dial dialog--------------------//

        public Func<AppQuery, AppQuery> SL { get; }
        public Func<AppQuery, AppQuery> SLBtn { get; }
        public Func<AppQuery, AppQuery> TP { get; }
        public Func<AppQuery, AppQuery> TPBtn { get; }
        public Func<AppQuery, AppQuery> CloseDealBtn { get; }
        public Func<AppQuery, AppQuery> SaveBtn { get; }
        public Func<AppQuery, AppQuery> DuplicateBtn { get; }
        public Func<AppQuery, AppQuery> LockBtn { get; }
        public Func<AppQuery, AppQuery> Today { get; }
        public Func<AppQuery, AppQuery> Price { get; }
        public Func<AppQuery, AppQuery> ToggleChartType { get; }
    }
}
