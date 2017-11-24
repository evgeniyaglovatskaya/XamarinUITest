using Xamarin.UITest;

namespace EN_Smoke_UI
{
    public class AppInitializer
    {

        private const string AppPath ="/Users/Mac/Downloads/buildAgent/work/16d7e8b022d15bdc/mob/mob/mob.iOS/bin/iPhoneSimulator/Release/mob.iOS.app";
        //private const string AppPath = "../mob/mob.iOS/bin/iPhoneSimulator/Release/mob.iOS.app";
        private const string ApkPath ="/Users/Mac/Downloads/buildAgent/work/16d7e8b022d15bdc/mob/mob/mob.Droid/bin/Release/com.maximarkets.trading.apk";


        public static IApp StartApp(Platform platform, string simulatorId)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .EnableLocalScreenshots()
                    .DeviceSerial(simulatorId)
                    .ApkFile(ApkPath)
                    .StartApp();
            }
            return ConfigureApp
                .iOS
                .DeviceIdentifier(simulatorId)
                .AppBundle(AppPath)
                .StartApp();


        }

        
    }

}