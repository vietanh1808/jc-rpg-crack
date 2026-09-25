using System.Collections.Generic;
using JoyCraftSDK.ExternalLink;
using JoyCraftSDK.Game;
using JoyCraftSDK.GameUI;
using JoyCraftSDK.IAP;
using JoyCraftSDK.LiveEvent;
using JoyCraftSDK.Notification;
using JoyCraftSDK.RateApp;
using JoyCraftSDK.RemoteConfig;
using JoyCraftSDK.SaveSystem;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace JoyCraftSDK
{
	public abstract class AGameConfig : JScriptableObject
	{
		[SerializeField]
		public SavedGameDataContainer defaultSavedGameData;

		[SerializeField]
		public List<SceneData> scenesData;

		[SerializeField]
		public AGameAssets gameAssets;

		[SerializeField]
		public AssetLabelReference initKey;

		[SerializeField]
		public AUIConfig gameUIConfig;

		[SerializeField]
		public AUIConfig testUIConfig;

		[SerializeField]
		public AUIConfig gameOverlayUIConfig;

		[SerializeField]
		public AShopContentConfig shopContentConfig;

		[SerializeField]
		public AIAPGroupConfig iapGroupConfig;

		[SerializeField]
		public AUnlockTable unlockTable;

		[SerializeField]
		public AUnlockFeatureConfig unlockFeatureConfig;

		[SerializeField]
		public ABoosterConfig boosterConfig;

		[SerializeField]
		public BuyBoosterData[] buyBoosterDatas;

		[SerializeField]
		public AEffectDatabase effectDatabase;

		[SerializeField]
		public ALevelDatabase normalLevelDatabase;

		[SerializeField]
		public ALevelDatabase hardLevelDatabase;

		[SerializeField]
		public FirebaseRemoteConfigData firebaseRemoteConfigData;

		[SerializeField]
		public ATimedRegenConfig timedRegenConfig;

		[SerializeField]
		public ATimedBuffConfig timedBuffConfig;

		[SerializeField]
		public ARateAppConfig rateAppConfig;

		[SerializeField]
		public ABattlePassConfig battlePassConfig;

		[SerializeField]
		public ANotificationConfig notificationConfig;

		[SerializeField]
		public AExternalLinkConfig externalLinkConfig;

		[SerializeField]
		public JScriptableObject gameTuningConfig;
	}
}
