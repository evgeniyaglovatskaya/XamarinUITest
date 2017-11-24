using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.UITest.Queries;

namespace PortableUI
{
   public interface IClosedDealsScreen
    {
        //------------------------P&L Panel--------------------//

        Func<AppQuery, AppQuery> PLPanel { get; }//Вся панель
        Func<AppQuery, AppQuery> NegativePL { get; }
        Func<AppQuery, AppQuery> PositivePL { get; }
        Func<AppQuery, AppQuery> TotalPL { get; }


        //-----------------------Closed deal card---------------//

        Func<AppQuery, AppQuery> InstrNameOnClosedDealCard { get; }// Название инструмента на карточке сделки
        Func<AppQuery, AppQuery> DealTypeBtnOnClosedDealCard { get; }//Sell or Buy
        Func<AppQuery, AppQuery> OpenPriceBtnOnClosedDealCard { get; }
        Func<AppQuery, AppQuery> ClosePriceOnClosedDealCard { get; }
        Func<AppQuery, AppQuery> PlOnOpenClosedCard { get; }//Значение на самой карте
        Func<AppQuery, AppQuery> AmountOnClosedCardCard { get; }// Поле ввода amount
    }
}
