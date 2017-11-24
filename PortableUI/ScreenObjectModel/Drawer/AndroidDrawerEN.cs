using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace PortableUI
{
    class AndroidDrawerEN:IDrawer
    {
        public Func<AppQuery, AppQuery> Deposit { get; }=c => c.Text("Deposit");
        public Func<AppQuery, AppQuery> Balances { get; }=c => c.Text("Balances");
        public Func<AppQuery, AppQuery> Favorites { get; } =c => c.Text("Favorites");
        public Func<AppQuery, AppQuery> Tools { get; } =c => c.Text("Tools");
        public Func<AppQuery, AppQuery> Open_Deals { get; } =c => c.Text("Open Deals");
        public Func<AppQuery, AppQuery> Limit_Orders { get; } =c => c.Text("Limit Orders");
        public Func<AppQuery, AppQuery> Closed_Deals { get; } =c => c.Text("Closed Deals");
        public Func<AppQuery, AppQuery> Detail_Mode { get; } =c => c.Text("Detail Mode");
    }
}
