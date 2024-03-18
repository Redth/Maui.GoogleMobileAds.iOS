GOOGLEMOBILEADS_IOS_SDK_VERSION=11.1.0
BINDING_OUTPUT_PATH?=../../$(BINDING_PROJECT_NAME)
BINDING_PROJECT_PATH?=../../$(BINDING_PROJECT_NAME).csproj

BINDING_NAMESPACE?=Binding
SWIFT_BUILD_PATH?=.build

GOOGLEMOBILEADS_IOS_SDK_URL?=https://dl.google.com/googleadmobadssdk/googlemobileadssdkios.zip

all: .build/GoogleMobileAdsSdkiOS-$(GOOGLEMOBILEADS_IOS_SDK_VERSION) .build/Binding/GoogleMobileAds/ApiDefinitions.cs .build/Binding/UserMessagingPlatform/ApiDefinitions.cs

.build:
	mkdir -p .build

.build/GoogleMobileAdsSdk.zip: .build
	curl -L -o .build/GoogleMobileAdsSdk.zip $(GOOGLEMOBILEADS_IOS_SDK_URL)

.build/GoogleMobileAdsSdkiOS-$(GOOGLEMOBILEADS_IOS_SDK_VERSION): .build/GoogleMobileAdsSdk.zip
	unzip -o .build/GoogleMobileAdsSdk.zip -d .build/

.build/Binding:
	mkdir -p .build/Binding

.build/Binding/GoogleMobileAds/ApiDefinitions.cs: .build/Binding
	sharpie bind --sdk=iphoneos17.2 --output .build/Binding/GoogleMobileAds/ --namespace=GoogleMobileAds --framework .build/GoogleMobileAdsSdkiOS-$(GOOGLEMOBILEADS_IOS_SDK_VERSION)/GoogleMobileAds.xcframework/ios-arm64/GoogleMobileAds.framework

.build/Binding/UserMessagingPlatform/ApiDefinitions.cs: .build/Binding
	sharpie bind --sdk=iphoneos17.2 --output .build/Binding/UserMessagingPlatform/ --namespace=UserMessagingPlatform --framework .build/GoogleMobileAdsSdkiOS-$(GOOGLEMOBILEADS_IOS_SDK_VERSION)/UserMessagingPlatform.xcframework/ios-arm64/UserMessagingPlatform.framework

clean:
	rm -Rf .build
