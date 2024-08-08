using Chartboost.Mediation.Adapters;

namespace Chartboost.Mediation.MobileFuse.Common
{
    /// <summary>
    /// The Chartboost Mediation MobileFuse adapter.
    /// </summary>
    internal interface IMobileFuseAdapter : IPartnerAdapterConfiguration
    {
        /// <summary>
        /// Enable/disable MobileFuse's test mode. Remember to set this to false in production.
        /// </summary>
        public bool TestMode { get; set; }
    }
}
