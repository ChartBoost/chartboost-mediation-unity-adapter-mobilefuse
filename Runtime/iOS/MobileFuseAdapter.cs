using System.Runtime.InteropServices;
using Chartboost.Constants;
using Chartboost.Mediation.MobileFuse.Common;
using UnityEngine;

namespace Chartboost.Mediation.MobileFuse.IOS
{
    internal sealed class MobileFuseAdapter : IMobileFuseAdapter
    {
        [RuntimeInitializeOnLoadMethod]
        private static void RegisterInstance()
        {
            if (Application.isEditor)
                return;
            MobileFuse.MobileFuseAdapter.Instance = new MobileFuseAdapter();
        }

        /// <inheritdoc/>
        public string AdapterNativeVersion => _CBMMobileFuseAdapterAdapterVersion();
        
        /// <inheritdoc/>
        public string PartnerSDKVersion => _CBMMobileFuseAdapterPartnerSDKVersion();
        
        /// <inheritdoc/>
        public string PartnerIdentifier => _CBMMobileFuseAdapterPartnerId();
        
        /// <inheritdoc/>
        public string PartnerDisplayName => _CBMMobileFuseAdapterPartnerDisplayName();

        /// <inheritdoc/>
        public bool TestMode
        {
            get => _CBMMobileFuseAdapterGetTestMode();
            set => _CBMMobileFuseAdapterSetTestMode(value);
        }

        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMMobileFuseAdapterAdapterVersion();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMMobileFuseAdapterPartnerSDKVersion();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMMobileFuseAdapterPartnerId();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMMobileFuseAdapterPartnerDisplayName();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern bool _CBMMobileFuseAdapterGetTestMode();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern void _CBMMobileFuseAdapterSetTestMode(bool testMode);
    }
}
