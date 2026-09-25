using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	[RequireComponent(typeof(AButtonAnim))]
	public class ButtonAnimController : AButtonAnimController
	{
		[SerializeField]
		private AButtonAnim buttonAnim;

		public override void _0024BGA(bool _1 = false)
		{
		}

		public override void _0024cGA(bool _1 = false)
		{
		}

		public override bool _0024CGA()
		{
			return false;
		}

		private void OnValidate()
		{
		}
	}
}
