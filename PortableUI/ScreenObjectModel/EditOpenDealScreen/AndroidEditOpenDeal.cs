using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace PortableUI
{
    class AndroidEditOpenDeal : IEditOpenDealScreen
    {

        //-------------------Edit open dial dialog--------------------//

        public Func<AppQuery, AppQuery> SL { get; } = c => c.Id("lblSlTp");
        public Func<AppQuery, AppQuery> SLBtn { get; } = c => c.Id("btnSlTp");
        public Func<AppQuery, AppQuery> TP { get; } = c => c.Id("lblSlTp");
        public Func<AppQuery, AppQuery> TPBtn { get; } = c => c.Id("btnSlTp");
        public Func<AppQuery, AppQuery> CloseDealBtn { get; } = c => c.Id("editDealCloseBtnBottom");
        public Func<AppQuery, AppQuery> SaveBtn { get; } = c => c.Id("editDealSaveBtn");
        public Func<AppQuery, AppQuery> DuplicateBtn { get; } = c => c.Id("editDealDuplicateBtn");
        public Func<AppQuery, AppQuery> LockBtn { get; } = c => c.Id("editDealLockBtn");
        public Func<AppQuery, AppQuery> Today { get; } = c => c.Id("edit_open_deal_dialog_tv_diff_perc ");
        public Func<AppQuery, AppQuery> Price { get; } = c => c.Id("edit_open_deal_dialog_tv_cur_price");
        public Func<AppQuery, AppQuery> ToggleChartType { get; } = c => c.Id("");
    }
}
