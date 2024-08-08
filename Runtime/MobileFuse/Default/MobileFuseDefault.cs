using Chartboost.Mediation.MobileFuse.Common;

namespace Chartboost.Mediation.MobileFuse.Default
{
    internal class MobileFuseDefault : IMobileFuseAdapter
    {
        /// <inheritdoc/>
        public string AdapterNativeVersion => MobileFuseAdapter.AdapterUnityVersion;

        /// <inheritdoc/>
        public string PartnerSDKVersion => MobileFuseAdapter.AdapterUnityVersion;
        
        /// <inheritdoc/>
        public string PartnerIdentifier => "mobilefuse";
        
        /// <inheritdoc/>
        public string PartnerDisplayName => "MobileFuse";

        /// <inheritdoc/>
        public bool TestMode { get; set; }
    }
}
