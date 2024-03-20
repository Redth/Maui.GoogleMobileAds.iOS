param (
	[String]$MobileAdsVersion = '11.2.0',
	[String]$UserMessagingPlatformVersion = '2.3.0',
	[String]$BuildPath = '.build/',
	[Bool]$BuildNuGet = $true,
	[Bool]$GenerateBindings = $false
)


Function DownloadGoogleMobileAdsSdks(
	[String]$MobileAdsVersion = '11.2.0',
	[String]$UserMessagingPlatformVersion = '2.3.0',
	[String]$DownloadPath = '.build/'
){
	# Get the download URL's for the Google Mobile Ads SDK tar.gz
	$GoogleMobileAdsSdkDownloadUrl = ((Invoke-WebRequest -Uri $GoogleMobileAdsPodspecUrl).Content | ConvertFrom-Json).source.http
	$GoogleUserMessagingPlatformDownloadUrl = ((Invoke-WebRequest -Uri $GoogleUserMessagingPlatformPodspecUrl).Content | ConvertFrom-Json).source.http

	# Make sure .build/ exists
	New-Item -ItemType Directory -Force -Path $DownloadPath -ErrorAction SilentlyContinue

	$AdsTgzPath = (Join-Path $DownloadPath "GoogleMobileAds.tar.gz")
	$UserMessagingPlatformTgzPath = (Join-Path $DownloadPath "GoogleUserMessagingPlatform.tar.gz")

	# Download the SDK tar.gz files
	Invoke-WebRequest $GoogleMobileAdsSdkDownloadUrl -OutFile $AdsTgzPath
	Invoke-WebRequest $GoogleUserMessagingPlatformDownloadUrl -OutFile $UserMessagingPlatformTgzPath

	$AdsSdkPath = (Join-Path $DownloadPath "GoogleMobileAds")
	$UserMessagingPlatformSdkPath = (Join-Path $DownloadPath "GoogleUserMessagingPlatform")
	
	# Make directories to extract
	New-Item -ItemType Directory -Force -Path $AdsSdkPath -ErrorAction SilentlyContinue
	New-Item -ItemType Directory -Force -Path $UserMessagingPlatformSdkPath -ErrorAction SilentlyContinue

	# Extract the tar.gz files
	& tar -xzf $AdsTgzPath -C $AdsSdkPath
	& tar -xzf $UserMessagingPlatformTgzPath -C $UserMessagingPlatformSdkPath
}

$GoogleUserMessagingPlatformPodspecUrl = "https://github.com/CocoaPods/Specs/raw/master/Specs/7/e/f/GoogleUserMessagingPlatform/$UserMessagingPlatformVersion/GoogleUserMessagingPlatform.podspec.json"
$GoogleMobileAdsPodspecUrl = "https://github.com/CocoaPods/Specs/raw/master/Specs/5/9/a/Google-Mobile-Ads-SDK/$MobileAdsVersion/Google-Mobile-Ads-SDK.podspec.json"

# Clear out old
Remove-Item -Recurse -Force -Path $BuildPath -ErrorAction SilentlyContinue

DownloadGoogleMobileAdsSdks -MobileAdsVersion $MobileAdsVersion -UserMessagingPlatformVersion $UserMessagingPlatformVersion -DownloadPath $BuildPath

if ($BuildNuGet -eq $True) {
	$NuGetOutputPath = (Join-Path $BuildPath "NuGet")
	New-Item -ItemType Directory -Force -Path $NuGetOutputPath -ErrorAction SilentlyContinue

	dotnet build -t:Pack -c:Release -p:PackageVersion=$MobileAdsVersion -p:PackageOutputPath=$NuGetOutputPath ./GoogleMobileAds.iOS.Binding/GoogleMobileAds.iOS.Binding.csproj
	dotnet build -t:Pack -c:Release -p:PackageVersion=$UserMessagingPlatformVersion -p:PackageOutputPath=$NuGetOutputPath ./UserMessagingPlatform.iOS.Binding/UserMessagingPlatform.iOS.Binding.csproj
}

if ($GenerateBindings -eq $True) {
	$BindingOutputPath = (Join-Path $BuildPath "Binding")
	New-Item -ItemType Directory -Force -Path $BindingOutputPath -ErrorAction SilentlyContinue

	& sharpie bind --sdk=iphoneos17.2 --output (Join-Path $BindingOutputPath "UserMessagingPlatform/") --namespace=UserMessagingPlatform --framework (Join-Path $BuildPath "GoogleUserMessagingPlatform/Frameworks/Release/UserMessagingPlatform.xcframework/ios-arm64/UserMessagingPlatform.framework")
	& sharpie bind --sdk=iphoneos17.2 --output (Join-Path $BindingOutputPath "GoogleMobileAds/") --namespace=GoogleMobileAds --framework (Join-Path $BuildPath "GoogleMobileAds/Frameworks/GoogleMobileAdsFramework/GoogleMobileAds.xcframework/ios-arm64/GoogleMobileAds.framework")
}
