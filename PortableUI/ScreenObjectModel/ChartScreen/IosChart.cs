//using System;////////////////////////////////////////////////изменить ID//////////////////////////////////////////
//using System.Collections.Generic;////////////////////////////////////////////////изменить ID//////////////////////////////////////////
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Xamarin.UITest;
//using Xamarin.UITest.Queries;
//using NUnit;

//namespace UI_Test_CrossPlatform.ScreenObjectModel.ChartScreen
//{
//    public class IosChart : IChartScreen
//    {


//        //-----------------------  Full Screen ---------------//

//        public Func<AppQuery, AppQuery> Time_Frame { get; } = new Func<AppQuery, AppQuery>(c => c.Id("_btnIntervalSelect")); //Кнопка выбора таймфрейма
//        public Func<AppQuery, AppQuery> Chart_Type { get; } = new Func<AppQuery, AppQuery>(c => c.Id("_btnChartTypeSelect")); // Кнопка выбора графика
//        public Func<AppQuery, AppQuery> Chart_Indicator { get; } = new Func<AppQuery, AppQuery>(c => c.Id("_btnIndicatorSelect")); //Кнопка выбора индикатора
//        //public Func<AppQuery, AppQuery> Chart_Scroll { get; } = new Func<AppQuery, AppQuery>(c => c.Id("chartScroll"));//Скролл графика справа
//        public Func<AppQuery, AppQuery> Full_Screen_Layout { get; } = new Func<AppQuery, AppQuery>(c => c.Id("_chartContainerFull")); // fullscreenLayout
//        public Func<AppQuery, AppQuery> Btn_To_Dashboard_From_Full { get; } = new Func<AppQuery, AppQuery>(c => c.Id("_btnBack")); // Кнопка перехода на детальную страницу
//        public Func<AppQuery, AppQuery> Default { get; } = new Func<AppQuery, AppQuery>(c => c.Id("_btnDefault")); // Кнопка Default

//        //-----------------------  Sell ---------------//

//        public Func<AppQuery, AppQuery> MACD { get; }

//        public Func<AppQuery, AppQuery> Sell_Chart { get; } = new Func<AppQuery, AppQuery>(c => c.Id("_btnSell"));//Кнопка Sell
//        // public Func<AppQuery, AppQuery> NewWindow { get; } = new Func<AppQuery, AppQuery>(c => c.Id("NewWindow"));//Кнопка Sell

//        //-----------------------  Buy ---------------//

//        public Func<AppQuery, AppQuery> Buy_Chart { get; } = new Func<AppQuery, AppQuery>(c => c.Id("_btnBuy"));//Кнопка Buy
//        // public Func<AppQuery, AppQuery> NewWindowBuy { get; } = new Func<AppQuery, AppQuery>(c => c.Id("NewWindow")); //Кнопка Buy

//        //-----------------------  Limmit Order ---------------//

//        public Func<AppQuery, AppQuery> Limit_Order_Chart { get; } = new Func<AppQuery, AppQuery>(c => c.Id("_btnLimitOrder")); //Кнопка Limit Order
//        //public Func<AppQuery, AppQuery> NewWindowLimitOrder { get; } =new Func<AppQuery, AppQuery>(c => c.Id("NewWindow")); //Кнопка Buy


//        //public Func<AppQuery, AppQuery> Go_To_Full_Screen { get; } = new Func<AppQuery, AppQuery>(c => c.Id("imgBtnDet"));

