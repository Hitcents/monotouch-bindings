// @interface TJEventRequest : NSObject
[BaseType (typeof (NSObject))]
interface TJEventRequest {

	// @property (assign, nonatomic) TJCEventRequestType type;
	[Export ("type", ArgumentSemantic.UnsafeUnretained)]
	TJCEventRequestTypeEnum Type { get; set; }

	// @property (copy, nonatomic) NSString * identifier;
	[Export ("identifier")]
	string Identifier { get; set; }

	// @property (assign, nonatomic) int quantity;
	[Export ("quantity", ArgumentSemantic.UnsafeUnretained)]
	int Quantity { get; set; }

	// @property (copy, nonatomic) id callback;
	[Export ("callback", ArgumentSemantic.Copy)]
	NSObject Callback { get; set; }

	// -(void)completed;
	[Export ("completed")]
	void Completed ();

	// -(void)cancelled;
	[Export ("cancelled")]
	void Cancelled ();
}

// @protocol TJEventDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof (NSObject))]
interface TJEventDelegate {

	// @optional -(void)sendEventComplete:(TJEvent *)event withContent:(BOOL)contentIsAvailable;
	[Export ("sendEventComplete:withContent:")]
	void WithContent (TJEvent event, bool contentIsAvailable);

	// @optional -(void)sendEventFail:(TJEvent *)event error:(NSError *)error;
	[Export ("sendEventFail:error:")]
	void Error (TJEvent event, NSError error);

	// @optional -(void)contentIsReady:(TJEvent *)event withStatus:(int)status;
	[Export ("contentIsReady:withStatus:")]
	void WithStatus (TJEvent event, int status);

	// @optional -(void)contentWillAppear:(TJEvent *)event;
	[Export ("contentWillAppear:")]
	void ContentWillAppear (TJEvent event);

	// @optional -(void)contentDidAppear:(TJEvent *)event;
	[Export ("contentDidAppear:")]
	void ContentDidAppear (TJEvent event);

	// @optional -(void)contentWillDisappear:(TJEvent *)event;
	[Export ("contentWillDisappear:")]
	void ContentWillDisappear (TJEvent event);

	// @optional -(void)contentDidDisappear:(TJEvent *)event;
	[Export ("contentDidDisappear:")]
	void ContentDidDisappear (TJEvent event);

	// @optional -(void)event:(TJEvent *)event didRequestAction:(TJEventRequest *)request;
	[Export ("event:didRequestAction:")]
	void DidRequestAction (TJEvent event, TJEventRequest request);
}

// @interface TJEvent : NSObject
[BaseType (typeof (NSObject))]
interface TJEvent {

	// @property (nonatomic, unsafe_unretained) id<TJEventDelegate> delegate;
	[Export ("delegate", ArgumentSemantic.UnsafeUnretained)]
	[NullAllowed]
	NSObject WeakDelegate { get; set; }

	// @property (nonatomic, unsafe_unretained) id<TJEventDelegate> delegate;
	[Wrap ("WeakDelegate")]
	TJEventDelegate Delegate { get; set; }

	// @property (copy, nonatomic) NSString * eventName;
	[Export ("eventName")]
	string EventName { get; set; }

	// @property (nonatomic, strong) NSString * eventValue;
	[Export ("eventValue", ArgumentSemantic.Retain)]
	string EventValue { get; set; }

	// @property (assign, nonatomic) BOOL presentAutomatically;
	[Export ("presentAutomatically", ArgumentSemantic.UnsafeUnretained)]
	bool PresentAutomatically { get; set; }

	// @property (assign, nonatomic) BOOL preload;
	[Export ("preload", ArgumentSemantic.UnsafeUnretained)]
	bool Preload { get; set; }

	// @property (readonly, assign, nonatomic, getter = isContentReady) BOOL contentReady;
	[Export ("contentReady", ArgumentSemantic.UnsafeUnretained)]
	bool ContentReady { [Bind ("isContentReady")] get; }

	// @property (readonly, assign, nonatomic, getter = isContentAvailable) BOOL contentAvailable;
	[Export ("contentAvailable", ArgumentSemantic.UnsafeUnretained)]
	bool ContentAvailable { [Bind ("isContentAvailable")] get; }

	// @property (retain, nonatomic) UIViewController * presentationViewController;
	[Export ("presentationViewController", ArgumentSemantic.Retain)]
	UIViewController PresentationViewController { get; set; }

