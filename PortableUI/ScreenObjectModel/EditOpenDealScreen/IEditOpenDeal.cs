using System;
using Xamarin.UITest.Queries;

namespace PortableUI
{
    public interface IEditOpenDealScreen
    {

        //-------------------Edit open dial dialog--------------------//

        Func<AppQuery, AppQuery> SL { get; }
        Func<AppQuery, AppQuery> SLBtn { get; }
        Func<AppQuery, AppQuery> TP { get; }
        Func<AppQuery, AppQuery> TPBtn { get; }
        Func<AppQuery, AppQuery> CloseDealBtn { get; }
        Func<AppQuery, AppQuery> SaveBtn { get; }
        Func<AppQuery, AppQuery> DuplicateBtn { get; }
        Func<AppQuery, AppQuery> LockBtn { get; }
        Func<AppQuery, AppQuery> Today { get; }
        Func<AppQuery, AppQuery> Price { get; }
        Func<AppQuery, AppQuery> ToggleChartType { get; }
    }
}
