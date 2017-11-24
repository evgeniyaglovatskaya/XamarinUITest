using System.Linq;
using NUnit.Framework;
using PortableUI;
using Xamarin.UITest;

namespace EN_Smoke_UI_1
{

    public class SmokeTest : BaseTest
    {
        public SmokeTest(Platform platform, string simulatorName) : base(platform, simulatorName)
        {
        }

        [SetUp]
        public void BeforeEachTest()
        {
            Helper.Authorize("tvma@i.ua", "123qwe");
            // _helper.Authorize("other1", "password");
            Helper.WaitForElementWithTime(Resources.Screen.Favorites.Card, 60);
        }

        [Test]
        public void DrawerScreen()
        {
            Helper.Swipe(Resources.Screen.Favorites.Card);
            Helper.CheckDrawerStrings();
        }

        [Test]
        public void FavoritesScreen()
        {
            Helper.CheckFavoritesStrings();
            Helper.CheckToolsStrings();
            Helper.WaitForElementWithTime(Resources.Screen.Drawer.Favorites, 10);
        }

        [Test]
        public void OpenDealDialogScreen()
        {
            Helper.GoToOpenDealDialog(Resources.Screen.Favorites.InstrName);
            Helper.CheckOpenDealStrings();
            Helper.CheckPartOfString(Resources.Screen.Localization.Margin, Resources.Screen.OpenDeal.Margin);
            Helper.CheckPartOfString(Resources.Screen.Localization.Today, Resources.Screen.OpenDeal.Today);
            Helper.CheckToolsStrings();
        }

        [Test]
        public void OpenedDealsListScreen()
        {
            Helper.Swipe(Resources.Screen.Favorites.Card);
            Helper.TransitionFromDrawer(Resources.Screen.Drawer.Open_Deals);
            Helper.CheckOpenedDealsStrings();
            Helper.CheckToolsStrings();
            Helper.WaitForElementWithTime(Resources.Screen.Drawer.Open_Deals, 10);
        }

        [Test]
        public void ClosedDealsListScreen()
        {
            Helper.CheckClosedDealsStrings();
            Helper.CheckToolsStrings();
            Helper.WaitForElementWithTime(Resources.Screen.Drawer.Closed_Deals, 10);
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
