using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using NUnit;
namespace PortableUI
{
    public interface ILimitOrderScreen
    {
        //-------------------Limit order card--------------------------//
        Func<AppQuery, AppQuery> InstrName { get; }// Название инструмента на карточке сделки
        Func<AppQuery, AppQuery> DealType { get; } //
        Func<AppQuery, AppQuery> CurrentPrice { get; }
        Func<AppQuery, AppQuery> LimitPrice { get; }
        Func<AppQuery, AppQuery> StopLossLbl { get; }//
        Func<AppQuery, AppQuery> TakeProfitLbl { get; }//
        Func<AppQuery, AppQuery> CancelBtn { get; }//
     

      
    }
}
