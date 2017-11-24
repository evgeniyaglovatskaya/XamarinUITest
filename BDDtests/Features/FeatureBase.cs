using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PortableUI;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace BDDtests.Features
{
[TestFixture(Platform.Android, Simulators.Local_Android)]

    public class FeatureBase
    {

        protected Platform Platform;
        public string SimulatorName;
        public IApp App;
        public Helpers Helper;

        public FeatureBase(Platform platform, string simulatorName)
        {
            SimulatorName = simulatorName;
            Resources.Screen = new ScreenInit(platform, LocalizationEnum.Ru);
            Platform = platform;

        }
        

        [TestFixtureSetUp]
        public void BeforeAllTests()

        {
            App = AppInitializer.StartApp(Platform, SimulatorName);
            Helper = new Helpers(Platform, App, Resources.Screen, LocalizationEnum.Ru);
            ElemDictionary.Init(Resources.Screen);
            LocalizationDictionary.Init(Resources.Screen);
            Helper.Authorize("tvma@i.ua","123qwe");
            Helper.WaitForElementWithTime(Resources.Screen.Favorites.Card, 60);

        }

        [SetUp]
        public void BeforeEachTest()
        {
            FeatureContext.Current.Add("App", App);
            FeatureContext.Current.Add("Helper", Helper);
        }
        

        [TearDown]
        public void AfterEachTest()
        {
            FeatureContext.Current.Remove("App");
            FeatureContext.Current.Remove("Helper");
        }

    }
}