	// +(id)eventWithName:(NSString *)eventName delegate:(id<TJEventDelegate>)delegate;
	[Static, Export ("eventWithName:delegate:")]
	NSObject EventWithName (string eventName, TJEventDelegate delegate);

	// +(id)eventWithName:(NSString *)eventName value:(NSString *)value delegate:(id<TJEventDelegate>)delegate;
	[Static, Export ("eventWithName:value:delegate:")]
	NSObject EventWithName (string eventName, string value, TJEventDelegate delegate);

	// -(void)send;
	[Export ("send")]
	void Send ();

	// -(void)presentContentWithViewController:(UIViewController *)viewController;
	[Export ("presentContentWithViewController:")]
	void PresentContentWithViewController (UIViewController viewController);
}

// @interface TJCAdView : UIView <UIWebViewDelegate>
[BaseType (typeof (UIView))]
interface TJCAdView : UIWebViewDelegate {

}

// @interface Tapjoy : NSObject
[BaseType (typeof (NSObject))]
interface Tapjoy {

	// @property (copy, nonatomic) NSString * appID;
	[Export ("appID")]
	string AppID { get; set; }

	// @property (copy, nonatomic) NSString * secretKey;
	[Export ("secretKey")]
	string SecretKey { get; set; }

	// @property (copy, nonatomic) NSString * userID;
	[Export ("userID")]
	string UserID { get; set; }

	// @property (copy, nonatomic) NSString * plugin;
	[Export ("plugin")]
	string Plugin { get; set; }

	// @property (assign, nonatomic) float currencyMultiplier;
	[Export ("currencyMultiplier", ArgumentSemantic.UnsafeUnretained)]
	float CurrencyMultiplier { get; set; }

	// @property (nonatomic, strong) TJCAdManager * displayAdManager;
	[Export ("displayAdManager", ArgumentSemantic.Retain)]
	TJCAdManager DisplayAdManager { get; set; }

	// @property (nonatomic, strong) TJCEventTrackingManager * eventTrackingManager;
	[Export ("eventTrackingManager", ArgumentSemantic.Retain)]
	TJCEventTrackingManager EventTrackingManager { get; set; }

	// @property (nonatomic, strong) TJCFullScreenAdManager * fullScreenAdManager;
	[Export ("fullScreenAdManager", ArgumentSemantic.Retain)]
	TJCFullScreenAdManager FullScreenAdManager { get; set; }

	// @property (nonatomic, strong) TJCOffersManager * offersManager;
	[Export ("offersManager", ArgumentSemantic.Retain)]
	TJCOffersManager OffersManager { get; set; }

	// @property (nonatomic, strong) TJCUserAccountManager * userAccountManager;
	[Export ("userAccountManager", ArgumentSemantic.Retain)]
	TJCUserAccountManager UserAccountManager { get; set; }

	// @property (nonatomic, strong) TJCVideoManager * videoManager;
	[Export ("videoManager", ArgumentSemantic.Retain)]
	TJCVideoManager VideoManager { get; set; }

	// @property (nonatomic, strong) TJCViewHandler * viewHandler;
	[Export ("viewHandler", ArgumentSemantic.Retain)]
	TJCViewHandler ViewHandler { get; set; }

	// @property (nonatomic, strong) TJCUtil * util;
	[Export ("util", ArgumentSemantic.Retain)]
	TJCUtil Util { get; set; }

	// @property (nonatomic, strong) TJCLog * log;
	[Export ("log", ArgumentSemantic.Retain)]
	TJCLog Log { get; set; }

	// +(void)requestTapjoyConnect:(NSString *)appID secretKey:(NSString *)secretKey;
	[Static, Export ("requestTapjoyConnect:secretKey:")]
	void RequestTapjoyConnect (string appID, string secretKey);

	// +(void)requestTapjoyConnect:(NSString *)appID secretKey:(NSString *)secretKey options:(NSDictionary *)optionsDict;
	[Static, Export ("requestTapjoyConnect:secretKey:options:")]
	void RequestTapjoyConnect (string appID, string secretKey, NSDictionary optionsDict);

	// +(void)actionComplete:(NSString *)actionID;
	[Static, Export ("actionComplete:")]
	void ActionComplete (string actionID);

	// +(id)sharedTapjoyConnect;
	[Static, Export ("sharedTapjoyConnect")]
	NSObject SharedTapjoyConnect ();

