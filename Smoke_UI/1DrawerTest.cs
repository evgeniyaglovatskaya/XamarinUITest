using System.Linq;
using NUnit.Framework;
using PortableUI;
using Xamarin.UITest;

namespace RU_Smoke_UI
{

    public class DrawerTest : BaseTest
    {
        public DrawerTest(Platform platform, string simulatorName) : base(platform, simulatorName)
        {
        }

        [SetUp]
        public void BeforeEachTest()
        {
           
        }

        [Test]
        public void AuthorizationScreen()
        {
            App.Repl();
            Helper.CheckStringElement(Resources.Screen.Localization.Email,Resources.Screen.Authorize.Email);
            Helper.CheckStringElement(Resources.Screen.Localization.Password, Resources.Screen.Authorize.Password);
            Helper.CheckStringElement(Resources.Screen.Localization.LoginButton, Resources.Screen.Authorize.Login_Btn);
            Helper.CheckStringElement(Resources.Screen.Localization.SignUpButton, Resources.Screen.Authorize.Btn_Registr_From_Login);
        }
        [Test]
        public void DrawerScreen()
        {
            Helper.Authorize("tvma@i.ua", "123qwe");
            //_helper.Authorize("other1", "password");
            Helper.WaitForElementWithTime(Resources.Screen.Favorites.Card, 60);
            Helper.Swipe(Resources.Screen.Favorites.Card);
            Helper.CheckDrawerStrings();
        }

        [Test]
        public void FavoritesScreen()
        {
            Helper.Authorize("tvma@i.ua", "123qwe");
            //_helper.Authorize("other1", "password");
            Helper.WaitForElementWithTime(Resources.Screen.Favorites.Card, 60);
            Helper.CheckFavoritesStrings();
            Helper.CheckToolsStrings();
            Helper.WaitForElementWithTime(Resources.Screen.Drawer.Favorites, 10);
        }

        [Test]
        public void OpenDealDialogScreen()
        {
            Helper.Authorize("tvma@i.ua", "123qwe");
            //_helper.Authorize("other1", "password");
            Helper.WaitForElementWithTime(Resources.Screen.Favorites.Card, 60);
            Helper.GoToOpenDealDialog(Resources.Screen.Favorites.InstrName);
            Helper.CheckOpenDealStrings();
            Helper.CheckPartOfString(Resources.Screen.Localization.Margin, Resources.Screen.OpenDeal.Margin);
            Helper.CheckPartOfString(Resources.Screen.Localization.Today, Resources.Screen.OpenDeal.Today);
            Helper.CheckToolsStrings();
        }

        [Test]
        public void OpenedDealsListScreen()
        {
            Helper.Authorize("tvma@i.ua", "123qwe");
            //_helper.Authorize("other1", "password");
            Helper.WaitForElementWithTime(Resources.Screen.Favorites.Card, 60);
            Helper.Swipe(Resources.Screen.Favorites.Card);
            Helper.TransitionFromDrawer(Resources.Screen.Drawer.Open_Deals);
            Helper.CheckOpenedDealsStrings();
            Helper.CheckToolsStrings();
            Helper.WaitForElementWithTime(Resources.Screen.Drawer.Open_Deals, 10);
        }

        [Test]
        public void ClosedDealsListScreen()
        {
            Helper.Authorize("tvma@i.ua", "123qwe");
            //_helper.Authorize("other1", "password");
            Helper.WaitForElementWithTime(Resources.Screen.Favorites.Card, 60);
            Helper.CheckClosedDealsStrings();
            Helper.CheckToolsStrings();
            //_helper.WaitForElementWithTime(c=>c.Text("Закрытые сделки"), 10);
        }
        //public void Edit_Open_Deal_Dialog_Transition()
        //{
        //    Swipe(Screen.Favorites.Card);
        //    TransitionFromDrawer(Screen.Drawer.Open_Deals);
        //    GoToEditOpenDealDialog();
        //    WaitForElementWithTime(Screen.EditOpenDeal.DuplicateBtn, 10);
        //}

    }
}
