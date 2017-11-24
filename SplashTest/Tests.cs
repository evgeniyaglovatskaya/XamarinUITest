using System;
using System.IO;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using PortableUI;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace SplashTest
{
    
  
    public class Tests:BaseTest
    {
        public Tests(Platform platform) : base(platform)
        {
        }




        [Test]
        public void AppLaunches()
        {
             App.Screenshot("AppLaunches");
        }
        //[Test]
        //public void AppLaunches()
        //{
        //   Helper.Authorize("tvma@i.ua","123qwe");
        //    Helper.WaitForElementWithTime(Resources.Screen.Favorites.Card,30);
        //    Helper.Swipe(Resources.Screen.Favorites.Card);
        //    Helper.TransitionFromDrawer(Resources.Screen.Drawer.Tools);
        //    App.Screenshot("Tools");
        //}
        //[Test]
        //public void DepositLayoutTest()
        //{
        //    Helper.Authorize("tvma@i.ua", "123qwe");
        //    Helper.WaitForElementWithTime(Resources.Screen.Favorites.Card,30);
        //    Helper.Swipe(Resources.Screen.Favorites.Card);
        //    App.Tap(Resources.Screen.Drawer.Deposit);
        //    Thread.Sleep(20000);
        //    App.Screenshot("Deposit");
        //}
        //[Test]
        //public void ToolsLayoutTest()
        //{
        //    Helper.Authorize("tvma@i.ua", "123qwe");
        //    Helper.WaitForElementWithTime(Resources.Screen.Favorites.Card, 30);
        //    Helper.Swipe(Resources.Screen.Favorites.Card);
        //    App.Tap(Resources.Screen.Drawer.Tools);
        //    Thread.Sleep(2000);
        //    App.Screenshot("FilterTab");
        //}

        //[Test]
        //public void DrawerScreenTest()
        //{
        //    Helper.Authorize("tvma@i.ua", "123qwe");
        //    Helper.WaitForElementWithTime(Resources.Screen.Favorites.Card, 30);
        //    Helper.Swipe(Resources.Screen.Favorites.Card);
        //    Helper.WaitForElementWithTime(Resources.Screen.Drawer.Open_Deals, 30);
        //    App.Screenshot("Drawer");
        //}
    }
}

