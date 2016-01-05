using System;
using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;
using CoreLocation;
using StoreKit;

namespace HeyzapBinding
{
	partial interface Constants
	{
		// extern NSString *const kHZLogThirdPartyLoggingEnabledChangedNotification;
		[Field ("kHZLogThirdPartyLoggingEnabledChangedNotification", "__Internal")]
		NSString kHZLogThirdPartyLoggingEnabledChangedNotification { get; }
	}

	// @interface HZLog : NSObject
	[BaseType (typeof(NSObject))]
	interface HZLog
	{
		// +(HZDebugLevel)debugLevel;
		// +(void)setDebugLevel:(HZDebugLevel)debugLevel;
		[Static]
		[Export ("debugLevel")]
		//[Verify (MethodToProperty)]
		HZDebugLevel DebugLevel { get; set; }

		// +(void)debug:(NSString *)message;
		[Static]
		[Export ("debug:")]
		void Debug (string message);

		// +(void)info:(NSString *)message;
		[Static]
		[Export ("info:")]
		void Info (string message);

		// +(void)error:(NSString *)message;
		[Static]
		[Export ("error:")]
		void Error (string message);

		// +(void)always:(NSString *)message;
		[Static]
		[Export ("always:")]
		void Always (string message);

		// +(void)log:(NSString *)message atDebugLevel:(HZDebugLevel)debugLevel;
		[Static]
		[Export ("log:atDebugLevel:")]
		void Log (string message, HZDebugLevel debugLevel);

		// +(BOOL)isThirdPartyLoggingEnabled;
		[Static]
		[Export ("isThirdPartyLoggingEnabled")]
		//[Verify (MethodToProperty)]
		bool IsThirdPartyLoggingEnabled { get; }

		// +(void)setThirdPartyLoggingEnabled:(BOOL)enabled;
		[Static]
		[Export ("setThirdPartyLoggingEnabled:")]
		void SetThirdPartyLoggingEnabled (bool enabled);
	}

	// @interface HZShowOptions : NSObject
	[BaseType (typeof(NSObject))]
	interface HZShowOptions
	{
		// @property (nonatomic, weak) UIViewController * _Nullable viewController;
		[NullAllowed, Export ("viewController", ArgumentSemantic.Weak)]
		UIViewController ViewController { get; set; }

		// @property (nonatomic, strong) NSString * tag;
		[Export ("tag", ArgumentSemantic.Strong)]
		string Tag { get; set; }

		// @property (copy, nonatomic) void (^completion)(BOOL, NSError *);
		[Export ("completion", ArgumentSemantic.Copy)]
		Action<bool, NSError> Completion { get; set; }

		// @property (nonatomic, strong) NSString * incentivizedInfo;
		[Export ("incentivizedInfo", ArgumentSemantic.Strong)]
		string IncentivizedInfo { get; set; }
	}

	// @interface HZInterstitialAd : NSObject
	[BaseType (typeof(NSObject))]
	interface HZInterstitialAd
	{
		// +(void)show;
		[Static]
		[Export ("show")]
		void Show ();

		// +(void)showForTag:(NSString *)tag;
		[Static]
		[Export ("showForTag:")]
		void ShowForTag (string tag);

		// +(void)showForTag:(NSString *)tag completion:(void (^)(BOOL, NSError *))completion;
		[Static]
		[Export ("showForTag:completion:")]
		void ShowForTag (string tag, Action<bool, NSError> completion);

		// +(void)showWithOptions:(HZShowOptions *)options;
		[Static]
		[Export ("showWithOptions:")]
		void ShowWithOptions (HZShowOptions options);

		// +(void)setDelegate:(id<HZAdsDelegate>)delegate;
		[Static]
		[Export ("setDelegate:")]
		void SetDelegate (HZAdsDelegate @delegate);

		// +(void)fetch;
		[Static]
		[Export ("fetch")]
		void Fetch ();

		// +(void)fetchWithCompletion:(void (^)(BOOL, NSError *))completion;
		[Static]
		[Export ("fetchWithCompletion:")]
		void FetchWithCompletion (Action<bool, NSError> completion);

		// +(void)fetchForTag:(NSString *)tag;
		[Static]
		[Export ("fetchForTag:")]
		void FetchForTag (string tag);

		// +(void)fetchForTag:(NSString *)tag withCompletion:(void (^)(BOOL, NSError *))completion;
		[Static]
		[Export ("fetchForTag:withCompletion:")]
		void FetchForTag (string tag, Action<bool, NSError> completion);

		// +(void)fetchForTags:(NSArray *)tags;
		[Static]
		[Export ("fetchForTags:")]
		//[Verify (StronglyTypedNSArray)]
		void FetchForTags (NSObject[] tags);

		// +(void)fetchForTags:(NSArray *)tags withCompletion:(void (^)(BOOL, NSError *))completion;
		[Static]
		[Export ("fetchForTags:withCompletion:")]
		//[Verify (StronglyTypedNSArray)]
		void FetchForTags (NSObject[] tags, Action<bool, NSError> completion);

