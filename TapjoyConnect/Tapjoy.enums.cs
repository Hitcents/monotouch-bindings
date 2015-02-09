public enum TJCTransitionEnum {
	TJCTransitionBottomToTop = 0,
	TJCTransitionTopToBottom,
	TJCTransitionLeftToRight,
	TJCTransitionRightToLeft,
	TJCTransitionFadeEffect,
	TJCTransitionNormalToBottom,
	TJCTransitionNormalToTop,
	TJCTransitionNormalToLeft,
	TJCTransitionNormalToRight,
	TJCTransitionFadeEffectReverse,
	TJCTransitionExpand,
	TJCTransitionShrink,
	TJCTransitionFlip,
	TJCTransitionFlipReverse,
	TJCTransitionPageCurl,
	TJCTransitionPageCurlReverse,
	TJCTransitionNoEffect = -1
}

public enum TJCViewTypeEnum : uint {
	TJC_EVENT_CONTENT_VIEW,
	TJC_OFFER_WALL_AD_VIEW,
	TJC_FULL_SCREEN_AD_VIEW,
	TJC_OTHER_AD_VIEW,
	TJC_AD_VIEW_MAX
}

public enum TJCMacAddressOption : uint {
	On = 0,
	OffWithVersionCheck,
	Off
}

public enum TJCEventPreloadStatusEnum : uint {
	TJCEventPreloadPartial = 0,
	TJCEventPreloadComplete
}

public enum TJCEventRequestTypeEnum : uint {
	TJEventRequestInAppPurchase = 1,
	TJEventRequestVirtualGood,
	TJEventRequestCurrency,
	TJEventRequestNavigation
}
