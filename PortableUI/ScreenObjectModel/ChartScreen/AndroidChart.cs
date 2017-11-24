//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Xamarin.UITest;
//using Xamarin.UITest.Queries;
//using NUnit;

//namespace UI_Test_CrossPlatform.ScreenObjectModel.ChartScreen
//{
//    public class AndroidChart : IChartScreen
//    {

        
//        //-----------------------  Full Screen ---------------//

//        public Func<AppQuery, AppQuery> Time_Frame { get; } = new Func<AppQuery, AppQuery>(c => c.Id("intervalSelectButton")); //Кнопка выбора таймфрейма
//        public Func<AppQuery, AppQuery> Chart_Type { get; } = new Func<AppQuery, AppQuery>(c => c.Id("typeSelectButton")); // Кнопка выбора графика
//        public Func<AppQuery, AppQuery> Chart_Indicator { get; } = new Func<AppQuery, AppQuery>(c => c.Id("indicatorSelectButton")); //Кнопка выбора индикатора
//        //public Func<AppQuery, AppQuery> Chart_Scroll { get; } = new Func<AppQuery, AppQuery>(c => c.Id("chartScroll"));//Скролл графика справа
//        public Func<AppQuery, AppQuery> Full_Screen_Layout { get; } = new Func<AppQuery, AppQuery>(c => c.Id("chartViewD")); // fullscreenLayout
//        public Func<AppQuery, AppQuery> Btn_To_Dashboard_From_Full { get; } = new Func<AppQuery, AppQuery>(c => c.Id("btnDetailChart")); // Кнопка перехода на детальную страницу
//        public Func<AppQuery, AppQuery> Default { get; } = new Func<AppQuery, AppQuery>(c => c.Id("resetChartToDefault")); // Кнопка Default

//        //-----------------------  Sell ---------------//

//        public Func<AppQuery, AppQuery> MACD { get; }

//        public Func<AppQuery, AppQuery> Sell_Chart { get; } = new Func<AppQuery, AppQuery>(c => c.Id("sellBtn"));//Кнопка Sell
//        // public Func<AppQuery, AppQuery> NewWindow { get; } = new Func<AppQuery, AppQuery>(c => c.Id("NewWindow"));//Кнопка Sell

//        //-----------------------  Buy ---------------//

//        public Func<AppQuery, AppQuery> Buy_Chart { get; } = new Func<AppQuery, AppQuery>(c => c.Id("buyBtn"));//Кнопка Buy
//        // public Func<AppQuery, AppQuery> NewWindowBuy { get; } = new Func<AppQuery, AppQuery>(c => c.Id("NewWindow")); //Кнопка Buy

//        //-----------------------  Limmit Order ---------------//

//        public Func<AppQuery, AppQuery> Limit_Order_Chart { get; } = new Func<AppQuery, AppQuery>(c => c.Id("limitOrderBtn")); //Кнопка Limit Order
//        //public Func<AppQuery, AppQuery> NewWindowLimitOrder { get; } =new Func<AppQuery, AppQuery>(c => c.Id("NewWindow")); //Кнопка Buy


        


//        //-----------------------  Chart Full Screen Timeframe---------------//
//        public Func<AppQuery, AppQuery> Min_1 { get; } = new Func<AppQuery, AppQuery>(c => c.Class("android.widget.LinearLayout").Index(0)); 
//        public Func<AppQuery, AppQuery> Min_5 { get; } = new Func<AppQuery, AppQuery>(c => c.Class("android.widget.LinearLayout").Index(1)); 
//        public Func<AppQuery, AppQuery> Min_15 { get; } = new Func<AppQuery, AppQuery>(c => c.Class("android.widget.LinearLayout").Index(2)); 
//        public Func<AppQuery, AppQuery> Min_30 { get; } = new Func<AppQuery, AppQuery>(c => c.Class("android.widget.LinearLayout").Index(3)); 
//        public Func<AppQuery, AppQuery> Hour_1 { get; } = new Func<AppQuery, AppQuery>(c => c.Class("android.widget.LinearLayout").Index(4));
//        public Func<AppQuery, AppQuery> Hour_4 { get; } = new Func<AppQuery, AppQuery>(c => c.Class("android.widget.LinearLayout").Index(5));
//        public Func<AppQuery, AppQuery> Hour_8 { get; } = new Func<AppQuery, AppQuery>(c => c.Class("android.widget.LinearLayout").Index(6));
//        public Func<AppQuery, AppQuery> Day { get; } = new Func<AppQuery, AppQuery>(c => c.Class("android.widget.LinearLayout").Index(7));
//        public Func<AppQuery, AppQuery> Week { get; } = new Func<AppQuery, AppQuery>(c => c.Class("android.widget.LinearLayout").Index(8));

//        //-----------------------  Chart Full Screen TypeChart---------------//
//        public Func<AppQuery, AppQuery> Candles { get; } = new Func<AppQuery, AppQuery>(c => c.Class("android.widget.LinearLayout").Index(0)); 
//        public Func<AppQuery, AppQuery> Linear { get; } = new Func<AppQuery, AppQuery>(c => c.Class("android.widget.LinearLayout").Index(1));
//        public Func<AppQuery, AppQuery> Linear_With_Gradient { get; } = new Func<AppQuery, AppQuery>(c => c.Class("android.widget.LinearLayout").Index(2));
        
//        //-----------------------  Chart Full Screen Indicators---------------//
//        public Func<AppQuery, AppQuery> Bollinger_Bands { get; } = new Func<AppQuery, AppQuery>(c => c.Class("android.widget.LinearLayout").Index(0));
//        public Func<AppQuery, AppQuery> EMA_5 { get; } = new Func<AppQuery, AppQuery>(c => c.Class("android.widget.LinearLayout").Index(1));
//        public Func<AppQuery, AppQuery> EMA_14 { get; } = new Func<AppQuery, AppQuery>(c => c.Class("android.widget.LinearLayout").Index(2));
//        public Func<AppQuery, AppQuery> EMA_20 { get; } = new Func<AppQuery, AppQuery>(c => c.Class("android.widget.LinearLayout").Index(3));
//        public Func<AppQuery, AppQuery> EMA_50 { get; } = new Func<AppQuery, AppQuery>(c => c.Class("android.widget.LinearLayout").Index(4));
//        public Func<AppQuery, AppQuery> Fractal { get; } = new Func<AppQuery, AppQuery>(c => c.Class("android.widget.LinearLayout").Index(5));
//        public Func<AppQuery, AppQuery> SMA_5 { get; } = new Func<AppQuery, AppQuery>(c => c.Class("android.widget.LinearLayout").Index(6));
//        public Func<AppQuery, AppQuery> SMA_20 { get; } = new Func<AppQuery, AppQuery>(c => c.Class("android.widget.LinearLayout").Index(7));
//        public Func<AppQuery, AppQuery> Ichimoku { get; }
//        public Func<AppQuery, AppQuery> Parabolic_Sar { get; }
//        public Func<AppQuery, AppQuery> Envelopes { get; }
//        public Func<AppQuery, AppQuery> Bears_Power { get; }
//        public Func<AppQuery, AppQuery> Bulls_Power { get; }
//        public Func<AppQuery, AppQuery> Stochastic { get; }
//        public Func<AppQuery, AppQuery> ATR { get; }
//        public Func<AppQuery, AppQuery> RSI { get; }
//        public Func<AppQuery, AppQuery> Williams_R { get; }
//        public Func<AppQuery, AppQuery> ADX { get; }
//    }


//}