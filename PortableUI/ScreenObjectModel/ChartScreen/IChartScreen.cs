//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Xamarin.UITest;
//using Xamarin.UITest.Queries;

//namespace UI_Test_CrossPlatform.ScreenObjectModel.ChartScreen
//{
//    public interface IChartScreen
//    {

//        //-----------------------  Chart Full Screen ---------------//
//        Func<AppQuery, AppQuery> Time_Frame { get; } //Кнопка выбора таймфрейма
//        Func<AppQuery, AppQuery> Chart_Type { get; } // Кнопка выбора графика
//        Func<AppQuery, AppQuery> Chart_Indicator { get; } //Кнопка выбора индикатора
//        //Func<AppQuery, AppQuery> Chart_Scroll { get; } //Скролл графика справа
//        Func<AppQuery, AppQuery> Full_Screen_Layout { get; } // fullscreenLayout
//        Func<AppQuery, AppQuery> Btn_To_Dashboard_From_Full { get; }  // Кнопка перехода на детальную страницу
//        Func<AppQuery, AppQuery> Default { get; }  // Кнопка Default

//        //-----------------------  Chart Full Screen Timeframe---------------//
//        Func<AppQuery, AppQuery> Min_1 { get; } //Кнопка выбора таймфрейма
//        Func<AppQuery, AppQuery> Min_5 { get; } // Кнопка выбора графика
//        Func<AppQuery, AppQuery> Min_15 { get; } //Кнопка выбора индикатора
//        Func<AppQuery, AppQuery> Min_30 { get; } //Скролл графика справа
//        Func<AppQuery, AppQuery> Hour_1 { get; } // fullscreenLayout
//        Func<AppQuery, AppQuery> Hour_4 { get; } // fullscreenLayout
//        Func<AppQuery, AppQuery> Hour_8 { get; } // fullscreenLayout
//        Func<AppQuery, AppQuery> Day { get; } // fullscreenLayout
//        Func<AppQuery, AppQuery> Week { get; } // fullscreenLayout

//        //-----------------------  Chart Full Screen TypeChart---------------//
//        Func<AppQuery, AppQuery> Candles { get; } //Кнопка выбора таймфрейма
//        Func<AppQuery, AppQuery> Linear { get; } // Кнопка выбора графика
//        Func<AppQuery, AppQuery> Linear_With_Gradient { get; } //Кнопка выбора индикатора
        

//        //-----------------------  Chart Full Screen Indicators---------------//
//        Func<AppQuery, AppQuery> Bollinger_Bands { get; } //Кнопка выбора таймфрейма
//        Func<AppQuery, AppQuery> EMA_5 { get; } // Кнопка выбора графика
//        Func<AppQuery, AppQuery> EMA_14 { get; } //Кнопка выбора индикатора
//        Func<AppQuery, AppQuery> EMA_20 { get; } //Скролл графика справа
//        Func<AppQuery, AppQuery> EMA_50 { get; } // fullscreenLayout
//        Func<AppQuery, AppQuery> Fractal { get; } //Кнопка выбора таймфрейма
//        Func<AppQuery, AppQuery> SMA_5 { get; } // Кнопка выбора графика
//        Func<AppQuery, AppQuery> SMA_20 { get; } //Кнопка выбора индикатора
//        Func<AppQuery, AppQuery> Ichimoku { get; } //Кнопка выбора индикатора
//        Func<AppQuery, AppQuery> Parabolic_Sar { get; } //Кнопка выбора индикатора
//        Func<AppQuery, AppQuery> Envelopes { get; } //Кнопка выбора индикатора

//        //-----------------------  Chart Full Screen Oscillators---------------//
//        Func<AppQuery, AppQuery> Bears_Power { get; } //Кнопка выбора таймфрейма
//        Func<AppQuery, AppQuery> Bulls_Power { get; } //Кнопка выбора таймфрейма
//        Func<AppQuery, AppQuery> Stochastic { get; } //Кнопка выбора таймфрейма
//        Func<AppQuery, AppQuery> ATR { get; } //Кнопка выбора таймфрейма
//        Func<AppQuery, AppQuery> RSI { get; } //Кнопка выбора таймфрейма
//        Func<AppQuery, AppQuery> Williams_R { get; } //Кнопка выбора таймфрейма
//        Func<AppQuery, AppQuery> ADX { get; } //Кнопка выбора таймфрейма
//        Func<AppQuery, AppQuery> MACD { get; } //Кнопка выбора таймфрейма

//        //-----------------------  Sell ---------------//
//        Func<AppQuery, AppQuery> Sell_Chart { get; }//Кнопка Sell
//        //Func<AppQuery, AppQuery> NewWindow { get; }//Кнопка Sell

//        //-----------------------  Buy ---------------//
//        Func<AppQuery, AppQuery> Buy_Chart { get; }//Кнопка Buy
//                                                   // Func<AppQuery, AppQuery> NewWindowBuy { get; }//Кнопка Buy

//        //-----------------------  Limmit Order ---------------//
//        Func<AppQuery, AppQuery> Limit_Order_Chart { get; }//Кнопка Limit Order
//                                                           // Func<AppQuery, AppQuery> NewWindowLimitOrder { get; }//Кнопка Buy
//    }
//}