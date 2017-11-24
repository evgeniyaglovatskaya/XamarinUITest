using PortableUI.ScreenObjectModel.Deposit;
using PortableUI.ScreenObjectModel.RegisterScreen;
using Xamarin.UITest;

namespace PortableUI
{
    public class ScreenInit
    {
        Platform _platform;
        public IAuthRegisterScreen Authorize;
        public IRegisterScreen Register;
        public ITools Tools;
        public IClosedDealsScreen ClosedDeal;
        public IOpenedDealsScreen OpenedDeal;
        public IOpenDealScreen OpenDeal;
        public IEditOpenDealScreen EditOpenDeal;
        public IFavoritesScreen Favorites;
        public ILimitOrderScreen LimitOrder;
        public IDrawer Drawer;
        public ILocalization Localization;
        public DepositBase Deposit; 


        public ScreenInit(Platform platform, LocalizationEnum locale)
        {
            _platform = platform;
            if (_platform == Platform.Android)
            {
                InitAndroid(_platform, locale);
            }
            else
            {
                InitIos(_platform, locale);
            }
            
        }

        public void InitAndroid(Platform platform, LocalizationEnum locale)
        {
            Register = new AndroidRegisterScreen();
            Deposit = new DepositBase();
            Authorize = new AndroidAuthRegister();
            Tools = new AndroidTools();
            ClosedDeal = new AndroidClosedDeals();
            OpenedDeal = new AndroidOpenedDeals();
            OpenDeal = new AndroidOpenDeal();
            EditOpenDeal = new AndroidEditOpenDeal();
            Favorites = new AndroidFavorites();
            LimitOrder = new AndroidLimitOrder();

            if (locale == LocalizationEnum.En)
            {
                Localization = new ENStrings();
                Drawer = new AndroidDrawerEN();
            }
            else if (locale == LocalizationEnum.Ru)
            {
                Localization = new RUStrings();
                Drawer = new AndroidDrawerRU();
            }
        }

        public void InitIos(Platform platform, LocalizationEnum locale)
        {
            Register = new IosRegisterScreen();
            Deposit = new DepositBase();
            Authorize = new IosAuthRegister();
            Tools = new IosTools();
            ClosedDeal = new IosClosedDeals();
            OpenedDeal = new IosOpenedDeals();
            OpenDeal = new IosOpenDeal();
            EditOpenDeal = new IosEditOpenDeal();
            Favorites = new IosFavorites();
            LimitOrder = new IosLimitOrder();
            if (locale == LocalizationEnum.En)
            {
                Localization = new ENStrings();
                Drawer = new IosDrawerEN();
            }
            else if (locale == LocalizationEnum.Ru)
            {
                Localization = new RUStrings();
                Drawer = new IosDrawerRU();
            }
        }
    }
}