	// +(NSString *)getAppID;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("getAppID")]
	string GetAppID ();

	// +(void)setUserID:(NSString *)theUserID;
	[Static, Export ("setUserID:")]
	void SetUserID (string theUserID);

	// +(NSString *)getUserID;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("getUserID")]
	string GetUserID ();

	// +(NSString *)getSecretKey;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("getSecretKey")]
	string GetSecretKey ();

	// +(void)setCurrencyMultiplier:(float)mult;
	[Static, Export ("setCurrencyMultiplier:")]
	void SetCurrencyMultiplier (float mult);

	// +(float)getCurrencyMultiplier;
	[Static, Export ("getCurrencyMultiplier")]
	float GetCurrencyMultiplier ();

	// +(void)enableLogging:(BOOL)enable;
	[Static, Export ("enableLogging:")]
	void EnableLogging (bool enable);

	// +(NSString *)getVersion;
	[Static, Export ("getVersion")]
	string GetVersion ();

	// +(void)dismissContent;
	[Static, Export ("dismissContent")]
	void DismissContent ();

	// +(void)sendSegmentationParams:(NSDictionary *)params;
	[Static, Export ("sendSegmentationParams:")]
	void SendSegmentationParams (NSDictionary params);
}

// @protocol TJCAdDelegate <NSObject>
[Availability (Deprecated = Platform.iOS | Platform.Mac)]
[Protocol, Model]
[BaseType (typeof (NSObject))]
interface TJCAdDelegate {

	// @required -(void)didReceiveAd:(TJCAdView *)adView;
	[Export ("didReceiveAd:")]
	[Abstract]
	void DidReceiveAd (TJCAdView adView);

	// @required -(void)didFailWithMessage:(NSString *)msg;
	[Export ("didFailWithMessage:")]
	[Abstract]
	void DidFailWithMessage (string msg);

	// @required -(NSString *)adContentSize;
	[Export ("adContentSize")]
	[Abstract]
	string AdContentSize ();

	// @required -(BOOL)shouldRefreshAd;
	[Export ("shouldRefreshAd")]
	[Abstract]
	bool ShouldRefreshAd ();
}

// @protocol TJCVideoAdDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof (NSObject))]
interface TJCVideoAdDelegate {

	// @optional -(void)videoAdBegan;
	[Export ("videoAdBegan")]
	void VideoAdBegan ();

	// @optional -(void)videoAdClosed;
	[Export ("videoAdClosed")]
	void VideoAdClosed ();

	// @optional -(void)videoAdCompleted;
	[Export ("videoAdCompleted")]
	void VideoAdCompleted ();

	// @optional -(void)videoAdError:(NSString *)errorMsg;
	[Export ("videoAdError:")]
	void VideoAdError (string errorMsg);
}

// @protocol TJCViewDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof (NSObject))]
interface TJCViewDelegate {

	// @optional -(void)viewWillAppearWithType:(int)viewType;
	[Export ("viewWillAppearWithType:")]
	void ViewWillAppearWithType (int viewType);

	// @optional -(void)viewDidAppearWithType:(int)viewType;
	[Export ("viewDidAppearWithType:")]
	void ViewDidAppearWithType (int viewType);

	// @optional -(void)viewWillDisappearWithType:(int)viewType;
	[Export ("viewWillDisappearWithType:")]
	void ViewWillDisappearWithType (int viewType);

	// @optional -(void)viewDidDisappearWithType:(int)viewType;
	[Export ("viewDidDisappearWithType:")]
	void ViewDidDisappearWithType (int viewType);
}

// @interface TJCAdManager (Tapjoy)
[Category]
[BaseType (typeof (Tapjoy))]
interface TJCAdManager {

	// +(id)getDisplayAdWithDelegate:(id<TJCAdDelegate>)deleg;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("getDisplayAdWithDelegate:")]
	NSObject GetDisplayAdWithDelegate (TJCAdDelegate deleg);

	// +(id)getDisplayAdWithDelegate:(id<TJCAdDelegate>)deleg currencyID:(NSString *)currencyID;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("getDisplayAdWithDelegate:currencyID:")]
	NSObject GetDisplayAdWithDelegate (TJCAdDelegate deleg, string currencyID);

	// +(BOOL)isDisplayAdLoaded;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("isDisplayAdLoaded")]
	bool IsDisplayAdLoaded ();

