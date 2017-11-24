using System;
using Xamarin.UITest.Queries;

namespace PortableUI
{
    public interface IFavoritesScreen
    {
        Func<AppQuery, AppQuery> InfoPanel { get; }
        Func<AppQuery, AppQuery> InfoPanelName { get; }
        Func<AppQuery, AppQuery> InfoPanelTrend { get; }
        Func<AppQuery, AppQuery> InfoPanelSell { get; }
        Func<AppQuery, AppQuery> InfoPanelBuy { get; }
        Func<AppQuery, AppQuery> Recycler { get; }
        //-----------------------  Instrumental card ---------------//
        Func<AppQuery, AppQuery> Card { get; } //Инструментальная карточка
        Func<AppQuery, AppQuery> InstrName { get; }//Имя инструмента на чарте
        Func<AppQuery, AppQuery> ChartCardLayout { get; }//Чарт с трендом на карточке
        Func<AppQuery, AppQuery> SellCard { get; }//Значение Bid
        Func<AppQuery, AppQuery> BuyCard { get; }//Значение Ask  




    }
}