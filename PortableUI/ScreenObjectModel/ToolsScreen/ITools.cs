using System;
using Xamarin.UITest.Queries;

namespace PortableUI
{
    public interface ITools
    {
        
        //-----------------------  Deposit card -------------------//
        Func<AppQuery,AppQuery> DepositBalance { get; }
         Func<AppQuery, AppQuery> Deposit_Btn { get; } //Кнопка deposit
         Func<AppQuery, AppQuery> Deposit_Web_View { get;}
         Func<AppQuery, AppQuery> FreeBalance{ get; } //Свободный баланс
         Func<AppQuery, AppQuery> PL { get; }
         Func<AppQuery, AppQuery> ToolbarTitle { get; }
         Func<AppQuery, AppQuery> Eguity { get; } //Баланс Тотал
         Func<AppQuery, AppQuery> Balance { get; }//Баланс
         Func<AppQuery, AppQuery> Balances_Panel { get; } //Панель балансов
    }
}