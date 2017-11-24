using System;
using Xamarin.UITest.Queries;

namespace PortableUI
{
    public interface IOpenDealScreen
    {


        //-------------------Create open deal window------------------//
        Func<AppQuery, AppQuery> InstName { get; }// Название инструмента 
        Func<AppQuery, AppQuery> Today { get; }
        Func<AppQuery, AppQuery> AmountField { get; }// Поле ввода amount
        Func<AppQuery, AppQuery> ToggleChartType { get; }
        Func<AppQuery, AppQuery> SellBtn { get; }//Кнопка 
        Func<AppQuery, AppQuery> BuyBtn { get; }//
        Func<AppQuery, AppQuery> Chart { get; }
        Func<AppQuery, AppQuery> LimitOrderBtn { get; }
        Func<AppQuery, AppQuery> FavoritesBtn { get; }
        Func<AppQuery, AppQuery> Margin { get; }
        Func<AppQuery, AppQuery> DealInstrAmount { get; }
        Func<AppQuery, AppQuery> Price { get; }

    }
}
