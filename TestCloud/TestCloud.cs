using NUnit.Framework;
using PortableUI;
using Xamarin.UITest;

namespace TestCloud
{
   
    public class TestCloud:BaseTest
    {
        

        public TestCloud(Platform platform) : base(platform)
        {
        }

        [Test]
        public void AuthorizationPassRecovery()
        {
            App.Screenshot("AuthorizationScreen");
            App.Tap(Resources.Screen.Authorize.Forgot_Pass);
            App.Screenshot("PasswordRecoveryScreen");
        }
        [Test]
        public void Registration()
        {
            App.Tap(Resources.Screen.Authorize.Btn_Registr_From_Login);
            App.Screenshot("EmailRegistrationScreen");
            App.Tap(Resources.Screen.Register.EmailField);
            App.EnterText("t@i.ua");
            App.DismissKeyboard();
            App.Tap(Resources.Screen.Register.EmailNextBtn);
            App.Screenshot("PhoneRegistrationScreen");
            App.Tap(Resources.Screen.Register.PhoneField);
            App.EnterText("123456");
            App.DismissKeyboard();
            App.Tap(Resources.Screen.Register.PhoneNextBtn);
            App.Screenshot("NameRegistrationScreen");
            App.Tap(Resources.Screen.Register.FirstNameField);
            App.EnterText("й");
            App.Tap(Resources.Screen.Register.LastNameField);
            App.EnterText("й");
            App.DismissKeyboard();
            App.Tap(Resources.Screen.Register.NameNextBtn);
            App.Tap(Resources.Screen.Register.PasswordField);
            App.EnterText("1");
            App.DismissKeyboard();
            App.Screenshot("PasswordRegistrationScreen");
            
        }
        [Test]
        public void FavoritesAndOpenDeal()
        {
            Helper.Authorize("tvma@i.ua", "123qwe");
            Helper.WaitForElementWithTime(Resources.Screen.Favorites.Card, 15);
            App.Screenshot("FavoritesScreen");
            Helper.GoToOpenDealDialog(Resources.Screen.Favorites.InstrName);
            Helper.WaitForElementWithTime(Resources.Screen.OpenDeal.Price, 5);
            App.Screenshot("OpenDealDialog");
        }


        [Test]
        public void DrawerAndOpenedDealsAndEditOpenDealDialog()
        {
            Helper.Authorize("tvma@i.ua", "123qwe");
            Helper.Swipe(Resources.Screen.Favorites.Card);
            App.Screenshot("Drawer");
            Helper.TransitionFromDrawer(Resources.Screen.Drawer.Open_Deals);
            Helper.WaitForElementWithTime(Resources.Screen.OpenedDeal.Card, 10);
            App.Screenshot("OpenedDealsListScreen");
            Helper.GoToEditOpenDealDialog();
            Helper.WaitForElementWithTime(Resources.Screen.EditOpenDeal.Price, 10);
            App.Screenshot("EditOpenDealDialog");
        }

        //[Test]
        //public void CreateLimitOrder()
        //{

        //}
        //[Test]
        //public void EditLimitOrder()
        //{

        //}
        //[Test]
        //public void LimitOrderList()
        //{

        //}
        [Test]
        public void ClosedDealsList()
        {
            Helper.Authorize("tvma@i.ua", "123qwe");
            Helper.Swipe(Resources.Screen.Favorites.Card);
            Helper.TransitionFromDrawer(Resources.Screen.Drawer.Closed_Deals);
            Helper.WaitForElementWithTime(Resources.Screen.ClosedDeal.InstrNameOnClosedDealCard, 10);
            App.Screenshot("ClosedDealsListScreen");
        }

        [Test]
        public void Deposit()
        {
            Helper.Authorize("tvma@i.ua", "123qwe");
            Helper.GoToDeposit();
            App.Screenshot("VisaCreditCard");
            App.Back();
            App.Screenshot("DepositMainPage");
            App.Tap(Resources.Screen.Deposit.Deposit.Visa3dSecure);
            App.Screenshot("Visa3dSecure");
            App.Back();
            App.Tap(Resources.Screen.Deposit.Deposit.WireTransfer);
            App.Screenshot("WireTransfer");
            App.Back();
            App.Tap(Resources.Screen.Deposit.Deposit.OnlineWireTransfer);
            App.Screenshot("OnlineWireTransfer");
            App.Back();
            App.ScrollDownTo(Resources.Screen.Deposit.Deposit.OnlineWireTransfer);
            App.Tap(Resources.Screen.Deposit.Deposit.CASHU);
            App.Screenshot("CashU");
            App.Back();
            App.Tap(Resources.Screen.Deposit.Deposit.Neteller);
            App.Screenshot("Neteller");
            App.Back();
            App.Tap(Resources.Screen.Deposit.Deposit.WalletOne);
            App.Screenshot("WalletOne");
            App.Back();
            App.Tap(Resources.Screen.Deposit.Deposit.YandexMoney);
            App.Screenshot("YandexMoney");
            App.Back();
            App.Tap(Resources.Screen.Deposit.Deposit.QiwiWallet);
            App.Screenshot("QiwiWallet");
            App.Back();
            App.ScrollDownTo(Resources.Screen.Deposit.Deposit.QiwiWallet);
            App.Tap(Resources.Screen.Deposit.Deposit.WebMoney);
            App.Screenshot("WebMoney");
            App.Back();
            App.Tap(Resources.Screen.Deposit.Deposit.YuuPay);
            App.Screenshot("YuuPay");
            App.Back();
            App.Tap(Resources.Screen.Deposit.Deposit.MonetaRu);
            App.Screenshot("MonetaRu");
            App.Back();
            App.Tap(Resources.Screen.Deposit.Deposit.BoletoBankario);
            App.Screenshot("Boleto");
            App.Back();
            App.ScrollDownTo(Resources.Screen.Deposit.Deposit.BoletoBankario);
            App.Tap(Resources.Screen.Deposit.Deposit.Astropay);
            App.Screenshot("Astropay");
            App.Back();
            App.Tap(Resources.Screen.Deposit.Deposit.AlfaBank);
            App.Screenshot("AlfaBank");
            App.Back();
            App.Tap(Resources.Screen.Deposit.Deposit.Promsvyazbank);
            App.Screenshot("Promsvyazbank");
            App.Back();
            App.Tap(Resources.Screen.Deposit.Deposit.Aonpay);
            App.Screenshot("Aonpay");
            App.Back();
        }

    }
}
