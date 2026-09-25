using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	[RequireComponent(typeof(Toggle))]
	public class ToggleEvents : AToggleEvents
	{
		[SerializeField]
		private Toggle toggle;

		private bool _0024En;

		public override void _0024OGA(bool _1)
		{
		}

		public override bool _0024pGA()
		{
			return false;
		}

		private void _0024bo(bool _1)
		{
		}

		protected override void _0024hbA()
		{
		}

		protected override void _0024HbA()
		{
		}

		private void OnValidate()
		{
		}
	}
}
