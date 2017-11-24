using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.iOS;
using Xamarin.UITest.Queries;

namespace iOS_UI_Tests
{
	[TestFixture]
	public class Smoke
	{
		iOSApp app;

		[SetUp]
		public void BeforeEachTest()
		{
			// TODO: If the iOS app being tested is included in the solution then open
			// the Unit Tests window, right click Test Apps, select Add App Project
			// and select the app projects that should be tested.
			//
			// The iOS project should have the Xamarin.TestCloud.Agent NuGet package
			// installed. To start the Test Cloud Agent the following code should be
			// added to the FinishedLaunching method of the AppDelegate:
			//
			//    #if ENABLE_TEST_CLOUD
			//    Xamarin.Calabash.Start();
			//    #endif
			app = ConfigureApp
				.iOS
				// TODO: Update this path to point to your iOS app and uncomment the
				// code if the app is not included in the solution.
				//.AppBundle ("../../../iOS/bin/iPhoneSimulator/Debug/iOS_UI_Tests.iOS.app")
				.EnableLocalScreenshots()
				.StartApp();
		}


		public static void Sleep(int ms)
		{
			Task.Delay(ms).Wait();
		}

		[Test]
		public void Auth_1()
		{
			app.Tap(x => x.Marked("E-mail"));
			app.EnterText(x => x.Marked("E-mail"), "tvma@i.ua");
			app.Tap(x => x.Marked("Password"));
			app.EnterText(x => x.Marked("Password"), "123qwe");
			app.Tap(x => x.Marked("SIGN IN"));
		}

