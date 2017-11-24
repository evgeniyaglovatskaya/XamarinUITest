using System;
using System.IO;
using System.Linq;
using PortableUI;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace SplashTest
{
    public class AppInitializer
    {
       
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .ApkFile(PathToProject.Android_APK)
                    .StartApp();
            }

            return ConfigureApp
                .iOS
                .AppBundle(PathToProject.Ios_APP)
                .StartApp();
        }
    }
}

