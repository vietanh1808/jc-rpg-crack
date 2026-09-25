using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class SwitchToggleEvents : JMonoBehaviour
	{
		[SerializeField]
		private AToggleEvents toggleEvents;

		[SerializeField]
		private ASwitchToggleBgData switchToggleBgData;

		[SerializeField]
		private bool activateText;

		[SerializeField]
		private TextMeshProUGUI textOff;

		[SerializeField]
		private TextMeshProUGUI textOn;

		private Image _0024Cn;

		private Image _0024dn;

		private RectTransform _0024Dn;

		private Vector2 _0024en;

		public override void Awake()
		{
		}

		private void _0024Ao(bool _1)
		{
		}

		protected override void OnDestroy()
		{
		}

		private void OnValidate()
		{
		}
	}
}
