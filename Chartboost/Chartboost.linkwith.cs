using System;
using ObjCRuntime;

[assembly: LinkWith ("Chartboost.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64, SmartLink = true, ForceLoad = true, Frameworks = "StoreKit Foundation CoreGraphics UIKit")]
