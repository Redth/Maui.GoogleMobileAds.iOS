param (
	[String]$FromMobileAdsVersion = '11.1.0',
	[String]$FromUserMessagingPlatformVersion = '2.2.0',
	[String]$ToMobileAdsVersion = '11.2.0',
	[String]$ToUserMessagingPlatformVersion = '2.3.0'
)

# Start with clean folder
Remove-Item -Recurse -Force -Path ".build/" -ErrorAction SilentlyContinue

# Make sure dirs exist
New-Item -ItemType Directory -Force -Path ".build/" -ErrorAction SilentlyContinue
New-Item -ItemType Directory -Force -Path ".build/from/" -ErrorAction SilentlyContinue
New-Item -ItemType Directory -Force -Path ".build/to/" -ErrorAction SilentlyContinue

# Get the sdks downloaded
& ../build.ps1 -BuildPath ".build/from/" -MobileAdsVersion $FromMobileAdsVersion -UserMessagingPlatformVersion $FromUserMessagingPlatformVersion -BuildNuGet $false
& ../build.ps1 -BuildPath ".build/to/" -MobileAdsVersion $FromMobileAdsVersion -UserMessagingPlatformVersion $ToUserMessagingPlatformVersion -BuildNuGet $false

# Run the diff on the frameworks
diff -Naur ".build/from/GoogleMobileAds/Frameworks/GoogleMobileAdsFramework/GoogleMobileAds.xcframework/ios-arm64/GoogleMobileAds.framework/Headers" ".build/to/GoogleMobileAds/Frameworks/GoogleMobileAdsFramework/GoogleMobileAds.xcframework/ios-arm64/GoogleMobileAds.framework/Headers" > "./GoogleMobileAds-$FromMobileAdsVersion-to-$ToMobileAdsVersion.diff"
diff -Naur ".build/from/GoogleUserMessagingPlatform/Frameworks/Release/UserMessagingPlatform.xcframework/ios-arm64/UserMessagingPlatform.framework/Headers" ".build/to/GoogleUserMessagingPlatform/Frameworks/Release/UserMessagingPlatform.xcframework/ios-arm64/UserMessagingPlatform.framework/Headers" > "./UserMessagingPlatform-$FromUserMessagingPlatformVersion-to-$ToUserMessagingPlatformVersion-to-.diff"
