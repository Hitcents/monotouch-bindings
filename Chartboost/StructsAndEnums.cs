using System;
using ObjCRuntime;

namespace ChartboostSDK
{
    [Native]
    public enum CBFramework : ulong /* nuint */ {
        Unity,
        Corona,
        AIR,
        GameSalad,
        Cordova,
        CocoonJS
    }

    [Native]
    public enum CBLoadError : ulong /* nuint */ {
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
    public enum CBClickError : ulong /* nuint */ {
        UriInvalid,
        UriUnrecognized,
        AgeGateFailure,
        Internal
    }
}

