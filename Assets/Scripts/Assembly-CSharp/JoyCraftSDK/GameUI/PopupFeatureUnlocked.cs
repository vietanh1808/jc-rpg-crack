using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.Video;

namespace JoyCraftSDK.GameUI
{
	public class PopupFeatureUnlocked : JUIPanel
	{
		[SerializeField]
		private VideoPlayer videoPlayer;

		[SerializeField]
		private TextMeshProUGUI title;

		[SerializeField]
		private TextMeshProUGUI featureName;

		[SerializeField]
		private TextMeshProUGUI featureDescription;

		private GameFeatureType _0024NN;

		public override UIPanelID _0024dgA()
		{
			return UIPanelID.None;
		}

		protected override void OnEnable()
		{
		}

		public override void _0024ngA()
		{
		}
	}
}
