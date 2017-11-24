using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using PortableUI;
using Xamarin.UITest.Queries;

namespace BDDtests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform, string simulatorId)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .EnableLocalScreenshots()
                    .DeviceSerial(simulatorId)
                    .ApkFile(PathToProject.Android_APK)
                    .StartApp();
            }
            return ConfigureApp
                .iOS
                .DeviceIdentifier(simulatorId)
                .AppBundle(PathToProject.Ios_APP)
                .StartApp();
        }
    }
}

