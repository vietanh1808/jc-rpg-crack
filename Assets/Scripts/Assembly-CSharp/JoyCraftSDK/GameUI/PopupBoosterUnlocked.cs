using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

namespace JoyCraftSDK.GameUI
{
	public class PopupBoosterUnlocked : JUIPanel
	{
		[SerializeField]
		private VideoPlayer videoPlayer;

		[SerializeField]
		private TextMeshProUGUI title;

		[SerializeField]
		private TextMeshProUGUI boosterName;

		[SerializeField]
		private TextMeshProUGUI boosterDescription;

		private BoosterType _0024nN;

		[SerializeField]
		private Button playBtn;

		public new Vector3 _0024a => _0024SP();

		public new Transform _0024A => _0024tP();

		public override UIPanelID _0024dgA()
		{
			return UIPanelID.None;
		}

		private void Start()
		{
		}

		public Vector3 _0024SP()
		{
			return default;
		}

		public Transform _0024tP()
		{
			return null;
		}

		private void _0024TP()
		{
		}

		protected override void OnEnable()
		{
		}

		public override void _0024ngA()
		{
		}
	}
}
