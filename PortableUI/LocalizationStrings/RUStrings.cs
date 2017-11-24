using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortableUI
{
    class RUStrings:ILocalization
    {
        public string Email { get; } = "Email";
        public string Password { get; } = "Пароль";
        public string LoginButton { get; } = "ВОЙТИ";
        public string NoAccount { get; } = "Нет аккаунта?";

        public string NextButton { get; } = "ДАЛЕЕ";
        public string EnterEmail { get; } = "Введите вашу почту";
        public string SloganEmail { get; } = "Служба поддержки 24/7";
        public string EnterPhone { get; } = "Введите ваш телефон";
        public string Phone { get; } = "Номер телефона";
        public string SloganPhone { get; } = "Актуальные котировки от надежных провайдеров";

        public string EnterNames { get; } = "Введите имя и фамилию";
        public string FirstName { get; } = "Имя";
        public string LastName { get; } = "Фамилия";
        public string SloganNames { get; } = "170 торговых активов для вашей прибыли!";

        public string EnterPass { get; } = "Установите пароль";
        public string ConfirmPassword { get; } = "Подтвердите пароль";
        public string UserAgreement { get; } = "Нажимая \"Зарегистрироваться\", вы соглашаетесь с условиями нашего Пользовательского соглашения.";
        public string SignUpButton { get; } = "ЗАРЕГИСТРИРОВАТЬСЯ";
        public string SloganPass { get; } = "Earnings without hidden commissions!";

        public string RecoverPassButton { get; } = "ВОССТАНОВИТЬ ПАРОЛЬ";
        public string SloganRecoverPass { get; } = "Зарабатывайте, где бы вы ни были!";


        public string SuccessfulRegistrationMessage { get; } = "Регистрация прошла успешно!";
        public string IncorrectEmailPassMessage { get; } = "Некорректный адрес электронной почты или пароль.";

        //Favorites screen
        public string ToolbarTitleOnFavorites { get; } = "Избранные";
        public string DepositBtn { get; } = "ДЕПОЗИТ";
        public string FreeBalance { get; } = "Доступно:";
        public string BalancePL { get; } = "Доход:";
        public string InfoPanelName { get; } = "Название";
        public string InfoPanelTrend { get; } = "Тренд";
        public string InfoPanelSell { get; } = "Продажа";
        public string InfoPanelBuy { get; } = "Покупка";
        public string DealTypeSell { get; } = "SELL";
        public string DealTypeBuy { get; } = "BUY";

        //Drawer
        public string DrawerDeposit { get; } = "Пополнить счет";
        public string DrawerBalances { get; } = "Балансы";
        public string DrawerFavorites { get; } = "Избранные";
        public string DrawerTools { get; } = "Инструменты";
        public string DrawerOpenDeals { get; } = "Открытые сделки";
        public string DrawerLimitOrders { get; } = "Лимитные ордера";
        public string DrawerClosedDeals { get; } = "Закрытые сделки";
        public string DrawerDetailMode { get; } = "Детальный режим";

        //Open deal dialog
        public string LimitOrderBtn { get; } = "Лимит.\nордер";
        public string TickerContracts { get; } = "Контр.";
        public string TickerStocks { get; } = "Акции";
        public string BuyBtn { get; } = "ПОКУПКА";
        public string SellBtn { get; } = "ПРОДАЖА";
        public string Today { get; } = "сегодня";
        public string Margin { get; } = "Маржа";
        public string InvalidAmount { get; } = "Количество заказа не находится в допустимом интервале.";

        //Opened Deals screen
        public string CloseDealBtn { get; } = "ЗАКРЫТЬ СДЕЛКУ";
        public string SL { get; } = "СЛ";
        public string TP { get; } = "ТП";
        public string ToolbarTitleOnOpenedDeals { get; } = "Открытые сделки";

        //Closed deals
        public string ToolbarTitleOnClosedDeals { get; } = "Закрытые сделки";

        public string Yes { get; } = "Да";
    }
}
