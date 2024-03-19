using System;
using CoreGraphics;
using Foundation;
using GoogleMobileAds;
using ObjCRuntime;
using UIKit;
using WebKit;

namespace GoogleMobileAds
{
	[Static]
	partial interface Constants
	{
		// extern const unsigned char[] GoogleMobileAdsVersionString;
		[Field("GoogleMobileAdsVersionString", "__Internal")]
		NSString GoogleMobileAdsVersionString { get; }

		// extern GADAdLoaderAdType  _Nonnull const GADAdLoaderAdTypeCustomNative;
		[Field("GADAdLoaderAdTypeCustomNative", "__Internal")]
		NSString GADAdLoaderAdTypeCustomNative { get; }

		// extern GADAdLoaderAdType  _Nonnull const GADAdLoaderAdTypeGAMBanner;
		[Field("GADAdLoaderAdTypeGAMBanner", "__Internal")]
		NSString GADAdLoaderAdTypeGAMBanner { get; }

		// extern GADAdLoaderAdType  _Nonnull const GADAdLoaderAdTypeNative;
		[Field("GADAdLoaderAdTypeNative", "__Internal")]
		NSString GADAdLoaderAdTypeNative { get; }

		// extern const GADAdSize kGADAdSizeSmartBannerPortrait __attribute__((deprecated("Use GADPortraitAnchoredAdaptiveBannerAdSizeWithWidth.")));
		[Field("kGADAdSizeSmartBannerPortrait", "__Internal")]
		IntPtr kGADAdSizeSmartBannerPortrait { get; }

		// extern const GADAdSize kGADAdSizeSmartBannerLandscape __attribute__((deprecated("Use GADLandscapeAnchoredAdaptiveBannerAdSizeWithWidth")));
		[Field("kGADAdSizeSmartBannerLandscape", "__Internal")]
		IntPtr kGADAdSizeSmartBannerLandscape { get; }

		// extern NSString *const _Nonnull GADGoogleAdNetworkClassName;
		[Field("GADGoogleAdNetworkClassName", "__Internal")]
		NSString GADGoogleAdNetworkClassName { get; }

		// extern NSString *const _Nonnull GADCustomEventAdNetworkClassName;
		[Field("GADCustomEventAdNetworkClassName", "__Internal")]
		NSString GADCustomEventAdNetworkClassName { get; }

		// extern NSString * _Nonnull GADErrorUserInfoKeyResponseInfo;
		[Field("GADErrorUserInfoKeyResponseInfo", "__Internal")]
		NSString GADErrorUserInfoKeyResponseInfo { get; }

		// extern GADNativeAssetIdentifier  _Nonnull const GADNativeHeadlineAsset;
		[Field("GADNativeHeadlineAsset", "__Internal")]
		NSString GADNativeHeadlineAsset { get; }

		// extern GADNativeAssetIdentifier  _Nonnull const GADNativeCallToActionAsset;
		[Field("GADNativeCallToActionAsset", "__Internal")]
		NSString GADNativeCallToActionAsset { get; }

		// extern GADNativeAssetIdentifier  _Nonnull const GADNativeIconAsset;
		[Field("GADNativeIconAsset", "__Internal")]
		NSString GADNativeIconAsset { get; }

		// extern GADNativeAssetIdentifier  _Nonnull const GADNativeBodyAsset;
		[Field("GADNativeBodyAsset", "__Internal")]
		NSString GADNativeBodyAsset { get; }

		// extern GADNativeAssetIdentifier  _Nonnull const GADNativeStoreAsset;
		[Field("GADNativeStoreAsset", "__Internal")]
		NSString GADNativeStoreAsset { get; }

		// extern GADNativeAssetIdentifier  _Nonnull const GADNativePriceAsset;
		[Field("GADNativePriceAsset", "__Internal")]
		NSString GADNativePriceAsset { get; }

		// extern GADNativeAssetIdentifier  _Nonnull const GADNativeImageAsset;
		[Field("GADNativeImageAsset", "__Internal")]
		NSString GADNativeImageAsset { get; }

		// extern GADNativeAssetIdentifier  _Nonnull const GADNativeStarRatingAsset;
		[Field("GADNativeStarRatingAsset", "__Internal")]
		NSString GADNativeStarRatingAsset { get; }

		// extern GADNativeAssetIdentifier  _Nonnull const GADNativeAdvertiserAsset;
		[Field("GADNativeAdvertiserAsset", "__Internal")]
		NSString GADNativeAdvertiserAsset { get; }

		// extern GADNativeAssetIdentifier  _Nonnull const GADNativeMediaViewAsset;
		[Field("GADNativeMediaViewAsset", "__Internal")]
		NSString GADNativeMediaViewAsset { get; }

		// extern GADNativeAssetIdentifier  _Nonnull const GADNativeAdChoicesViewAsset;
		[Field("GADNativeAdChoicesViewAsset", "__Internal")]
		NSString GADNativeAdChoicesViewAsset { get; }

		// extern NSString *const _Nonnull GADCustomEventParametersServer;
		[Field("GADCustomEventParametersServer", "__Internal")]
		NSString GADCustomEventParametersServer { get; }

		// extern NSString *const _Nonnull GADCustomNativeAdMediaViewKey;
		[Field("GADCustomNativeAdMediaViewKey", "__Internal")]
		NSString GADCustomNativeAdMediaViewKey { get; }


	}

	// @interface GADAdChoicesView : UIView
	[BaseType(typeof(UIView))]
	interface GADAdChoicesView
	{
	}

	// @protocol GADAdLoaderDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GADAdLoaderDelegate
	{
		// @required -(void)adLoader:(GADAdLoader * _Nonnull)adLoader didFailToReceiveAdWithError:(NSError * _Nonnull)error;
		[Abstract]
		[Export("adLoader:didFailToReceiveAdWithError:")]
		void AdLoaderDidFailToReceiveAd(GADAdLoader adLoader, NSError error);

		// @optional -(void)adLoaderDidFinishLoading:(GADAdLoader * _Nonnull)adLoader;
		[Export("adLoaderDidFinishLoading:")]
		void AdLoaderDidFinishLoading(GADAdLoader adLoader);
	}

	// @protocol GADAdNetworkExtras <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface GADAdNetworkExtras
	{
	}

