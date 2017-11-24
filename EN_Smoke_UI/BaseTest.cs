using NUnit.Framework;
using Xamarin.UITest;
using PortableUI;
namespace EN_Smoke_UI
{
  
    [TestFixture(Platform.Android, "emulator-5554")]
    [TestFixture(Platform.iOS, "BC0DBE8A-5470-494A-AE2C-C85B49D2B49F")]
    public class BaseTest
    {
        protected Platform Platform;
        public string _simulatorName;
        public IApp _app;
        public Helpers _helper;

        public BaseTest(Platform platform, string simulatorName)
        {
            _simulatorName = simulatorName;
            Resources.Screen = new ScreenInit(platform, LocalizationEnum.En);
            Platform = platform;
            
        }

        [SetUp]
        public void BeforeEachTest()
        {
            _app = AppInitializer.StartApp(Platform, _simulatorName);
            _helper = new Helpers(Platform, _app, Resources.Screen, LocalizationEnum.En);
            ElemDictionary.Init(Resources.Screen);
            LocalizationDictionary.Init(Resources.Screen);
        }



    }
}
