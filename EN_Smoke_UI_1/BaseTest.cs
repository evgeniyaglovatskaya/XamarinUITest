using NUnit.Framework;
using Xamarin.UITest;
using PortableUI;
namespace EN_Smoke_UI_1
{
  
    [TestFixture(Platform.Android, Simulators.MAC_Android)]
    [TestFixture(Platform.iOS, Simulators.MAC_iOS_EN)]
    public class BaseTest
    {
        protected Platform Platform;
        protected string SimulatorName;
        protected IApp App;
        protected Helpers Helper;

        public BaseTest(Platform platform, string simulatorName)
        {
            SimulatorName = simulatorName;
            Resources.Screen = new ScreenInit(platform, LocalizationEnum.En);
            Platform = platform;
            
        }

        [SetUp]
        public void BeforeEachTest()
        {
            App = AppInitializer.StartApp(Platform, SimulatorName);
            Helper = new Helpers(Platform, App, Resources.Screen, LocalizationEnum.En);
            ElemDictionary.Init(Resources.Screen);
            LocalizationDictionary.Init(Resources.Screen);
        }



    }
}
