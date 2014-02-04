using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Microsoft.WindowsAzure.Messaging
{
    /*@interface SBNotificationHub : NSObject

    - (void) unregisterAllWithDeviceToken:(NSData*)deviceToken completion:(void (^)(NSError* error))completion;

    // sync operations
    - (BOOL) registerNativeWithDeviceToken:(NSData*)deviceToken tags:(NSSet*)tags error:(NSError**)error;
    - (BOOL) registerTemplateWithDeviceToken:(NSData*)deviceToken name:(NSString*)templateName jsonBodyTemplate:(NSString*)bodyTemplate expiryTemplate:(NSString*)expiryTemplate tags:(NSSet*)tags error:(NSError**)error;

    - (BOOL) unregisterNativeWithError:(NSError**)error;
    - (BOOL) unregisterTemplateWithName:(NSString*)name error:(NSError**)error;

    - (BOOL) unregisterAllWithDeviceToken:(NSData*)deviceToken error:(NSError**)error;*/

    public delegate void SBNotificationHubHandler(NSError error);

    [BaseType(typeof(NSObject))]
    public interface SBNotificationHub
    {
        [Static, Export("version")]
        string Version
        {
            get;
        }

        [Export("initWithConnectionString:notificationHubPath:")]
        IntPtr Constructor(string connectionString, string notificationHubPath);

        [Export("registerNativeWithDeviceToken:tags:completion:")]
        void Register(NSData deviceToken, NSSet tags, SBNotificationHubHandler completion);

        [Export("unregisterNativeWithCompletion:")]
        void Unregister(SBNotificationHubHandler completion);
    }
}

