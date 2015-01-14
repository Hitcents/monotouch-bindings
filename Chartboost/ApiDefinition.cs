using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.ObjCRuntime;

namespace ChartboostSDK
{
    // @interface Chartboost : NSObject
    [BaseType (typeof (NSObject))]
    interface Chartboost {

    	// +(void)startWithAppId:(NSString *)appId appSignature:(NSString *)appSignature delegate:(id<ChartboostDelegate>)delegate;
    	[Static, Export ("startWithAppId:appSignature:delegate:")]
    	void StartWithAppId (string appId, string appSignature, ChartboostDelegate chartboostDelegate);

    	// +(BOOL)isAnyViewVisible;
    	[Static, Export ("isAnyViewVisible")]
    	bool IsAnyViewVisible ();

    	// +(BOOL)hasInterstitial:(CBLocation)location;
    	[Static, Export ("hasInterstitial:")]
    	bool HasInterstitial (string location);

    	// +(void)showInterstitial:(CBLocation)location;
    	[Static, Export ("showInterstitial:")]
    	void ShowInterstitial (string location);

    	// +(BOOL)hasMoreApps:(CBLocation)location;
    	[Static, Export ("hasMoreApps:")]
    	bool HasMoreApps (string location);

    	// +(void)showMoreApps:(CBLocation)location;
    	[Static, Export ("showMoreApps:")]
    	void ShowMoreApps (string location);

    	// +(void)showMoreApps:(UIViewController *)viewController location:(CBLocation)location;
    	[Static, Export ("showMoreApps:location:")]
    	void ShowMoreApps (UIViewController viewController, string location);

    	// +(BOOL)hasRewardedVideo:(CBLocation)location;
    	[Static, Export ("hasRewardedVideo:")]
    	bool HasRewardedVideo (string location);

    	// +(void)showRewardedVideo:(CBLocation)location;
    	[Static, Export ("showRewardedVideo:")]
    	void ShowRewardedVideo (string location);

    	// +(void)didPassAgeGate:(BOOL)pass;
    	[Static, Export ("didPassAgeGate:")]
    	void DidPassAgeGate (bool pass);

    	// +(BOOL)handleOpenURL:(NSURL *)url sourceApplication:(NSString *)sourceApplication;
    	[Static, Export ("handleOpenURL:sourceApplication:")]
    	bool HandleOpenURL (NSUrl url, string sourceApplication);

    	// +(BOOL)handleOpenURL:(NSURL *)url sourceApplication:(NSString *)sourceApplication annotation:(id)annotation;
    	[Static, Export ("handleOpenURL:sourceApplication:annotation:")]
    	bool HandleOpenURL (NSUrl url, string sourceApplication, NSObject annotation);

    	// +(void)setCustomId:(NSString *)customId;
    	[Static, Export ("setCustomId:")]
    	void SetCustomId (string customId);

    	// +(NSString *)getCustomId;
    	[Static, Export ("getCustomId")]
    	string GetCustomId ();

    	// +(void)setFramework:(CBFramework)framework;
    	[Static, Export ("setFramework:")]
    	void SetFramework (CBFramework framework);

    	// +(void)setShouldRequestInterstitialsInFirstSession:(BOOL)shouldRequest;
    	[Static, Export ("setShouldRequestInterstitialsInFirstSession:")]
    	void SetShouldRequestInterstitialsInFirstSession (bool shouldRequest);

    	// +(void)setShouldPauseClickForConfirmation:(BOOL)shouldPause;
    	[Static, Export ("setShouldPauseClickForConfirmation:")]
    	void SetShouldPauseClickForConfirmation (bool shouldPause);

    	// +(void)setShouldDisplayLoadingViewForMoreApps:(BOOL)shouldDisplay;
    	[Static, Export ("setShouldDisplayLoadingViewForMoreApps:")]
    	void SetShouldDisplayLoadingViewForMoreApps (bool shouldDisplay);

    	// +(void)setShouldPrefetchVideoContent:(BOOL)shouldPrefetch;
    	[Static, Export ("setShouldPrefetchVideoContent:")]
    	void SetShouldPrefetchVideoContent (bool shouldPrefetch);

