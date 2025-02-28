using Chartboost.Mediation.Adapters;
using Chartboost.Mediation.MobileFuse.Common;
using Chartboost.Mediation.MobileFuse.Default;

namespace Chartboost.Mediation.MobileFuse
{
    /// <inheritdoc cref="IMobileFuseAdapter"/>
    public static class MobileFuseAdapter 
    {
        internal static IMobileFuseAdapter Instance = new MobileFuseDefault();
        
        /// <summary>
        /// The partner adapter Unity version.
        /// </summary>
        public const string AdapterUnityVersion = "5.0.4";
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.AdapterNativeVersion"/>
        public static string AdapterNativeVersion => Instance.AdapterNativeVersion;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerSDKVersion"/>
        public static string PartnerSDKVersion => Instance.PartnerSDKVersion;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerIdentifier"/>
        public static string PartnerIdentifier => Instance.PartnerIdentifier;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerDisplayName"/>
        public static string PartnerDisplayName => Instance.PartnerDisplayName;

        /// <inheritdoc cref="IMobileFuseAdapter.TestMode"/>
        public static bool TestMode
        {
            get => Instance.TestMode;
            set => Instance.TestMode = value;
        }
    }
}