		// +(BOOL)isAvailable;
		[Static]
		[Export ("isAvailable")]
		//[Verify (MethodToProperty)]
		bool IsAvailable { get; }

		// +(BOOL)isAvailableForTag:(NSString *)tag;
		[Static]
		[Export ("isAvailableForTag:")]
		bool IsAvailableForTag (string tag);

		// +(void)setCreativeID:(int)creativeID;
		[Static]
		[Export ("setCreativeID:")]
		void SetCreativeID (int creativeID);

		// +(void)forceTestCreative:(BOOL)forceTestCreative;
		[Static]
		[Export ("forceTestCreative:")]
		void ForceTestCreative (bool forceTestCreative);

		// +(void)setCreativeType:(NSString *)creativeType;
		[Static]
		[Export ("setCreativeType:")]
		void SetCreativeType (string creativeType);
	}

	// @interface HZVideoAd : NSObject
	[BaseType (typeof(NSObject))]
	interface HZVideoAd
	{
		// +(void)setDelegate:(id<HZAdsDelegate>)delegate;
		[Static]
		[Export ("setDelegate:")]
		void SetDelegate (HZAdsDelegate @delegate);

		// +(void)show;
		[Static]
		[Export ("show")]
		void Show ();

		// +(void)showForTag:(NSString *)tag;
		[Static]
		[Export ("showForTag:")]
		void ShowForTag (string tag);

		// +(void)showForTag:(NSString *)tag completion:(void (^)(BOOL, NSError *))completion;
		[Static]
		[Export ("showForTag:completion:")]
		void ShowForTag (string tag, Action<bool, NSError> completion);

		// +(void)showWithOptions:(HZShowOptions *)options;
		[Static]
		[Export ("showWithOptions:")]
		void ShowWithOptions (HZShowOptions options);

		// +(void)fetch;
		[Static]
		[Export ("fetch")]
		void Fetch ();

		// +(void)fetchWithCompletion:(void (^)(BOOL, NSError *))completion;
		[Static]
		[Export ("fetchWithCompletion:")]
		void FetchWithCompletion (Action<bool, NSError> completion);

		// +(void)fetchForTag:(NSString *)tag;
		[Static]
		[Export ("fetchForTag:")]
		void FetchForTag (string tag);

		// +(void)fetchForTag:(NSString *)tag withCompletion:(void (^)(BOOL, NSError *))completion;
		[Static]
		[Export ("fetchForTag:withCompletion:")]
		void FetchForTag (string tag, Action<bool, NSError> completion);

		// +(void)fetchForTags:(NSArray *)tags;
		[Static]
		[Export ("fetchForTags:")]
		//[Verify (StronglyTypedNSArray)]
		void FetchForTags (NSObject[] tags);

		// +(void)fetchForTags:(NSArray *)tags withCompletion:(void (^)(BOOL, NSError *))completion;
		[Static]
		[Export ("fetchForTags:withCompletion:")]
		//[Verify (StronglyTypedNSArray)]
		void FetchForTags (NSObject[] tags, Action<bool, NSError> completion);

		// +(BOOL)isAvailable;
		[Static]
		[Export ("isAvailable")]
		//[Verify (MethodToProperty)]
		bool IsAvailable { get; }

		// +(BOOL)isAvailableForTag:(NSString *)tag;
		[Static]
		[Export ("isAvailableForTag:")]
		bool IsAvailableForTag (string tag);

		// +(void)setCreativeID:(int)creativeID;
		[Static]
		[Export ("setCreativeID:")]
		void SetCreativeID (int creativeID);
	}

	// @interface HZIncentivizedAd : NSObject
	[BaseType (typeof(NSObject))]
	interface HZIncentivizedAd
	{
		// +(void)setDelegate:(id<HZIncentivizedAdDelegate>)delegate;
		[Static]
		[Export ("setDelegate:")]
		void SetDelegate (HZIncentivizedAdDelegate @delegate);

		// +(void)show;
		[Static]
		[Export ("show")]
		void Show ();

		// +(void)showForTag:(NSString *)tag;
		[Static]
		[Export ("showForTag:")]
		void ShowForTag (string tag);

		// +(void)showWithOptions:(HZShowOptions *)options;
		[Static]
		[Export ("showWithOptions:")]
		void ShowWithOptions (HZShowOptions options);

		// +(void)fetch;
		[Static]
		[Export ("fetch")]
		void Fetch ();

		// +(void)fetchForTag:(NSString *)tag;
		[Static]
		[Export ("fetchForTag:")]
		void FetchForTag (string tag);

		// +(void)fetchWithCompletion:(void (^)(BOOL, NSError *))completion;
		[Static]
		[Export ("fetchWithCompletion:")]
		void FetchWithCompletion (Action<bool, NSError> completion);