    	// +(void)cacheInterstitial:(CBLocation)location;
    	[Static, Export ("cacheInterstitial:")]
    	void CacheInterstitial (string location);

    	// +(void)cacheMoreApps:(CBLocation)location;
    	[Static, Export ("cacheMoreApps:")]
    	void CacheMoreApps (string location);

    	// +(void)cacheRewardedVideo:(CBLocation)location;
    	[Static, Export ("cacheRewardedVideo:")]
    	void CacheRewardedVideo (string location);

    	// +(void)setAutoCacheAds:(BOOL)shouldCache;
    	[Static, Export ("setAutoCacheAds:")]
    	void SetAutoCacheAds (bool shouldCache);

    	// +(BOOL)getAutoCacheAds;
    	[Static, Export ("getAutoCacheAds")]
    	bool GetAutoCacheAds ();
    }

    // @protocol ChartboostDelegate <NSObject>
    [Protocol, Model]
    [BaseType (typeof (NSObject))]
    interface ChartboostDelegate {

    	// @optional -(BOOL)shouldRequestInterstitial:(CBLocation)location;
    	[Export ("shouldRequestInterstitial:")]
    	bool ShouldRequestInterstitial (string location);

    	// @optional -(BOOL)shouldDisplayInterstitial:(CBLocation)location;
    	[Export ("shouldDisplayInterstitial:")]
    	bool ShouldDisplayInterstitial (string location);

    	// @optional -(void)didDisplayInterstitial:(CBLocation)location;
    	[Export ("didDisplayInterstitial:")]
    	void DidDisplayInterstitial (string location);

    	// @optional -(void)didCacheInterstitial:(CBLocation)location;
    	[Export ("didCacheInterstitial:")]
    	void DidCacheInterstitial (string location);

    	// @optional -(void)didFailToLoadInterstitial:(CBLocation)location withError:(CBLoadError)error;
    	[Export ("didFailToLoadInterstitial:withError:")]
    	void DidFailToLoadInterstitial (string location, CBLoadError error);

    	// @optional -(void)didFailToRecordClick:(CBLocation)location withError:(CBClickError)error;
    	[Export ("didFailToRecordClick:withError:")]
    	void DidFailToRecordClick (string location, CBClickError error);

    	// @optional -(void)didDismissInterstitial:(CBLocation)location;
    	[Export ("didDismissInterstitial:")]
    	void DidDismissInterstitial (string location);

    	// @optional -(void)didCloseInterstitial:(CBLocation)location;
    	[Export ("didCloseInterstitial:")]
    	void DidCloseInterstitial (string location);

    	// @optional -(void)didClickInterstitial:(CBLocation)location;
    	[Export ("didClickInterstitial:")]
    	void DidClickInterstitial (string location);

    	// @optional -(BOOL)shouldDisplayMoreApps:(CBLocation)location;
    	[Export ("shouldDisplayMoreApps:")]
    	bool ShouldDisplayMoreApps (string location);

    	// @optional -(void)didDisplayMoreApps:(CBLocation)location;
    	[Export ("didDisplayMoreApps:")]
    	void DidDisplayMoreApps (string location);

    	// @optional -(void)didCacheMoreApps:(CBLocation)location;
    	[Export ("didCacheMoreApps:")]
    	void DidCacheMoreApps (string location);

    	// @optional -(void)didDismissMoreApps:(CBLocation)location;
    	[Export ("didDismissMoreApps:")]
    	void DidDismissMoreApps (string location);

    	// @optional -(void)didCloseMoreApps:(CBLocation)location;
    	[Export ("didCloseMoreApps:")]
    	void DidCloseMoreApps (string location);

    	// @optional -(void)didClickMoreApps:(CBLocation)location;
    	[Export ("didClickMoreApps:")]
    	void DidClickMoreApps (string location);

