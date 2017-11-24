using System;
using Xamarin.UITest.Queries;

namespace PortableUI
{
    public interface IDrawer
    {
         Func<AppQuery, AppQuery> Deposit {get;}
         Func<AppQuery, AppQuery> Balances { get; }
         Func<AppQuery, AppQuery> Favorites { get; }
         Func<AppQuery, AppQuery> Tools { get; }
         Func<AppQuery, AppQuery> Open_Deals { get; }
         Func<AppQuery, AppQuery> Limit_Orders { get; }
         Func<AppQuery, AppQuery> Closed_Deals { get; }
         Func<AppQuery, AppQuery> Detail_Mode { get; }
    }
    
}