	// +(TJCAdView *)getDisplayAdView;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("getDisplayAdView")]
	TJCAdView GetDisplayAdView ();
}

// @interface TJCEventTrackingManager (Tapjoy)
[Category]
[BaseType (typeof (Tapjoy))]
interface TJCEventTrackingManager {

	// +(void)sendIAPEvent:(NSString *)name price:(float)price quantity:(int)quantity currencyCode:(NSString *)currencyCode;
	[Static, Export ("sendIAPEvent:price:quantity:currencyCode:")]
	void SendIAPEvent (string name, float price, int quantity, string currencyCode);
}

// @interface TJCFullScreenAdManager (Tapjoy)
[Category]
[BaseType (typeof (Tapjoy))]
interface TJCFullScreenAdManager {

	// +(void)getFullScreenAd;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("getFullScreenAd")]
	void GetFullScreenAd ();

	// +(void)getFullScreenAdWithCurrencyID:(NSString *)currencyID;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("getFullScreenAdWithCurrencyID:")]
	void GetFullScreenAdWithCurrencyID (string currencyID);

	// +(UIView *)showFullScreenAd;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("showFullScreenAd")]
	UIView ShowFullScreenAd ();

	// +(void)showFullScreenAdWithViewController:(UIViewController *)vController;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("showFullScreenAdWithViewController:")]
	void ShowFullScreenAdWithViewController (UIViewController vController);

	// +(void)setFullScreenAdDelayCount:(int)delayCount;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("setFullScreenAdDelayCount:")]
	void SetFullScreenAdDelayCount (int delayCount);
}

// @interface TJCOffersManager (Tapjoy)
[Category]
[BaseType (typeof (Tapjoy))]
interface TJCOffersManager {

	// +(UIView *)showOffers;
	[Static, Export ("showOffers")]
	UIView ShowOffers ();

	// +(void)showOffersWithViewController:(UIViewController *)vController;
	[Static, Export ("showOffersWithViewController:")]
	void ShowOffersWithViewController (UIViewController vController);

	// +(UIView *)showOffersWithCurrencyID:(NSString *)currencyID withCurrencySelector:(BOOL)isSelectorVisible;
	[Static, Export ("showOffersWithCurrencyID:withCurrencySelector:")]
	UIView ShowOffersWithCurrencyID (string currencyID, bool isSelectorVisible);

	// +(void)showOffersWithCurrencyID:(NSString *)currencyID withViewController:(UIViewController *)vController withCurrencySelector:(BOOL)isSelectorVisible;
	[Static, Export ("showOffersWithCurrencyID:withViewController:withCurrencySelector:")]
	void ShowOffersWithCurrencyID (string currencyID, UIViewController vController, bool isSelectorVisible);
}

// @interface TJCUserAccountManager (Tapjoy)
[Category]
[BaseType (typeof (Tapjoy))]
interface TJCUserAccountManager {

	// +(void)getTapPoints;
	[Static, Export ("getTapPoints")]
	void GetTapPoints ();

	// +(void)getTapPointsWithCompletion:(tapPointsCompletion)completion;
	[Static, Export ("getTapPointsWithCompletion:")]
	void GetTapPointsWithCompletion (Action<NSDictionary, NSError> completion);

	// +(void)spendTapPoints:(int)points;
	[Static, Export ("spendTapPoints:")]
	void SpendTapPoints (int points);

	// +(void)spendTapPoints:(int)points completion:(tapPointsCompletion)completion;
	[Static, Export ("spendTapPoints:completion:")]
	void SpendTapPoints (int points, Action<NSDictionary, NSError> completion);

	// +(void)awardTapPoints:(int)points;
	[Static, Export ("awardTapPoints:")]
	void AwardTapPoints (int points);

	// +(void)awardTapPoints:(int)points completion:(tapPointsCompletion)completion;
	[Static, Export ("awardTapPoints:completion:")]
	void AwardTapPoints (int points, Action<NSDictionary, NSError> completion);

	// +(void)showDefaultEarnedCurrencyAlert;
	[Static, Export ("showDefaultEarnedCurrencyAlert")]
	void ShowDefaultEarnedCurrencyAlert ();
}

// @interface TJCVideoViewHandler (Tapjoy)
[Category]
[BaseType (typeof (Tapjoy))]
interface TJCVideoViewHandler {