		// +(void)fetchForTag:(NSString *)tag withCompletion:(void (^)(BOOL, NSError *))completion;
		[Static]
		[Export ("fetchForTag:withCompletion:")]
		void FetchForTag (string tag, Action<bool, NSError> completion);

		// +(void)fetchForTags:(NSArray *)tags;
		[Static]
		[Export ("fetchForTags:")]
		//[Verify (StronglyTypedNSArray)]
		void FetchForTags (NSObject[] tags);

		// +(void)fetchForTags:(NSArray *)tags withCompletion:(void (^)(BOOL, NSError *))completion;
		[Static]
		[Export ("fetchForTags:withCompletion:")]
		//[Verify (StronglyTypedNSArray)]
		void FetchForTags (NSObject[] tags, Action<bool, NSError> completion);

		// +(BOOL)isAvailable;
		[Static]
		[Export ("isAvailable")]
		//[Verify (MethodToProperty)]
		bool IsAvailable { get; }

		// +(BOOL)isAvailableForTag:(NSString *)tag;
		[Static]
		[Export ("isAvailableForTag:")]
		bool IsAvailableForTag (string tag);

		// +(void)setUserIdentifier:(NSString *)userIdentifier __attribute__((deprecated("Please use the `incentivizedInfo` string that can be passed to calls to `showWithOptions:` instead if you want to pass information to your server regarding rewarded videos. More info about this feature can be found at https://developers.heyzap.com/docs/advanced-publishing ")));
		[Static]
		[Export ("setUserIdentifier:")]
		void SetUserIdentifier (string userIdentifier);

		// +(void)setCreativeID:(int)creativeID;
		[Static]
		[Export ("setCreativeID:")]
		void SetCreativeID (int creativeID);
	}

	// @interface HZNativeAdController : NSObject
	[BaseType (typeof(NSObject))]
	interface HZNativeAdController
	{
		// +(void)fetchAds:(NSUInteger)numberOfAds tag:(NSString *)tag completion:(void (^)(NSError *, HZNativeAdCollection *))completion;
		[Static]
		[Export ("fetchAds:tag:completion:")]
		void FetchAds (nuint numberOfAds, string tag, Action<NSError, HZNativeAdCollection> completion);
	}

	// @interface HZNativeAdCollection : NSObject
	[BaseType (typeof(NSObject))]
	interface HZNativeAdCollection
	{
		// @property (readonly, nonatomic) NSArray * ads;
		[Export ("ads")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] Ads { get; }

		// -(void)reportImpressionOnAllAds;
		[Export ("reportImpressionOnAllAds")]
		void ReportImpressionOnAllAds ();
	}

	// @interface HZNativeAd : NSObject
	[BaseType (typeof(NSObject))]
	interface HZNativeAd
	{
		// @property (readonly, nonatomic) NSString * appName;
		[Export ("appName")]
		string AppName { get; }

		// @property (readonly, nonatomic) NSString * callToAction;
		[Export ("callToAction")]
		string CallToAction { get; }

		// @property (readonly, nonatomic) NSURL * iconURL __attribute__((deprecated("Use the `url` property of `iconImage` instead.")));
		[Export ("iconURL")]
		NSUrl IconURL { get; }

		// @property (readonly, nonatomic) HZNativeAdImage * iconImage;
		[Export ("iconImage")]
		HZNativeAdImage IconImage { get; }

		// @property (readonly, nonatomic) HZNativeAdImage * landscapeCreative;
		[Export ("landscapeCreative")]
		HZNativeAdImage LandscapeCreative { get; }

		// @property (readonly, nonatomic) HZNativeAdImage * portraitCreative;
		[Export ("portraitCreative")]
		HZNativeAdImage PortraitCreative { get; }

		// @property (readonly, nonatomic) NSNumber * rating;
		[Export ("rating")]
		NSNumber Rating { get; }

		// @property (readonly, nonatomic) NSString * category;
		[Export ("category")]
		string Category { get; }

		// @property (readonly, nonatomic) NSString * appDescription;
		[Export ("appDescription")]
		string AppDescription { get; }

		// @property (readonly, nonatomic) NSString * developerName;
		[Export ("developerName")]
		string DeveloperName { get; }

		// @property (readonly, nonatomic) NSDictionary * rawResponse;
		[Export ("rawResponse")]
		NSDictionary RawResponse { get; }

		// -(void)reportImpression;
		[Export ("reportImpression")]
		void ReportImpression ();

		// -(SKStoreProductViewController *)presentAppStoreFromViewController:(UIViewController *)viewController storeDelegate:(id<SKStoreProductViewControllerDelegate>)storeDelegate completion:(void (^)(BOOL, NSError *))completion;
		[Export ("presentAppStoreFromViewController:storeDelegate:completion:")]
		SKStoreProductViewController PresentAppStoreFromViewController (UIViewController viewController, SKStoreProductViewControllerDelegate storeDelegate, Action<bool, NSError> completion);
	}

	// @interface HZNativeAdImage : NSObject
	[BaseType (typeof(NSObject))]
	interface HZNativeAdImage
	{
		// @property (readonly, nonatomic) NSURL * url;
		[Export ("url")]
		NSUrl Url { get; }

