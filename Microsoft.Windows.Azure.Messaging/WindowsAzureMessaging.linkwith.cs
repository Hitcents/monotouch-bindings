using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("WindowsAzureMessaging.a", LinkTarget.ArmV7 | LinkTarget.Simulator, ForceLoad = false, SmartLink = true)]
