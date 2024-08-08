using Chartboost.Editor;
using Chartboost.Logging;
using Chartboost.Mediation.MobileFuse;
using NUnit.Framework;

namespace Chartboost.Tests.Editor
{
    internal class VersionValidator
    {
        private const string UnityPackageManagerPackageName = "com.chartboost.mediation.unity.adapter.mobilefuse";
        private const string NuGetPackageName = "Chartboost.CSharp.Mediation.Unity.Adapter.MobileFuse";
        
        [SetUp]
        public void SetUp() 
            => LogController.LoggingLevel = LogLevel.Debug;
            
        [Test]
        public void ValidateVersion() 
            => VersionCheck.ValidateVersions(UnityPackageManagerPackageName, NuGetPackageName, MobileFuseAdapter.AdapterUnityVersion);
    }
}
