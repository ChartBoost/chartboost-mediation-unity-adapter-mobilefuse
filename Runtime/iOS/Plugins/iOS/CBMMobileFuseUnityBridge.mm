#import "CBMDelegates.h"
#import "ChartboostUnityUtilities.h"
#import <ChartboostMediationAdapterMobileFuse/ChartboostMediationAdapterMobileFuse-Swift.h>

extern "C" {

    const char * _CBMMobileFuseAdapterAdapterVersion(){
        return toCStringOrNull([MobileFuseAdapterConfiguration adapterVersion]);
    }

    const char * _CBMMobileFuseAdapterPartnerSDKVersion(){
        return toCStringOrNull([MobileFuseAdapterConfiguration partnerSDKVersion]);
    }

    const char * _CBMMobileFuseAdapterPartnerId(){
        return toCStringOrNull([MobileFuseAdapterConfiguration partnerID]);
    }

    const char * _CBMMobileFuseAdapterPartnerDisplayName(){
        return toCStringOrNull([MobileFuseAdapterConfiguration partnerDisplayName]);
    }

    BOOL _CBMMobileFuseAdapterGetTestMode(){
        return [MobileFuseAdapterConfiguration testMode];
    }

    void _CBMMobileFuseAdapterSetTestMode(BOOL testMode){
        [MobileFuseAdapterConfiguration setTestMode:testMode];
    }
}
