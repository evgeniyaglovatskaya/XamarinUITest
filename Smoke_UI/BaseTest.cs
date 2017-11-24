using NUnit.Framework;
using PortableUI;
using Xamarin.UITest;


namespace RU_Smoke_UI
{

 
     [TestFixture(Platform.Android, Simulators.Local_Android)]
    [TestFixture(Platform.iOS, Simulators.MAC_iOS_RU)]
    public class BaseTest
    {
        public Platform Platform;
        public string SimulatorName;
        public IApp App;
        public Helpers Helper;

        public BaseTest(Platform platform, string simulatorName)
        {
            SimulatorName = simulatorName;
            Resources.Screen = new ScreenInit(platform, LocalizationEnum.Ru);
            Platform = platform;
            
        }

        [SetUp]
        public void BeforeEachTest()
        {
            App = AppInitializer.StartApp(Platform, SimulatorName);
            Helper = new Helpers(Platform, App, Resources.Screen, LocalizationEnum.Ru);
            ElemDictionary.Init(Resources.Screen);
            LocalizationDictionary.Init(Resources.Screen);
        }


      
    }
}
