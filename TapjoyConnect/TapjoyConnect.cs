using System;

namespace TapjoySDK
{
    public partial class TapjoyConnect
    {
        public const string TJC_CONNECT_SUCCESS = "TJC_Connect_Success";
        public const string TJC_CONNECT_FAILED = "TJC_Connect_Failed";

        // This notification is fired after getTapPoints has been called, and indicates that user currency amount has been received from the server.
        public const string TJC_TAP_POINTS_RESPONSE_NOTIFICATION = "TJC_TAP_POINTS_RESPONSE_NOTIFICATION";
        // This notification is fired after spendTapPoints has been called, and indicates that the user has successfully spent currency.
        public const string TJC_SPEND_TAP_POINTS_RESPONSE_NOTIFICATION = "TJC_SPEND_TAP_POINTS_RESPONSE_NOTIFICATION";
        // This notification is fired after awardTapPoints has been called, and indicates that the user has successfully been awarded currency.
        public const string TJC_AWARD_TAP_POINTS_RESPONSE_NOTIFICATION = "TJC_AWARD_TAP_POINTS_RESPONSE_NOTIFICATION";

        // Error notification for getTapPoints.
        public const string TJC_TAP_POINTS_RESPONSE_NOTIFICATION_ERROR = "TJC_TAP_POINTS_RESPONSE_NOTIFICATION_ERROR";
        // Error notification for spendTapPoints
        public const string TJC_SPEND_TAP_POINTS_RESPONSE_NOTIFICATION_ERROR = "TJC_SPEND_TAP_POINTS_RESPONSE_NOTIFICATION_ERROR";
        // Error notification for awardTapPoints
        public const string TJC_AWARD_TAP_POINTS_RESPONSE_NOTIFICATION_ERROR = "TJC_AWARD_TAP_POINTS_RESPONSE_NOTIFICATION_ERROR";

        // Notification that is fired after an event has been logged.
        public const string TJC_EVENT_TRACKING_RESPONSE_NOTIFICATION = "TJC_EVENT_TRACKING_RESPONSE_NOTIFICATION";
        // Error notification for Event Tracking.
        public const string TJC_EVENT_TRACKING_RESPONSE_NOTIFICATION_ERROR = "TJC_EVENT_TRACKING_RESPONSE_NOTIFICATION_ERROR";

        // Full Screen Ad notification is fired after full screen ad data is received from the server.
        public const string TJC_FULL_SCREEN_AD_RESPONSE_NOTIFICATION = "TJC_FULL_SCREEN_AD_RESPONSE_NOTIFICATION";
        // Error notification for Full Screen Ad.
        public const string TJC_FULL_SCREEN_AD_RESPONSE_NOTIFICATION_ERROR = "TJC_FULL_SCREEN_AD_RESPONSE_NOTIFICATION_ERROR";

        // Offers notification is fired after the ad data is loaded.
        public const string TJC_OFFERS_RESPONSE_NOTIFICATION = "TJC_OFFERS_RESPONSE_NOTIFICATION";
        // Error notification for offers.
        public const string TJC_OFFERS_RESPONSE_NOTIFICATION_ERROR = "TJC_OFFERS_RESPONSE_NOTIFICATION_ERROR";

        // Notification that a user has just successfully completed an offer and earned currency. This only fires on init/resume.
        public const string TJC_TAPPOINTS_EARNED_NOTIFICATION = "TJC_TAPPOINTS_EARNED_NOTIFICATION";

        // Fired when any Tapjoy view is closed.
        public const string TJC_VIEW_CLOSED_NOTIFICATION = "TJC_VIEW_CLOSED_NOTIFICATION";

        // Fired when a webview fails to load
        public const string TJC_VIEW_LOADING_ERROR_NOTIFICATION = "TJC_VIEW_LOADING_ERROR_NOTIFICATION";

        // The keys for the options dictionary when calling requestTapjoyConnect.
        public const string TJC_OPTION_DISABLE_VIDEOS = "TJC_OPTION_DISABLE_VIDEOS";
        public const string TJC_OPTION_VIDEO_CACHE_COUNT = "TJC_OPTION_VIDEO_CACHE_COUNT";
        public const string TJC_OPTION_FULL_SCREEN_AD_DELAY_COUNT = "TJC_OPTION_FULL_SCREEN_AD_DELAY_COUNT";
        public const string TJC_OPTION_ENABLE_LOGGING = "TJC_OPTION_ENABLE_LOGGING";
        public const string TJC_OPTION_USER_ID = "TJC_OPTION_USER_ID";
        public const string TJC_OPTION_TRANSITION_EFFECT = "TJC_OPTION_TRANSITION_EFFECT";
        public const string TJC_OPTION_CLEAR_SHARED_URL_CACHE = "TJC_OPTION_CLEAR_SHARED_URL_CACHE";
        public const string TJC_OPTION_COLLECT_MAC_ADDRESS = "TJC_OPTION_COLLECT_MAC_ADDRESS";
        public const string TJC_OPTION_DISABLE_GENERIC_ERROR_ALERT = "TJC_OPTION_DISABLE_GENERIC_ERROR_ALERT";
        public const string TJC_OPTION_SEGMENTATION_PARAMS = "TJC_OPTION_SEGMENTATION_PARAMS";

        public const string TJC_DISPLAY_AD_SIZE_320X50 = "320x50";
        public const string TJC_DISPLAY_AD_SIZE_640X100 = "640x100";
        public const string TJC_DISPLAY_AD_SIZE_768X90 = "768x90";
    }
}