		// @property (readonly, nonatomic) NSUInteger width;
		[Export ("width")]
		nuint Width { get; }

		// @property (readonly, nonatomic) NSUInteger height;
		[Export ("height")]
		nuint Height { get; }

		// @property (readonly, nonatomic) CGSize size;
		[Export ("size")]
		CGSize Size { get; }
	}

	partial interface Constants
	{
		// extern NSString *const kHZBannerAdDidReceiveAdNotification;
		[Field ("kHZBannerAdDidReceiveAdNotification", "__Internal")]
		NSString kHZBannerAdDidReceiveAdNotification { get; }

		// extern NSString *const kHZBannerAdDidFailToReceiveAdNotification;
		[Field ("kHZBannerAdDidFailToReceiveAdNotification", "__Internal")]
		NSString kHZBannerAdDidFailToReceiveAdNotification { get; }

		// extern NSString *const kHZBannerAdWasClickedNotification;
		[Field ("kHZBannerAdWasClickedNotification", "__Internal")]
		NSString kHZBannerAdWasClickedNotification { get; }

		// extern NSString *const kHZBannerAdWillPresentModalViewNotification;
		[Field ("kHZBannerAdWillPresentModalViewNotification", "__Internal")]
		NSString kHZBannerAdWillPresentModalViewNotification { get; }

		// extern NSString *const kHZBannerAdDidDismissModalViewNotification;
		[Field ("kHZBannerAdDidDismissModalViewNotification", "__Internal")]
		NSString kHZBannerAdDidDismissModalViewNotification { get; }

		// extern NSString *const kHZBannerAdWillLeaveApplicationNotification;
		[Field ("kHZBannerAdWillLeaveApplicationNotification", "__Internal")]
		NSString kHZBannerAdWillLeaveApplicationNotification { get; }

		// extern NSString *const kHZBannerAdNotificationErrorKey __attribute__((deprecated("")));
		[Field ("kHZBannerAdNotificationErrorKey", "__Internal")]
		NSString kHZBannerAdNotificationErrorKey { get; }
	}

	// @protocol HZBannerAdDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface HZBannerAdDelegate
	{
		// @optional -(void)bannerDidReceiveAd:(HZBannerAd *)banner;
		[Export ("bannerDidReceiveAd:")]
		void BannerDidReceiveAd (HZBannerAd banner);

		// @optional -(void)bannerDidFailToReceiveAd:(HZBannerAd *)banner error:(NSError *)error;
		[Export ("bannerDidFailToReceiveAd:error:")]
		void BannerDidFailToReceiveAd (HZBannerAd banner, NSError error);

		// @optional -(void)bannerWasClicked:(HZBannerAd *)banner;
		[Export ("bannerWasClicked:")]
		void BannerWasClicked (HZBannerAd banner);

		// @optional -(void)bannerWillPresentModalView:(HZBannerAd *)banner;
		[Export ("bannerWillPresentModalView:")]
		void BannerWillPresentModalView (HZBannerAd banner);

		// @optional -(void)bannerDidDismissModalView:(HZBannerAd *)banner;
		[Export ("bannerDidDismissModalView:")]
		void BannerDidDismissModalView (HZBannerAd banner);

		// @optional -(void)bannerWillLeaveApplication:(HZBannerAd *)banner;
		[Export ("bannerWillLeaveApplication:")]
		void BannerWillLeaveApplication (HZBannerAd banner);
	}

	// @interface HZBannerAd : UIView
	[BaseType (typeof(UIView))]
	interface HZBannerAd
	{
		// +(void)placeBannerInView:(UIView *)view position:(HZBannerPosition)position options:(HZBannerAdOptions *)options success:(void (^)(HZBannerAd *))success failure:(void (^)(NSError *))failure;
		[Static]
		[Export ("placeBannerInView:position:options:success:failure:")]
		void PlaceBannerInView (UIView view, HZBannerPosition position, HZBannerAdOptions options, Action<HZBannerAd> success, Action<NSError> failure);

		// +(void)requestBannerWithOptions:(HZBannerAdOptions *)options success:(void (^)(HZBannerAd *))success failure:(void (^)(NSError *))failure;
		[Static]
		[Export ("requestBannerWithOptions:success:failure:")]
		void RequestBannerWithOptions (HZBannerAdOptions options, Action<HZBannerAd> success, Action<NSError> failure);

		// -(NSString *)dimensionsDescription;
		[Export ("dimensionsDescription")]
		//[Verify (MethodToProperty)]
		string DimensionsDescription { get; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		HZBannerAdDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<HZBannerAdDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, copy, nonatomic) HZBannerAdOptions * options;
		[Export ("options", ArgumentSemantic.Copy)]
		HZBannerAdOptions Options { get; }

		// @property (readonly, nonatomic, strong) NSString * mediatedNetwork;
		[Export ("mediatedNetwork", ArgumentSemantic.Strong)]
		string MediatedNetwork { get; }
	}