	// +(void)setVideoAdDelegate:(id<TJCVideoAdDelegate>)delegate;
	[Static, Export ("setVideoAdDelegate:")]
	void SetVideoAdDelegate (TJCVideoAdDelegate delegate);

	// +(void)cacheVideosWithDelegate:(id<TJCVideoAdDelegate>)delegate;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("cacheVideosWithDelegate:")]
	void CacheVideosWithDelegate (TJCVideoAdDelegate delegate);

	// +(void)setVideoCacheCount:(int)count;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("setVideoCacheCount:")]
	void SetVideoCacheCount (int count);

	// +(void)shouldDisplayVideoLogo:(BOOL)display;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("shouldDisplayVideoLogo:")]
	void ShouldDisplayVideoLogo (bool display);

	// +(void)disableVideo:(BOOL)shouldDisable;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("disableVideo:")]
	void DisableVideo (bool shouldDisable);
}

// @interface TJCViewHandler (Tapjoy)
[Category]
[BaseType (typeof (Tapjoy))]
interface TJCViewHandler {

	// +(void)setTransitionEffect:(TJCTransitionEnum)transitionEffect;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("setTransitionEffect:")]
	void SetTransitionEffect (TJCTransitionEnum transitionEffect);

	// +(float)getTransitionDelay;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("getTransitionDelay")]
	float GetTransitionDelay ();

	// +(TJCTransitionEnum)getCurrentTransitionEffect;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("getCurrentTransitionEffect")]
	TJCTransitionEnum GetCurrentTransitionEffect ();

	// +(TJCTransitionEnum)getReverseTransitionEffect;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("getReverseTransitionEffect")]
	TJCTransitionEnum GetReverseTransitionEffect ();

	// +(void)setViewDelegate:(id<TJCViewDelegate>)delegate;
	[Static, Export ("setViewDelegate:")]
	void SetViewDelegate (TJCViewDelegate delegate);
}

// @interface TapjoyConnect : NSObject
[BaseType (typeof (NSObject))]
interface TapjoyConnect {

	// +(void)requestTapjoyConnect:(NSString *)appID secretKey:(NSString *)secretKey;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("requestTapjoyConnect:secretKey:")]
	void RequestTapjoyConnect (string appID, string secretKey);

	// +(void)requestTapjoyConnect:(NSString *)appID secretKey:(NSString *)secretKey options:(NSDictionary *)optionsDict;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("requestTapjoyConnect:secretKey:options:")]
	void RequestTapjoyConnect (string appID, string secretKey, NSDictionary optionsDict);

	// +(void)actionComplete:(NSString *)actionID;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("actionComplete:")]
	void ActionComplete (string actionID);

	// +(id)sharedTapjoyConnect;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("sharedTapjoyConnect")]
	NSObject SharedTapjoyConnect ();

	// +(NSString *)getAppID;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("getAppID")]
	string GetAppID ();

	// +(void)setUserID:(NSString *)theUserID;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("setUserID:")]
	void SetUserID (string theUserID);

	// +(NSString *)getUserID;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("getUserID")]
	string GetUserID ();

	// +(NSString *)getSecretKey;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("getSecretKey")]
	string GetSecretKey ();

	// +(void)setCurrencyMultiplier:(float)mult;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("setCurrencyMultiplier:")]
	void SetCurrencyMultiplier (float mult);

	// +(float)getCurrencyMultiplier;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("getCurrencyMultiplier")]
	float GetCurrencyMultiplier ();

	// +(void)enableLogging:(BOOL)enable;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("enableLogging:")]
	void EnableLogging (bool enable);

	// +(id)getDisplayAdWithDelegate:(id<TJCAdDelegate>)deleg;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("getDisplayAdWithDelegate:")]
	NSObject GetDisplayAdWithDelegate (TJCAdDelegate deleg);

	// +(id)getDisplayAdWithDelegate:(id<TJCAdDelegate>)deleg currencyID:(NSString *)currencyID;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("getDisplayAdWithDelegate:currencyID:")]
	NSObject GetDisplayAdWithDelegate (TJCAdDelegate deleg, string currencyID);

	// +(BOOL)isDisplayAdLoaded;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("isDisplayAdLoaded")]
	bool IsDisplayAdLoaded ();

	// +(TJCAdView *)getDisplayAdView;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("getDisplayAdView")]
	TJCAdView GetDisplayAdView ();

