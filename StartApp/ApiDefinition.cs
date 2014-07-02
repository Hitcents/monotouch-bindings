using System.Drawing;
using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;

namespace StartApp {

	[Model, BaseType (typeof (NSObject))]
	public partial interface STADelegateProtocol {

		[Export ("didLoadAd:")]
		void DidLoadAd (STAAbstractAd ad);

		[Export ("failedLoadAd:withError:")]
		void FailedLoadAd (STAAbstractAd ad, NSError error);

		[Export ("didShowAd:")]
		void DidShowAd (STAAbstractAd ad);

		[Export ("failedShowAd:withError:")]
		void FailedShowAd (STAAbstractAd ad, NSError error);

		[Export ("didCloseAd:")]
		void DidCloseAd (STAAbstractAd ad);
	}

	[BaseType (typeof (NSObject))]
	public partial interface STAAdPreferences {

		[Export ("latitude")]
		double Latitude { get; set; }

		[Export ("longitude")]
		double Longitude { get; set; }

		[Static, Export ("prefrencesWithLatitude:andLongitude:")]
		STAAdPreferences PrefrencesWithLatitude (double latitude, double longitude);
	}

	[BaseType (typeof (NSObject))]
	public partial interface STAAbstractAd {

		[Export ("preferences", ArgumentSemantic.Retain)]
		STAAdPreferences Preferences { get; set; }

		[Export ("isReady")]
		bool IsReady { get; }

//		[Field ("STA_PortraitAdSize_320x50")]
//		STABannerSize STA_PortraitAdSize_320x50 { get; }
//
//		[Field ("STA_LandscapeAdSize_480x50")]
//		STABannerSize STA_LandscapeAdSize_480x50 { get; }
//
//		[Field ("STA_PortraitAdSize_768x90")]
//		STABannerSize STA_PortraitAdSize_768x90 { get; }
//
//		[Field ("STA_LandscapeAdSize_1024x90")]
//		STABannerSize STA_LandscapeAdSize_1024x90 { get; }
//
//		[Field ("STA_AutoAdSize")]
//		STABannerSize STA_AutoAdSize { get; }
	}

	[Model, BaseType (typeof (NSObject))]
	public partial interface STABannerDelegagteProtocol {

		[Export ("didDisplayBannerAd:")]
		void DidDisplayBannerAd (STABannerView banner);

		[Export ("failedLoadBannerAd:withError:")]
		void FailedLoadBannerAd (STABannerView banner, NSError error);

		[Export ("didClickBannerAd:")]
		void DidClickBannerAd (STABannerView banner);
	}

	[BaseType (typeof (UIView))]
    public partial interface STABannerView : IUIWebViewDelegate {

		[Export ("initWithSize:origin:withView:withDelegate:")]
		IntPtr Constructor (STABannerSize size, PointF origin, UIView view, STABannerDelegagteProtocol bannerDelegate);

		[Export ("initWithSize:autoOrigin:withView:withDelegate:")]
		IntPtr Constructor (STABannerSize size, STAAdOrigin origin, UIView view, STABannerDelegagteProtocol bannerDelegate);

		[Export ("sTABannerSize")]
		STABannerSize STABannerSize { set; }

		[Export ("origin")]
		PointF Origin { set; }

		[Export ("sTAAutoOrigin")]
		STAAdOrigin STAAutoOrigin { set; }

		[Export ("didRotateFromInterfaceOrientation:")]
		void DidRotateFromInterfaceOrientation (UIInterfaceOrientation fromInterfaceOrientation);

		[Export ("addSTABannerToCell:withIndexPath:atIntexPathSection:repeatEach:")]
		void AddSTABannerToCell (UITableViewCell cell, NSIndexPath indexPath, int section, int each);

		[Export ("addSTABannerToCell:withIndexPath:atIntexPathSection:")]
		void AddSTABannerToCell (UITableViewCell cell, NSIndexPath indexPath, int section);
	}

	[BaseType (typeof (STAAbstractAd))]
	public partial interface STAStartAppAd {

		[Export ("STAShouldAutoRotate")]
		bool STAShouldAutoRotate { get; set; }

		[Export ("startAppAdType")]
		STAAdType StartAppAdType { get; set; }

		[Export ("loadAd")]
		void LoadAd ();

		[Export ("loadAd:")]
		void LoadAd (STAAdType adType);

		[Export ("loadAd:withAdPreferences:")]
		void LoadAd (STAAdType adType, STAAdPreferences adPrefs);

		[Export ("loadAd:withDelegate:")]
        void LoadAd (STAAdType adType, STADelegateProtocol delegateProtocol);

		[Export ("loadAd:withDelegate:withAdPreferences:")]
        void LoadAd (STAAdType adType, STADelegateProtocol delegateProtocol, STAAdPreferences adPrefs);

		[Export ("showAd")]
		void ShowAd ();

		[Static, Export ("initWithAppId:developerId:")]
		void InitWithAppId (string applicationId, string developerId);
	}

	[BaseType (typeof (NSObject))]
	public partial interface STASDKPreferences {

		[Export ("age")]
		uint Age { get; set; }

		[Export ("gender")]
		STAGender Gender { get; set; }

		[Static, Export ("prefrencesWithAge:andGender:")]
		STASDKPreferences PrefrencesWithAge (uint age, STAGender gender);
	}

	[BaseType (typeof (NSObject))]
	public partial interface STAStartAppSDK {

		[Static, Export ("sharedInstance")]
		STAStartAppSDK SharedInstance { get; }

		[Export ("SDKInitialize:andAppID:")]
		void SDKInitialize (string devID, string appID);

		[Export ("appID", ArgumentSemantic.Retain)]
		string AppID { get; set; }

		[Export ("devID", ArgumentSemantic.Retain)]
		string DevID { get; set; }

		[Export ("preferences", ArgumentSemantic.Retain)]
		STASDKPreferences Preferences { get; set; }
	}
}
