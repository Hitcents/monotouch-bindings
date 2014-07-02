using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libStartAppAdSDK.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s, ForceLoad = true, Frameworks = "CoreTelephony SystemConfiguration CoreGraphics StoreKit AdSupport QuartzCore")]
