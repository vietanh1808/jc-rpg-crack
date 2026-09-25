using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class BtnCloseScreenLose : JButton
	{
		[SerializeField]
		private ScreenLose screenLose;

		protected override bool _0024a => _0024PGA();

		protected override bool _0024PGA()
		{
			return false;
		}

		protected override void _0024CgA()
		{
		}
	}
}
