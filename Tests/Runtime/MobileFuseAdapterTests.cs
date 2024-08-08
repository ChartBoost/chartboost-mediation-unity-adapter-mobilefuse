using Chartboost.Logging;
using Chartboost.Mediation.MobileFuse;
using Chartboost.Tests.Runtime;
using NUnit.Framework;

namespace Chartboost.Tests
{
    internal class MobileFuseAdapterTests
    {
        [SetUp]
        public void SetUp()
            => LogController.LoggingLevel = LogLevel.Debug;

        [Test]
        public void AdapterNativeVersion()
            => TestUtilities.TestStringGetter(() => MobileFuseAdapter.AdapterNativeVersion);

        [Test]
        public void PartnerSDKVersion()
            => TestUtilities.TestStringGetter(() => MobileFuseAdapter.PartnerSDKVersion);

        [Test]
        public void PartnerIdentifier()
            => TestUtilities.TestStringGetter(() => MobileFuseAdapter.PartnerIdentifier);

        [Test]
        public void PartnerDisplayName()
            => TestUtilities.TestStringGetter(() => MobileFuseAdapter.PartnerDisplayName);

        [Test]
        public void TestMode() =>
            TestUtilities.TestBooleanAccessor(() => MobileFuseAdapter.TestMode, value => MobileFuseAdapter.TestMode = value);
    }
}
