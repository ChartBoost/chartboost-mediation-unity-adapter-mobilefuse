using Chartboost.Editor;
using Chartboost.Mediation.MobileFuse;
using NUnit.Framework;

namespace Chartboost.Mediation.MobileFuse.Tests.Editor
{
    internal class VersionValidator
    {
        private const string UnityPackageManagerPackageName = "com.chartboost.mediation.unity.adapter.mobilefuse";
        private const string NuGetPackageName = "Chartboost.CSharp.Mediation.Unity.Adapter.MobileFuse";
        
        [Test]
        public void ValidateVersion() 
            => VersionCheck.ValidateVersions(UnityPackageManagerPackageName, NuGetPackageName, MobileFuseAdapter.AdapterUnityVersion);
    }
}
