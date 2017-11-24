using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace PortableUI
{
   class AndroidOpenDeal : IOpenDealScreen
    {
        //-------------------Create open deal window------------------//

        public Func<AppQuery, AppQuery> InstName { get; } = c => c.Id("toolbar_title");
        public Func<AppQuery, AppQuery> AmountField { get; } = c => c.Id("buyselldialog_edittext_amount");// Поле ввода amount
        public Func<AppQuery, AppQuery> ToggleChartType { get; } = c => c.Id("togglebutton_layout");
        public Func<AppQuery, AppQuery> SellBtn { get; } = c => c.Id("buyselldialog_sellButton");
        public Func<AppQuery, AppQuery> BuyBtn { get; } = c => c.Id("buyselldialog_buyButton");
        public Func<AppQuery, AppQuery> Chart { get; } = c => c.Id("chartViewD");
        public Func<AppQuery, AppQuery> LimitOrderBtn { get; } = c => c.Id("buyselldialog_textview_limitorder");
        public Func<AppQuery, AppQuery> DealInstrAmount { get; } = c => c.Id("buy_sell_dialog_tv_deal_instr");
        public Func<AppQuery, AppQuery> Price { get; } = c => c.Id("edit_open_deal_dialog_tv_cur_price");
        public Func<AppQuery, AppQuery> FavoritesBtn { get; } = c => c.Id("toolbar_favour_btn");
        public Func<AppQuery, AppQuery> Margin { get; } = c => c.Id("buyselldialog_marginfield");

        public Func<AppQuery, AppQuery> Today { get; } = c => c.Id("edit_open_deal_dialog_tv_diff_perc");


    }
}
