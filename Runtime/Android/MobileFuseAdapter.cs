using Chartboost.Constants;
using Chartboost.Mediation.MobileFuse.Common;
using UnityEngine;

namespace Chartboost.Mediation.MobileFuse.Android
{
    internal sealed class MobileFuseAdapter : IMobileFuseAdapter
    {
        private const string MobileFuseAdapterConfiguration = "com.chartboost.mediation.mobilefuseadapter.MobileFuseAdapterConfiguration";
        
        [RuntimeInitializeOnLoadMethod]
        private static void RegisterInstance()
        {
            if (Application.isEditor)
                return;
            MobileFuse.MobileFuseAdapter.Instance = new MobileFuseAdapter();
        }
        
        /// <inheritdoc/>
        public string AdapterNativeVersion
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(MobileFuseAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetAdapterVersion);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerSDKVersion 
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(MobileFuseAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerSdkVersion);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerIdentifier
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(MobileFuseAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerId);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerDisplayName 
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(MobileFuseAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerDisplayName);
            }
        }

        /// <inheritdoc/>
        public bool TestMode
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(MobileFuseAdapterConfiguration);
                return adapterConfiguration.Call<bool>(SharedAndroidConstants.FunctionGetTestMode);
            }
            set
            {
                using var adapterConfiguration = new AndroidJavaObject(MobileFuseAdapterConfiguration);
                adapterConfiguration.Call(SharedAndroidConstants.FunctionSetTestMode, value);
            }
        }
    }
}
