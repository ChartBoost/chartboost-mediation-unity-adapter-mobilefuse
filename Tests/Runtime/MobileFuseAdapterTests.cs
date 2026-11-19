using Chartboost.Mediation.MobileFuse;
using Chartboost.Testing;
using NUnit.Framework;

namespace Chartboost.Tests
{
    internal class MobileFuseAdapterTests
    {
        [Test]
        public void Identity() => AdapterContract.AssertIdentity("mobilefuse", "MobileFuse", MobileFuseAdapter.AdapterUnityVersion,
            MobileFuseAdapter.PartnerIdentifier, MobileFuseAdapter.PartnerDisplayName, MobileFuseAdapter.AdapterNativeVersion, MobileFuseAdapter.PartnerSDKVersion);

        [Test]
        public void TestModeKeepsItsValue()
            => AdapterContract.AssertKeeps(() => MobileFuseAdapter.TestMode, value => MobileFuseAdapter.TestMode = value, true, false);
    }
}
