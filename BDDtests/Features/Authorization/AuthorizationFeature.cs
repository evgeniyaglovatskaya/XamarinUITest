using NUnit.Framework;
using PortableUI;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace BDDtests.Features
{
    

    public partial class AuthorizationFeature:AuthFeatureBase
    {
        public AuthorizationFeature(Platform platform, string simulatorName) : base(platform, simulatorName)
        {
        }
    }
}
