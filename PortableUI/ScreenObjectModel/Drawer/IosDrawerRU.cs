using System;
using Xamarin.UITest.Queries;


namespace PortableUI
{
    class IosDrawerRU:IDrawer
    {
        public Func<AppQuery, AppQuery> Deposit { get; } = c => c.Text("Пополнить счет");
        public Func<AppQuery, AppQuery> Balances { get; } = c => c.Text("Балансы");
        public Func<AppQuery, AppQuery> Favorites { get; } = c => c.Text("Избранные");
        public Func<AppQuery, AppQuery> Tools { get; } = c => c.Text("Инструменты");
        public Func<AppQuery, AppQuery> Open_Deals { get; } = c => c.Text("Открытые сделки");
        public Func<AppQuery, AppQuery> Limit_Orders { get; } = c => c.Text("Лимитные ордера");
        public Func<AppQuery, AppQuery> Closed_Deals { get; } = c => c.Text("Закрытые сделки");
        public Func<AppQuery, AppQuery> Detail_Mode { get; } = c => c.Text("Детальный режим");
    }
}
