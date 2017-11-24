using NUnit.Framework;
using PortableUI;
using Xamarin.UITest;


namespace SplashTest
{

    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class BaseTest
    {
        public Platform Platform;
        public IApp App;
        public Helpers Helper;

        public BaseTest(Platform platform)
        {
            
            Resources.Screen = new ScreenInit(platform, LocalizationEnum.En);
            Platform = platform;

        }

        [SetUp]
        public void BeforeEachTest()
        {
            App = AppInitializer.StartApp(Platform);
            Helper = new Helpers(Platform, App, Resources.Screen, LocalizationEnum.En);
            ElemDictionary.Init(Resources.Screen);
            LocalizationDictionary.Init(Resources.Screen);
           
        }



    }
}