	partial interface Constants
	{
		// extern const CGSize HZInMobiBannerSize320x50;
		[Field ("HZInMobiBannerSize320x50", "__Internal")]
		CGSize HZInMobiBannerSize320x50 { get; }

		// extern const CGSize HZInMobiBannerSize468x60;
		[Field ("HZInMobiBannerSize468x60", "__Internal")]
		CGSize HZInMobiBannerSize468x60 { get; }

		// extern const CGSize HZInMobiBannerSize480x75;
		[Field ("HZInMobiBannerSize480x75", "__Internal")]
		CGSize HZInMobiBannerSize480x75 { get; }

		// extern const CGSize HZInMobiBannerSize728x90;
		[Field ("HZInMobiBannerSize728x90", "__Internal")]
		CGSize HZInMobiBannerSize728x90 { get; }
	}

	// @interface HZBannerAdOptions : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface HZBannerAdOptions : INSCopying
	{
		// @property (nonatomic) HZFacebookBannerSize facebookBannerSize;
		[Export ("facebookBannerSize", ArgumentSemantic.Assign)]
		HZFacebookBannerSize FacebookBannerSize { get; set; }

		// @property (nonatomic) HZAdMobBannerSize admobBannerSize;
		[Export ("admobBannerSize", ArgumentSemantic.Assign)]
		HZAdMobBannerSize AdmobBannerSize { get; set; }

		// @property (nonatomic) CGSize inMobiBannerSize;
		[Export ("inMobiBannerSize", ArgumentSemantic.Assign)]
		CGSize InMobiBannerSize { get; set; }

		// @property (nonatomic, weak) UIViewController * _Nullable presentingViewController;
		[NullAllowed, Export ("presentingViewController", ArgumentSemantic.Weak)]
		UIViewController PresentingViewController { get; set; }

		// @property (nonatomic, strong) NSString * tag;
		[Export ("tag", ArgumentSemantic.Strong)]
		string Tag { get; set; }

		// @property (nonatomic) NSTimeInterval fetchTimeout;
		[Export ("fetchTimeout")]
		double FetchTimeout { get; set; }
	}

	// @interface HZDemographics : NSObject
	[BaseType (typeof(NSObject))]
	public interface HZDemographics
	{
		// @property (nonatomic) CLLocation * location;
		[Export ("location", ArgumentSemantic.Assign)]
		CLLocation Location { get; set; }
	}

	[Static]
	partial interface Constants
	{
		// extern NSString *const HZNetworkHeyzap;
		[Field ("HZNetworkHeyzap", "__Internal")]
		NSString HZNetworkHeyzap { get; }

		// extern NSString *const HZNetworkCrossPromo;
		[Field ("HZNetworkCrossPromo", "__Internal")]
		NSString HZNetworkCrossPromo { get; }

		// extern NSString *const HZNetworkFacebook;
		[Field ("HZNetworkFacebook", "__Internal")]
		NSString HZNetworkFacebook { get; }

		// extern NSString *const HZNetworkUnityAds;
		[Field ("HZNetworkUnityAds", "__Internal")]
		NSString HZNetworkUnityAds { get; }

		// extern NSString *const HZNetworkAppLovin;
		[Field ("HZNetworkAppLovin", "__Internal")]
		NSString HZNetworkAppLovin { get; }

		// extern NSString *const HZNetworkVungle;
		[Field ("HZNetworkVungle", "__Internal")]
		NSString HZNetworkVungle { get; }

		// extern NSString *const HZNetworkChartboost;
		[Field ("HZNetworkChartboost", "__Internal")]
		NSString HZNetworkChartboost { get; }

		// extern NSString *const HZNetworkAdColony;
		[Field ("HZNetworkAdColony", "__Internal")]
		NSString HZNetworkAdColony { get; }

		// extern NSString *const HZNetworkAdMob;
		[Field ("HZNetworkAdMob", "__Internal")]
		NSString HZNetworkAdMob { get; }

		// extern NSString *const HZNetworkIAd;
		[Field ("HZNetworkIAd", "__Internal")]
		NSString HZNetworkIAd { get; }

		// extern NSString *const HZNetworkHyprMX;
		[Field ("HZNetworkHyprMX", "__Internal")]
		NSString HZNetworkHyprMX { get; }

		// extern NSString *const HZNetworkHeyzapExchange;
		[Field ("HZNetworkHeyzapExchange", "__Internal")]
		NSString HZNetworkHeyzapExchange { get; }

		// extern NSString *const HZNetworkLeadbolt;
		[Field ("HZNetworkLeadbolt", "__Internal")]
		NSString HZNetworkLeadbolt { get; }

		// extern NSString *const HZNetworkCallbackInitialized;
		[Field ("HZNetworkCallbackInitialized", "__Internal")]
		NSString HZNetworkCallbackInitialized { get; }

