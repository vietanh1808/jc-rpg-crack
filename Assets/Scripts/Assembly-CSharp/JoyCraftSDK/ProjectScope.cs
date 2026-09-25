using JoyCraftSDK.DOTS.Bridge;
using JoyCraftSDK.Game;
using JoyCraftSDK.GameUI;
using JoyCraftSDK.JInput;
using JoyCraftSDK.SaveSystem;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace JoyCraftSDK
{
	public class ProjectScope : LifetimeScope
	{
		[SerializeField]
		private AEcsWorldBridge ecsWorldBridge;

		[SerializeField]
		private ProjectManagers projectManager;

		[SerializeField]
		private AProjectInitManager projectInitManager;

		[SerializeField]
		private AEventManager eventManager;

		[SerializeField]
		private APoolManager poolManager;

		[SerializeField]
		private ATaskManager taskManager;

		[SerializeField]
		private AFrameRateManager frameRateManager;

		[SerializeField]
		private AInternetManager internetManager;

		[SerializeField]
		private AAudioManager audioManager;

		[SerializeField]
		private AHapticManager hapticManager;

		[SerializeField]
		private ASaveDatabaseService database;

		[SerializeField]
		private ASaveReferencesManager saveReferencesManager;

		[SerializeField]
		private AGameDataManager gameDataManager;

		[SerializeField]
		private AGuiManager guiManager;

		[SerializeField]
		private AJInputManager inputManager;

		[SerializeField]
		private AAdNetworksManager adNetworksManager;

		[SerializeField]
		private ATimeManager timeManager;

		[SerializeField]
		private ATutorialController tutorialController;

		protected override void Awake()
		{
		}

		private void _0024dD()
		{
		}

		protected override void Configure(IContainerBuilder builder)
		{
		}

		private void _0024DD(IContainerBuilder _1)
		{
		}
	}
}
