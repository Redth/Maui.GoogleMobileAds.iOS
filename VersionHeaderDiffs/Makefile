FROM_VERSION?=11.1.0
TO_VERSION?=11.2.0

FROM_PODSPEC_URL=https://github.com/CocoaPods/Specs/raw/master/Specs/5/9/a/Google-Mobile-Ads-SDK/$(FROM_VERSION)/Google-Mobile-Ads-SDK.podspec.json
TO_PODSPEC_URL=https://github.com/CocoaPods/Specs/raw/master/Specs/5/9/a/Google-Mobile-Ads-SDK/$(TO_VERSION)/Google-Mobile-Ads-SDK.podspec.json

URL_PATTERN=https://dl.google.com/dl/.*/Google-Mobile-Ads-SDK-.*gz


all:
	rm -rf .tmp
	mkdir -p .tmp
	curl -L $(FROM_PODSPEC_URL) -o .tmp/from.json
	curl -L $(TO_PODSPEC_URL) -o .tmp/to.json
	grep -o -e '$(URL_PATTERN)' .tmp/from.json | xargs curl -L -o .tmp/from.tar.gz
	grep -o -e '$(URL_PATTERN)' .tmp/to.json | xargs curl -L -o .tmp/to.tar.gz
	mkdir -p .tmp/from
	tar -xvf .tmp/from.tar.gz -C .tmp/from
	mkdir -p .tmp/to
	tar -xvf .tmp/to.tar.gz -C .tmp/to
	diff -Naur .tmp/from/Frameworks/GoogleMobileAdsFramework/GoogleMobileAds.xcframework/ios-arm64/GoogleMobileAds.framework/Headers .tmp/to/Frameworks/GoogleMobileAdsFramework/GoogleMobileAds.xcframework/ios-arm64/GoogleMobileAds.framework/Headers > ./diff-$(FROM_VERSION)-to-$(TO_VERSION).diff

