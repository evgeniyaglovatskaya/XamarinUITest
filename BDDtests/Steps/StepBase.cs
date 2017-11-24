using PortableUI;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace BDDtests.Steps
{
   public class StepBase
    {
        protected IApp App;
        protected Helpers Helper;


        public StepBase()
        {
            App = FeatureContext.Current.Get<IApp>("App");
            Helper = FeatureContext.Current.Get<Helpers>("Helper");
        }

    }
}
