using System;
using Xamarin.UITest.Queries;


namespace PortableUI.ScreenObjectModel.Deposit
{
    public class Boleto
    {  
        //Boleto
        public Func<AppQuery, AppWebQuery> Amount { get; } =
            c => c.WebView().Css("#boletoAmount");
        public Func<AppQuery, AppWebQuery> Send { get; } =
            c => c.WebView().Css("#btnBoletoSubmit");
    }
}
