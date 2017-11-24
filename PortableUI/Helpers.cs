using System;
using System.Globalization;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace PortableUI
{
    public class Helpers
    {
        private Platform _platform;
        private IApp _app;
        private ScreenInit _screen;
        private LocalizationEnum _locale;
        public Helpers(Platform platform, IApp app, ScreenInit screen, LocalizationEnum locale)
        {
            _platform = platform;
            _app = app;
            _screen = screen;
            _locale = locale;
        }

        public void Authorize(string login, string pass)
        {
            if (_platform == Platform.Android)
            {

                _app.Tap(Resources.Screen.Authorize.Email);
                _app.EnterText(login);
                _app.Tap(Resources.Screen.Authorize.Password);
                _app.EnterText(pass);
                _app.Tap(Resources.Screen.Authorize.Login_Btn);
            }
            else
            {
                if (_locale == LocalizationEnum.En)
                {
                    _app.Tap(c => c.Text("Email"));
                    _app.EnterText(login);
                    _app.Tap(c => c.Text("Password"));
                    _app.EnterText(pass);
                    _app.Tap(c => c.Text("LOG IN"));
                }
                if (_locale == LocalizationEnum.Ru)
                {
                    _app.Tap(c => c.Text("Email"));
                    _app.EnterText(login);
                    _app.Tap(c => c.Text("Пароль"));
                    _app.EnterText(pass);
                    _app.Tap(c => c.Text("ВОЙТИ"));
                }
            }
        }

        public void GoToRegister()
        {
            _app.Tap(_screen.Authorize.Btn_Registr_From_Login);
        }
        public void RegisterTapOnNext()
        {
      //      _app.Tap(_screen.Authorize.NextBtn);
        }

        public void EnterText(Func<AppQuery,AppQuery> elem,string text)
        {
            _app.Tap(elem);
            _app.EnterText(text);
        }

        public void EnterTextDeposit(Func<AppQuery, AppWebQuery> elem, string text)
        {
            _app.Tap(elem);
            _app.EnterText(text);
        }
        void Register(string first_name, string last_name, string email, string phone, IApp _app)
        {
         //  _app.Tap(_screen.Authorize);

        }

        public void GoToChangePassword()
        {
            
        }
        //public void Change_password(string first_name, string result, IApp _app)
        //{
        //    _app.Tap(Screen.Authorize.Change_Password_Field);
        //    _app.EnterText(first_name);
        //    _app.Tap(Screen.Authorize.Change_Pass_Btn);
        //}


        public void Swipe(Func<AppQuery, AppQuery> elem)
        {
            if (_platform == Platform.Android)
            {
                _app.SwipeLeftToRight(elem, swipePercentage: 0.99D, swipeSpeed: 1000);
            }
            else
            {
                _app.SwipeLeftToRight(swipePercentage: 0.99D, swipeSpeed: 1000);
            }
        }

        public void WaitForElementWithTime(Func<AppQuery, AppQuery> elem, int time)
        {
            _app.WaitForElement(elem, timeout: TimeSpan.FromSeconds(time), timeoutMessage: "Couldn't find element");
        }

        public void TransitionFromDrawer(Func<AppQuery, AppQuery> elem)
        {
            _app.Tap(elem);
        }

        public void GoToDeposit()
        {
            _app.Tap(Resources.Screen.Tools.Deposit_Btn);
            WaitForElementWithTime(Resources.Screen.Tools.Deposit_Web_View, 10);
            _app.WaitForElement(Resources.Screen.Tools.Deposit_Web_View);
        }

        public void GoToOpenDealDialog(Func<AppQuery, AppQuery> elem)
        {
            _app.Tap(elem);
            //WaitForElementWithTime(Resources.Screen.OpenDeal.Margin, 5);
        }

        public void GoToEditOpenDealDialog()
        {
            _app.Tap(Resources.Screen.OpenedDeal.InstrName);
        }

        public void CloseAllOpenedDeals()
        {
            _app.Tap(Resources.Screen.OpenedDeal.CloseAllBlueBtn);
            _app.Tap(Resources.Screen.Localization.Yes);
        }

        public void CheckStringElement(string localeString, Func<AppQuery, AppQuery> elem) // метод который сверяет соответсвие елемента и текста
        {
            AppResult[] stringa = _app.WaitForElement(elem);
            Assert.AreEqual(localeString, stringa[0].Text);
            
        }

        public void CheckPartOfString(string localeString, Func<AppQuery, AppQuery> elem)
        {
            AppResult[] stringa = _app.WaitForElement(elem);
            bool res = stringa[0].Text.Contains(localeString);
            Assert.AreEqual(true, res);
        }

        public void CheckToolsStrings()
        {
            for (int i = 0; i < ElemDictionary.ToolsQueriesLocalized.Count; i++)
            {
                CheckStringElement(LocalizationDictionary.ToolsStrings.ElementAt(i).Value, ElemDictionary.ToolsQueriesLocalized.ElementAt(i).Value);
            }
        }

        public void CheckDrawerStrings()
        {
            for (int i = 0; i < ElemDictionary.DrawerQueriesLocalized.Count; i++)
            {
                CheckStringElement(LocalizationDictionary.DrawerLocalizedStrings.ElementAt(i).Value, ElemDictionary.DrawerQueriesLocalized.ElementAt(i).Value);
            }
        }
        public void CheckFavoritesStrings()
        {
            for (int i = 0; i < ElemDictionary.FavoritesQueriesLocalized.Count; i++)
            {
                CheckStringElement(LocalizationDictionary.FavoritesStrings.ElementAt(i).Value, ElemDictionary.FavoritesQueriesLocalized.ElementAt(i).Value);
            }
        }
        public void CheckOpenDealStrings()
        {
            for (int i = 0; i < ElemDictionary.OpenDealDialogQueriesLocalized.Count; i++)
            {
                CheckStringElement(LocalizationDictionary.OpenDealDialogStrings.ElementAt(i).Value, ElemDictionary.OpenDealDialogQueriesLocalized.ElementAt(i).Value);
            }
        }
        public void CheckOpenedDealsStrings()
        {
            for (int i = 0; i < ElemDictionary.OpenedDealsListQueriesLocalized.Count; i++)
            {
                CheckStringElement(LocalizationDictionary.OpenedDealsListStrings.ElementAt(i).Value, ElemDictionary.OpenedDealsListQueriesLocalized.ElementAt(i).Value);
            }
        }

        public void CheckClosedDealsStrings()
        {

            for (int i = 0; i < ElemDictionary.ClosedDealsListQueriesLocalized.Count; i++)
            {
                CheckStringElement(LocalizationDictionary.ClosedDealsListStrings.ElementAt(i).Value, ElemDictionary.ClosedDealsListQueriesLocalized.ElementAt(i).Value);
            }
        }

        public int CheckNumberOfDeals(Func<AppQuery,AppQuery> elementForSwipe, Func<AppQuery, AppQuery> whereToGoFromDrawer, Func<AppQuery, AppQuery> whatToSaveInAppResult )
        {
            
            AppResult[] deals = _app.Query(whatToSaveInAppResult);
            return deals.Length;

        }

        public void GoToOpenedDealsList(Func<AppQuery, AppQuery> elementForSwipe, Func<AppQuery, AppQuery> whereToGoFromDrawer)
        {
            Swipe(elementForSwipe);
            TransitionFromDrawer(whereToGoFromDrawer);

        }

        public double Parser(string value)
        {
            string result = "";
            foreach (var ch in value)
            {
                if (Char.IsDigit(ch))
                {
                    result += ch;
                }
                else if (ch == Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
                {
                    result += ch;
                }
            }
            return Convert.ToDouble(result);
        }
        public double CheckAmountValue()
        {
            AppResult[] amountField = _app.Query(Resources.Screen.OpenDeal.AmountField);
            double amount = Parser(amountField[0].Text);
            return amount;
        }

        public double CheckBalance()
        {
            AppResult[] balanceStr = _app.Query(Resources.Screen.Tools.DepositBalance);
            double balance = Parser(balanceStr[0].Text);
            return balance;
        }
    }
}
