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

    public class AuthFeatureBase
    {

        protected Platform Platform;
        public string SimulatorName;
        public IApp App;
        public Helpers Helper;

        public AuthFeatureBase(Platform platform, string simulatorName)
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