//        //-----------------------  Chart Full Screen Timeframe---------------//
//        public Func<AppQuery, AppQuery> Min_1 { get; } = new Func<AppQuery, AppQuery>(c => c.Text("1 мин"));
//        public Func<AppQuery, AppQuery> Min_5 { get; } = new Func<AppQuery, AppQuery>(c => c.Text("5 мин"));
//        public Func<AppQuery, AppQuery> Min_15 { get; } = new Func<AppQuery, AppQuery>(c => c.Text("15 мин"));
//        public Func<AppQuery, AppQuery> Min_30 { get; } = new Func<AppQuery, AppQuery>(c => c.Text("30 мин"));
//        public Func<AppQuery, AppQuery> Hour_1 { get; } = new Func<AppQuery, AppQuery>(c => c.Text("1 час"));
//        public Func<AppQuery, AppQuery> Hour_4 { get; } = new Func<AppQuery, AppQuery>(c => c.Text("4 часа"));
//        public Func<AppQuery, AppQuery> Hour_8 { get; } = new Func<AppQuery, AppQuery>(c => c.Text("8 часов"));
//        public Func<AppQuery, AppQuery> Day { get; } = new Func<AppQuery, AppQuery>(c => c.Text("День"));
//        public Func<AppQuery, AppQuery> Week { get; } = new Func<AppQuery, AppQuery>(c => c.Text("Неделя"));

//        //-----------------------  Chart Full Screen TypeChart---------------//
//        public Func<AppQuery, AppQuery> Candles { get; } = new Func<AppQuery, AppQuery>(c => c.Text("Свечи"));
//        public Func<AppQuery, AppQuery> Linear { get; } = new Func<AppQuery, AppQuery>(c => c.Text("Линейный"));
//        public Func<AppQuery, AppQuery> Linear_With_Gradient { get; } = new Func<AppQuery, AppQuery>(c => c.Text("Линейный градиент"));

//        //-----------------------  Chart Full Screen Indicators---------------//
//        public Func<AppQuery, AppQuery> Bollinger_Bands { get; } = new Func<AppQuery, AppQuery>(c => c.Text("Bollinger Bands"));
//        public Func<AppQuery, AppQuery> EMA_5 { get; } = new Func<AppQuery, AppQuery>(c => c.Text("EMA 5"));
//        public Func<AppQuery, AppQuery> EMA_14 { get; } = new Func<AppQuery, AppQuery>(c => c.Text("EMA 14"));
//        public Func<AppQuery, AppQuery> EMA_20 { get; } = new Func<AppQuery, AppQuery>(c => c.Text("EMA 20"));
//        public Func<AppQuery, AppQuery> EMA_50 { get; } = new Func<AppQuery, AppQuery>(c => c.Text("EMA 50"));
//        public Func<AppQuery, AppQuery> Fractal { get; } = new Func<AppQuery, AppQuery>(c => c.Text("Fractal"));
//        public Func<AppQuery, AppQuery> SMA_5 { get; } = new Func<AppQuery, AppQuery>(c => c.Text("SMA 5"));
//        public Func<AppQuery, AppQuery> SMA_20 { get; } = new Func<AppQuery, AppQuery>(c => c.Text("SMA 20"));
//        public Func<AppQuery, AppQuery> Ichimoku { get; } = new Func<AppQuery, AppQuery>(c => c.Text("Ichimoku"));
//        public Func<AppQuery, AppQuery> Parabolic_Sar { get; } = new Func<AppQuery, AppQuery>(c => c.Text("Parabolic Sar"));
//        public Func<AppQuery, AppQuery> Envelopes { get; } = new Func<AppQuery, AppQuery>(c => c.Text("Envelopes"));
//        public Func<AppQuery, AppQuery> Bears_Power { get; } = new Func<AppQuery, AppQuery>(c => c.Text("Bears_Power"));
//        public Func<AppQuery, AppQuery> Bulls_Power { get; } = new Func<AppQuery, AppQuery>(c => c.Text("Bulls_Power"));
//        public Func<AppQuery, AppQuery> Stochastic { get; } = new Func<AppQuery, AppQuery>(c => c.Text("Stochastic"));
//        public Func<AppQuery, AppQuery> ATR { get; } = new Func<AppQuery, AppQuery>(c => c.Text("ATR"));
//        public Func<AppQuery, AppQuery> RSI { get; } = new Func<AppQuery, AppQuery>(c => c.Text("RSI"));
//        public Func<AppQuery, AppQuery> Williams_R { get; } = new Func<AppQuery, AppQuery>(c => c.Text("Williams R"));
//        public Func<AppQuery, AppQuery> ADX { get; } = new Func<AppQuery, AppQuery>(c => c.Text("ADX"));
//    }
//}