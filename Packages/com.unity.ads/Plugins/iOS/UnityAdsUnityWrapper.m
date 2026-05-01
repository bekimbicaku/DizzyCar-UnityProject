#if __has_include(<UnityAds/UnityAds.h>)
#import "UnityAppController.h"
#import "Unity/UnityInterface.h"

#import "UnityAds/UnityAds.h"
#import <UnityAds/UADSBanner.h>
#import "UnityAds/UADSMetaData.h"

#import "UnityAdsUtilities.h"
#import "UnityAdsInitializationListener.h"
#import "UnityAdsLoadListener.h"
#import "UnityAdsShowListener.h"

void UnityAdsInitialize(const char * gameId, bool testMode, void *listenerPtr) {
    UnityAdsInitializationListener *listener = listenerPtr ? (__bridge UnityAdsInitializationListener *)listenerPtr : nil;
    [UnityAds initialize:[NSString stringWithUTF8String:gameId] testMode:testMode initializationDelegate:listener];
}

void UnityAdsLoad(const char * placementId, const char * objectId, void *listenerPtr) {
    UnityAdsLoadListener *listener = listenerPtr ? (__bridge UnityAdsLoadListener *)listenerPtr : nil;
    UADSLoadOptions *options = [[UADSLoadOptions alloc] init];
    [options setObjectId:[NSString stringWithUTF8String:objectId]];
    [UnityAds load:[NSString stringWithUTF8String:placementId] options:options loadDelegate:listener];
}

void UnityAdsShow(const char * placementId, const char * objectId, void *listenerPtr) {
    UnityAdsShowListener *listener = listenerPtr ? (__bridge UnityAdsShowListener *)listenerPtr : nil;
    UADSShowOptions *options = [[UADSShowOptions alloc] init];
    [options setObjectId:[NSString stringWithUTF8String:objectId]];
    [UnityAds show:UnityGetGLViewController() placementId:NSSTRING_OR_EMPTY(placementId)  options:options showDelegate:listener];
}

bool UnityAdsGetDebugMode() {
    return [UnityAds getDebugMode];
}

void UnityAdsSetDebugMode(bool debugMode) {
    [UnityAds setDebugMode:debugMode];
}

bool UnityAdsIsSupported() {
    return [UnityAds isSupported];
}

const char * UnityAdsGetVersion() {
    return UnityAdsCopyString([[UnityAds getVersion] UTF8String]);
}

bool UnityAdsIsInitialized() {
    return [UnityAds isInitialized];
}

void UnityAdsSetMetaData(const char * category, const char * data) {
    if(category != NULL && data != NULL) {
        UADSMetaData* metaData = [[UADSMetaData alloc] initWithCategory:[NSString stringWithUTF8String:category]];
        NSDictionary* json = [NSJSONSerialization JSONObjectWithData:[[NSString stringWithUTF8String:data] dataUsingEncoding:NSUTF8StringEncoding] options:0 error:nil];
        for(id key in json) {
            [metaData set:key value:[json objectForKey:key]];
        }
        [metaData commit];
    }
}

#else  // UnityAds framework not available - provide stub implementations

void UnityAdsInitialize(const char * gameId, bool testMode, void *listenerPtr) {
}

void UnityAdsLoad(const char * placementId, const char * objectId, void *listenerPtr) {
}

void UnityAdsShow(const char * placementId, const char * objectId, void *listenerPtr) {
}

bool UnityAdsGetDebugMode() {
    return false;
}

void UnityAdsSetDebugMode(bool debugMode) {
}

bool UnityAdsIsSupported() {
    return false;
}

const char * UnityAdsGetVersion() {
    return "";
}

bool UnityAdsIsInitialized() {
    return false;
}

void UnityAdsSetMetaData(const char * category, const char * data) {
}

#endif  // __has_include(<UnityAds/UnityAds.h>)
