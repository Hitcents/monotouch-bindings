using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libTalkingDataGA.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true, SmartLink = true, Frameworks = "Security", WeakFrameworks = "CoreTelephony AdSupport", LinkerFlags = "-lz")]
