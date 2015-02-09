using System;
using ObjCRuntime;

[assembly: LinkWith ("Tapjoy.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64, SmartLink = true, ForceLoad = true, Frameworks = "AdSupport CFNetwork CoreData CoreGraphics CoreLocation CoreMotion EventKitUI EventKit Foundation MapKit MediaPlayer MessageUI MobileCoreServices QuartzCore Security SystemConfiguration Twitter UIKit", WeakFrameworks = "CoreTelephony PassKit Social StoreKit", LinkerFlags = "-lsqlite3.0 -lxml2 -lz")]
