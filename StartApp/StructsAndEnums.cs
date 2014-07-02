using System;
using System.Drawing;

namespace StartApp
{
    public enum STAAdOrigin {
        _Top = 1,
        _Bottom = 2
    }

    public enum STAAdType {
        _FullScreen = 1,
        _OfferWall = 2,
        _Automatic = 3,
        _AppWall = 4,
        _Overlay = 5
    }

    public enum STAGender {
        _Undefined = 0,
        _Female = 1,
        _Male = 2
    }

    public struct STABannerSize {
        public SizeF size;
        public bool isAuto;
    }
}

