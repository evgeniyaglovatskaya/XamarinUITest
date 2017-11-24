using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace PortableUI
{
    public interface IOpenedDealsScreen
    {

        //-------------------Open-deal card--------------------------//
        Func<AppQuery, AppQuery> Card { get; }//
        Func<AppQuery, AppQuery> InstrName { get; }// Название инструмента на карточке сделки
        Func<AppQuery, AppQuery> DealType { get; }//   
        Func<AppQuery, AppQuery> Amount { get; }
        Func<AppQuery, AppQuery> DealPrice { get; }
        Func<AppQuery, AppQuery> MarketPrice { get; }
        Func<AppQuery, AppQuery> StopLoss { get; }//
        Func<AppQuery, AppQuery> TakeProfit { get; }//
        Func<AppQuery, AppQuery> CloseBtn { get; }//
        Func<AppQuery, AppQuery> PnLOnBtn { get; }

        //-------------------Close all panel-----------------------//
        Func<AppQuery, AppQuery> CloseAllBlueBtn { get; }//Close all
        Func<AppQuery, AppQuery> CloseAllRedBtn { get; }//Close unprofitable
        Func<AppQuery, AppQuery> CloseAllGreenBtn { get; }//Close profitable

    }
}