		[Test]
		public void Auth_4()
		{
			app.Tap(x => x.Text("*Forgot your password"));
			app.Tap(x => x.Marked("E-mail"));
			app.EnterText(x => x.Class("UITextField"), "tvma@i.ua");
			app.Tap(x => x.Marked("NEXT"));
			//app.WaitForElement(x => x.Text("Password recovery guide sent to the users mail, tvma@i.ua"));
			app.WaitForElement(x => x.ClassFull("UILabel"));
			//app.Tap(x => x.Text("Ok"));
			app.Tap(x => x.ClassFull("_UIAlertControllerActionView"));
			app.WaitForElement(x => x.Text("Authorization"));
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void Dashboard_4()
		{
			Auth_1();
			app.ScrollDownTo(x => x.ClassFull("NewsCollectionViewCell"));
			app.Tap(x => x.Class("UIView"));
			app.WaitForElement(x => x.ClassFull("NewsDetailCollectionViewCell"));
		}

		[Test]
		public void Insrtumental_2()
		{
			Auth_1();
			app.Tap(x => x.Id("Image/currency.png"));
			app.Tap(x => x.Id("Image/candle_neactiv.png"));
			app.Tap(x => x.Id("Image/info1.png"));
			app.ScrollDownTo(x => x.Id("Image/arrow1.png"));
			app.WaitForElement(x => x.ClassFull("ChartViewIOS"));
			app.WaitForElement(x => x.Text("Pivot Point"));

		}

		[Test]
		public void Insrtumental_3()
		{
			Insrtumental_2();
			app.Tap(x => x.Id("Image/menu.png"));
			app.Tap(x => x.Text("Collapse All"));

			app.Tap(x => x.Id("Image/candle_neactiv.png"));
			app.Tap(x => x.Id("Image/info1.png"));
			app.ScrollDownTo(x => x.Id("Image/arrow1.png"));

			app.Tap(x => x.Id("Image/ic_more_vert_black_24dp.png"));
			app.Tap(x => x.Text("Collapse"));
		}

		[Test]
		public void Insrtumental_4()
		{
			Auth_1();
			app.Tap(x => x.Id("Image/arrow1.png"));
			app.ScrollDownTo(x => x.ClassFull("AnalyzeCollectionViewCell"));
			app.WaitForElement(x => x.ClassFull("AnalyzeCollectionViewCell"));
		}

		[Test]
		public void Insrtumental_5()
		{
			Auth_1();
			app.Tap(x => x.Id("Image/currency.png"));
			app.WaitForNoElement(x => x.Id("Image/flag_blue.png"));
			app.Tap(x => x.Id("Image/ic_more_vert_black_24dp.png"));
			app.Tap(x => x.Text("Add to Favour"));
			app.WaitForElement(x => x.Id("Image/flag_blue.png"));

		}

		[Test]
		public void Full_2()
		{
			Auth_1();
			app.Tap(x => x.Id("Image/arrow1.png"));
			app.ScrollDownTo("Image/fullscreen.png");
			app.Tap(x => x.Marked("fullscreen"));
			app.Tap(x => x.Id("Image/candle_neactiv.png"));
			app.WaitForElement(x => x.Text("Linear gradient"));
			app.WaitForElement(x => x.Text("Linear"));
			app.WaitForElement(x => x.Text("Candles"));
		}

		[Test]
		public void Full_3()
		{
			Auth_1();
			app.Tap(x => x.Id("Image/arrow1.png"));
			app.ScrollDownTo("Image/fullscreen.png");
			app.Tap(x => x.Marked("fullscreen"));
			app.Tap(x => x.Id("Image/indikator_neactiv.png"));
			app.WaitForElement(x => x.Text("Bollinger Bands"));
			app.WaitForElement(x => x.Text("EMA 5"));
			app.WaitForElement(x => x.Text("EMA 14"));
			app.WaitForElement(x => x.Text("EMA 20"));
			app.WaitForElement(x => x.Text("EMA 50"));
		}

		//Не закончил
		[Test]
		public void Settings_2()
		{
			Auth_1();
			app.Tap(x => x.Marked("menu"));
			app.Tap(x => x.Marked("Settings"));

			app.Tap(x => x.Class("UITableViewLabel").Text("Currency").Marked("Currency"));
			app.Tap(x => x.Class("UITableViewCellContentView"));
			app.Tap(x => x.Class("UITableViewCellContentView").Index(1));
			app.Tap(x => x.Text("Edit"));
			//app.TouchAndHold(x => x.Class("UIImageView").Index(7));
			app.TouchAndHold(x => x.Marked("Reorder"));
			app.Tap(x => x.Text("Done"));
			app.Tap(x => x.Text("Back"));
			app.Tap(x => x.Class("UINavigationItemButtonView").Marked("Home"));

			app.Tap(x => x.Id("Image/currency.png"));
			app.WaitForElement(x => x.Text("USD/PLN"));
		}

		[Test]
		public void Toolbar_1()
		{
			Auth_1();
			app.Tap(x => x.ClassFull("UINavigationButton"));
			app.EnterText(x => x.Text("Enter a search query"), "usd");
			app.Tap(x => x.Text("USD/CZK"));
			app.WaitForElement(x => x.Id("USD/CZK"));
		}

		[Test]
		public void Toolbar_3()
		{
			Insrtumental_2();
			app.Tap(x => x.Id("Image/menu.png"));
			app.Tap(x => x.Text("Collapse All"));

		}

		[Test]
		public void Database_1()
		{
			Auth_1();
			app.Tap(x => x.Marked("menu"));
			app.Tap(x => x.Marked("Settings"));
			app.Tap(x => x.Marked("Language"));
			app.Tap(x => x.Marked("Русский"));
			app.Tap(x => x.Text("Назад"));
			//app.Tap(x => x.Text("Главная"));
			app.Tap(x => x.ClassFull("UINavigationItemButtonView"));
			Sleep(2000);
			app.SendAppToBackground(new TimeSpan(0, 0, 5));
			app.WaitForElement(x => x.Text("Главная"));
		}

		[Test]
		public void Database_4()
		{
			Auth_1();
			app.Tap(x => x.Id("Image/lock_open.png"));
			app.WaitForElement(x => x.Id("Image/lock_outline.png"));
			Sleep(500);
			app.SendAppToBackground(new TimeSpan(0, 0, 5));
			app.WaitForElement(x => x.Id("Image/lock_outline.png"));
		}

		[Test]
		public void Database_5()
		{
			Auth_1();
			app.Tap(x => x.Id("Image/info1.png"));
			app.ScrollDownTo(x => x.Id("Image/arrow1.png"));
			app.Tap(x => x.Id("Image/candle_neactiv.png"));
			app.ScrollDownTo(x => x.Id("Image/arrow1.png"));
			app.WaitForElement(x => x.ClassFull("ChartViewIOS"));
			app.WaitForElement(x => x.Text("Pivot Point"));
			Sleep(500);
			app.SendAppToBackground(new TimeSpan(0, 0, 5));
			app.WaitForElement(x => x.ClassFull("ChartViewIOS"));
			app.WaitForElement(x => x.Text("Pivot Point"));
		}
	}
}
