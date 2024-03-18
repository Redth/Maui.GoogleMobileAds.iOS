using Foundation;
using ObjCRuntime;
using UIKit;
using UserMessagingPlatform;

namespace UserMessagingPlatform
{
	// @interface UMPDebugSettings : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface UMPDebugSettings : INSCopying
	{
		// @property (nonatomic) NSArray<NSString *> * _Nullable testDeviceIdentifiers;
		[NullAllowed, Export ("testDeviceIdentifiers", ArgumentSemantic.Assign)]
		string[] TestDeviceIdentifiers { get; set; }

		// @property (nonatomic) UMPDebugGeography geography;
		[Export ("geography", ArgumentSemantic.Assign)]
		UMPDebugGeography Geography { get; set; }
	}

	// @interface UMPRequestParameters : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface UMPRequestParameters : INSCopying
	{
		// @property (nonatomic) BOOL tagForUnderAgeOfConsent;
		[Export ("tagForUnderAgeOfConsent")]
		bool TagForUnderAgeOfConsent { get; set; }

		// @property (copy, nonatomic) UMPDebugSettings * _Nullable debugSettings;
		[NullAllowed, Export ("debugSettings", ArgumentSemantic.Copy)]
		UMPDebugSettings DebugSettings { get; set; }
	}

	[Static]
	partial interface Constants
	{
		// extern NSString *const _Nonnull UMPVersionString;
		[Field ("UMPVersionString", "__Internal")]
		NSString UMPVersionString { get; }
		
		// extern NSErrorDomain  _Nonnull const UMPErrorDomain;
		[Field ("UMPErrorDomain", "__Internal")]
		NSString UMPErrorDomain { get; }
	}

	// typedef void (^UMPConsentInformationUpdateCompletionHandler)(NSError * _Nullable);
	delegate void UMPConsentInformationUpdateCompletionHandler ([NullAllowed] NSError error);

	// @interface UMPConsentInformation : NSObject
	[BaseType (typeof(NSObject))]
	interface UMPConsentInformation
	{
		// @property (readonly, nonatomic, class) UMPConsentInformation * _Nonnull sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		UMPConsentInformation SharedInstance { get; }

		// @property (readonly, nonatomic) UMPConsentStatus consentStatus;
		[Export ("consentStatus")]
		UMPConsentStatus ConsentStatus { get; }

		// @property (readonly, nonatomic) BOOL canRequestAds;
		[Export ("canRequestAds")]
		bool CanRequestAds { get; }

		// @property (readonly, nonatomic) UMPFormStatus formStatus;
		[Export ("formStatus")]
		UMPFormStatus FormStatus { get; }

		// @property (readonly, nonatomic) UMPPrivacyOptionsRequirementStatus privacyOptionsRequirementStatus;
		[Export ("privacyOptionsRequirementStatus")]
		UMPPrivacyOptionsRequirementStatus PrivacyOptionsRequirementStatus { get; }

		// -(void)requestConsentInfoUpdateWithParameters:(UMPRequestParameters * _Nullable)parameters completionHandler:(UMPConsentInformationUpdateCompletionHandler _Nonnull)handler;
		[Export ("requestConsentInfoUpdateWithParameters:completionHandler:")]
		void RequestConsentInfoUpdateWithParameters ([NullAllowed] UMPRequestParameters parameters, UMPConsentInformationUpdateCompletionHandler handler);

		// -(void)reset;
		[Export ("reset")]
		void Reset ();
	}

	// typedef void (^UMPConsentFormLoadCompletionHandler)(UMPConsentForm * _Nullable, NSError * _Nullable);
	delegate void UMPConsentFormLoadCompletionHandler ([NullAllowed] UMPConsentForm arg0, [NullAllowed] NSError arg1);

	// typedef void (^UMPConsentFormPresentCompletionHandler)(NSError * _Nullable);
	delegate void UMPConsentFormPresentCompletionHandler ([NullAllowed] NSError arg0);

	// @interface UMPConsentForm : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface UMPConsentForm
	{
		// +(void)loadWithCompletionHandler:(UMPConsentFormLoadCompletionHandler _Nonnull)completionHandler;
		[Static]
		[Export ("loadWithCompletionHandler:")]
		void LoadWithCompletionHandler (UMPConsentFormLoadCompletionHandler completionHandler);

		// +(void)loadAndPresentIfRequiredFromViewController:(UIViewController * _Nonnull)viewController completionHandler:(UMPConsentFormPresentCompletionHandler _Nullable)completionHandler;
		[Static]
		[Export ("loadAndPresentIfRequiredFromViewController:completionHandler:")]
		void LoadAndPresentIfRequiredFromViewController (UIViewController viewController, [NullAllowed] UMPConsentFormPresentCompletionHandler completionHandler);

		// +(void)presentPrivacyOptionsFormFromViewController:(UIViewController * _Nonnull)viewController completionHandler:(UMPConsentFormPresentCompletionHandler _Nullable)completionHandler;
		[Static]
		[Export ("presentPrivacyOptionsFormFromViewController:completionHandler:")]
		void PresentPrivacyOptionsFormFromViewController (UIViewController viewController, [NullAllowed] UMPConsentFormPresentCompletionHandler completionHandler);

		// -(void)presentFromViewController:(UIViewController * _Nonnull)viewController completionHandler:(UMPConsentFormPresentCompletionHandler _Nullable)completionHandler;
		[Export ("presentFromViewController:completionHandler:")]
		void PresentFromViewController (UIViewController viewController, [NullAllowed] UMPConsentFormPresentCompletionHandler completionHandler);
	}

}
