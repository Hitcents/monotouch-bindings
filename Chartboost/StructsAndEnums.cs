using System;
using MonoTouch.ObjCRuntime;

namespace ChartboostSDK
{
    [Native]
    public enum CBFramework : uint /* nuint */ {
        Unity,
        Corona,
        AIR,
        GameSalad,
        Cordova,
        CocoonJS
    }

    [Native]
    public enum CBLoadError : uint /* nuint */ {
        Internal,
        InternetUnavailable,
        TooManyConnections,
        WrongOrientation,
        FirstSessionInterstitialsDisabled,
        NetworkFailure,
        NoAdFound,
        SessionNotStarted,
        UserCancellation,
        NoLocationFound
    }

    [Native]
    public enum CBClickError : uint /* nuint */ {
        UriInvalid,
        UriUnrecognized,
        AgeGateFailure,
        Internal
    }
}