		// extern NSString *const HZNetworkCallbackShow;
		[Field ("HZNetworkCallbackShow", "__Internal")]
		NSString HZNetworkCallbackShow { get; }

		// extern NSString *const HZNetworkCallbackAvailable;
		[Field ("HZNetworkCallbackAvailable", "__Internal")]
		NSString HZNetworkCallbackAvailable { get; }

		// extern NSString *const HZNetworkCallbackHide;
		[Field ("HZNetworkCallbackHide", "__Internal")]
		NSString HZNetworkCallbackHide { get; }

		// extern NSString *const HZNetworkCallbackFetchFailed;
		[Field ("HZNetworkCallbackFetchFailed", "__Internal")]
		NSString HZNetworkCallbackFetchFailed { get; }

		// extern NSString *const HZNetworkCallbackClick;
		[Field ("HZNetworkCallbackClick", "__Internal")]
		NSString HZNetworkCallbackClick { get; }

		// extern NSString *const HZNetworkCallbackDismiss;
		[Field ("HZNetworkCallbackDismiss", "__Internal")]
		NSString HZNetworkCallbackDismiss { get; }

		// extern NSString *const HZNetworkCallbackIncentivizedResultIncomplete;
		[Field ("HZNetworkCallbackIncentivizedResultIncomplete", "__Internal")]
		NSString HZNetworkCallbackIncentivizedResultIncomplete { get; }

		// extern NSString *const HZNetworkCallbackIncentivizedResultComplete;
		[Field ("HZNetworkCallbackIncentivizedResultComplete", "__Internal")]
		NSString HZNetworkCallbackIncentivizedResultComplete { get; }

		// extern NSString *const HZNetworkCallbackAudioStarting;
		[Field ("HZNetworkCallbackAudioStarting", "__Internal")]
		NSString HZNetworkCallbackAudioStarting { get; }

		// extern NSString *const HZNetworkCallbackAudioFinished;
		[Field ("HZNetworkCallbackAudioFinished", "__Internal")]
		NSString HZNetworkCallbackAudioFinished { get; }

		// extern NSString *const HZNetworkCallbackLeaveApplication;
		[Field ("HZNetworkCallbackLeaveApplication", "__Internal")]
		NSString HZNetworkCallbackLeaveApplication { get; }

		// extern NSString *const HZNetworkCallbackBannerLoaded __attribute__((deprecated("")));
		[Field ("HZNetworkCallbackBannerLoaded", "__Internal")]
		NSString HZNetworkCallbackBannerLoaded { get; }

		// extern NSString *const HZNetworkCallbackBannerClick __attribute__((deprecated("")));
		[Field ("HZNetworkCallbackBannerClick", "__Internal")]
		NSString HZNetworkCallbackBannerClick { get; }

		// extern NSString *const HZNetworkCallbackBannerHide __attribute__((deprecated("")));
		[Field ("HZNetworkCallbackBannerHide", "__Internal")]
		NSString HZNetworkCallbackBannerHide { get; }

		// extern NSString *const HZNetworkCallbackBannerDismiss __attribute__((deprecated("")));
		[Field ("HZNetworkCallbackBannerDismiss", "__Internal")]
		NSString HZNetworkCallbackBannerDismiss { get; }

		// extern NSString *const HZNetworkCallbackBannerFetchFailed __attribute__((deprecated("")));
		[Field ("HZNetworkCallbackBannerFetchFailed", "__Internal")]
		NSString HZNetworkCallbackBannerFetchFailed { get; }

		// extern NSString *const HZNetworkCallbackChartboostMoreAppsFetchFailed;
		[Field ("HZNetworkCallbackChartboostMoreAppsFetchFailed", "__Internal")]
		NSString HZNetworkCallbackChartboostMoreAppsFetchFailed { get; }

		// extern NSString *const HZNetworkCallbackChartboostMoreAppsDismiss;
		[Field ("HZNetworkCallbackChartboostMoreAppsDismiss", "__Internal")]
		NSString HZNetworkCallbackChartboostMoreAppsDismiss { get; }

		// extern NSString *const HZNetworkCallbackChartboostMoreAppsHide;
		[Field ("HZNetworkCallbackChartboostMoreAppsHide", "__Internal")]
		NSString HZNetworkCallbackChartboostMoreAppsHide { get; }

		// extern NSString *const HZNetworkCallbackChartboostMoreAppsClick;
		[Field ("HZNetworkCallbackChartboostMoreAppsClick", "__Internal")]
		NSString HZNetworkCallbackChartboostMoreAppsClick { get; }

		// extern NSString *const HZNetworkCallbackChartboostMoreAppsShow;
		[Field ("HZNetworkCallbackChartboostMoreAppsShow", "__Internal")]
		NSString HZNetworkCallbackChartboostMoreAppsShow { get; }

		// extern NSString *const HZNetworkCallbackChartboostMoreAppsAvailable;
		[Field ("HZNetworkCallbackChartboostMoreAppsAvailable", "__Internal")]
		NSString HZNetworkCallbackChartboostMoreAppsAvailable { get; }