    	// @optional -(void)didFailToLoadMoreApps:(CBLocation)location withError:(CBLoadError)error;
    	[Export ("didFailToLoadMoreApps:withError:")]
    	void DidFailToLoadMoreApps (string location, CBLoadError error);

    	// @optional -(BOOL)shouldDisplayRewardedVideo:(CBLocation)location;
    	[Export ("shouldDisplayRewardedVideo:")]
    	bool ShouldDisplayRewardedVideo (string location);

    	// @optional -(void)didDisplayRewardedVideo:(CBLocation)location;
    	[Export ("didDisplayRewardedVideo:")]
    	void DidDisplayRewardedVideo (string location);

    	// @optional -(void)didCacheRewardedVideo:(CBLocation)location;
    	[Export ("didCacheRewardedVideo:")]
    	void DidCacheRewardedVideo (string location);

    	// @optional -(void)didFailToLoadRewardedVideo:(CBLocation)location withError:(CBLoadError)error;
    	[Export ("didFailToLoadRewardedVideo:withError:")]
    	void DidFailToLoadRewardedVideo (string location, CBLoadError error);

    	// @optional -(void)didDismissRewardedVideo:(CBLocation)location;
    	[Export ("didDismissRewardedVideo:")]
    	void DidDismissRewardedVideo (string location);

    	// @optional -(void)didCloseRewardedVideo:(CBLocation)location;
    	[Export ("didCloseRewardedVideo:")]
    	void DidCloseRewardedVideo (string location);

    	// @optional -(void)didClickRewardedVideo:(CBLocation)location;
    	[Export ("didClickRewardedVideo:")]
    	void DidClickRewardedVideo (string location);

    	// @optional -(void)didCompleteRewardedVideo:(CBLocation)location withReward:(int)reward;
    	[Export ("didCompleteRewardedVideo:withReward:")]
    	void DidCompleteRewardedVideo (string location, int reward);

    	// @optional -(void)didCacheInPlay:(CBLocation)location;
    	[Export ("didCacheInPlay:")]
    	void DidCacheInPlay (string location);

    	// @optional -(void)didFailToLoadInPlay:(CBLocation)location withError:(CBLoadError)error;
    	[Export ("didFailToLoadInPlay:withError:")]
    	void DidFailToLoadInPlay (string location, CBLoadError error);

    	// @optional -(void)willDisplayVideo:(CBLocation)location;
    	[Export ("willDisplayVideo:")]
    	void WillDisplayVideo (string location);

    	// @optional -(void)didCompleteAppStoreSheetFlow;
    	[Export ("didCompleteAppStoreSheetFlow")]
    	void DidCompleteAppStoreSheetFlow ();

    	// @optional -(void)didPauseClickForConfirmation;
    	[Export ("didPauseClickForConfirmation")]
    	void DidPauseClickForConfirmation ();

    	// @optional -(BOOL)shouldDisplayMoreApps;
    	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
    	[Export ("shouldDisplayMoreApps")]
    	bool ShouldDisplayMoreApps ();

    	// @optional -(void)didDisplayMoreApps;
    	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
    	[Export ("didDisplayMoreApps")]
    	void DidDisplayMoreApps ();

    	// @optional -(void)didCacheMoreApps;
    	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
    	[Export ("didCacheMoreApps")]
    	void DidCacheMoreApps ();

    	// @optional -(void)didDismissMoreApps;
    	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
    	[Export ("didDismissMoreApps")]
    	void DidDismissMoreApps ();

    	// @optional -(void)didCloseMoreApps;
    	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
    	[Export ("didCloseMoreApps")]
    	void DidCloseMoreApps ();

    	// @optional -(void)didClickMoreApps;
    	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
    	[Export ("didClickMoreApps")]
    	void DidClickMoreApps ();

    	// @optional -(void)didFailToLoadMoreApps:(CBLoadError)error;
    	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
    	[Export ("didFailToLoadMoreApps:")]
    	void DidFailToLoadMoreApps (CBLoadError error);

    	// @optional -(void)didLoadInPlay;
    	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
    	[Export ("didLoadInPlay")]
    	void DidLoadInPlay ();
    }
}