	// +(void)sendIAPEvent:(NSString *)name price:(float)price quantity:(int)quantity currencyCode:(NSString *)currencyCode;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("sendIAPEvent:price:quantity:currencyCode:")]
	void SendIAPEvent (string name, float price, int quantity, string currencyCode);

	// +(void)getFullScreenAd;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("getFullScreenAd")]
	void GetFullScreenAd ();

	// +(void)getFullScreenAdWithCurrencyID:(NSString *)currencyID;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("getFullScreenAdWithCurrencyID:")]
	void GetFullScreenAdWithCurrencyID (string currencyID);

	// +(UIView *)showFullScreenAd;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("showFullScreenAd")]
	UIView ShowFullScreenAd ();

	// +(void)showFullScreenAdWithViewController:(UIViewController *)vController;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("showFullScreenAdWithViewController:")]
	void ShowFullScreenAdWithViewController (UIViewController vController);

	// +(void)setFullScreenAdDelayCount:(int)delayCount;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("setFullScreenAdDelayCount:")]
	void SetFullScreenAdDelayCount (int delayCount);

	// +(UIView *)showOffers;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("showOffers")]
	UIView ShowOffers ();

	// +(void)showOffersWithViewController:(UIViewController *)vController;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("showOffersWithViewController:")]
	void ShowOffersWithViewController (UIViewController vController);

	// +(UIView *)showOffersWithCurrencyID:(NSString *)currencyID withCurrencySelector:(BOOL)isSelectorVisible;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("showOffersWithCurrencyID:withCurrencySelector:")]
	UIView ShowOffersWithCurrencyID (string currencyID, bool isSelectorVisible);

	// +(void)showOffersWithCurrencyID:(NSString *)currencyID withViewController:(UIViewController *)vController withCurrencySelector:(BOOL)isSelectorVisible;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("showOffersWithCurrencyID:withViewController:withCurrencySelector:")]
	void ShowOffersWithCurrencyID (string currencyID, UIViewController vController, bool isSelectorVisible);

	// +(void)getTapPoints;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("getTapPoints")]
	void GetTapPoints ();

	// +(void)spendTapPoints:(int)points;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("spendTapPoints:")]
	void SpendTapPoints (int points);

	// +(void)awardTapPoints:(int)points;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("awardTapPoints:")]
	void AwardTapPoints (int points);

	// +(void)showDefaultEarnedCurrencyAlert;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("showDefaultEarnedCurrencyAlert")]
	void ShowDefaultEarnedCurrencyAlert ();

	// +(void)setVideoAdDelegate:(id<TJCVideoAdDelegate>)delegate;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("setVideoAdDelegate:")]
	void SetVideoAdDelegate (TJCVideoAdDelegate delegate);

	// +(void)cacheVideosWithDelegate:(id<TJCVideoAdDelegate>)delegate;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("cacheVideosWithDelegate:")]
	void CacheVideosWithDelegate (TJCVideoAdDelegate delegate);

	// +(void)setVideoCacheCount:(int)count;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("setVideoCacheCount:")]
	void SetVideoCacheCount (int count);

	// +(void)shouldDisplayVideoLogo:(BOOL)display;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("shouldDisplayVideoLogo:")]
	void ShouldDisplayVideoLogo (bool display);

	// +(void)disableVideo:(BOOL)shouldDisable;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("disableVideo:")]
	void DisableVideo (bool shouldDisable);

	// +(void)setTransitionEffect:(TJCTransitionEnum)transitionEffect;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("setTransitionEffect:")]
	void SetTransitionEffect (TJCTransitionEnum transitionEffect);

	// +(float)getTransitionDelay;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("getTransitionDelay")]
	float GetTransitionDelay ();

	// +(TJCTransitionEnum)getCurrentTransitionEffect;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("getCurrentTransitionEffect")]
	TJCTransitionEnum GetCurrentTransitionEffect ();

	// +(TJCTransitionEnum)getReverseTransitionEffect;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("getReverseTransitionEffect")]
	TJCTransitionEnum GetReverseTransitionEffect ();

	// +(void)setViewDelegate:(id<TJCViewDelegate>)delegate;
	[Availability (Deprecated = Platform.iOS | Platform.Mac)]
	[Static, Export ("setViewDelegate:")]
	void SetViewDelegate (TJCViewDelegate delegate);
}
