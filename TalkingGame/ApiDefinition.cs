using System;
using Foundation;
using UIKit;

namespace TalkingGame {

	[BaseType (typeof (NSObject))]
	public partial interface TalkingDataGA {

		[Static, Export ("onStart:withChannelId:")]
		void OnStart (string appId, string channelId);

		[Static, Export ("onEvent:eventData:")]
		void OnEvent (string eventId, NSDictionary eventData);

		[Static, Export ("setLatitude:longitude:")]
		void SetLatitude (double latitude, double longitude);

		[Static, Export ("getDeviceId")]
		string GetDeviceId { get; }

		[Static, Export ("setVerboseLogDisabled")]
		void SetVerboseLogDisabled ();

		[Static, Export ("sdkType")]
		int SdkType { set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface TDGAAccount {

		[Static, Export ("setAccount:")]
		TDGAAccount SetAccount (string accountId);

		[Export ("accountName")]
		string AccountName { set; }

		[Export ("accountType")]
		TDGAAccountType AccountType { set; }

		[Export ("level")]
		int Level { set; }

		[Export ("gender")]
		TDGAGender Gender { set; }

		[Export ("age")]
		int Age { set; }

		[Export ("gameServer")]
		string GameServer { set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface TDGAMission {

		[Static, Export ("onBegin:")]
		void OnBegin (string missionId);

		[Static, Export ("onCompleted:")]
		void OnCompleted (string missionId);

		[Static, Export ("onFailed:failedCause:")]
		void OnFailed (string missionId, string cause);
	}

	[BaseType (typeof (NSObject))]
	public partial interface TDGAVirtualCurrency {

		[Static, Export ("onChargeRequst:iapId:currencyAmount:currencyType:virtualCurrencyAmount:paymentType:")]
		void OnChargeRequst (string orderId, string iapId, double currencyAmount, string currencyType, double virtualCurrencyAmount, string paymentType);

		[Static, Export ("onChargeSuccess:")]
		void OnChargeSuccess (string orderId);

		[Static, Export ("onReward:reason:")]
		void OnReward (double virtualCurrencyAmount, string reason);
	}

	[BaseType (typeof (NSObject))]
	public partial interface TDGAItem {

		[Static, Export ("onPurchase:itemNumber:priceInVirtualCurrency:")]
		void OnPurchase (string item, int number, double price);

		[Static, Export ("onUse:itemNumber:")]
		void OnUse (string item, int number);
	}
}
