using System.Linq;
using NUnit.Framework;
using PortableUI;
using Xamarin.UITest;

namespace EN_Smoke_UI
{

    public class SmokeTest : BaseTest
    {
        public SmokeTest(Platform platform, string simulatorName) : base(platform, simulatorName)
        {
        }

        [SetUp]
        public void BeforeEachTest()
        {
            //_helper.Authorize("tvma@i.ua", "123qwe");
            _helper.Authorize("other1", "password");
            _helper.WaitForElementWithTime(Resources.Screen.Favorites.Card, 60);
        }

        [Test]
        public void DrawerScreen()
        {
            _helper.Swipe(Resources.Screen.Favorites.Card);
            _helper.CheckDrawerStrings();
        }

        [Test]
        public void FavoritesScreen()
        {
            _helper.CheckFavoritesStrings();
            _helper.CheckToolsStrings();
            _helper.WaitForElementWithTime(Resources.Screen.Drawer.Favorites, 10);
        }

        [Test]
        public void OpenDealDialogScreen()
        {
            _helper.GoToOpenDealDialog(Resources.Screen.Favorites.InstrName);
            _helper.CheckOpenDealStrings();
            _helper.CheckPartOfString(Resources.Screen.Localization.Margin, Resources.Screen.OpenDeal.Margin);
            _helper.CheckPartOfString(Resources.Screen.Localization.Today, Resources.Screen.OpenDeal.Today);
            _helper.CheckToolsStrings();
        }

        [Test]
        public void OpenedDealsListScreen()
        {
            _helper.Swipe(Resources.Screen.Favorites.Card);
            _helper.TransitionFromDrawer(Resources.Screen.Drawer.Open_Deals);
            _helper.CheckOpenedDealsStrings();
            _helper.CheckToolsStrings();
            _helper.WaitForElementWithTime(Resources.Screen.Drawer.Open_Deals, 10);
        }

        [Test]
        public void ClosedDealsListScreen()
        {
            _helper.CheckClosedDealsStrings();
            _helper.CheckToolsStrings();
            _helper.WaitForElementWithTime(Resources.Screen.Drawer.Closed_Deals, 10);
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