	// @interface GADRequest : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface GADRequest : INSCopying
	{
		// +(instancetype _Nonnull)request;
		[Static]
		[Export("request")]
		GADRequest Request();

		// -(void)registerAdNetworkExtras:(id<GADAdNetworkExtras> _Nonnull)extras;
		[Export("registerAdNetworkExtras:")]
		void RegisterAdNetworkExtras(GADAdNetworkExtras extras);

		// -(id<GADAdNetworkExtras> _Nullable)adNetworkExtrasFor:(Class<GADAdNetworkExtras> _Nonnull)aClass;
		[Export("adNetworkExtrasFor:")]
		[return: NullAllowed]
		GADAdNetworkExtras AdNetworkExtrasFor(GADAdNetworkExtras aClass);

		// -(void)removeAdNetworkExtrasFor:(Class<GADAdNetworkExtras> _Nonnull)aClass;
		[Export("removeAdNetworkExtrasFor:")]
		void RemoveAdNetworkExtrasFor(GADAdNetworkExtras aClass);

		// @property (nonatomic, weak) API_AVAILABLE(ios(13.0)) UIWindowScene * scene __attribute__((availability(ios, introduced=13.0)));
		//[iOS (13, 0)]
		[Export("scene", ArgumentSemantic.Weak)]
		UIWindowScene Scene { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nullable keywords;
		[NullAllowed, Export("keywords", ArgumentSemantic.Copy)]
		string[] Keywords { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable contentURL;
		[NullAllowed, Export("contentURL")] string ContentURL { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nullable neighboringContentURLStrings;
		[NullAllowed, Export("neighboringContentURLStrings", ArgumentSemantic.Copy)]
		string[] NeighboringContentURLStrings { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable requestAgent;
		[NullAllowed, Export("requestAgent")] string RequestAgent { get; set; }

		// extern const GADAdSize GADAdSizeBanner;
		[Field("GADAdSizeBanner", "__Internal")]
		IntPtr GADAdSizeBanner { get; }

		// extern const GADAdSize GADAdSizeLargeBanner;
		[Field("GADAdSizeLargeBanner", "__Internal")]
		IntPtr GADAdSizeLargeBanner { get; }

		// extern const GADAdSize GADAdSizeMediumRectangle;
		[Field("GADAdSizeMediumRectangle", "__Internal")]
		IntPtr GADAdSizeMediumRectangle { get; }

		// extern const GADAdSize GADAdSizeFullBanner;
		[Field("GADAdSizeFullBanner", "__Internal")]
		IntPtr GADAdSizeFullBanner { get; }

		// extern const GADAdSize GADAdSizeLeaderboard;
		[Field("GADAdSizeLeaderboard", "__Internal")]
		IntPtr GADAdSizeLeaderboard { get; }

		// extern const GADAdSize GADAdSizeSkyscraper;
		[Field("GADAdSizeSkyscraper", "__Internal")]
		IntPtr GADAdSizeSkyscraper { get; }

		// extern const GADAdSize GADAdSizeFluid;
		[Field("GADAdSizeFluid", "__Internal")]
		IntPtr GADAdSizeFluid { get; }

		// extern const GADAdSize GADAdSizeInvalid;
		[Field("GADAdSizeInvalid", "__Internal")]
		IntPtr GADAdSizeInvalid { get; }

		// extern GADMaxAdContentRating  _Nonnull const GADMaxAdContentRatingGeneral;
		[Field("GADMaxAdContentRatingGeneral", "__Internal")]
		NSString GADMaxAdContentRatingGeneral { get; }

		// extern GADMaxAdContentRating  _Nonnull const GADMaxAdContentRatingParentalGuidance;
		[Field("GADMaxAdContentRatingParentalGuidance", "__Internal")]
		NSString GADMaxAdContentRatingParentalGuidance { get; }

		// extern GADMaxAdContentRating  _Nonnull const GADMaxAdContentRatingTeen;
		[Field("GADMaxAdContentRatingTeen", "__Internal")]
		NSString GADMaxAdContentRatingTeen { get; }

		// extern GADMaxAdContentRating  _Nonnull const GADMaxAdContentRatingMatureAudience;
		[Field("GADMaxAdContentRatingMatureAudience", "__Internal")]
		NSString GADMaxAdContentRatingMatureAudience { get; }

		// extern GAD_DEPRECATED_MSG_ATTRIBUTE("Deprecated. Simulators are already in test mode by default.") NSString *const GADSimulatorID __attribute__((deprecated("Deprecated. Simulators are already in test mode by default.")));
		[Field("GADSimulatorID", "__Internal")]
		NSString GADSimulatorID { get; }

		// extern NSString *const _Nonnull GADErrorDomain;
		[Field("GADErrorDomain", "__Internal")]
		NSString GADErrorDomain { get; }

		// From Category GADRequest_AdStringIGADMAdNetworkConnector
		// @property (copy, nonatomic) NSString * _Nullable adString;
		[NullAllowed, Export("adString")] string AdString { get; set; }
	}

	// @interface GADAdLoaderOptions : NSObject
	[BaseType(typeof(NSObject))]
	interface GADAdLoaderOptions
	{
	}

	// @interface GADAdLoader : NSObject
	[BaseType(typeof(NSObject))]
	interface GADAdLoader
	{
		[Wrap("WeakDelegate")] [NullAllowed] GADAdLoaderDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<GADAdLoaderDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic) NSString * _Nonnull adUnitID;
		[Export("adUnitID")] string AdUnitID { get; }

		// @property (readonly, getter = isLoading, nonatomic) BOOL loading;
		[Export("loading")] bool Loading { [Bind("isLoading")] get; }

		// -(instancetype _Nonnull)initWithAdUnitID:(NSString * _Nonnull)adUnitID rootViewController:(UIViewController * _Nullable)rootViewController adTypes:(NSArray<GADAdLoaderAdType> * _Nonnull)adTypes options:(NSArray<GADAdLoaderOptions *> * _Nullable)options;
		[Export("initWithAdUnitID:rootViewController:adTypes:options:")]
		NativeHandle Constructor(string adUnitID, [NullAllowed] UIViewController rootViewController, string[] adTypes,
			[NullAllowed] GADAdLoaderOptions[] options);

		// -(void)loadRequest:(GADRequest * _Nullable)request;
		[Export("loadRequest:")]
		void LoadRequest([NullAllowed] GADRequest request);
	}

	// @protocol GADAdMetadataProvider <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface GADAdMetadataProvider
	{
		// @required @property (readonly, nonatomic) NSDictionary<GADAdMetadataKey,id> * _Nullable adMetadata;
		[Abstract]
		[NullAllowed, Export("adMetadata")]
		NSDictionary<NSString, NSObject> AdMetadata { get; }

		[Wrap("WeakAdMetadataDelegate"), Abstract]
		[NullAllowed]
		GADAdMetadataDelegate AdMetadataDelegate { get; set; }

		// @required @property (nonatomic, weak) id<GADAdMetadataDelegate> _Nullable adMetadataDelegate;
		[Abstract]
		[NullAllowed, Export("adMetadataDelegate", ArgumentSemantic.Weak)]
		NSObject WeakAdMetadataDelegate { get; set; }
	}

	// @protocol GADAdMetadataDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GADAdMetadataDelegate
	{
		// @required -(void)adMetadataDidChange:(id<GADAdMetadataProvider> _Nonnull)ad;
		[Abstract]
		[Export("adMetadataDidChange:")]
		void AdMetadataDidChange(GADAdMetadataProvider ad);
	}

	// typedef void (^GADUserDidEarnRewardHandler)();
	delegate void GADUserDidEarnRewardHandler();

	// @interface GADAdReward : NSObject
	[BaseType(typeof(NSObject))]
	interface GADAdReward
	{
		// @property (readonly, nonatomic) NSString * _Nonnull type;
		[Export("type")] string Type { get; }

		// @property (readonly, nonatomic) NSDecimalNumber * _Nonnull amount;
		[Export("amount")] NSDecimalNumber Amount { get; }

		// -(instancetype _Nonnull)initWithRewardType:(NSString * _Nullable)rewardType rewardAmount:(NSDecimalNumber * _Nullable)rewardAmount __attribute__((objc_designated_initializer));
		[Export("initWithRewardType:rewardAmount:")]
		[DesignatedInitializer]
		NativeHandle Constructor([NullAllowed] string rewardType, [NullAllowed] NSDecimalNumber rewardAmount);
	}

	// @protocol GADAdSizeDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GADAdSizeDelegate
	{
		// @required -(void)adView:(GADBannerView * _Nonnull)bannerView willChangeAdSizeTo:(GADAdSize)size;
		[Abstract]
		[Export("adView:willChangeAdSizeTo:")]
		void WillChangeAdSizeTo(GADBannerView bannerView, GADAdSize size);
	}

	// typedef void (^GADPaidEventHandler)(GADAdValue * _Nonnull);
	delegate void GADPaidEventHandler(GADAdValue arg0);

	// @interface GADAdValue : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface GADAdValue : INSCopying
	{
		// @property (readonly, nonatomic) GADAdValuePrecision precision;
		[Export("precision")] GADAdValuePrecision Precision { get; }

		// @property (readonly, nonatomic) NSDecimalNumber * _Nonnull value;
		[Export("value")] NSDecimalNumber Value { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull currencyCode;
		[Export("currencyCode")] string CurrencyCode { get; }
	}

	// @protocol GADAppEventDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GADAppEventDelegate
	{
		// @optional -(void)adView:(GADBannerView * _Nonnull)banner didReceiveAppEvent:(NSString * _Nonnull)name withInfo:(NSString * _Nullable)info;
		[Export("adView:didReceiveAppEvent:withInfo:")]
		void AdViewDidReceiveAppEvent(GADBannerView banner, string name, [NullAllowed] string info);

		// @optional -(void)interstitialAd:(GADInterstitialAd * _Nonnull)interstitialAd didReceiveAppEvent:(NSString * _Nonnull)name withInfo:(NSString * _Nullable)info;
		[Export("interstitialAd:didReceiveAppEvent:withInfo:")]
		void InterstitialAdDidReceiveAppEvent(GADInterstitialAd interstitialAd, string name, [NullAllowed] string info);
	}

	// @protocol GADFullScreenPresentingAd <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface GADFullScreenPresentingAd
	{
		[Wrap("WeakFullScreenContentDelegate"), Abstract]
		[NullAllowed]
		GADFullScreenContentDelegate FullScreenContentDelegate { get; set; }

		// @required @property (nonatomic, weak) id<GADFullScreenContentDelegate> _Nullable fullScreenContentDelegate;
		[Abstract]
		[NullAllowed, Export("fullScreenContentDelegate", ArgumentSemantic.Weak)]
		NSObject WeakFullScreenContentDelegate { get; set; }
	}

	// @protocol GADFullScreenContentDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GADFullScreenContentDelegate
	{
		// @optional -(void)adDidRecordImpression:(id<GADFullScreenPresentingAd> _Nonnull)ad;
		[Export("adDidRecordImpression:")]
		void AdDidRecordImpression(GADFullScreenPresentingAd ad);

		// @optional -(void)adDidRecordClick:(id<GADFullScreenPresentingAd> _Nonnull)ad;
		[Export("adDidRecordClick:")]
		void AdDidRecordClick(GADFullScreenPresentingAd ad);

		// @optional -(void)ad:(id<GADFullScreenPresentingAd> _Nonnull)ad didFailToPresentFullScreenContentWithError:(NSError * _Nonnull)error;
		[Export("ad:didFailToPresentFullScreenContentWithError:")]
		void AdDidFailToPresentFullScreenContent(GADFullScreenPresentingAd ad, NSError error);

		// @optional -(void)adWillPresentFullScreenContent:(id<GADFullScreenPresentingAd> _Nonnull)ad;
		[Export("adWillPresentFullScreenContent:")]
		void AdWillPresentFullScreenContent(GADFullScreenPresentingAd ad);

		// @optional -(void)adWillDismissFullScreenContent:(id<GADFullScreenPresentingAd> _Nonnull)ad;
		[Export("adWillDismissFullScreenContent:")]
		void AdWillDismissFullScreenContent(GADFullScreenPresentingAd ad);

		// @optional -(void)adDidDismissFullScreenContent:(id<GADFullScreenPresentingAd> _Nonnull)ad;
		[Export("adDidDismissFullScreenContent:")]
		void AdDidDismissFullScreenContent(GADFullScreenPresentingAd ad);
	}

	// @interface GADAdNetworkResponseInfo : NSObject
	[BaseType(typeof(NSObject))]
	interface GADAdNetworkResponseInfo
	{
		// @property (readonly, nonatomic) NSString * _Nonnull adNetworkClassName;
		[Export("adNetworkClassName")] string AdNetworkClassName { get; }

		// @property (readonly, nonatomic) NSDictionary<NSString *,id> * _Nonnull adUnitMapping;
		[Export("adUnitMapping")] NSDictionary<NSString, NSObject> AdUnitMapping { get; }

		// @property (readonly, nonatomic) NSString * _Nullable adSourceName;
		[NullAllowed, Export("adSourceName")] string AdSourceName { get; }

		// @property (readonly, nonatomic) NSString * _Nullable adSourceID;
		[NullAllowed, Export("adSourceID")] string AdSourceID { get; }

		// @property (readonly, nonatomic) NSString * _Nullable adSourceInstanceName;
		[NullAllowed, Export("adSourceInstanceName")]
		string AdSourceInstanceName { get; }

		// @property (readonly, nonatomic) NSString * _Nullable adSourceInstanceID;
		[NullAllowed, Export("adSourceInstanceID")]
		string AdSourceInstanceID { get; }

		// @property (readonly, nonatomic) NSError * _Nullable error;
		[NullAllowed, Export("error")] NSError Error { get; }

		// @property (readonly, nonatomic) NSTimeInterval latency;
		[Export("latency")] double Latency { get; }

		// @property (readonly, nonatomic) NSDictionary<NSString *,id> * _Nonnull dictionaryRepresentation;
		[Export("dictionaryRepresentation")] NSDictionary<NSString, NSObject> DictionaryRepresentation { get; }
	}



	// @interface GADResponseInfo : NSObject
	[BaseType(typeof(NSObject))]
	interface GADResponseInfo
	{
		// @property (readonly, nonatomic) NSString * _Nullable responseIdentifier;
		[NullAllowed, Export("responseIdentifier")]
		string ResponseIdentifier { get; }

		// @property (readonly, nonatomic) NSDictionary<NSString *,id> * _Nonnull extrasDictionary;
		[Export("extrasDictionary")] NSDictionary<NSString, NSObject> ExtrasDictionary { get; }

		// @property (readonly, nonatomic) GADAdNetworkResponseInfo * _Nullable loadedAdNetworkResponseInfo;
		[NullAllowed, Export("loadedAdNetworkResponseInfo")]
		GADAdNetworkResponseInfo LoadedAdNetworkResponseInfo { get; }

		// @property (readonly, nonatomic) NSArray<GADAdNetworkResponseInfo *> * _Nonnull adNetworkInfoArray;
		[Export("adNetworkInfoArray")] GADAdNetworkResponseInfo[] AdNetworkInfoArray { get; }

		// @property (readonly, nonatomic) NSDictionary<NSString *,id> * _Nonnull dictionaryRepresentation;
		[Export("dictionaryRepresentation")] NSDictionary<NSString, NSObject> DictionaryRepresentation { get; }
	}

	// typedef void (^GADAppOpenAdLoadCompletionHandler)(GADAppOpenAd * _Nullable, NSError * _Nullable);
	delegate void GADAppOpenAdLoadCompletionHandler([NullAllowed] GADAppOpenAd arg0, [NullAllowed] NSError arg1);

	// @interface GADAppOpenAd : NSObject <GADFullScreenPresentingAd>
	[BaseType(typeof(NSObject))]
	interface GADAppOpenAd : GADFullScreenPresentingAd
	{
		// +(void)loadWithAdUnitID:(NSString * _Nonnull)adUnitID request:(GADRequest * _Nullable)request completionHandler:(GADAppOpenAdLoadCompletionHandler _Nonnull)completionHandler;
		[Static]
		[Export("loadWithAdUnitID:request:completionHandler:")]
		void Load(string adUnitID, [NullAllowed] GADRequest request,
			GADAppOpenAdLoadCompletionHandler completionHandler);

		[Wrap("WeakFullScreenContentDelegate")]
		[NullAllowed]
		GADFullScreenContentDelegate FullScreenContentDelegate { get; set; }

		// @property (nonatomic, weak) id<GADFullScreenContentDelegate> _Nullable fullScreenContentDelegate;
		[NullAllowed, Export("fullScreenContentDelegate", ArgumentSemantic.Weak)]
		NSObject WeakFullScreenContentDelegate { get; set; }

		// @property (readonly, nonatomic) GADResponseInfo * _Nonnull responseInfo;
		[Export("responseInfo")] GADResponseInfo ResponseInfo { get; }

		// @property (copy, nonatomic) GADPaidEventHandler _Nullable paidEventHandler;
		[NullAllowed, Export("paidEventHandler", ArgumentSemantic.Copy)]
		GADPaidEventHandler PaidEventHandler { get; set; }

		// -(BOOL)canPresentFromRootViewController:(UIViewController * _Nullable)rootViewController error:(NSError * _Nullable * _Nullable)error;
		[Export("canPresentFromRootViewController:error:")]
		bool CanPresentFromRootViewController([NullAllowed] UIViewController rootViewController,
			[NullAllowed] out NSError error);

		// -(void)presentFromRootViewController:(UIViewController * _Nullable)rootViewController;
		[Export("presentFromRootViewController:")]
		void PresentFromRootViewController([NullAllowed] UIViewController rootViewController);
	}

	// @protocol GADAudioVideoManagerDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GADAudioVideoManagerDelegate
	{
		// @optional -(void)audioVideoManagerWillPlayVideo:(GADAudioVideoManager * _Nonnull)audioVideoManager;
		[Export("audioVideoManagerWillPlayVideo:")]
		void AudioVideoManagerWillPlayVideo(GADAudioVideoManager audioVideoManager);

		// @optional -(void)audioVideoManagerDidPauseAllVideo:(GADAudioVideoManager * _Nonnull)audioVideoManager;
		[Export("audioVideoManagerDidPauseAllVideo:")]
		void AudioVideoManagerDidPauseAllVideo(GADAudioVideoManager audioVideoManager);

		// @optional -(void)audioVideoManagerWillPlayAudio:(GADAudioVideoManager * _Nonnull)audioVideoManager;
		[Export("audioVideoManagerWillPlayAudio:")]
		void AudioVideoManagerWillPlayAudio(GADAudioVideoManager audioVideoManager);

		// @optional -(void)audioVideoManagerDidStopPlayingAudio:(GADAudioVideoManager * _Nonnull)audioVideoManager;
		[Export("audioVideoManagerDidStopPlayingAudio:")]
		void AudioVideoManagerDidStopPlayingAudio(GADAudioVideoManager audioVideoManager);
	}

	// @interface GADAudioVideoManager : NSObject
	[BaseType(typeof(NSObject))]
	interface GADAudioVideoManager
	{
		[Wrap("WeakDelegate")] [NullAllowed] GADAudioVideoManagerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<GADAudioVideoManagerDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (assign, nonatomic) BOOL audioSessionIsApplicationManaged;
		[Export("audioSessionIsApplicationManaged")]
		bool AudioSessionIsApplicationManaged { get; set; }
	}

	// @protocol GADBannerViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GADBannerViewDelegate
	{
		// @optional -(void)bannerViewDidReceiveAd:(GADBannerView * _Nonnull)bannerView;
		[Export("bannerViewDidReceiveAd:")]
		void BannerViewDidReceiveAd(GADBannerView bannerView);

		// @optional -(void)bannerView:(GADBannerView * _Nonnull)bannerView didFailToReceiveAdWithError:(NSError * _Nonnull)error;
		[Export("bannerView:didFailToReceiveAdWithError:")]
		void BannerViewDidFailToReceiveAd(GADBannerView bannerView, NSError error);

		// @optional -(void)bannerViewDidRecordImpression:(GADBannerView * _Nonnull)bannerView;
		[Export("bannerViewDidRecordImpression:")]
		void BannerViewDidRecordImpression(GADBannerView bannerView);

		// @optional -(void)bannerViewDidRecordClick:(GADBannerView * _Nonnull)bannerView;
		[Export("bannerViewDidRecordClick:")]
		void BannerViewDidRecordClick(GADBannerView bannerView);

		// @optional -(void)bannerViewWillPresentScreen:(GADBannerView * _Nonnull)bannerView;
		[Export("bannerViewWillPresentScreen:")]
		void BannerViewWillPresentScreen(GADBannerView bannerView);

		// @optional -(void)bannerViewWillDismissScreen:(GADBannerView * _Nonnull)bannerView;
		[Export("bannerViewWillDismissScreen:")]
		void BannerViewWillDismissScreen(GADBannerView bannerView);

		// @optional -(void)bannerViewDidDismissScreen:(GADBannerView * _Nonnull)bannerView;
		[Export("bannerViewDidDismissScreen:")]
		void BannerViewDidDismissScreen(GADBannerView bannerView);
	}

	// @interface GADBannerView : UIView
	[BaseType(typeof(UIView))]
	interface GADBannerView
	{
		// -(instancetype _Nonnull)initWithAdSize:(GADAdSize)adSize origin:(CGPoint)origin;
		[Export("initWithAdSize:origin:")]
		NativeHandle Constructor(GADAdSize adSize, CGPoint origin);

		// -(instancetype _Nonnull)initWithAdSize:(GADAdSize)adSize;
		[Export("initWithAdSize:")]
		NativeHandle Constructor(GADAdSize adSize);

		// @property (copy, nonatomic) NSString * _Nullable adUnitID;
		[NullAllowed, Export("adUnitID")] string AdUnitID { get; set; }

		// @property (nonatomic, weak) UIViewController * _Nullable rootViewController __attribute__((iboutlet));
		[NullAllowed, Export("rootViewController", ArgumentSemantic.Weak)]
		UIViewController RootViewController { get; set; }

		// @property (assign, nonatomic) GADAdSize adSize;
		[Export("adSize", ArgumentSemantic.Assign)]
		GADAdSize AdSize { get; set; }

		[Wrap("WeakDelegate")] [NullAllowed] GADBannerViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<GADBannerViewDelegate> _Nullable delegate __attribute__((iboutlet));
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		[Wrap("WeakAdSizeDelegate")]
		[NullAllowed]
		GADAdSizeDelegate AdSizeDelegate { get; set; }

		// @property (nonatomic, weak) id<GADAdSizeDelegate> _Nullable adSizeDelegate __attribute__((iboutlet));
		[NullAllowed, Export("adSizeDelegate", ArgumentSemantic.Weak)]
		NSObject WeakAdSizeDelegate { get; set; }

		// -(void)loadRequest:(GADRequest * _Nullable)request;
		[Export("loadRequest:")]
		void LoadRequest([NullAllowed] GADRequest request);

		// @property (getter = isAutoloadEnabled, assign, nonatomic) BOOL autoloadEnabled;
		[Export("autoloadEnabled")] bool AutoloadEnabled { [Bind("isAutoloadEnabled")] get; set; }

		// @property (readonly, nonatomic) GADResponseInfo * _Nullable responseInfo;
		[NullAllowed, Export("responseInfo")] GADResponseInfo ResponseInfo { get; }

		// @property (copy, nonatomic) GADPaidEventHandler _Nullable paidEventHandler;
		[NullAllowed, Export("paidEventHandler", ArgumentSemantic.Copy)]
		GADPaidEventHandler PaidEventHandler { get; set; }
	}

	// @protocol GADCustomEventBannerDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GADCustomEventBannerDelegate
	{
		// @required -(void)customEventBanner:(id<GADCustomEventBanner> _Nonnull)customEvent didReceiveAd:(UIView * _Nonnull)view;
		[Abstract]
		[Export("customEventBanner:didReceiveAd:")]
		void CustomEventBannerDidReceiveAd(GADCustomEventBanner customEvent, UIView view);

		// @required -(void)customEventBanner:(id<GADCustomEventBanner> _Nonnull)customEvent didFailAd:(NSError * _Nullable)error;
		[Abstract]
		[Export("customEventBanner:didFailAd:")]
		void CustomEventBannerDidFailAd(GADCustomEventBanner customEvent, [NullAllowed] NSError error);

		// @required -(void)customEventBannerWasClicked:(id<GADCustomEventBanner> _Nonnull)customEvent;
		[Abstract]
		[Export("customEventBannerWasClicked:")]
		void CustomEventBannerWasClicked(GADCustomEventBanner customEvent);

		// @required @property (readonly, nonatomic) UIViewController * _Nonnull viewControllerForPresentingModalView;
		[Abstract]
		[Export("viewControllerForPresentingModalView")]
		UIViewController ViewControllerForPresentingModalView { get; }

		// @required -(void)customEventBannerWillPresentModal:(id<GADCustomEventBanner> _Nonnull)customEvent;
		[Abstract]
		[Export("customEventBannerWillPresentModal:")]
		void CustomEventBannerWillPresentModal(GADCustomEventBanner customEvent);

		// @required -(void)customEventBannerWillDismissModal:(id<GADCustomEventBanner> _Nonnull)customEvent;
		[Abstract]
		[Export("customEventBannerWillDismissModal:")]
		void CustomEventBannerWillDismissModal(GADCustomEventBanner customEvent);

		// @required -(void)customEventBannerDidDismissModal:(id<GADCustomEventBanner> _Nonnull)customEvent;
		[Abstract]
		[Export("customEventBannerDidDismissModal:")]
		void CustomEventBannerDidDismissModal(GADCustomEventBanner customEvent);

		// @required -(void)customEventBanner:(id<GADCustomEventBanner> _Nonnull)customEvent clickDidOccurInAd:(UIView * _Nonnull)view __attribute__((deprecated("Use customEventBannerWasClicked:.")));
		[Abstract]
		[Export("customEventBanner:clickDidOccurInAd:")]
		void CustomEventBannerClickDidOccurInAd(GADCustomEventBanner customEvent, UIView view);

		// @required -(void)customEventBannerWillLeaveApplication:(id<GADCustomEventBanner> _Nonnull)customEvent __attribute__((deprecated("Deprecated. No replacement.")));
		[Abstract]
		[Export("customEventBannerWillLeaveApplication:")]
		void CustomEventBannerWillLeaveApplication(GADCustomEventBanner customEvent);
	}

	// @interface GADCustomEventRequest : NSObject
	[BaseType(typeof(NSObject))]
	interface GADCustomEventRequest
	{
		// @property (readonly, copy, nonatomic) NSArray * _Nullable userKeywords;
		[NullAllowed, Export("userKeywords", ArgumentSemantic.Copy)]
		NSObject[] UserKeywords { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nullable additionalParameters;
		[NullAllowed, Export("additionalParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalParameters { get; }

		// @property (readonly, assign, nonatomic) BOOL isTesting;
		[Export("isTesting")] bool IsTesting { get; }
	}

	// @protocol GADCustomEventBanner <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface GADCustomEventBanner
	{
		[Wrap("WeakDelegate"), Abstract]
		[NullAllowed]
		GADCustomEventBannerDelegate Delegate { get; set; }

		// @required @property (nonatomic, weak) id<GADCustomEventBannerDelegate> _Nullable delegate;
		[Abstract]
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @required -(void)requestBannerAd:(GADAdSize)adSize parameter:(NSString * _Nullable)serverParameter label:(NSString * _Nullable)serverLabel request:(GADCustomEventRequest * _Nonnull)request;
		[Abstract]
		[Export("requestBannerAd:parameter:label:request:")]
		void RequestBannerAd(GADAdSize adSize, [NullAllowed] string serverParameter, [NullAllowed] string serverLabel,
			GADCustomEventRequest request);
	}

	// @interface GADCustomEventExtras : NSObject <GADAdNetworkExtras>
	[BaseType(typeof(NSObject))]
	interface GADCustomEventExtras : GADAdNetworkExtras
	{
		// -(void)setExtras:(NSDictionary * _Nullable)extras forLabel:(NSString * _Nonnull)label;
		[Export("setExtras:forLabel:")]
		void SetExtras([NullAllowed] NSDictionary extras, string label);

		// -(NSDictionary * _Nullable)extrasForLabel:(NSString * _Nonnull)label;
		[Export("extrasForLabel:")]
		[return: NullAllowed]
		NSDictionary ExtrasForLabel(string label);

		// -(void)removeAllExtras;
		[Export("removeAllExtras")]
		void RemoveAllExtras();

		// -(NSDictionary * _Nonnull)allExtras;
		[Export("allExtras")] NSDictionary AllExtras { get; }
	}

	// @protocol GADCustomEventInterstitialDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GADCustomEventInterstitialDelegate
	{
		// @required -(void)customEventInterstitialDidReceiveAd:(id<GADCustomEventInterstitial> _Nonnull)customEvent;
		[Abstract]
		[Export("customEventInterstitialDidReceiveAd:")]
		void CustomEventInterstitialDidReceiveAd(GADCustomEventInterstitial customEvent);

		// @required -(void)customEventInterstitial:(id<GADCustomEventInterstitial> _Nonnull)customEvent didFailAd:(NSError * _Nullable)error;
		[Abstract]
		[Export("customEventInterstitial:didFailAd:")]
		void CustomEventInterstitialDidFailAd(GADCustomEventInterstitial customEvent, [NullAllowed] NSError error);

		// @required -(void)customEventInterstitialWasClicked:(id<GADCustomEventInterstitial> _Nonnull)customEvent;
		[Abstract]
		[Export("customEventInterstitialWasClicked:")]
		void CustomEventInterstitialWasClicked(GADCustomEventInterstitial customEvent);

		// @required -(void)customEventInterstitialWillPresent:(id<GADCustomEventInterstitial> _Nonnull)customEvent;
		[Abstract]
		[Export("customEventInterstitialWillPresent:")]
		void CustomEventInterstitialWillPresent(GADCustomEventInterstitial customEvent);

		// @required -(void)customEventInterstitialWillDismiss:(id<GADCustomEventInterstitial> _Nonnull)customEvent;
		[Abstract]
		[Export("customEventInterstitialWillDismiss:")]
		void CustomEventInterstitialWillDismiss(GADCustomEventInterstitial customEvent);

		// @required -(void)customEventInterstitialDidDismiss:(id<GADCustomEventInterstitial> _Nonnull)customEvent;
		[Abstract]
		[Export("customEventInterstitialDidDismiss:")]
		void CustomEventInterstitialDidDismiss(GADCustomEventInterstitial customEvent);

		// @required -(void)customEventInterstitial:(id<GADCustomEventInterstitial> _Nonnull)customEvent didReceiveAd:(NSObject * _Nonnull)ad __attribute__((deprecated("Use customEventInterstitialDidReceiveAd:.")));
		[Abstract]
		[Export("customEventInterstitial:didReceiveAd:")]
		void CustomEventInterstitialDidReceiveAd(GADCustomEventInterstitial customEvent, NSObject ad);

		// @required -(void)customEventInterstitialWillLeaveApplication:(id<GADCustomEventInterstitial> _Nonnull)customEvent __attribute__((deprecated("Deprecated. No replacement.")));
		[Abstract]
		[Export("customEventInterstitialWillLeaveApplication:")]
		void CustomEventInterstitialWillLeaveApplication(GADCustomEventInterstitial customEvent);
	}

	// @protocol GADCustomEventInterstitial <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface GADCustomEventInterstitial
	{
		[Wrap("WeakDelegate"), Abstract]
		[NullAllowed]
		GADCustomEventInterstitialDelegate Delegate { get; set; }

		// @required @property (nonatomic, weak) id<GADCustomEventInterstitialDelegate> _Nullable delegate;
		[Abstract]
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @required -(void)requestInterstitialAdWithParameter:(NSString * _Nullable)serverParameter label:(NSString * _Nullable)serverLabel request:(GADCustomEventRequest * _Nonnull)request;
		[Abstract]
		[Export("requestInterstitialAdWithParameter:label:request:")]
		void RequestInterstitialAd([NullAllowed] string serverParameter, [NullAllowed] string serverLabel,
			GADCustomEventRequest request);

		// @required -(void)presentFromRootViewController:(UIViewController * _Nonnull)rootViewController;
		[Abstract]
		[Export("presentFromRootViewController:")]
		void PresentFromRootViewController(UIViewController rootViewController);
	}

	// @protocol GADCustomEventNativeAd <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface GADCustomEventNativeAd
	{
		[Wrap("WeakDelegate"), Abstract]
		[NullAllowed]
		GADCustomEventNativeAdDelegate Delegate { get; set; }

		// @required @property (nonatomic, weak) id<GADCustomEventNativeAdDelegate> _Nullable delegate;
		[Abstract]
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @required -(void)requestNativeAdWithParameter:(NSString * _Nonnull)serverParameter request:(GADCustomEventRequest * _Nonnull)request adTypes:(NSArray * _Nonnull)adTypes options:(NSArray * _Nonnull)options rootViewController:(UIViewController * _Nonnull)rootViewController;
		[Abstract]
		[Export("requestNativeAdWithParameter:request:adTypes:options:rootViewController:")]
		void RequestNativeAd(string serverParameter, GADCustomEventRequest request, NSObject[] adTypes, NSObject[] options,
			UIViewController rootViewController);

		// @required -(BOOL)handlesUserClicks;
		[Abstract]
		[Export("handlesUserClicks")]
		bool HandlesUserClicks { get; }

		// @required -(BOOL)handlesUserImpressions;
		[Abstract]
		[Export("handlesUserImpressions")]
		bool HandlesUserImpressions { get; }
	}

	// @interface GADNativeAdImage : NSObject
	[BaseType(typeof(NSObject))]
	interface GADNativeAdImage
	{
		// @property (readonly, nonatomic, strong) UIImage * _Nullable image;
		[NullAllowed, Export("image", ArgumentSemantic.Strong)]
		UIImage Image { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nullable imageURL;
		[NullAllowed, Export("imageURL", ArgumentSemantic.Copy)]
		NSUrl ImageURL { get; }

		// @property (readonly, assign, nonatomic) CGFloat scale;
		[Export("scale")] nfloat Scale { get; }

		// From Category GADNativeAdImage_MediationAdditions
		// -(instancetype _Nonnull)initWithImage:(UIImage * _Nonnull)image;
		[Export("initWithImage:")]
		NativeHandle Constructor(UIImage image);

		// -(instancetype _Nonnull)initWithURL:(NSURL * _Nonnull)URL scale:(CGFloat)scale;
		[Export("initWithURL:scale:")]
		NativeHandle Constructor(NSUrl URL, nfloat scale);
	}

	// @protocol GADMediatedUnifiedNativeAd <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface GADMediatedUnifiedNativeAd
	{
		// @required @property (readonly, copy, nonatomic) NSString * _Nullable headline;
		[Abstract]
		[NullAllowed, Export("headline")]
		string Headline { get; }

		// @required @property (readonly, nonatomic) NSArray<GADNativeAdImage *> * _Nullable images;
		[Abstract]
		[NullAllowed, Export("images")]
		GADNativeAdImage[] Images { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nullable body;
		[Abstract]
		[NullAllowed, Export("body")]
		string Body { get; }

		// @required @property (readonly, nonatomic) GADNativeAdImage * _Nullable icon;
		[Abstract]
		[NullAllowed, Export("icon")]
		GADNativeAdImage Icon { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nullable callToAction;
		[Abstract]
		[NullAllowed, Export("callToAction")]
		string CallToAction { get; }

		// @required @property (readonly, copy, nonatomic) NSDecimalNumber * _Nullable starRating;
		[Abstract]
		[NullAllowed, Export("starRating", ArgumentSemantic.Copy)]
		NSDecimalNumber StarRating { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nullable store;
		[Abstract]
		[NullAllowed, Export("store")]
		string Store { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nullable price;
		[Abstract]
		[NullAllowed, Export("price")]
		string Price { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nullable advertiser;
		[Abstract]
		[NullAllowed, Export("advertiser")]
		string Advertiser { get; }

		// @required @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nullable extraAssets;
		[Abstract]
		[NullAllowed, Export("extraAssets", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> ExtraAssets { get; }

		// @optional @property (readonly, nonatomic) UIView * _Nullable adChoicesView;
		[NullAllowed, Export("adChoicesView")] UIView AdChoicesView { get; }

		// @optional @property (readonly, nonatomic) UIView * _Nullable mediaView;
		[NullAllowed, Export("mediaView")] UIView MediaView { get; }

		// @optional @property (readonly, nonatomic) BOOL hasVideoContent;
		[Export("hasVideoContent")] bool HasVideoContent { get; }

		// @optional @property (readonly, nonatomic) CGFloat mediaContentAspectRatio;
		[Export("mediaContentAspectRatio")] nfloat MediaContentAspectRatio { get; }

		// @optional @property (readonly, nonatomic) NSTimeInterval duration;
		[Export("duration")] double Duration { get; }

		// @optional @property (readonly, nonatomic) NSTimeInterval currentTime;
		[Export("currentTime")] double CurrentTime { get; }

		// @optional -(void)didRenderInView:(UIView * _Nonnull)view clickableAssetViews:(NSDictionary<GADNativeAssetIdentifier,UIView *> * _Nonnull)clickableAssetViews nonclickableAssetViews:(NSDictionary<GADNativeAssetIdentifier,UIView *> * _Nonnull)nonclickableAssetViews viewController:(UIViewController * _Nonnull)viewController;
		[Export("didRenderInView:clickableAssetViews:nonclickableAssetViews:viewController:")]
		void DidRenderInView(UIView view, NSDictionary<NSString, UIView> clickableAssetViews,
			NSDictionary<NSString, UIView> nonclickableAssetViews, UIViewController viewController);

		// @optional -(void)didRecordImpression;
		[Export("didRecordImpression")]
		void DidRecordImpression();

		// @optional -(void)didRecordClickOnAssetWithName:(GADNativeAssetIdentifier _Nonnull)assetName view:(UIView * _Nonnull)view viewController:(UIViewController * _Nonnull)viewController;
		[Export("didRecordClickOnAssetWithName:view:viewController:")]
		void DidRecordClickOnAssetWithName(string assetName, UIView view, UIViewController viewController);

		// @optional -(void)didUntrackView:(UIView * _Nullable)view;
		[Export("didUntrackView:")]
		void DidUntrackView([NullAllowed] UIView view);
	}

	// @protocol GADCustomEventNativeAdDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GADCustomEventNativeAdDelegate
	{
		// @required -(void)customEventNativeAd:(id<GADCustomEventNativeAd> _Nonnull)customEventNativeAd didFailToLoadWithError:(NSError * _Nonnull)error;
		[Abstract]
		[Export("customEventNativeAd:didFailToLoadWithError:")]
		void DidFailToLoadWithError(GADCustomEventNativeAd customEventNativeAd, NSError error);

		// @required -(void)customEventNativeAd:(id<GADCustomEventNativeAd> _Nonnull)customEventNativeAd didReceiveMediatedUnifiedNativeAd:(id<GADMediatedUnifiedNativeAd> _Nonnull)mediatedUnifiedNativeAd;
		[Abstract]
		[Export("customEventNativeAd:didReceiveMediatedUnifiedNativeAd:")]
		void DidReceiveMediatedUnifiedNativeAd(GADCustomEventNativeAd customEventNativeAd,
			GADMediatedUnifiedNativeAd mediatedUnifiedNativeAd);
	}

	// @interface GADDisplayAdMeasurement : NSObject
	[BaseType(typeof(NSObject))]
	interface GADDisplayAdMeasurement
	{
		// @property (nonatomic, weak) UIView * _Nullable view;
		[NullAllowed, Export("view", ArgumentSemantic.Weak)]
		UIView View { get; set; }

		// -(BOOL)startWithError:(NSError * _Nullable * _Nullable)error;
		[Export("startWithError:")]
		bool Start([NullAllowed] out NSError error);
	}

	// @interface GADVideoController : NSObject
	[BaseType(typeof(NSObject))]
	interface GADVideoController
	{
		[Wrap("WeakDelegate")] [NullAllowed] GADVideoControllerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<GADVideoControllerDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic) BOOL isMuted;
		[Export("isMuted")] bool IsMuted { get; }

		// -(void)setMute:(BOOL)mute;
		[Export("setMute:")]
		void SetMute(bool mute);

		// -(void)play;
		[Export("play")]
		void Play();

		// -(void)pause;
		[Export("pause")]
		void Pause();

		// -(void)stop;
		[Export("stop")]
		void Stop();

		// -(BOOL)customControlsEnabled;
		[Export("customControlsEnabled")] bool CustomControlsEnabled { get; }

		// -(BOOL)clickToExpandEnabled;
		[Export("clickToExpandEnabled")] bool ClickToExpandEnabled { get; }
	}

	// @interface GADMediaContent : NSObject
	[BaseType(typeof(NSObject))]
	interface GADMediaContent
	{
		// @property (readonly, nonatomic) GADVideoController * _Nonnull videoController;
		[Export("videoController")] GADVideoController VideoController { get; }

		// @property (readonly, nonatomic) BOOL hasVideoContent;
		[Export("hasVideoContent")] bool HasVideoContent { get; }

		// @property (readonly, nonatomic) CGFloat aspectRatio;
		[Export("aspectRatio")] nfloat AspectRatio { get; }

		// @property (readonly, nonatomic) NSTimeInterval duration;
		[Export("duration")] double Duration { get; }

		// @property (readonly, nonatomic) NSTimeInterval currentTime;
		[Export("currentTime")] double CurrentTime { get; }

		// From Category: GADMediaContent_NativeAd
		// @property (nonatomic) UIImage * _Nullable mainImage;
		[NullAllowed, Export("mainImage", ArgumentSemantic.Assign)]
		UIImage MainImage { get; set; }
	}

	// // @interface NativeAd (GADMediaContent)
	// [Category]
	// [BaseType(typeof(GADMediaContent))]
	// interface GADMediaContent_NativeAd
	// {
	// 	// @property (nonatomic) UIImage * _Nullable mainImage;
	// 	[NullAllowed, Export("mainImage", ArgumentSemantic.Assign)]
	// 	UIImage MainImage { get; set; }
	// }

	// @interface GADMediaView : UIView
	[BaseType(typeof(UIView))]
	interface GADMediaView
	{
		// @property (nonatomic) GADMediaContent * _Nullable mediaContent;
		[NullAllowed, Export("mediaContent", ArgumentSemantic.Assign)]
		GADMediaContent MediaContent { get; set; }
	}

	// typedef void (^GADNativeAdCustomClickHandler)(NSString * _Nonnull);
	delegate void GADNativeAdCustomClickHandler(string arg0);

	// @interface GADCustomNativeAd : NSObject
	[BaseType(typeof(NSObject))]
	interface GADCustomNativeAd
	{
		// @property (readonly, nonatomic) NSString * _Nonnull formatID;
		[Export("formatID")] string FormatID { get; }

		// @property (readonly, nonatomic) NSArray<NSString *> * _Nonnull availableAssetKeys;
		[Export("availableAssetKeys")] string[] AvailableAssetKeys { get; }

		// @property (copy, atomic) GADNativeAdCustomClickHandler _Nullable customClickHandler;
		[NullAllowed, Export("customClickHandler", ArgumentSemantic.Copy)]
		GADNativeAdCustomClickHandler CustomClickHandler { get; set; }

		// @property (readonly, nonatomic) GADDisplayAdMeasurement * _Nullable displayAdMeasurement;
		[NullAllowed, Export("displayAdMeasurement")]
		GADDisplayAdMeasurement DisplayAdMeasurement { get; }

		// @property (readonly, nonatomic) GADMediaContent * _Nonnull mediaContent;
		[Export("mediaContent")] GADMediaContent MediaContent { get; }

		[Wrap("WeakDelegate")] [NullAllowed] GADCustomNativeAdDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<GADCustomNativeAdDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, weak) UIViewController * _Nullable rootViewController;
		[NullAllowed, Export("rootViewController", ArgumentSemantic.Weak)]
		UIViewController RootViewController { get; set; }

		// @property (readonly, nonatomic) GADResponseInfo * _Nonnull responseInfo;
		[Export("responseInfo")] GADResponseInfo ResponseInfo { get; }

		// -(GADNativeAdImage * _Nullable)imageForKey:(NSString * _Nonnull)key;
		[Export("imageForKey:")]
		[return: NullAllowed]
		GADNativeAdImage ImageForKey(string key);

		// -(NSString * _Nullable)stringForKey:(NSString * _Nonnull)key;
		[Export("stringForKey:")]
		[return: NullAllowed]
		string StringForKey(string key);

		// -(void)performClickOnAssetWithKey:(NSString * _Nonnull)assetKey;
		[Export("performClickOnAssetWithKey:")]
		void PerformClickOnAssetWithKey(string assetKey);

		// -(void)recordImpression;
		[Export("recordImpression")]
		void RecordImpression();
	}

	interface IGADAdLoaderDelegate
	{
	}

	// @protocol GADCustomNativeAdLoaderDelegate <GADAdLoaderDelegate>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GADCustomNativeAdLoaderDelegate : GADAdLoaderDelegate
	{
		// @required -(NSArray<NSString *> * _Nonnull)customNativeAdFormatIDsForAdLoader:(GADAdLoader * _Nonnull)adLoader;
		[Abstract]
		[Export("customNativeAdFormatIDsForAdLoader:")]
		string[] GetCustomNativeAdFormatIDs(GADAdLoader adLoader);

		// @required -(void)adLoader:(GADAdLoader * _Nonnull)adLoader didReceiveCustomNativeAd:(GADCustomNativeAd * _Nonnull)customNativeAd;
		[Abstract]
		[Export("adLoader:didReceiveCustomNativeAd:")]
		void AdLoaderDidReceiveCustomNativeAd(GADAdLoader adLoader, GADCustomNativeAd customNativeAd);
	}

	// @protocol GADCustomNativeAdDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GADCustomNativeAdDelegate
	{
		// @optional -(void)customNativeAdDidRecordImpression:(GADCustomNativeAd * _Nonnull)nativeAd;
		[Export("customNativeAdDidRecordImpression:")]
		void CustomNativeAdDidRecordImpression(GADCustomNativeAd nativeAd);

		// @optional -(void)customNativeAdDidRecordClick:(GADCustomNativeAd * _Nonnull)nativeAd;
		[Export("customNativeAdDidRecordClick:")]
		void CustomNativeAdDidRecordClick(GADCustomNativeAd nativeAd);

		// @optional -(void)customNativeAdWillPresentScreen:(GADCustomNativeAd * _Nonnull)nativeAd;
		[Export("customNativeAdWillPresentScreen:")]
		void CustomNativeAdWillPresentScreen(GADCustomNativeAd nativeAd);

		// @optional -(void)customNativeAdWillDismissScreen:(GADCustomNativeAd * _Nonnull)nativeAd;
		[Export("customNativeAdWillDismissScreen:")]
		void CustomNativeAdWillDismissScreen(GADCustomNativeAd nativeAd);

		// @optional -(void)customNativeAdDidDismissScreen:(GADCustomNativeAd * _Nonnull)nativeAd;
		[Export("customNativeAdDidDismissScreen:")]
		void CustomNativeAdDidDismissScreen(GADCustomNativeAd nativeAd);
	}

	// @protocol GADDebugOptionsViewControllerDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GADDebugOptionsViewControllerDelegate
	{
		// @required -(void)debugOptionsViewControllerDidDismiss:(GADDebugOptionsViewController * _Nonnull)controller;
		[Abstract]
		[Export("debugOptionsViewControllerDidDismiss:")]
		void DebugOptionsViewControllerDidDismiss(GADDebugOptionsViewController controller);
	}

	// @interface GADDebugOptionsViewController : UIViewController
	[BaseType(typeof(UIViewController))]
	interface GADDebugOptionsViewController
	{
		// +(instancetype _Nonnull)debugOptionsViewControllerWithAdUnitID:(NSString * _Nonnull)adUnitID;
		[Static]
		[Export("debugOptionsViewControllerWithAdUnitID:")]
		GADDebugOptionsViewController DebugOptionsViewControllerWithAdUnitID(string adUnitID);

		[Wrap("WeakDelegate")] [NullAllowed] GADDebugOptionsViewControllerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<GADDebugOptionsViewControllerDelegate> _Nullable delegate __attribute__((iboutlet));
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }
	}

	// @interface GADDynamicHeightSearchRequest : GADRequest
	[BaseType(typeof(GADRequest))]
	interface GADDynamicHeightSearchRequest
	{
		// @property (copy, nonatomic) NSString * _Nullable query;
		[NullAllowed, Export("query")] string Query { get; set; }

		// @property (assign, nonatomic) NSInteger adPage;
		[Export("adPage")] nint AdPage { get; set; }

		// @property (assign, nonatomic) BOOL adTestEnabled;
		[Export("adTestEnabled")] bool AdTestEnabled { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable channel;
		[NullAllowed, Export("channel")] string Channel { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable hostLanguage;
		[NullAllowed, Export("hostLanguage")] string HostLanguage { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable locationExtensionTextColor;
		[NullAllowed, Export("locationExtensionTextColor")]
		string LocationExtensionTextColor { get; set; }

		// @property (assign, nonatomic) CGFloat locationExtensionFontSize;
		[Export("locationExtensionFontSize")] nfloat LocationExtensionFontSize { get; set; }

		// @property (assign, nonatomic) BOOL clickToCallExtensionEnabled;
		[Export("clickToCallExtensionEnabled")]
		bool ClickToCallExtensionEnabled { get; set; }

		// @property (assign, nonatomic) BOOL locationExtensionEnabled;
		[Export("locationExtensionEnabled")] bool LocationExtensionEnabled { get; set; }

		// @property (assign, nonatomic) BOOL plusOnesExtensionEnabled;
		[Export("plusOnesExtensionEnabled")] bool PlusOnesExtensionEnabled { get; set; }

		// @property (assign, nonatomic) BOOL sellerRatingsExtensionEnabled;
		[Export("sellerRatingsExtensionEnabled")]
		bool SellerRatingsExtensionEnabled { get; set; }

		// @property (assign, nonatomic) BOOL siteLinksExtensionEnabled;
		[Export("siteLinksExtensionEnabled")] bool SiteLinksExtensionEnabled { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable CSSWidth;
		[NullAllowed, Export("CSSWidth")] string CSSWidth { get; set; }

		// @property (assign, nonatomic) NSInteger numberOfAds;
		[Export("numberOfAds")] nint NumberOfAds { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable fontFamily;
		[NullAllowed, Export("fontFamily")] string FontFamily { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable attributionFontFamily;
		[NullAllowed, Export("attributionFontFamily")]
		string AttributionFontFamily { get; set; }

		// @property (assign, nonatomic) CGFloat annotationFontSize;
		[Export("annotationFontSize")] nfloat AnnotationFontSize { get; set; }

		// @property (assign, nonatomic) CGFloat attributionFontSize;
		[Export("attributionFontSize")] nfloat AttributionFontSize { get; set; }

		// @property (assign, nonatomic) CGFloat descriptionFontSize;
		[Export("descriptionFontSize")] nfloat DescriptionFontSize { get; set; }

		// @property (assign, nonatomic) CGFloat domainLinkFontSize;
		[Export("domainLinkFontSize")] nfloat DomainLinkFontSize { get; set; }

		// @property (assign, nonatomic) CGFloat titleFontSize;
		[Export("titleFontSize")] nfloat TitleFontSize { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable adBorderColor;
		[NullAllowed, Export("adBorderColor")] string AdBorderColor { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable adSeparatorColor;
		[NullAllowed, Export("adSeparatorColor")]
		string AdSeparatorColor { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable annotationTextColor;
		[NullAllowed, Export("annotationTextColor")]
		string AnnotationTextColor { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable attributionTextColor;
		[NullAllowed, Export("attributionTextColor")]
		string AttributionTextColor { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable backgroundColor;
		[NullAllowed, Export("backgroundColor")]
		string BackgroundColor { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable borderColor;
		[NullAllowed, Export("borderColor")] string BorderColor { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable domainLinkColor;
		[NullAllowed, Export("domainLinkColor")]
		string DomainLinkColor { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable textColor;
		[NullAllowed, Export("textColor")] string TextColor { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable titleLinkColor;
		[NullAllowed, Export("titleLinkColor")]
		string TitleLinkColor { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable adBorderCSSSelections;
		[NullAllowed, Export("adBorderCSSSelections")]
		string AdBorderCSSSelections { get; set; }

		// @property (assign, nonatomic) CGFloat adjustableLineHeight;
		[Export("adjustableLineHeight")] nfloat AdjustableLineHeight { get; set; }

		// @property (assign, nonatomic) CGFloat attributionBottomSpacing;
		[Export("attributionBottomSpacing")] nfloat AttributionBottomSpacing { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable borderCSSSelections;
		[NullAllowed, Export("borderCSSSelections")]
		string BorderCSSSelections { get; set; }

		// @property (assign, nonatomic) BOOL titleUnderlineHidden;
		[Export("titleUnderlineHidden")] bool TitleUnderlineHidden { get; set; }

		// @property (assign, nonatomic) BOOL boldTitleEnabled;
		[Export("boldTitleEnabled")] bool BoldTitleEnabled { get; set; }

		// @property (assign, nonatomic) CGFloat verticalSpacing;
		[Export("verticalSpacing")] nfloat VerticalSpacing { get; set; }

		// @property (assign, nonatomic) BOOL detailedAttributionExtensionEnabled;
		[Export("detailedAttributionExtensionEnabled")]
		bool DetailedAttributionExtensionEnabled { get; set; }

		// @property (assign, nonatomic) BOOL longerHeadlinesExtensionEnabled;
		[Export("longerHeadlinesExtensionEnabled")]
		bool LongerHeadlinesExtensionEnabled { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable styleID;
		[NullAllowed, Export("styleID")] string StyleID { get; set; }

		// -(void)setAdvancedOptionValue:(id _Nonnull)value forKey:(NSString * _Nonnull)key;
		[Export("setAdvancedOptionValue:forKey:")]
		void SetAdvancedOptionValue(NSObject value, string key);
	}


	// @interface GADExtras : NSObject <GADAdNetworkExtras>
	[BaseType(typeof(NSObject))]
	interface GADExtras : GADAdNetworkExtras
	{
		// @property (copy, nonatomic) NSDictionary * _Nullable additionalParameters;
		[NullAllowed, Export("additionalParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalParameters { get; set; }
	}

	// @interface GADAdapterStatus : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface GADAdapterStatus : INSCopying
	{
		// @property (readonly, nonatomic) GADAdapterInitializationState state;
		[Export("state")] GADAdapterInitializationState State { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull description;
		[Export("description")] string Description { get; }

		// @property (readonly, nonatomic) NSTimeInterval latency;
		[Export("latency")] double Latency { get; }
	}

	// @interface GADInitializationStatus : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface GADInitializationStatus : INSCopying
	{
		// @property (readonly, nonatomic) NSDictionary<NSString *,GADAdapterStatus *> * _Nonnull adapterStatusesByClassName;
		[Export("adapterStatusesByClassName")]
		NSDictionary<NSString, GADAdapterStatus> AdapterStatusesByClassName { get; }
	}

	// @interface GADServerSideVerificationOptions : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface GADServerSideVerificationOptions : INSCopying
	{
		// @property (copy, nonatomic) NSString * _Nullable userIdentifier;
		[NullAllowed, Export("userIdentifier")]
		string UserIdentifier { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable customRewardString;
		[NullAllowed, Export("customRewardString")]
		string CustomRewardString { get; set; }
	}

	// typedef void (^GADInterstitialAdLoadCompletionHandler)(GADInterstitialAd * _Nullable, NSError * _Nullable);
	delegate void GADInterstitialAdLoadCompletionHandler([NullAllowed] GADInterstitialAd arg0,
		[NullAllowed] NSError arg1);

	// @interface GADInterstitialAd : NSObject <GADFullScreenPresentingAd>
	[BaseType(typeof(NSObject))]
	interface GADInterstitialAd : GADFullScreenPresentingAd
	{
		// @property (readonly, nonatomic) NSString * _Nonnull adUnitID;
		[Export("adUnitID")] string AdUnitID { get; }

		// @property (readonly, nonatomic) GADResponseInfo * _Nonnull responseInfo;
		[Export("responseInfo")] GADResponseInfo ResponseInfo { get; }

		[Wrap("WeakFullScreenContentDelegate")]
		[NullAllowed]
		GADFullScreenContentDelegate FullScreenContentDelegate { get; set; }

		// @property (nonatomic, weak) id<GADFullScreenContentDelegate> _Nullable fullScreenContentDelegate;
		[NullAllowed, Export("fullScreenContentDelegate", ArgumentSemantic.Weak)]
		NSObject WeakFullScreenContentDelegate { get; set; }

		// @property (copy, nonatomic) GADPaidEventHandler _Nullable paidEventHandler;
		[NullAllowed, Export("paidEventHandler", ArgumentSemantic.Copy)]
		GADPaidEventHandler PaidEventHandler { get; set; }

		// +(void)loadWithAdUnitID:(NSString * _Nonnull)adUnitID request:(GADRequest * _Nullable)request completionHandler:(GADInterstitialAdLoadCompletionHandler _Nonnull)completionHandler;
		[Static]
		[Export("loadWithAdUnitID:request:completionHandler:")]
		void LoadWithAdUnitID(string adUnitID, [NullAllowed] GADRequest request,
			GADInterstitialAdLoadCompletionHandler completionHandler);

		// -(BOOL)canPresentFromRootViewController:(UIViewController * _Nullable)rootViewController error:(NSError * _Nullable * _Nullable)error;
		[Export("canPresentFromRootViewController:error:")]
		bool CanPresentFromRootViewController([NullAllowed] UIViewController rootViewController,
			[NullAllowed] out NSError error);

		// -(void)presentFromRootViewController:(UIViewController * _Nullable)rootViewController;
		[Export("presentFromRootViewController:")]
		void PresentFromRootViewController([NullAllowed] UIViewController rootViewController);
	}

	// @interface GADRequestConfiguration : NSObject
	[BaseType(typeof(NSObject))]
	interface GADRequestConfiguration
	{
		// @property (copy, nonatomic) GADMaxAdContentRating _Nullable maxAdContentRating;
		[NullAllowed, Export("maxAdContentRating")]
		string MaxAdContentRating { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nullable testDeviceIdentifiers;
		[NullAllowed, Export("testDeviceIdentifiers", ArgumentSemantic.Copy)]
		string[] TestDeviceIdentifiers { get; set; }

		// @property (copy, nonatomic) NSNumber * _Nullable tagForUnderAgeOfConsent;
		[NullAllowed, Export("tagForUnderAgeOfConsent", ArgumentSemantic.Copy)]
		NSNumber TagForUnderAgeOfConsent { get; set; }

		// @property (copy, nonatomic) NSNumber * _Nullable tagForChildDirectedTreatment;
		[NullAllowed, Export("tagForChildDirectedTreatment", ArgumentSemantic.Copy)]
		NSNumber TagForChildDirectedTreatment { get; set; }

		// -(void)setPublisherFirstPartyIDEnabled:(BOOL)enabled;
		[Export("setPublisherFirstPartyIDEnabled:")]
		void SetPublisherFirstPartyIDEnabled(bool enabled);

		// @property (nonatomic) GADPublisherPrivacyPersonalizationState publisherPrivacyPersonalizationState;
		[Export("publisherPrivacyPersonalizationState", ArgumentSemantic.Assign)]
		GADPublisherPrivacyPersonalizationState PublisherPrivacyPersonalizationState { get; set; }
	}

	// typedef void (^GADInitializationCompletionHandler)(GADInitializationStatus * _Nonnull);
	delegate void GADInitializationCompletionHandler(GADInitializationStatus arg0);

	// typedef void (^GADAdInspectorCompletionHandler)(NSError * _Nullable);
	delegate void GADAdInspectorCompletionHandler([NullAllowed] NSError arg0);

	// @interface GADMobileAds : NSObject
	[BaseType(typeof(NSObject))]
	interface GADMobileAds
	{
		// +(GADMobileAds * _Nonnull)sharedInstance;
		[Static] [Export("sharedInstance")] GADMobileAds SharedInstance { get; }

		// @property (readonly, nonatomic) GADVersionNumber versionNumber;
		[Export("versionNumber")] GADVersionNumber VersionNumber { get; }

		// @property (assign, nonatomic) float applicationVolume;
		[Export("applicationVolume")] float ApplicationVolume { get; set; }

		// @property (assign, nonatomic) BOOL applicationMuted;
		[Export("applicationMuted")] bool ApplicationMuted { get; set; }

		// @property (readonly, nonatomic, strong) GADAudioVideoManager * _Nonnull audioVideoManager;
		[Export("audioVideoManager", ArgumentSemantic.Strong)]
		GADAudioVideoManager AudioVideoManager { get; }

		// @property (readonly, nonatomic, strong) GADRequestConfiguration * _Nonnull requestConfiguration;
		[Export("requestConfiguration", ArgumentSemantic.Strong)]
		GADRequestConfiguration RequestConfiguration { get; }

		// @property (readonly, nonatomic) GADInitializationStatus * _Nonnull initializationStatus;
		[Export("initializationStatus")] GADInitializationStatus InitializationStatus { get; }

		// -(BOOL)isSDKVersionAtLeastMajor:(NSInteger)major minor:(NSInteger)minor patch:(NSInteger)patch __attribute__((swift_name("isSDKVersionAtLeast(major:minor:patch:)")));
		[Export("isSDKVersionAtLeastMajor:minor:patch:")]
		bool IsSDKVersionAtLeastMajor(nint major, nint minor, nint patch);

		// -(void)startWithCompletionHandler:(GADInitializationCompletionHandler _Nullable)completionHandler;
		[Export("startWithCompletionHandler:")]
		void StartWithCompletionHandler([NullAllowed] GADInitializationCompletionHandler completionHandler);

		// -(void)disableSDKCrashReporting;
		[Export("disableSDKCrashReporting")]
		void DisableSDKCrashReporting();

		// -(void)disableMediationInitialization;
		[Export("disableMediationInitialization")]
		void DisableMediationInitialization();

		// -(void)presentAdInspectorFromViewController:(UIViewController * _Nullable)viewController completionHandler:(GADAdInspectorCompletionHandler _Nullable)completionHandler;
		[Export("presentAdInspectorFromViewController:completionHandler:")]
		void PresentAdInspectorFromViewController([NullAllowed] UIViewController viewController,
			[NullAllowed] GADAdInspectorCompletionHandler completionHandler);

		// -(void)registerWebView:(WKWebView * _Nonnull)webView;
		[Export("registerWebView:")]
		void RegisterWebView(WKWebView webView);
	}

	// @interface GADMultipleAdsAdLoaderOptions : GADAdLoaderOptions
	[BaseType(typeof(GADAdLoaderOptions))]
	interface GADMultipleAdsAdLoaderOptions
	{
		// @property (nonatomic) NSInteger numberOfAds;
		[Export("numberOfAds")] nint NumberOfAds { get; set; }
	}

	// @interface GADMuteThisAdReason : NSObject
	[BaseType(typeof(NSObject))]
	interface GADMuteThisAdReason
	{
		// @property (readonly, nonatomic) NSString * _Nonnull reasonDescription;
		[Export("reasonDescription")] string ReasonDescription { get; }
	}

	// @protocol GADNativeAdDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GADNativeAdDelegate
	{
		// @optional -(void)nativeAdDidRecordImpression:(GADNativeAd * _Nonnull)nativeAd;
		[Export("nativeAdDidRecordImpression:")]
		void NativeAdDidRecordImpression(GADNativeAd nativeAd);

		// @optional -(void)nativeAdDidRecordClick:(GADNativeAd * _Nonnull)nativeAd;
		[Export("nativeAdDidRecordClick:")]
		void NativeAdDidRecordClick(GADNativeAd nativeAd);

		// @optional -(void)nativeAdDidRecordSwipeGestureClick:(GADNativeAd * _Nonnull)nativeAd;
		[Export("nativeAdDidRecordSwipeGestureClick:")]
		void NativeAdDidRecordSwipeGestureClick(GADNativeAd nativeAd);

		// @optional -(void)nativeAdWillPresentScreen:(GADNativeAd * _Nonnull)nativeAd;
		[Export("nativeAdWillPresentScreen:")]
		void NativeAdWillPresentScreen(GADNativeAd nativeAd);

		// @optional -(void)nativeAdWillDismissScreen:(GADNativeAd * _Nonnull)nativeAd;
		[Export("nativeAdWillDismissScreen:")]
		void NativeAdWillDismissScreen(GADNativeAd nativeAd);

		// @optional -(void)nativeAdDidDismissScreen:(GADNativeAd * _Nonnull)nativeAd;
		[Export("nativeAdDidDismissScreen:")]
		void NativeAdDidDismissScreen(GADNativeAd nativeAd);

		// @optional -(void)nativeAdIsMuted:(GADNativeAd * _Nonnull)nativeAd;
		[Export("nativeAdIsMuted:")]
		void NativeAdIsMuted(GADNativeAd nativeAd);
	}

	interface IGADNativeAdDelegate
	{
	}

	// @interface GADNativeAd : NSObject
	[BaseType(typeof(NSObject))]
	interface GADNativeAd
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable headline;
		[NullAllowed, Export("headline")] string Headline { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable callToAction;
		[NullAllowed, Export("callToAction")] string CallToAction { get; }

		// @property (readonly, nonatomic, strong) GADNativeAdImage * _Nullable icon;
		[NullAllowed, Export("icon", ArgumentSemantic.Strong)]
		GADNativeAdImage Icon { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable body;
		[NullAllowed, Export("body")] string Body { get; }

		// @property (readonly, nonatomic, strong) NSArray<GADNativeAdImage *> * _Nullable images;
		[NullAllowed, Export("images", ArgumentSemantic.Strong)]
		GADNativeAdImage[] Images { get; }

		// @property (readonly, copy, nonatomic) NSDecimalNumber * _Nullable starRating;
		[NullAllowed, Export("starRating", ArgumentSemantic.Copy)]
		NSDecimalNumber StarRating { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable store;
		[NullAllowed, Export("store")] string Store { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable price;
		[NullAllowed, Export("price")] string Price { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable advertiser;
		[NullAllowed, Export("advertiser")] string Advertiser { get; }

		// @property (readonly, nonatomic) GADMediaContent * _Nonnull mediaContent;
		[Export("mediaContent")] GADMediaContent MediaContent { get; }

		[Wrap("WeakDelegate")] [NullAllowed] IGADNativeAdDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<GADNativeAdDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, weak) UIViewController * _Nullable rootViewController;
		[NullAllowed, Export("rootViewController", ArgumentSemantic.Weak)]
		UIViewController RootViewController { get; set; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nullable extraAssets;
		[NullAllowed, Export("extraAssets", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> ExtraAssets { get; }

		// @property (readonly, nonatomic) GADResponseInfo * _Nonnull responseInfo;
		[Export("responseInfo")] GADResponseInfo ResponseInfo { get; }

		// @property (copy, nonatomic) GADPaidEventHandler _Nullable paidEventHandler;
		[NullAllowed, Export("paidEventHandler", ArgumentSemantic.Copy)]
		GADPaidEventHandler PaidEventHandler { get; set; }

		// @property (readonly, getter = isCustomMuteThisAdAvailable, nonatomic) BOOL customMuteThisAdAvailable;
		[Export("customMuteThisAdAvailable")]
		bool CustomMuteThisAdAvailable { [Bind("isCustomMuteThisAdAvailable")] get; }

		// @property (readonly, nonatomic) NSArray<GADMuteThisAdReason *> * _Nullable muteThisAdReasons;
		[NullAllowed, Export("muteThisAdReasons")]
		GADMuteThisAdReason[] MuteThisAdReasons { get; }

		// -(void)registerAdView:(UIView * _Nonnull)adView clickableAssetViews:(NSDictionary<GADNativeAssetIdentifier,UIView *> * _Nonnull)clickableAssetViews nonclickableAssetViews:(NSDictionary<GADNativeAssetIdentifier,UIView *> * _Nonnull)nonclickableAssetViews;
		[Export("registerAdView:clickableAssetViews:nonclickableAssetViews:")]
		void RegisterAdView(UIView adView, NSDictionary<NSString, UIView> clickableAssetViews,
			NSDictionary<NSString, UIView> nonclickableAssetViews);

		// -(void)unregisterAdView;
		[Export("unregisterAdView")]
		void UnregisterAdView();

		// -(void)muteThisAdWithReason:(GADMuteThisAdReason * _Nullable)reason;
		[Export("muteThisAdWithReason:")]
		void MuteThisAdWithReason([NullAllowed] GADMuteThisAdReason reason);

		// From Category
		// @property (readonly, getter = isCustomClickGestureEnabled, nonatomic) BOOL customClickGestureEnabled;
		[Export("customClickGestureEnabled")]
		bool CustomClickGestureEnabled { [Bind("isCustomClickGestureEnabled")] get; }

		// -(void)enableCustomClickGestures;
		[Export("enableCustomClickGestures")]
		void EnableCustomClickGestures();

		// -(void)recordCustomClickGesture;
		[Export("recordCustomClickGesture")]
		void RecordCustomClickGesture();

		// From Category
		[Wrap("WeakUnconfirmedClickDelegate")]
		[NullAllowed]
		GADNativeAdUnconfirmedClickDelegate UnconfirmedClickDelegate { get; set; }

		// @property (nonatomic, weak) id<GADNativeAdUnconfirmedClickDelegate> _Nullable unconfirmedClickDelegate;
		[NullAllowed, Export("unconfirmedClickDelegate", ArgumentSemantic.Weak)]
		NSObject WeakUnconfirmedClickDelegate { get; set; }

		// -(void)registerClickConfirmingView:(UIView * _Nullable)view;
		[Export("registerClickConfirmingView:")]
		void RegisterClickConfirmingView([NullAllowed] UIView view);

		// -(void)cancelUnconfirmedClick;
		[Export("cancelUnconfirmedClick")]
		void CancelUnconfirmedClick();
	}

	// @protocol GADNativeAdLoaderDelegate <GADAdLoaderDelegate>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GADNativeAdLoaderDelegate : GADAdLoaderDelegate
	{
		// @required -(void)adLoader:(GADAdLoader * _Nonnull)adLoader didReceiveNativeAd:(GADNativeAd * _Nonnull)nativeAd;
		[Abstract]
		[Export("adLoader:didReceiveNativeAd:")]
		void AdLoaderDidReceiveNativeAd(GADAdLoader adLoader, GADNativeAd nativeAd);
	}

	// @interface GADNativeAdView : UIView
	[BaseType(typeof(UIView))]
	interface GADNativeAdView
	{
		// @property (nonatomic, strong) GADNativeAd * _Nullable nativeAd;
		[NullAllowed, Export("nativeAd", ArgumentSemantic.Strong)]
		GADNativeAd NativeAd { get; set; }

		// @property (nonatomic, weak) UIView * _Nullable headlineView __attribute__((iboutlet));
		[NullAllowed, Export("headlineView", ArgumentSemantic.Weak)]
		UIView HeadlineView { get; set; }

		// @property (nonatomic, weak) UIView * _Nullable callToActionView __attribute__((iboutlet));
		[NullAllowed, Export("callToActionView", ArgumentSemantic.Weak)]
		UIView CallToActionView { get; set; }

		// @property (nonatomic, weak) UIView * _Nullable iconView __attribute__((iboutlet));
		[NullAllowed, Export("iconView", ArgumentSemantic.Weak)]
		UIView IconView { get; set; }

		// @property (nonatomic, weak) UIView * _Nullable bodyView __attribute__((iboutlet));
		[NullAllowed, Export("bodyView", ArgumentSemantic.Weak)]
		UIView BodyView { get; set; }

		// @property (nonatomic, weak) UIView * _Nullable storeView __attribute__((iboutlet));
		[NullAllowed, Export("storeView", ArgumentSemantic.Weak)]
		UIView StoreView { get; set; }

		// @property (nonatomic, weak) UIView * _Nullable priceView __attribute__((iboutlet));
		[NullAllowed, Export("priceView", ArgumentSemantic.Weak)]
		UIView PriceView { get; set; }

		// @property (nonatomic, weak) UIView * _Nullable imageView __attribute__((iboutlet));
		[NullAllowed, Export("imageView", ArgumentSemantic.Weak)]
		UIView ImageView { get; set; }

		// @property (nonatomic, weak) UIView * _Nullable starRatingView __attribute__((iboutlet));
		[NullAllowed, Export("starRatingView", ArgumentSemantic.Weak)]
		UIView StarRatingView { get; set; }

		// @property (nonatomic, weak) UIView * _Nullable advertiserView __attribute__((iboutlet));
		[NullAllowed, Export("advertiserView", ArgumentSemantic.Weak)]
		UIView AdvertiserView { get; set; }

		// @property (nonatomic, weak) GADMediaView * _Nullable mediaView __attribute__((iboutlet));
		[NullAllowed, Export("mediaView", ArgumentSemantic.Weak)]
		GADMediaView MediaView { get; set; }

		// @property (nonatomic, weak) GADAdChoicesView * _Nullable adChoicesView __attribute__((iboutlet));
		[NullAllowed, Export("adChoicesView", ArgumentSemantic.Weak)]
		GADAdChoicesView AdChoicesView { get; set; }
	}

	// @protocol GADNativeAdUnconfirmedClickDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GADNativeAdUnconfirmedClickDelegate
	{
		// @required -(void)nativeAd:(GADNativeAd * _Nonnull)nativeAd didReceiveUnconfirmedClickOnAssetID:(GADNativeAssetIdentifier _Nonnull)assetID;
		[Abstract]
		[Export("nativeAd:didReceiveUnconfirmedClickOnAssetID:")]
		void NativeAdDidReceiveUnconfirmedClickOnAssetID(GADNativeAd nativeAd, string assetID);

		// @required -(void)nativeAdDidCancelUnconfirmedClick:(GADNativeAd * _Nonnull)nativeAd;
		[Abstract]
		[Export("nativeAdDidCancelUnconfirmedClick:")]
		void NativeAdDidCancelUnconfirmedClick(GADNativeAd nativeAd);
	}

	// // @interface ConfirmedClick (GADNativeAd)
	// [Category]
	// [BaseType(typeof(GADNativeAd))]
	// interface GADNativeAd_ConfirmedClick
	// {
	// 	[Wrap("WeakUnconfirmedClickDelegate")]
	// 	[NullAllowed]
	// 	GADNativeAdUnconfirmedClickDelegate UnconfirmedClickDelegate { get; set; }
	//
	// 	// @property (nonatomic, weak) id<GADNativeAdUnconfirmedClickDelegate> _Nullable unconfirmedClickDelegate;
	// 	[NullAllowed, Export("unconfirmedClickDelegate", ArgumentSemantic.Weak)]
	// 	NSObject WeakUnconfirmedClickDelegate { get; set; }
	//
	// 	// -(void)registerClickConfirmingView:(UIView * _Nullable)view;
	// 	[Export("registerClickConfirmingView:")]
	// 	void RegisterClickConfirmingView([NullAllowed] UIView view);
	//
	// 	// -(void)cancelUnconfirmedClick;
	// 	[Export("cancelUnconfirmedClick")]
	// 	void CancelUnconfirmedClick();
	// }

	// // @interface CustomClickGesture (GADNativeAd)
	// [Category]
	// [BaseType (typeof(GADNativeAd))]
	// interface GADNativeAd_CustomClickGesture
	// {
	// 	// @property (readonly, getter = isCustomClickGestureEnabled, nonatomic) BOOL customClickGestureEnabled;
	// 	[Export ("customClickGestureEnabled")]
	// 	bool CustomClickGestureEnabled { [Bind ("isCustomClickGestureEnabled")] get; }
	//
	// 	// -(void)enableCustomClickGestures;
	// 	[Export ("enableCustomClickGestures")]
	// 	void EnableCustomClickGestures ();
	//
	// 	// -(void)recordCustomClickGesture;
	// 	[Export ("recordCustomClickGesture")]
	// 	void RecordCustomClickGesture ();
	// }

	// @interface GADNativeAdCustomClickGestureOptions : GADAdLoaderOptions
	[BaseType(typeof(GADAdLoaderOptions))]
	[DisableDefaultCtor]
	interface GADNativeAdCustomClickGestureOptions
	{
		// @property (assign, nonatomic) UISwipeGestureRecognizerDirection swipeGestureDirection;
		[Export("swipeGestureDirection", ArgumentSemantic.Assign)]
		UISwipeGestureRecognizerDirection SwipeGestureDirection { get; set; }

		// @property (assign, nonatomic) BOOL tapsAllowed;
		[Export("tapsAllowed")] bool TapsAllowed { get; set; }

		// -(instancetype _Nonnull)initWithSwipeGestureDirection:(UISwipeGestureRecognizerDirection)direction tapsAllowed:(BOOL)tapsAllowed __attribute__((objc_designated_initializer));
		[Export("initWithSwipeGestureDirection:tapsAllowed:")]
		[DesignatedInitializer]
		NativeHandle Constructor(UISwipeGestureRecognizerDirection direction, bool tapsAllowed);
	}

	// // @interface MediationAdditions (GADNativeAdImage)
	// [Category]
	// [BaseType(typeof(GADNativeAdImage))]
	// interface GADNativeAdImage_MediationAdditions
	// {
	// 	// -(instancetype _Nonnull)initWithImage:(UIImage * _Nonnull)image;
	// 	[Export("initWithImage:")]
	// 	NativeHandle Constructor(UIImage image);
	//
	// 	// -(instancetype _Nonnull)initWithURL:(NSURL * _Nonnull)URL scale:(CGFloat)scale;
	// 	[Export("initWithURL:scale:")]
	// 	NativeHandle Constructor(NSUrl URL, nfloat scale);
	// }

	// @interface GADNativeAdImageAdLoaderOptions : GADAdLoaderOptions
	[BaseType(typeof(GADAdLoaderOptions))]
	interface GADNativeAdImageAdLoaderOptions
	{
		// @property (assign, nonatomic) BOOL disableImageLoading;
		[Export("disableImageLoading")] bool DisableImageLoading { get; set; }

		// @property (assign, nonatomic) BOOL shouldRequestMultipleImages;
		[Export("shouldRequestMultipleImages")]
		bool ShouldRequestMultipleImages { get; set; }
	}

	// @interface GADNativeAdMediaAdLoaderOptions : GADAdLoaderOptions
	[BaseType(typeof(GADAdLoaderOptions))]
	interface GADNativeAdMediaAdLoaderOptions
	{
		// @property (assign, nonatomic) GADMediaAspectRatio mediaAspectRatio;
		[Export("mediaAspectRatio", ArgumentSemantic.Assign)]
		GADMediaAspectRatio MediaAspectRatio { get; set; }
	}

	// @interface GADNativeAdViewAdOptions : GADAdLoaderOptions
	[BaseType(typeof(GADAdLoaderOptions))]
	interface GADNativeAdViewAdOptions
	{
		// @property (assign, nonatomic) GADAdChoicesPosition preferredAdChoicesPosition;
		[Export("preferredAdChoicesPosition", ArgumentSemantic.Assign)]
		GADAdChoicesPosition PreferredAdChoicesPosition { get; set; }
	}

	// @interface GADNativeMuteThisAdLoaderOptions : GADAdLoaderOptions
	[BaseType(typeof(GADAdLoaderOptions))]
	interface GADNativeMuteThisAdLoaderOptions
	{
		// @property (nonatomic) BOOL customMuteThisAdRequested;
		[Export("customMuteThisAdRequested")] bool CustomMuteThisAdRequested { get; set; }
	}

	// typedef void (^GADQueryInfoCreationCompletionHandler)(GADQueryInfo * _Nullable, NSError * _Nullable);
	delegate void GADQueryInfoCreationCompletionHandler([NullAllowed] GADQueryInfo arg0, [NullAllowed] NSError arg1);

	// @interface GADQueryInfo : NSObject
	[BaseType(typeof(NSObject))]
	interface GADQueryInfo
	{
		// @property (readonly, nonatomic) NSString * _Nonnull query;
		[Export("query")] string Query { get; }

		// +(void)createQueryInfoWithRequest:(GADRequest * _Nullable)request adFormat:(GADAdFormat)adFormat completionHandler:(GADQueryInfoCreationCompletionHandler _Nonnull)completionHandler;
		[Static]
		[Export("createQueryInfoWithRequest:adFormat:completionHandler:")]
		void CreateQueryInfo([NullAllowed] GADRequest request, GADAdFormat adFormat,
			GADQueryInfoCreationCompletionHandler completionHandler);

		// +(void)createQueryInfoWithRequest:(GADRequest * _Nullable)request adFormat:(GADAdFormat)adFormat adUnitID:(NSString * _Nonnull)adUnitID completionHandler:(GADQueryInfoCreationCompletionHandler _Nonnull)completionHandler;
		[Static]
		[Export("createQueryInfoWithRequest:adFormat:adUnitID:completionHandler:")]
		void CreateQueryInfo([NullAllowed] GADRequest request, GADAdFormat adFormat, string adUnitID,
			GADQueryInfoCreationCompletionHandler completionHandler);
	}

	// typedef void (^GADRewardedAdLoadCompletionHandler)(GADRewardedAd * _Nullable, NSError * _Nullable);
	delegate void GADRewardedAdLoadCompletionHandler([NullAllowed] GADRewardedAd arg0, [NullAllowed] NSError arg1);

	// @interface GADRewardedAd : NSObject <GADAdMetadataProvider, GADFullScreenPresentingAd>
	[BaseType(typeof(NSObject))]
	interface GADRewardedAd : GADAdMetadataProvider, GADFullScreenPresentingAd
	{
		// @property (readonly, nonatomic) NSString * _Nonnull adUnitID;
		[Export("adUnitID")] string AdUnitID { get; }

		// @property (readonly, nonatomic) GADResponseInfo * _Nonnull responseInfo;
		[Export("responseInfo")] GADResponseInfo ResponseInfo { get; }

		// @property (readonly, nonatomic) GADAdReward * _Nonnull adReward;
		[Export("adReward")] GADAdReward AdReward { get; }

		// @property (copy, nonatomic) GADServerSideVerificationOptions * _Nullable serverSideVerificationOptions;
		[NullAllowed, Export("serverSideVerificationOptions", ArgumentSemantic.Copy)]
		GADServerSideVerificationOptions ServerSideVerificationOptions { get; set; }

		[Wrap("WeakFullScreenContentDelegate")]
		[NullAllowed]
		GADFullScreenContentDelegate FullScreenContentDelegate { get; set; }

		// @property (nonatomic, weak) id<GADFullScreenContentDelegate> _Nullable fullScreenContentDelegate;
		[NullAllowed, Export("fullScreenContentDelegate", ArgumentSemantic.Weak)]
		NSObject WeakFullScreenContentDelegate { get; set; }

		// @property (copy, nonatomic) GADPaidEventHandler _Nullable paidEventHandler;
		[NullAllowed, Export("paidEventHandler", ArgumentSemantic.Copy)]
		GADPaidEventHandler PaidEventHandler { get; set; }

		// +(void)loadWithAdUnitID:(NSString * _Nonnull)adUnitID request:(GADRequest * _Nullable)request completionHandler:(GADRewardedAdLoadCompletionHandler _Nonnull)completionHandler;
		[Static]
		[Export("loadWithAdUnitID:request:completionHandler:")]
		void Load(string adUnitID, [NullAllowed] GADRequest request,
			GADRewardedAdLoadCompletionHandler completionHandler);

		// -(BOOL)canPresentFromRootViewController:(UIViewController * _Nullable)rootViewController error:(NSError * _Nullable * _Nullable)error;
		[Export("canPresentFromRootViewController:error:")]
		bool CanPresentFromRootViewController([NullAllowed] UIViewController rootViewController,
			[NullAllowed] out NSError error);

		// -(void)presentFromRootViewController:(UIViewController * _Nullable)rootViewController userDidEarnRewardHandler:(GADUserDidEarnRewardHandler _Nonnull)userDidEarnRewardHandler;
		[Export("presentFromRootViewController:userDidEarnRewardHandler:")]
		void PresentFromRootViewController([NullAllowed] UIViewController rootViewController,
			GADUserDidEarnRewardHandler userDidEarnRewardHandler);
	}

	// typedef void (^GADRewardedInterstitialAdLoadCompletionHandler)(GADRewardedInterstitialAd * _Nullable, NSError * _Nullable);
	delegate void GADRewardedInterstitialAdLoadCompletionHandler([NullAllowed] GADRewardedInterstitialAd arg0,
		[NullAllowed] NSError arg1);

	// @interface GADRewardedInterstitialAd : NSObject <GADAdMetadataProvider, GADFullScreenPresentingAd>
	[BaseType(typeof(NSObject))]
	interface GADRewardedInterstitialAd : GADAdMetadataProvider, GADFullScreenPresentingAd
	{
		// @property (readonly, nonatomic) NSString * _Nonnull adUnitID;
		[Export("adUnitID")] string AdUnitID { get; }

		// @property (readonly, nonatomic) GADResponseInfo * _Nonnull responseInfo;
		[Export("responseInfo")] GADResponseInfo ResponseInfo { get; }

		// @property (readonly, nonatomic) GADAdReward * _Nonnull adReward;
		[Export("adReward")] GADAdReward AdReward { get; }

		// @property (copy, nonatomic) GADServerSideVerificationOptions * _Nullable serverSideVerificationOptions;
		[NullAllowed, Export("serverSideVerificationOptions", ArgumentSemantic.Copy)]
		GADServerSideVerificationOptions ServerSideVerificationOptions { get; set; }

		[Wrap("WeakFullScreenContentDelegate")]
		[NullAllowed]
		GADFullScreenContentDelegate FullScreenContentDelegate { get; set; }

		// @property (nonatomic, weak) id<GADFullScreenContentDelegate> _Nullable fullScreenContentDelegate;
		[NullAllowed, Export("fullScreenContentDelegate", ArgumentSemantic.Weak)]
		NSObject WeakFullScreenContentDelegate { get; set; }

		// @property (copy, nonatomic) GADPaidEventHandler _Nullable paidEventHandler;
		[NullAllowed, Export("paidEventHandler", ArgumentSemantic.Copy)]
		GADPaidEventHandler PaidEventHandler { get; set; }

		// +(void)loadWithAdUnitID:(NSString * _Nonnull)adUnitID request:(GADRequest * _Nullable)request completionHandler:(GADRewardedInterstitialAdLoadCompletionHandler _Nonnull)completionHandler;
		[Static]
		[Export("loadWithAdUnitID:request:completionHandler:")]
		void Load(string adUnitID, [NullAllowed] GADRequest request,
			GADRewardedInterstitialAdLoadCompletionHandler completionHandler);

		// -(BOOL)canPresentFromRootViewController:(UIViewController * _Nullable)rootViewController error:(NSError * _Nullable * _Nullable)error;
		[Export("canPresentFromRootViewController:error:")]
		bool CanPresentFromRootViewController([NullAllowed] UIViewController rootViewController,
			[NullAllowed] out NSError error);

		// -(void)presentFromRootViewController:(UIViewController * _Nullable)viewController userDidEarnRewardHandler:(GADUserDidEarnRewardHandler _Nonnull)userDidEarnRewardHandler;
		[Export("presentFromRootViewController:userDidEarnRewardHandler:")]
		void PresentFromRootViewController([NullAllowed] UIViewController viewController,
			GADUserDidEarnRewardHandler userDidEarnRewardHandler);
	}

	// @interface GADSearchBannerView : GADBannerView
	[BaseType(typeof(GADBannerView))]
	interface GADSearchBannerView
	{
		[Wrap("WeakAdSizeDelegate")]
		[NullAllowed]
		GADAdSizeDelegate AdSizeDelegate { get; set; }

		// @property (nonatomic, weak) id<GADAdSizeDelegate> _Nullable adSizeDelegate __attribute__((iboutlet));
		[NullAllowed, Export("adSizeDelegate", ArgumentSemantic.Weak)]
		NSObject WeakAdSizeDelegate { get; set; }
	}

	// @protocol GADVideoControllerDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GADVideoControllerDelegate
	{
		// @optional -(void)videoControllerDidPlayVideo:(GADVideoController * _Nonnull)videoController;
		[Export("videoControllerDidPlayVideo:")]
		void VideoControllerDidPlayVideo(GADVideoController videoController);

		// @optional -(void)videoControllerDidPauseVideo:(GADVideoController * _Nonnull)videoController;
		[Export("videoControllerDidPauseVideo:")]
		void VideoControllerDidPauseVideo(GADVideoController videoController);

		// @optional -(void)videoControllerDidEndVideoPlayback:(GADVideoController * _Nonnull)videoController;
		[Export("videoControllerDidEndVideoPlayback:")]
		void VideoControllerDidEndVideoPlayback(GADVideoController videoController);

		// @optional -(void)videoControllerDidMuteVideo:(GADVideoController * _Nonnull)videoController;
		[Export("videoControllerDidMuteVideo:")]
		void VideoControllerDidMuteVideo(GADVideoController videoController);

		// @optional -(void)videoControllerDidUnmuteVideo:(GADVideoController * _Nonnull)videoController;
		[Export("videoControllerDidUnmuteVideo:")]
		void VideoControllerDidUnmuteVideo(GADVideoController videoController);
	}

	// @interface GADVideoOptions : GADAdLoaderOptions
	[BaseType(typeof(GADAdLoaderOptions))]
	interface GADVideoOptions
	{
		// @property (assign, nonatomic) BOOL startMuted;
		[Export("startMuted")] bool StartMuted { get; set; }

		// @property (assign, nonatomic) BOOL customControlsRequested;
		[Export("customControlsRequested")] bool CustomControlsRequested { get; set; }

		// @property (assign, nonatomic) BOOL clickToExpandRequested;
		[Export("clickToExpandRequested")] bool ClickToExpandRequested { get; set; }
	}

	// @protocol GAMBannerAdLoaderDelegate <GADAdLoaderDelegate>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GAMBannerAdLoaderDelegate : GADAdLoaderDelegate
	{
		// @required -(NSArray<NSValue *> * _Nonnull)validBannerSizesForAdLoader:(GADAdLoader * _Nonnull)adLoader;
		[Abstract]
		[Export("validBannerSizesForAdLoader:")]
		NSValue[] ValidBannerSizes(GADAdLoader adLoader);

		// @required -(void)adLoader:(GADAdLoader * _Nonnull)adLoader didReceiveGAMBannerView:(GAMBannerView * _Nonnull)bannerView;
		[Abstract]
		[Export("adLoader:didReceiveGAMBannerView:")]
		void AdLoaderDidReceiveGAMBannerView(GADAdLoader adLoader, GAMBannerView bannerView);
	}

	// @interface GAMBannerView : GADBannerView
	[BaseType(typeof(GADBannerView))]
	interface GAMBannerView
	{
		// @property (copy, nonatomic) NSString * _Nullable adUnitID;
		[NullAllowed, Export("adUnitID")] string AdUnitID { get; set; }

		[Wrap("WeakAppEventDelegate")]
		[NullAllowed]
		GADAppEventDelegate AppEventDelegate { get; set; }

		// @property (nonatomic, weak) id<GADAppEventDelegate> _Nullable appEventDelegate __attribute__((iboutlet));
		[NullAllowed, Export("appEventDelegate", ArgumentSemantic.Weak)]
		NSObject WeakAppEventDelegate { get; set; }

		[Wrap("WeakAdSizeDelegate")]
		[NullAllowed]
		GADAdSizeDelegate AdSizeDelegate { get; set; }

		// @property (nonatomic, weak) id<GADAdSizeDelegate> _Nullable adSizeDelegate __attribute__((iboutlet));
		[NullAllowed, Export("adSizeDelegate", ArgumentSemantic.Weak)]
		NSObject WeakAdSizeDelegate { get; set; }

		// @property (copy, nonatomic) NSArray<NSValue *> * _Nullable validAdSizes;
		[NullAllowed, Export("validAdSizes", ArgumentSemantic.Copy)]
		NSValue[] ValidAdSizes { get; set; }

		// @property (nonatomic) BOOL enableManualImpressions;
		[Export("enableManualImpressions")] bool EnableManualImpressions { get; set; }

		// @property (readonly, nonatomic) GADVideoController * _Nonnull videoController;
		[Export("videoController")] GADVideoController VideoController { get; }

		// -(void)recordImpression;
		[Export("recordImpression")]
		void RecordImpression();

		// -(void)resize:(GADAdSize)size;
		[Export("resize:")]
		void Resize(GADAdSize size);

		// -(void)setAdOptions:(NSArray<GADAdLoaderOptions *> * _Nonnull)adOptions;
		[Export("setAdOptions:")]
		void SetAdOptions(GADAdLoaderOptions[] adOptions);
	}

	// @interface GAMBannerViewOptions : GADAdLoaderOptions
	[BaseType(typeof(GADAdLoaderOptions))]
	interface GAMBannerViewOptions
	{
		// @property (assign, nonatomic) BOOL enableManualImpressions;
		[Export("enableManualImpressions")] bool EnableManualImpressions { get; set; }
	}

	// @interface GAMRequest : GADRequest
	[BaseType(typeof(GADRequest))]
	interface GAMRequest
	{
		// @property (copy, nonatomic) NSString * _Nullable publisherProvidedID;
		[NullAllowed, Export("publisherProvidedID")]
		string PublisherProvidedID { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nullable categoryExclusions;
		[NullAllowed, Export("categoryExclusions", ArgumentSemantic.Copy)]
		string[] CategoryExclusions { get; set; }

		// @property (copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nullable customTargeting;
		[NullAllowed, Export("customTargeting", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSString> CustomTargeting { get; set; }
	}

	// typedef void (^GAMInterstitialAdLoadCompletionHandler)(GAMInterstitialAd * _Nullable, NSError * _Nullable);
	delegate void GAMInterstitialAdLoadCompletionHandler([NullAllowed] GAMInterstitialAd arg0,
		[NullAllowed] NSError arg1);

	// @interface GAMInterstitialAd : GADInterstitialAd
	[BaseType(typeof(GADInterstitialAd))]
	interface GAMInterstitialAd
	{
		[Wrap("WeakAppEventDelegate")]
		[NullAllowed]
		GADAppEventDelegate AppEventDelegate { get; set; }

		// @property (nonatomic, weak) id<GADAppEventDelegate> _Nullable appEventDelegate;
		[NullAllowed, Export("appEventDelegate", ArgumentSemantic.Weak)]
		NSObject WeakAppEventDelegate { get; set; }

		// +(void)loadWithAdManagerAdUnitID:(NSString * _Nonnull)adUnitID request:(GAMRequest * _Nullable)request completionHandler:(GAMInterstitialAdLoadCompletionHandler _Nonnull)completionHandler;
		[Static]
		[Export("loadWithAdManagerAdUnitID:request:completionHandler:")]
		void Load(string adUnitID, [NullAllowed] GAMRequest request,
			GAMInterstitialAdLoadCompletionHandler completionHandler);
	}

	// @protocol GADMediationAdRequest <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol]
	interface GADMediationAdRequest
	{
		// @required -(NSString * _Nullable)publisherId;
		[Abstract]
		[NullAllowed, Export("publisherId")]
		string PublisherId { get; }

		// @required -(NSDictionary * _Nullable)credentials;
		[Abstract]
		[NullAllowed, Export("credentials")]
		NSDictionary Credentials { get; }

		// @required -(BOOL)testMode;
		[Abstract] [Export("testMode")] bool TestMode { get; }

		// @required -(id<GADAdNetworkExtras> _Nullable)networkExtras;
		[Abstract]
		[NullAllowed, Export("networkExtras")]
		GADAdNetworkExtras NetworkExtras { get; }

		// @required -(NSNumber * _Nullable)childDirectedTreatment;
		[Abstract]
		[NullAllowed, Export("childDirectedTreatment")]
		NSNumber ChildDirectedTreatment { get; }

		// @required -(GADMaxAdContentRating _Nullable)maxAdContentRating;
		[Abstract]
		[NullAllowed, Export("maxAdContentRating")]
		string MaxAdContentRating { get; }

		// @required -(NSNumber * _Nullable)underAgeOfConsent;
		[Abstract]
		[NullAllowed, Export("underAgeOfConsent")]
		NSNumber UnderAgeOfConsent { get; }

		// @required -(NSArray * _Nullable)userKeywords;
		[Abstract]
		[NullAllowed, Export("userKeywords")]
		NSObject[] UserKeywords { get; }
	}

	interface IGADMAdNetworkAdapter
	{
	}

	// @protocol GADMAdNetworkConnector <GADMediationAdRequest>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol]
	interface GADMAdNetworkConnector : GADMediationAdRequest
	{
		// @required -(UIViewController *)viewControllerForPresentingModalView;
		[Abstract]
		[Export("viewControllerForPresentingModalView")]
		UIViewController ViewControllerForPresentingModalView { get; }

		// @required -(float)adVolume;
		[Abstract] [Export("adVolume")] float AdVolume { get; }

		// @required -(BOOL)adMuted;
		[Abstract] [Export("adMuted")] bool AdMuted { get; }

		// @required -(void)adapter:(id<GADMAdNetworkAdapter>)adapter didFailAd:(NSError *)error;
		[Abstract]
		[Export("adapter:didFailAd:")]
		void AdapterDidFailAd(IGADMAdNetworkAdapter adapter, NSError error);

		// @required -(void)adapter:(id<GADMAdNetworkAdapter>)adapter didReceiveAdView:(UIView *)view;
		[Abstract]
		[Export("adapter:didReceiveAdView:")]
		void AdapterDidReceiveAdView(IGADMAdNetworkAdapter adapter, UIView view);

		// @required -(void)adapterDidReceiveInterstitial:(id<GADMAdNetworkAdapter>)adapter;
		[Abstract]
		[Export("adapterDidReceiveInterstitial:")]
		void AdapterDidReceiveInterstitial(IGADMAdNetworkAdapter adapter);

		// @required -(void)adapter:(id<GADMAdNetworkAdapter>)adapter didReceiveMediatedUnifiedNativeAd:(id<GADMediatedUnifiedNativeAd>)mediatedUnifiedNativeAd;
		[Abstract]
		[Export("adapter:didReceiveMediatedUnifiedNativeAd:")]
		void AdapterDidReceiveMediatedUnifiedNativeAd(IGADMAdNetworkAdapter adapter,
			GADMediatedUnifiedNativeAd mediatedUnifiedNativeAd);

		// @required -(void)adapterDidGetAdClick:(id<GADMAdNetworkAdapter>)adapter;
		[Abstract]
		[Export("adapterDidGetAdClick:")]
		void AdapterDidGetAdClick(IGADMAdNetworkAdapter adapter);

		// @required -(void)adapterWillPresentFullScreenModal:(id<GADMAdNetworkAdapter>)adapter;
		[Abstract]
		[Export("adapterWillPresentFullScreenModal:")]
		void AdapterWillPresentFullScreenModal(IGADMAdNetworkAdapter adapter);

		// @required -(void)adapterWillDismissFullScreenModal:(id<GADMAdNetworkAdapter>)adapter;
		[Abstract]
		[Export("adapterWillDismissFullScreenModal:")]
		void AdapterWillDismissFullScreenModal(IGADMAdNetworkAdapter adapter);

		// @required -(void)adapterDidDismissFullScreenModal:(id<GADMAdNetworkAdapter>)adapter;
		[Abstract]
		[Export("adapterDidDismissFullScreenModal:")]
		void AdapterDidDismissFullScreenModal(IGADMAdNetworkAdapter adapter);

		// @required -(void)adapterWillPresentInterstitial:(id<GADMAdNetworkAdapter>)adapter;
		[Abstract]
		[Export("adapterWillPresentInterstitial:")]
		void AdapterWillPresentInterstitial(IGADMAdNetworkAdapter adapter);

		// @required -(void)adapterWillDismissInterstitial:(id<GADMAdNetworkAdapter>)adapter;
		[Abstract]
		[Export("adapterWillDismissInterstitial:")]
		void AdapterWillDismissInterstitial(IGADMAdNetworkAdapter adapter);

		// @required -(void)adapterDidDismissInterstitial:(id<GADMAdNetworkAdapter>)adapter;
		[Abstract]
		[Export("adapterDidDismissInterstitial:")]
		void AdapterDidDismissInterstitial(IGADMAdNetworkAdapter adapter);

		// @required -(void)adapter:(id<GADMAdNetworkAdapter>)adapter didReceiveInterstitial:(NSObject *)interstitial __attribute__((deprecated("Use -adapterDidReceiveInterstitial:.")));
		[Abstract]
		[Export("adapter:didReceiveInterstitial:")]
		void AdapterDidReceiveInterstitial(IGADMAdNetworkAdapter adapter, NSObject interstitial);

		// @required -(void)adapter:(id<GADMAdNetworkAdapter>)adapter clickDidOccurInBanner:(UIView *)view __attribute__((deprecated("Use -adapterDidGetAdClick:.")));
		[Abstract]
		[Export("adapter:clickDidOccurInBanner:")]
		void AdapterClickDidOccurInBanner(IGADMAdNetworkAdapter adapter, UIView view);

		// @required -(void)adapter:(id<GADMAdNetworkAdapter>)adapter didFailInterstitial:(NSError *)error __attribute__((deprecated("Use -adapter:didFailAd:")));
		[Abstract]
		[Export("adapter:didFailInterstitial:")]
		void AdapterDidFailInterstitial(IGADMAdNetworkAdapter adapter, NSError error);

		// @required -(void)adapterWillLeaveApplication:(id<GADMAdNetworkAdapter>)adapter __attribute__((deprecated("Deprecated. No replacement.")));
		[Abstract]
		[Export("adapterWillLeaveApplication:")]
		void AdapterWillLeaveApplication(IGADMAdNetworkAdapter adapter);
	}

	// @protocol GADMAdNetworkAdapter <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol]
	interface GADMAdNetworkAdapter
	{
		// @required +(NSString *)adapterVersion;
		[Static, Abstract]
		[Export("adapterVersion")]
		string AdapterVersion { get; }

		// @required +(Class<GADAdNetworkExtras>)networkExtrasClass;
		[Static, Abstract]
		[Export("networkExtrasClass")]
		GADAdNetworkExtras NetworkExtrasClass { get; }

		// @required -(instancetype)initWithGADMAdNetworkConnector:(id<GADMAdNetworkConnector>)connector;
		[Abstract]
		[Export("initWithGADMAdNetworkConnector:")]
		NativeHandle Constructor(GADMAdNetworkConnector connector);

		// @required -(void)getBannerWithSize:(GADAdSize)adSize;
		[Abstract]
		[Export("getBannerWithSize:")]
		void GetBanner(GADAdSize adSize);

		// @required -(void)getInterstitial;
		[Abstract]
		[Export("getInterstitial")]
		void GetInterstitial();

		// @required -(void)stopBeingDelegate;
		[Abstract]
		[Export("stopBeingDelegate")]
		void StopBeingDelegate();

		// @required -(void)presentInterstitialFromRootViewController:(UIViewController *)rootViewController;
		[Abstract]
		[Export("presentInterstitialFromRootViewController:")]
		void PresentInterstitialFromRootViewController(UIViewController rootViewController);

		// @optional -(void)getNativeAdWithAdTypes:(NSArray<GADAdLoaderAdType> *)adTypes options:(NSArray<GADAdLoaderOptions *> *)options;
		[Export("getNativeAdWithAdTypes:options:")]
		void GetNativeAd(string[] adTypes, GADAdLoaderOptions[] options);

		// @optional -(BOOL)handlesUserClicks;
		[Export("handlesUserClicks")] bool HandlesUserClicks { get; }

		// @optional -(BOOL)handlesUserImpressions;
		[Export("handlesUserImpressions")] bool HandlesUserImpressions { get; }

		// @optional -(void)changeAdSizeTo:(GADAdSize)adSize;
		[Export("changeAdSizeTo:")]
		void ChangeAdSize(GADAdSize adSize);
	}

	// @interface GADMediatedUnifiedNativeAdNotificationSource : NSObject
	[BaseType(typeof(NSObject))]
	interface GADMediatedUnifiedNativeAdNotificationSource
	{
		// +(void)mediatedNativeAdDidRecordImpression:(id<GADMediatedUnifiedNativeAd> _Nonnull)mediatedNativeAd;
		[Static]
		[Export("mediatedNativeAdDidRecordImpression:")]
		void MediatedNativeAdDidRecordImpression(GADMediatedUnifiedNativeAd mediatedNativeAd);

		// +(void)mediatedNativeAdDidRecordClick:(id<GADMediatedUnifiedNativeAd> _Nonnull)mediatedNativeAd;
		[Static]
		[Export("mediatedNativeAdDidRecordClick:")]
		void MediatedNativeAdDidRecordClick(GADMediatedUnifiedNativeAd mediatedNativeAd);

		// +(void)mediatedNativeAdWillPresentScreen:(id<GADMediatedUnifiedNativeAd> _Nonnull)mediatedNativeAd;
		[Static]
		[Export("mediatedNativeAdWillPresentScreen:")]
		void MediatedNativeAdWillPresentScreen(GADMediatedUnifiedNativeAd mediatedNativeAd);

		// +(void)mediatedNativeAdWillDismissScreen:(id<GADMediatedUnifiedNativeAd> _Nonnull)mediatedNativeAd;
		[Static]
		[Export("mediatedNativeAdWillDismissScreen:")]
		void MediatedNativeAdWillDismissScreen(GADMediatedUnifiedNativeAd mediatedNativeAd);

		// +(void)mediatedNativeAdDidDismissScreen:(id<GADMediatedUnifiedNativeAd> _Nonnull)mediatedNativeAd;
		[Static]
		[Export("mediatedNativeAdDidDismissScreen:")]
		void MediatedNativeAdDidDismissScreen(GADMediatedUnifiedNativeAd mediatedNativeAd);

		// +(void)mediatedNativeAdDidPlayVideo:(id<GADMediatedUnifiedNativeAd> _Nonnull)mediatedNativeAd;
		[Static]
		[Export("mediatedNativeAdDidPlayVideo:")]
		void MediatedNativeAdDidPlayVideo(GADMediatedUnifiedNativeAd mediatedNativeAd);

		// +(void)mediatedNativeAdDidPauseVideo:(id<GADMediatedUnifiedNativeAd> _Nonnull)mediatedNativeAd;
		[Static]
		[Export("mediatedNativeAdDidPauseVideo:")]
		void MediatedNativeAdDidPauseVideo(GADMediatedUnifiedNativeAd mediatedNativeAd);

		// +(void)mediatedNativeAdDidEndVideoPlayback:(id<GADMediatedUnifiedNativeAd> _Nonnull)mediatedNativeAd;
		[Static]
		[Export("mediatedNativeAdDidEndVideoPlayback:")]
		void MediatedNativeAdDidEndVideoPlayback(GADMediatedUnifiedNativeAd mediatedNativeAd);
	}

	// @protocol GADMediationAd <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol]
	interface GADMediationAd
	{
	}

	// @interface GADMediationCredentials : NSObject
	[BaseType(typeof(NSObject))]
	interface GADMediationCredentials
	{
		// @property (readonly, nonatomic) NSDictionary<NSString *,id> * _Nonnull settings;
		[Export("settings")] NSDictionary<NSString, NSObject> Settings { get; }

		// @property (readonly, nonatomic) GADAdFormat format;
		[Export("format")] GADAdFormat Format { get; }
	}

	// @interface GADMediationServerConfiguration : NSObject
	[BaseType(typeof(NSObject))]
	interface GADMediationServerConfiguration
	{
		// @property (readonly, nonatomic) NSArray<GADMediationCredentials *> * _Nonnull credentials;
		[Export("credentials")] GADMediationCredentials[] Credentials { get; }
	}

	// @interface GADMediationAdConfiguration : NSObject
	[BaseType(typeof(NSObject))]
	interface GADMediationAdConfiguration
	{
		// @property (readonly, nonatomic) NSString * _Nullable bidResponse;
		[NullAllowed, Export("bidResponse")] string BidResponse { get; }

		// @property (readonly, nonatomic) UIViewController * _Nullable topViewController;
		[NullAllowed, Export("topViewController")]
		UIViewController TopViewController { get; }

		// @property (readonly, nonatomic) GADMediationCredentials * _Nonnull credentials;
		[Export("credentials")] GADMediationCredentials Credentials { get; }

		// @property (readonly, nonatomic) NSData * _Nullable watermark;
		[NullAllowed, Export("watermark")] NSData Watermark { get; }

		// @property (readonly, nonatomic) id<GADAdNetworkExtras> _Nullable extras;
		[NullAllowed, Export("extras")] GADAdNetworkExtras Extras { get; }

		// @property (readonly, nonatomic) BOOL isTestRequest;
		[Export("isTestRequest")] bool IsTestRequest { get; }
	}

	// @protocol GADMediationAdEventDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GADMediationAdEventDelegate
	{
		// @required -(void)reportImpression;
		[Abstract]
		[Export("reportImpression")]
		void ReportImpression();

		// @required -(void)reportClick;
		[Abstract]
		[Export("reportClick")]
		void ReportClick();

		// @required -(void)willPresentFullScreenView;
		[Abstract]
		[Export("willPresentFullScreenView")]
		void WillPresentFullScreenView();

		// @required -(void)didFailToPresentWithError:(NSError * _Nonnull)error;
		[Abstract]
		[Export("didFailToPresentWithError:")]
		void DidFailToPresent(NSError error);

		// @required -(void)willDismissFullScreenView;
		[Abstract]
		[Export("willDismissFullScreenView")]
		void WillDismissFullScreenView();

		// @required -(void)didDismissFullScreenView;
		[Abstract]
		[Export("didDismissFullScreenView")]
		void DidDismissFullScreenView();
	}

	// @protocol GADMediationBannerAdEventDelegate <GADMediationAdEventDelegate>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GADMediationBannerAdEventDelegate : GADMediationAdEventDelegate
	{
	}

	// @protocol GADMediationInterstitialAdEventDelegate <GADMediationAdEventDelegate>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GADMediationInterstitialAdEventDelegate : GADMediationAdEventDelegate
	{
	}

	// @protocol GADMediationNativeAdEventDelegate <GADMediationAdEventDelegate>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GADMediationNativeAdEventDelegate : GADMediationAdEventDelegate
	{
		// @required -(void)didPlayVideo;
		[Abstract]
		[Export("didPlayVideo")]
		void DidPlayVideo();

		// @required -(void)didPauseVideo;
		[Abstract]
		[Export("didPauseVideo")]
		void DidPauseVideo();

		// @required -(void)didEndVideo;
		[Abstract]
		[Export("didEndVideo")]
		void DidEndVideo();

		// @required -(void)didMuteVideo;
		[Abstract]
		[Export("didMuteVideo")]
		void DidMuteVideo();

		// @required -(void)didUnmuteVideo;
		[Abstract]
		[Export("didUnmuteVideo")]
		void DidUnmuteVideo();
	}

	interface IGADMediationRewardedAdEventDelegate
	{
	}

	// @protocol GADMediationRewardedAdEventDelegate <GADMediationAdEventDelegate>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GADMediationRewardedAdEventDelegate : GADMediationAdEventDelegate
	{
		// @required -(void)didRewardUser;
		[Abstract]
		[Export("didRewardUser")]
		void DidRewardUser();

		// @required -(void)didStartVideo;
		[Abstract]
		[Export("didStartVideo")]
		void DidStartVideo();

		// @required -(void)didEndVideo;
		[Abstract]
		[Export("didEndVideo")]
		void DidEndVideo();
	}

	// @protocol GADMediationAppOpenAdEventDelegate <GADMediationAdEventDelegate>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GADMediationAppOpenAdEventDelegate : GADMediationAdEventDelegate
	{
	}

	// @protocol GADMediationAppOpenAd <GADMediationAd>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol]
	interface GADMediationAppOpenAd : GADMediationAd
	{
		// @required -(void)presentFromViewController:(UIViewController * _Nonnull)viewController;
		[Abstract]
		[Export("presentFromViewController:")]
		void PresentFromViewController(UIViewController viewController);
	}

	// @interface GADMediationAppOpenAdConfiguration : GADMediationAdConfiguration
	[BaseType(typeof(GADMediationAdConfiguration))]
	interface GADMediationAppOpenAdConfiguration
	{
	}

	// @protocol GADMediationBannerAd <GADMediationAd>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol]
	interface GADMediationBannerAd : GADMediationAd
	{
		// @required @property (readonly, nonatomic) UIView * _Nonnull view;
		[Abstract] [Export("view")] UIView View { get; }

		// @optional -(void)changeAdSizeTo:(GADAdSize)adSize;
		[Export("changeAdSizeTo:")]
		void ChangeAdSize(GADAdSize adSize);
	}

	// @protocol GADMediationInterscrollerAd <GADMediationBannerAd>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol]
	interface GADMediationInterscrollerAd : GADMediationBannerAd
	{
		// @required @property (assign, nonatomic) BOOL delegateInterscrollerEffect;
		[Abstract]
		[Export("delegateInterscrollerEffect")]
		bool DelegateInterscrollerEffect { get; set; }
	}

	// @interface GADMediationBannerAdConfiguration : GADMediationAdConfiguration
	[BaseType(typeof(GADMediationAdConfiguration))]
	interface GADMediationBannerAdConfiguration
	{
		// @property (readonly, nonatomic) GADAdSize adSize;
		[Export("adSize")] GADAdSize AdSize { get; }
	}

	// @protocol GADMediationInterstitialAd <GADMediationAd>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol]
	interface GADMediationInterstitialAd : GADMediationAd
	{
		// @required -(void)presentFromViewController:(UIViewController * _Nonnull)viewController;
		[Abstract]
		[Export("presentFromViewController:")]
		void PresentFromViewController(UIViewController viewController);
	}

	// @interface GADMediationInterstitialAdConfiguration : GADMediationAdConfiguration
	[BaseType(typeof(GADMediationAdConfiguration))]
	interface GADMediationInterstitialAdConfiguration
	{
	}

	// @protocol GADMediationNativeAd <GADMediationAd, GADMediatedUnifiedNativeAd>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol]
	interface GADMediationNativeAd : GADMediationAd, GADMediatedUnifiedNativeAd
	{
		// @optional -(BOOL)handlesUserClicks;
		[Export("handlesUserClicks")] bool HandlesUserClicks { get; }

		// @optional -(BOOL)handlesUserImpressions;
		[Export("handlesUserImpressions")] bool HandlesUserImpressions { get; }
	}

	// @interface GADMediationNativeAdConfiguration : GADMediationAdConfiguration
	[BaseType(typeof(GADMediationAdConfiguration))]
	interface GADMediationNativeAdConfiguration
	{
		// @property (readonly, nonatomic) NSArray<GADAdLoaderOptions *> * _Nonnull options;
		[Export("options")] GADAdLoaderOptions[] Options { get; }
	}


	// @protocol GADMediationRewardedAd <GADMediationAd>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol]
	interface GADMediationRewardedAd : GADMediationAd
	{
		// @required -(void)presentFromViewController:(UIViewController * _Nonnull)viewController;
		[Abstract]
		[Export("presentFromViewController:")]
		void PresentFromViewController(UIViewController viewController);
	}

	interface IGADMediationAd
	{
	}

	// @interface GADMediationRewardedAdConfiguration : GADMediationAdConfiguration
	[BaseType(typeof(GADMediationAdConfiguration))]
	interface GADMediationRewardedAdConfiguration
	{
	}

	interface IGADMediationBannerAd
	{
	}

	interface IGADMediationInterscrollerAd
	{
	}

	interface IGADMediationInterstitialAd
	{
	}

	interface IGADMediationNativeAd
	{
	}

	interface IGADMediationRewardedAd
	{
	}

	interface IGADMediationAppOpenAd
	{
	}

	interface IGADMediationAppOpenAdEventDelegate
	{}

// typedef id<GADMediationBannerAdEventDelegate> _Nullable (^GADMediationBannerLoadCompletionHandler)(id<GADMediationBannerAd> _Nullable, NSError * _Nullable);
	delegate GADMediationBannerAdEventDelegate GADMediationBannerLoadCompletionHandler ([NullAllowed] IGADMediationBannerAd ad, [NullAllowed] NSError err);

	// typedef id<GADMediationBannerAdEventDelegate> _Nullable (^GADMediationInterscrollerAdLoadCompletionHandler)(id<GADMediationInterscrollerAd> _Nullable, NSError * _Nullable);
	delegate GADMediationBannerAdEventDelegate GADMediationInterscrollerAdLoadCompletionHandler ([NullAllowed] IGADMediationInterscrollerAd ad, [NullAllowed] NSError err);

	// typedef id<GADMediationInterstitialAdEventDelegate> _Nullable (^GADMediationInterstitialLoadCompletionHandler)(id<GADMediationInterstitialAd> _Nullable, NSError * _Nullable);
	delegate GADMediationInterstitialAdEventDelegate GADMediationInterstitialLoadCompletionHandler ([NullAllowed] IGADMediationInterstitialAd ad, [NullAllowed] NSError err);

	// typedef id<GADMediationNativeAdEventDelegate> _Nullable (^GADMediationNativeLoadCompletionHandler)(id<GADMediationNativeAd> _Nullable, NSError * _Nullable);
	delegate GADMediationNativeAdEventDelegate GADMediationNativeLoadCompletionHandler ([NullAllowed] IGADMediationNativeAd ad, [NullAllowed] NSError err);

	// typedef id<GADMediationRewardedAdEventDelegate> _Nullable (^GADMediationRewardedLoadCompletionHandler)(id<GADMediationRewardedAd> _Nullable, NSError * _Nullable);
	delegate GADMediationRewardedAdEventDelegate GADMediationRewardedLoadCompletionHandler ([NullAllowed] IGADMediationRewardedAd ad, [NullAllowed] NSError err);

	// typedef id<GADMediationAppOpenAdEventDelegate> _Nullable (^GADMediationAppOpenLoadCompletionHandler)(id<GADMediationAppOpenAd> _Nullable, NSError * _Nullable);
	delegate GADMediationAppOpenAdEventDelegate GADMediationAppOpenLoadCompletionHandler ([NullAllowed] IGADMediationAppOpenAd ad, [NullAllowed] NSError err);

	// typedef void (^GADMediationAdapterSetUpCompletionBlock)(NSError * _Nullable);
	delegate void GADMediationAdapterSetUpCompletionBlock ([NullAllowed] NSError err);

	// @protocol GADMediationAdapter <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface GADMediationAdapter
	{
		// @required +(GADVersionNumber)adapterVersion;
		[Static, Abstract]
		[Export ("adapterVersion")]
		GADVersionNumber AdapterVersion { get; }

		// @required +(GADVersionNumber)adSDKVersion;
		[Static, Abstract]
		[Export ("adSDKVersion")]
		GADVersionNumber AdSDKVersion { get; }

		// @required +(Class<GADAdNetworkExtras> _Nullable)networkExtrasClass;
		[Static, Abstract]
		[NullAllowed, Export ("networkExtrasClass")]
		GADAdNetworkExtras NetworkExtrasClass { get; }

		// @optional +(void)setUpWithConfiguration:(GADMediationServerConfiguration * _Nonnull)configuration completionHandler:(GADMediationAdapterSetUpCompletionBlock _Nonnull)completionHandler;
		[Static]
		[Export ("setUpWithConfiguration:completionHandler:")]
		void SetUp (GADMediationServerConfiguration configuration, GADMediationAdapterSetUpCompletionBlock completionHandler);

		// @optional -(void)loadBannerForAdConfiguration:(GADMediationBannerAdConfiguration * _Nonnull)adConfiguration completionHandler:(GADMediationBannerLoadCompletionHandler _Nonnull)completionHandler;
		[Export ("loadBannerForAdConfiguration:completionHandler:")]
		void LoadBanner (GADMediationBannerAdConfiguration adConfiguration, GADMediationBannerLoadCompletionHandler completionHandler);

		// @optional -(void)loadInterscrollerAdForAdConfiguration:(GADMediationBannerAdConfiguration * _Nonnull)adConfiguration completionHandler:(GADMediationInterscrollerAdLoadCompletionHandler _Nonnull)completionHandler;
		[Export ("loadInterscrollerAdForAdConfiguration:completionHandler:")]
		void LoadInterscrollerAdForAdConfiguration (GADMediationBannerAdConfiguration adConfiguration, GADMediationInterscrollerAdLoadCompletionHandler completionHandler);

		// @optional -(void)loadInterstitialForAdConfiguration:(GADMediationInterstitialAdConfiguration * _Nonnull)adConfiguration completionHandler:(GADMediationInterstitialLoadCompletionHandler _Nonnull)completionHandler;
		[Export ("loadInterstitialForAdConfiguration:completionHandler:")]
		void LoadInterstitialForAdConfiguration (GADMediationInterstitialAdConfiguration adConfiguration, GADMediationInterstitialLoadCompletionHandler completionHandler);

		// @optional -(void)loadNativeAdForAdConfiguration:(GADMediationNativeAdConfiguration * _Nonnull)adConfiguration completionHandler:(GADMediationNativeLoadCompletionHandler _Nonnull)completionHandler;
		[Export ("loadNativeAdForAdConfiguration:completionHandler:")]
		void LoadNativeAd (GADMediationNativeAdConfiguration adConfiguration, GADMediationNativeLoadCompletionHandler completionHandler);

		// @optional -(void)loadRewardedAdForAdConfiguration:(GADMediationRewardedAdConfiguration * _Nonnull)adConfiguration completionHandler:(GADMediationRewardedLoadCompletionHandler _Nonnull)completionHandler;
		[Export ("loadRewardedAdForAdConfiguration:completionHandler:")]
		void LoadRewardedAd (GADMediationRewardedAdConfiguration adConfiguration, GADMediationRewardedLoadCompletionHandler completionHandler);

		// @optional -(void)loadRewardedInterstitialAdForAdConfiguration:(GADMediationRewardedAdConfiguration * _Nonnull)adConfiguration completionHandler:(GADMediationRewardedLoadCompletionHandler _Nonnull)completionHandler;
		[Export ("loadRewardedInterstitialAdForAdConfiguration:completionHandler:")]
		void LoadRewardedInterstitialAd (GADMediationRewardedAdConfiguration adConfiguration, GADMediationRewardedLoadCompletionHandler completionHandler);

		// @optional -(void)loadAppOpenAdForAdConfiguration:(GADMediationAppOpenAdConfiguration * _Nonnull)adConfiguration completionHandler:(GADMediationAppOpenLoadCompletionHandler _Nonnull)completionHandler;
		[Export ("loadAppOpenAdForAdConfiguration:completionHandler:")]
		void LoadAppOpenAd (GADMediationAppOpenAdConfiguration adConfiguration, GADMediationAppOpenLoadCompletionHandler completionHandler);
	}
	
	interface IGADMediationAppOpenLoadCompletionHandler {}

	// // @interface AdString (GADRequest)
	// [Category]
	// [BaseType (typeof(GADRequest))]
	// interface GADRequest_AdString
	// {
	// 	// @property (copy, nonatomic) NSString * _Nullable adString;
	// 	[NullAllowed, Export ("adString")]
	// 	string AdString { get; set; }
	// }

	// @interface GADRTBMediationSignalsConfiguration : NSObject
	[BaseType (typeof(NSObject))]
	interface GADRTBMediationSignalsConfiguration
	{
		// @property (readonly, nonatomic) NSArray<GADMediationCredentials *> * _Nonnull credentials;
		[Export ("credentials")]
		GADMediationCredentials[] Credentials { get; }
	}

	// @interface GADRTBRequestParameters : NSObject
	[BaseType (typeof(NSObject))]
	interface GADRTBRequestParameters
	{
		// @property (readonly, nonatomic) GADRTBMediationSignalsConfiguration * _Nonnull configuration;
		[Export ("configuration")]
		GADRTBMediationSignalsConfiguration Configuration { get; }

		// @property (readonly, nonatomic) id<GADAdNetworkExtras> _Nullable extras;
		[NullAllowed, Export ("extras")]
		GADAdNetworkExtras Extras { get; }

		// @property (readonly, nonatomic) GADAdSize adSize;
		[Export ("adSize")]
		GADAdSize AdSize { get; }
	}

	// typedef void (^GADRTBSignalCompletionHandler)(NSString * _Nullable, NSError * _Nullable);
	delegate void GADRTBSignalCompletionHandler ([NullAllowed] string str, [NullAllowed] NSError err);

	

	// @protocol GADRTBAdapter <GADMediationAdapter>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface GADRTBAdapter : GADMediationAdapter
	{
		// @required -(void)collectSignalsForRequestParameters:(GADRTBRequestParameters * _Nonnull)params completionHandler:(GADRTBSignalCompletionHandler _Nonnull)completionHandler;
		[Abstract]
		[Export ("collectSignalsForRequestParameters:completionHandler:")]
		void CompletionHandler (GADRTBRequestParameters @params, GADRTBSignalCompletionHandler completionHandler);
	}
}