		// extern NSString *const HZNetworkCallbackChartboostMoreAppsClickFailed;
		[Field ("HZNetworkCallbackChartboostMoreAppsClickFailed", "__Internal")]
		NSString HZNetworkCallbackChartboostMoreAppsClickFailed { get; }

		// extern NSString *const HZNetworkCallbackFacebookLoggingImpression;
		[Field ("HZNetworkCallbackFacebookLoggingImpression", "__Internal")]
		NSString HZNetworkCallbackFacebookLoggingImpression { get; }

		// extern NSString *const HZRemoteDataRefreshedNotification;
		[Field ("HZRemoteDataRefreshedNotification", "__Internal")]
		NSString HZRemoteDataRefreshedNotification { get; }

		// extern NSString *const HZMediationNetworkCallbackNotification;
		[Field ("HZMediationNetworkCallbackNotification", "__Internal")]
		NSString HZMediationNetworkCallbackNotification { get; }

		// extern NSString *const HZMediationDidShowAdNotification;
		[Field ("HZMediationDidShowAdNotification", "__Internal")]
		NSString HZMediationDidShowAdNotification { get; }

		// extern NSString *const HZMediationDidFailToShowAdNotification;
		[Field ("HZMediationDidFailToShowAdNotification", "__Internal")]
		NSString HZMediationDidFailToShowAdNotification { get; }

		// extern NSString *const HZMediationDidReceiveAdNotification;
		[Field ("HZMediationDidReceiveAdNotification", "__Internal")]
		NSString HZMediationDidReceiveAdNotification { get; }

		// extern NSString *const HZMediationDidFailToReceiveAdNotification;
		[Field ("HZMediationDidFailToReceiveAdNotification", "__Internal")]
		NSString HZMediationDidFailToReceiveAdNotification { get; }

		// extern NSString *const HZMediationDidClickAdNotification;
		[Field ("HZMediationDidClickAdNotification", "__Internal")]
		NSString HZMediationDidClickAdNotification { get; }

		// extern NSString *const HZMediationDidHideAdNotification;
		[Field ("HZMediationDidHideAdNotification", "__Internal")]
		NSString HZMediationDidHideAdNotification { get; }

		// extern NSString *const HZMediationWillStartAdAudioNotification;
		[Field ("HZMediationWillStartAdAudioNotification", "__Internal")]
		NSString HZMediationWillStartAdAudioNotification { get; }

		// extern NSString *const HZMediationDidFinishAdAudioNotification;
		[Field ("HZMediationDidFinishAdAudioNotification", "__Internal")]
		NSString HZMediationDidFinishAdAudioNotification { get; }

		// extern NSString *const HZMediationDidCompleteIncentivizedAdNotification;
		[Field ("HZMediationDidCompleteIncentivizedAdNotification", "__Internal")]
		NSString HZMediationDidCompleteIncentivizedAdNotification { get; }

		// extern NSString *const HZMediationDidFailToCompleteIncentivizedAdNotification;
		[Field ("HZMediationDidFailToCompleteIncentivizedAdNotification", "__Internal")]
		NSString HZMediationDidFailToCompleteIncentivizedAdNotification { get; }

		// extern NSString *const HZNetworkCallbackNameUserInfoKey;
		[Field ("HZNetworkCallbackNameUserInfoKey", "__Internal")]
		NSString HZNetworkCallbackNameUserInfoKey { get; }

		// extern NSString *const HZAdTagUserInfoKey;
		[Field ("HZAdTagUserInfoKey", "__Internal")]
		NSString HZAdTagUserInfoKey { get; }

		// extern NSString *const HZNetworkNameUserInfoKey;
		[Field ("HZNetworkNameUserInfoKey", "__Internal")]
		NSString HZNetworkNameUserInfoKey { get; }
	}

	// @protocol HZAdsDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface HZAdsDelegate
	{
		// @optional -(void)didShowAdWithTag:(NSString *)tag;
		[Export ("didShowAdWithTag:")]
		void DidShowAdWithTag (string tag);

		// @optional -(void)didFailToShowAdWithTag:(NSString *)tag andError:(NSError *)error;
		[Export ("didFailToShowAdWithTag:andError:")]
		void DidFailToShowAdWithTag (string tag, NSError error);

		// @optional -(void)didReceiveAdWithTag:(NSString *)tag;
		[Export ("didReceiveAdWithTag:")]
		void DidReceiveAdWithTag (string tag);

		// @optional -(void)didFailToReceiveAdWithTag:(NSString *)tag;
		[Export ("didFailToReceiveAdWithTag:")]
		void DidFailToReceiveAdWithTag (string tag);

		// @optional -(void)didClickAdWithTag:(NSString *)tag;
		[Export ("didClickAdWithTag:")]
		void DidClickAdWithTag (string tag);

		// @optional -(void)didHideAdWithTag:(NSString *)tag;
		[Export ("didHideAdWithTag:")]
		void DidHideAdWithTag (string tag);

		// @optional -(void)willStartAudio;
		[Export ("willStartAudio")]
		void WillStartAudio ();

		// @optional -(void)didFinishAudio;
		[Export ("didFinishAudio")]
		void DidFinishAudio ();
	}

