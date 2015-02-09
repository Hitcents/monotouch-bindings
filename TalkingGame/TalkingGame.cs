// @interface TalkingDataGA : NSObject
[BaseType (typeof (NSObject))]
interface TalkingDataGA {

	// +(void)onStart:(NSString *)appId withChannelId:(NSString *)channelId;
	[Static, Export ("onStart:withChannelId:")]
	void OnStart (string appId, string channelId);

	// +(void)onEvent:(NSString *)eventId eventData:(NSDictionary *)eventData;
	[Static, Export ("onEvent:eventData:")]
	void OnEvent (string eventId, NSDictionary eventData);

	// +(void)setLatitude:(double)latitude longitude:(double)longitude;
	[Static, Export ("setLatitude:longitude:")]
	void SetLatitude (double latitude, double longitude);

	// +(NSString *)getDeviceId;
	[Static, Export ("getDeviceId")]
	string GetDeviceId ();

	// +(void)setDeviceToken:(NSData *)deviceToken;
	[Static, Export ("setDeviceToken:")]
	void SetDeviceToken (NSData deviceToken);

	// +(BOOL)handleTDGAPushMessage:(NSDictionary *)message;
	[Static, Export ("handleTDGAPushMessage:")]
	bool HandleTDGAPushMessage (NSDictionary message);

	// +(void)setVerboseLogDisabled;
	[Static, Export ("setVerboseLogDisabled")]
	void SetVerboseLogDisabled ();

	// +(void)setSdkType:(int)type;
	[Static, Export ("setSdkType:")]
	void SetSdkType (int type);
}

// @interface TDGAAccount : NSObject
[BaseType (typeof (NSObject))]
interface TDGAAccount {

	// +(TDGAAccount *)setAccount:(NSString *)accountId;
	[Static, Export ("setAccount:")]
	TDGAAccount SetAccount (string accountId);

	// -(void)setAccountName:(NSString *)accountName;
	[Export ("setAccountName:")]
	void SetAccountName (string accountName);

	// -(void)setAccountType:(TDGAAccountType)accountType;
	[Export ("setAccountType:")]
	void SetAccountType ( accountType);

	// -(void)setLevel:(int)level;
	[Export ("setLevel:")]
	void SetLevel (int level);

	// -(void)setGender:(TDGAGender)gender;
	[Export ("setGender:")]
	void SetGender ( gender);

	// -(void)setAge:(int)age;
	[Export ("setAge:")]
	void SetAge (int age);

	// -(void)setGameServer:(NSString *)gameServer;
	[Export ("setGameServer:")]
	void SetGameServer (string gameServer);
}

// @interface TDGAMission : NSObject
[BaseType (typeof (NSObject))]
interface TDGAMission {

	// +(void)onBegin:(NSString *)missionId;
	[Static, Export ("onBegin:")]
	void OnBegin (string missionId);

	// +(void)onCompleted:(NSString *)missionId;
	[Static, Export ("onCompleted:")]
	void OnCompleted (string missionId);

	// +(void)onFailed:(NSString *)missionId failedCause:(NSString *)cause;
	[Static, Export ("onFailed:failedCause:")]
	void OnFailed (string missionId, string cause);
}

// @interface TDGAVirtualCurrency : NSObject
[BaseType (typeof (NSObject))]
interface TDGAVirtualCurrency {

	// +(void)onChargeRequst:(NSString *)orderId iapId:(NSString *)iapId currencyAmount:(double)currencyAmount currencyType:(NSString *)currencyType virtualCurrencyAmount:(double)virtualCurrencyAmount paymentType:(NSString *)paymentType;
	[Static, Export ("onChargeRequst:iapId:currencyAmount:currencyType:virtualCurrencyAmount:paymentType:")]
	void OnChargeRequst (string orderId, string iapId, double currencyAmount, string currencyType, double virtualCurrencyAmount, string paymentType);

	// +(void)onChargeSuccess:(NSString *)orderId;
	[Static, Export ("onChargeSuccess:")]
	void OnChargeSuccess (string orderId);

	// +(void)onReward:(double)virtualCurrencyAmount reason:(NSString *)reason;
	[Static, Export ("onReward:reason:")]
	void OnReward (double virtualCurrencyAmount, string reason);
}

// @interface TDGAItem : NSObject
[BaseType (typeof (NSObject))]
interface TDGAItem {

	// +(void)onPurchase:(NSString *)item itemNumber:(int)number priceInVirtualCurrency:(double)price;
	[Static, Export ("onPurchase:itemNumber:priceInVirtualCurrency:")]
	void OnPurchase (string item, int number, double price);

	// +(void)onUse:(NSString *)item itemNumber:(int)number;
	[Static, Export ("onUse:itemNumber:")]
	void OnUse (string item, int number);
}
