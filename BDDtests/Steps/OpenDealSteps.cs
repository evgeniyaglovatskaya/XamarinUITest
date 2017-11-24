using System;
using System.Threading;
using NUnit.Core;
using PortableUI;
using TechTalk.SpecFlow;
using Xamarin.UITest.Queries;

namespace BDDtests.Steps
{
    [Binding]
    public class OpenDealSteps:StepBase
    {
       
        [Given(@"I closed all deals \(that could be closed\)")]
        public void GivenIClosedAllDealsThatCouldBeClosed()
        {
            Helper.GoToOpenedDealsList(Resources.Screen.Favorites.Card, Resources.Screen.Drawer.Open_Deals);
            Helper.CloseAllOpenedDeals();
            Thread.Sleep(3000);
        }

        [Given(@"I have checked number of already opened deals")]
        public void GivenIHaveCheckedNumberOfAlreadyOpenedDeals()
        {

          
            int numberOfOpenedDealsBeforeTest = Helper.CheckNumberOfDeals(Resources.Screen.Favorites.Card, Resources.Screen.Drawer.Open_Deals,
                Resources.Screen.OpenedDeal.InstrName);
            ScenarioContext.Current.Add("numberOfDeals", numberOfOpenedDealsBeforeTest);
            Helper.Swipe(Resources.Screen.OpenedDeal.Card);
            Helper.TransitionFromDrawer(Resources.Screen.Drawer.Favorites);
        }

        [Given(@"I have opened currency open deal dialog")]
        public void GivenIHaveOpenedCurrencyOpenDealDialog()
        {
            App.Tap("AUD/CAD");
            //Helper.WaitForElementWithTime(Resources.Screen.OpenDeal.AmountField, 10);
        }
        
        [Given(@"I have tapped on Sell button")]
        public void GivenIHaveTappedOnSellButton()
        {
            App.Tap(Resources.Screen.OpenDeal.SellBtn);
        }
        
        [Given(@"I have tapped on Buy button")]
        public void GivenIHaveTappedOnBuyButton()
        {
            App.Tap(Resources.Screen.OpenDeal.BuyBtn);
        }
        
        [Given(@"I have opened commodity open deal dialog")]
        public void GivenIHaveOpenedCommodityOpenDealDialog()
        {
            App.Tap("COP/USD");
           // Helper.WaitForElementWithTime(Resources.Screen.OpenDeal.AmountField, 10);
        }
        
        [Given(@"I have opened index open deal dialog")]
        public void GivenIHaveOpenedIndexOpenDealDialog()
        {
            App.Tap("DAX");
          //  Helper.WaitForElementWithTime(Resources.Screen.OpenDeal.AmountField, 10);
        }
        
        [Given(@"I have opened stocks open deal dialog")]
        public void GivenIHaveOpenedStocksOpenDealDialog()
        {
            App.Tap("Adidas");
          //  Helper.WaitForElementWithTime(Resources.Screen.OpenDeal.AmountField, 10);
        }
        
        [When(@"I press Yes in confirmation message")]
        public void WhenIPressYesInConfirmationMessage()
        {
            App.Tap(Resources.Screen.Localization.Yes);
        }
        
        [Then(@"the result should be new deal in opened deals list")]
        public void ThenTheResultShouldBeNewDealInOpenedDealsList()
        {
           App.Back();
            Helper.GoToOpenedDealsList(Resources.Screen.Favorites.Card, Resources.Screen.Drawer.Open_Deals);
            int numberOfOpenedDealsAfterTest = Helper.CheckNumberOfDeals(Resources.Screen.Favorites.Card, Resources.Screen.Drawer.Open_Deals,
               Resources.Screen.OpenedDeal.InstrName);
           int numberBefore = ScenarioContext.Current.Get<int>("numberOfDeals");
           NUnitFramework.Assert.AreEqual(numberOfOpenedDealsAfterTest, numberBefore+1);
            Helper.Swipe(Resources.Screen.OpenedDeal.Card);
            Helper.TransitionFromDrawer(Resources.Screen.Drawer.Favorites);
        }
        [Given(@"I have entered an invalid amount")]
        public void GivenIHaveEnteredAnInvalidAmount()
        {
            App.Tap(Resources.Screen.OpenDeal.AmountField);
            App.ClearText();
            App.EnterText("0");
            //App.Tap(Resources.Screen.OpenDeal.Chart);
            //double amount = Helper.CheckAmountValue() - 1;
            //App.Tap(Resources.Screen.OpenDeal.AmountField);
            //App.ClearText();
            //App.EnterText(amount+"");
        }

        [Then(@"the result should be is error message that amount is invalid")]
        public void ThenTheResultShouldBeIsErrorMessageThatAmountIsInvalid()
        {
            App.WaitForElement(Resources.Screen.Localization.InvalidAmount);
            App.Tap("OK");
            App.Back();
            Helper.Swipe(Resources.Screen.OpenedDeal.Card);
            Helper.TransitionFromDrawer(Resources.Screen.Drawer.Favorites);
        }
    }
}
