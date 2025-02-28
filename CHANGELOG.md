# Changelog
All notable changes to this project will be documented in this file using the standards as defined at [Keep a Changelog](https://keepachangelog.com/en/1.0.0/). This project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0).

### Version 5.0.4 *(2025-02-28)*
This version of the MobileFuse Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-mobilefuse:5.1.9.+`
  * iOS: `ChartboostMediationAdapterMobileFuse: ~> 5.1.9.0`

### Version 5.0.3 *(2025-02-28)*
This version of the MobileFuse Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-mobilefuse:5.1.9.+`
  * iOS: `ChartboostMediationAdapterMobileFuse: ~> 5.1.8.0`

### Version 5.0.2 *(2024-10-25)*
This version of the MobileFuse Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-mobilefuse:5.1.8.+`
  * iOS: `ChartboostMediationAdapterMobileFuse: ~> 5.1.8.0`

### Version 5.0.1 *(2024-10-18)*
This version of the MobileFuse Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-mobilefuse:5.1.8.+`
  * iOS: `ChartboostMediationAdapterMobileFuse: ~> 5.1.7.0`

### Version 5.0.0 *(2024-08-08)*

First version of the Chartboost Mediation Unity SDK - MobileFuse Adapter.

#Added
- Support for the following `MobileFuse` dependencies. Notice adapter dependencies are optimistic and any patches and hot-fixes will be automatically picked up.:
    * Android: `com.chartboost:chartboost-mediation-adapter-mobilefuse:5.1.7.+`
    * iOS: `ChartboostMediationAdapterMobileFuse ~> 5.1.7.0`
    
- `MobileFuseAdapter.cs` with Configuration Properties for `MobileFuse`.
- The following properties have been added in `MobileFuseAdapter.cs`
    * `string AdapterUnityVersion`
    * `string AdapterNativeVersion`
    * `string PartnerSDKVersion`
    * `string PartnerIdentifier`
    * `string PartnerDisplayName`
    * `bool TestMode`
