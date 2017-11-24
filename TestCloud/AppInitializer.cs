using PortableUI;
using Xamarin.UITest;

namespace TestCloud
{
    public class AppInitializer
    {

        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .EnableLocalScreenshots()
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

