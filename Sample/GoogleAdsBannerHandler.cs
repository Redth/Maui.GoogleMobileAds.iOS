using Microsoft.Maui;
using Microsoft.Maui.Handlers;

#if IOS
using NativeBannerAdView = GoogleMobileAds.GADBannerView;
using Foundation;
using UIKit;
using GoogleMobileAds;
#else
using NativeBannerAdView = object;
#endif

namespace Sample;

public interface IGoogleAdsBannerView : IView
{

}

public partial class GoogleAdsBannerHandler : ViewHandler<IGoogleAdsBannerView, NativeBannerAdView>
{

    public GoogleAdsBannerHandler() : base(ViewHandler.ViewMapper)
    {
		
    }
    
    protected override NativeBannerAdView CreatePlatformView()
    {
#if IOS
        var viewWidth = UIKit.UIApplication.SharedApplication.KeyWindow.Frame.Width;
        
        // Here the current interface orientation is used. Use
        // GADLandscapeAnchoredAdaptiveBannerAdSizeWithWidth or
        // GADPortraitAnchoredAdaptiveBannerAdSizeWithWidth if you prefer to load an ad of a
        // particular orientation,
        var adaptiveSize = GoogleMobileAds.AdSize.GADCurrentOrientationAnchoredAdaptiveBannerAdSizeWithWidth(viewWidth);
        var bannerView = new GoogleMobileAds.GADBannerView(adaptiveSize);
        bannerView.Delegate = new BannerDg();
        return bannerView;
#else
		return null;
#endif
    }

    protected override void ConnectHandler(NativeBannerAdView platformView)
    {
        base.ConnectHandler(platformView);
        
        #if IOS
        platformView.AdUnitID = "ca-app-pub-3940256099942544/2435281174";
        platformView.RootViewController = this.ViewController;

        platformView.LoadRequest(new GoogleMobileAds.GADRequest());
#endif
    }
}

public partial class GoogleAdsBannerView : View, IGoogleAdsBannerView
{
}

#if IOS
public class BannerDg : GoogleMobileAds.GADBannerViewDelegate
{
   public override void BannerView(GADBannerView bannerView, NSError error)
	{
		Console.WriteLine("DidFailToReceiveAd " + error.Description);
	}

	public override void BannerViewDidReceiveAd(GADBannerView bannerView)
	{
		Console.WriteLine("BannerViewDidReceiveAd");
	}
}

#endif