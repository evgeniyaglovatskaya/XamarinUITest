using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.iOS;
using Xamarin.UITest.Queries;

namespace iOS_UI_Tests
{
	[TestFixture]
	public class Auth
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

		
		[Test]
		public void Login_Correct()
		{
			app.Tap(x => x.Marked("E-mail"));
			app.EnterText(x => x.Marked("E-mail"), "tvma@i.ua");
			app.Tap(x => x.Marked("Password"));
			app.EnterText(x => x.Marked("Password"), "123qwe");
			app.Tap(x => x.Marked("SIGN IN"));
			app.WaitForElement(x => x.Id("Image/home.png"));// проверить что это
		}

		/*[Test]
		public void Login_Incorrect()
		{
			app.Tap(x => x.Marked("E-mail"));
			app.EnterText(x => x.Marked("E-mail"), "tvm3213a@h.ua");
			app.Tap(x => x.Marked("Password"));
			app.EnterText(x => x.Marked("Password"), "1fdsf23qwe");
			app.Tap(x => x.Marked("SIGN IN"));
			app.WaitForElement(x => x.ClassFull("_UIInterfaceActionGroupHeaderScrollView"));
		}*/

		[Test]
		public void Login_Valid()
		{
			app.Tap(x => x.Marked("E-mail"));
			app.EnterText(x => x.Marked("E-mail"), "tvm3213");
			app.WaitForElement(x => x.Text("Invalid data format."));
			app.Tap(x => x.Marked("Password"));
			app.EnterText(x => x.Marked("Password"), "1fd");
			app.WaitForElement(x => x.Text("Invalid data format."));
			app.Tap(x => x.Marked("SIGN IN"));
			app.WaitForElement(x => x.ClassFull("_UIInterfaceActionGroupHeaderScrollView"));

		    
		}

	}
}
