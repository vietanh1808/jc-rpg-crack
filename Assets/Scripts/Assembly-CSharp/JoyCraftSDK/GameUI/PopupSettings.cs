using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class PopupSettings : JUIPanel
	{
		[SerializeField]
		private Toggle sfxTgl;

		[SerializeField]
		private Toggle musicTgl;

		[SerializeField]
		private Toggle hapticTgl;

		[SerializeField]
		private GameObject homeBtn;

		[SerializeField]
		private GameObject supportBtn;

		[SerializeField]
		private GameObject adminTestBtn;

		[SerializeField]
		private TextMeshProUGUI version;

		public override UIPanelID _0024dgA()
		{
			return UIPanelID.None;
		}

		protected override void _0024mgA()
		{
		}
	}
}
