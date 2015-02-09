using System;
using ObjCRuntime;

[assembly: LinkWith ("libTalkingDataGA.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator | LinkTarget.Arm64, ForceLoad = true, SmartLink = true, Frameworks = "Security", WeakFrameworks = "CoreTelephony AdSupport", LinkerFlags = "-lz")]