	// @protocol HZIncentivizedAdDelegate <HZAdsDelegate>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface HZIncentivizedAdDelegate : HZAdsDelegate
	{
		// @optional -(void)didCompleteAdWithTag:(NSString *)tag;
		[Export ("didCompleteAdWithTag:")]
		void DidCompleteAdWithTag (string tag);

		// @optional -(void)didFailToCompleteAdWithTag:(NSString *)tag;
		[Export ("didFailToCompleteAdWithTag:")]
		void DidFailToCompleteAdWithTag (string tag);
	}

	// @interface HeyzapAds : NSObject
	[BaseType (typeof(NSObject))]
	public interface HeyzapAds
	{
		// +(void)setDelegate:(id)delegate forNetwork:(NSString *)network;
		[Static]
		[Export ("setDelegate:forNetwork:")]
		void SetDelegate (NSObject @delegate, string network);

		// +(void)networkCallbackWithBlock:(void (^)(NSString *, NSString *))block;
		[Static]
		[Export ("networkCallbackWithBlock:")]
		void NetworkCallbackWithBlock (Action<NSString, NSString> block);

		// +(BOOL)isNetworkInitialized:(NSString *)network;
		[Static]
		[Export ("isNetworkInitialized:")]
		bool IsNetworkInitialized (string network);

		// +(void)startWithPublisherID:(NSString *)publisherID andOptions:(HZAdOptions)options;
		[Static]
		[Export ("startWithPublisherID:andOptions:")]
		void StartWithPublisherID (string publisherID, HZAdOptions options);

		// +(void)startWithPublisherID:(NSString *)publisherID andOptions:(HZAdOptions)options andFramework:(NSString *)framework;
		[Static]
		[Export ("startWithPublisherID:andOptions:andFramework:")]
		void StartWithPublisherID (string publisherID, HZAdOptions options, string framework);

		// +(void)startWithPublisherID:(NSString *)publisherID;
		[Static]
		[Export ("startWithPublisherID:")]
		void StartWithPublisherID (string publisherID);

		// +(BOOL)isStarted;
		[Static]
		[Export ("isStarted")]
		//[Verify (MethodToProperty)]
		bool IsStarted { get; }

		// +(void)setDebugLevel:(HZDebugLevel)debugLevel;
		[Static]
		[Export ("setDebugLevel:")]
		void SetDebugLevel (HZDebugLevel debugLevel);

		// +(void)setDebug:(BOOL)choice;
		[Static]
		[Export ("setDebug:")]
		void SetDebug (bool choice);

		// +(void)setOptions:(HZAdOptions)options;
		[Static]
		[Export ("setOptions:")]
		void SetOptions (HZAdOptions options);

		// +(void)setFramework:(NSString *)framework;
		[Static]
		[Export ("setFramework:")]
		void SetFramework (string framework);

		// +(void)setMediator:(NSString *)mediator;
		[Static]
		[Export ("setMediator:")]
		void SetMediator (string mediator);

		// +(void)setBundleIdentifier:(NSString *)bundleIdentifier;
		[Static]
		[Export ("setBundleIdentifier:")]
		void SetBundleIdentifier (string bundleIdentifier);

		// +(NSString *)defaultTagName;
		[Static]
		[Export ("defaultTagName")]
		//[Verify (MethodToProperty)]
		string DefaultTagName { get; }

		// +(NSDictionary *)remoteData;
		[Static]
		[Export ("remoteData")]
		//[Verify (MethodToProperty)]
		NSDictionary RemoteData { get; }

		// +(NSString *)getRemoteDataJsonString;
		[Static]
		[Export ("getRemoteDataJsonString")]
		//[Verify (MethodToProperty)]
		string RemoteDataJsonString { get; }

		// +(HZDemographics *)demographicInformation;
		[Static]
		[Export ("demographicInformation")]
		//[Verify (MethodToProperty)]
		HZDemographics DemographicInformation { get; }

		// +(void)presentMediationDebugViewController;
		[Static]
		[Export ("presentMediationDebugViewController")]
		void PresentMediationDebugViewController ();

		// +(void)pauseExpensiveWork;
		[Static]
		[Export ("pauseExpensiveWork")]
		void PauseExpensiveWork ();

		// +(void)resumeExpensiveWork;
		[Static]
		[Export ("resumeExpensiveWork")]
		void ResumeExpensiveWork ();

		// +(void)onIAPPurchaseComplete:(NSString *)productId productName:(NSString *)productName price:(NSDecimalNumber *)price;
		[Static]
		[Export ("onIAPPurchaseComplete:productName:price:")]
		void OnIAPPurchaseComplete (string productId, string productName, NSDecimalNumber price);
	}
}