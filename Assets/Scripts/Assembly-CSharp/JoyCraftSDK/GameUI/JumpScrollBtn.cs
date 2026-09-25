using System;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class JumpScrollBtn : JButton
	{
		[SerializeField]
		private bool center;

		[SerializeField]
		private bool animate;

		[SerializeField]
		private GameObject activeArea;

		[SerializeField]
		private GameObject deactiveArea;

		[SerializeField]
		private Image icon;

		private AScroll _0024iO;

		private int _0024IO;

		private Action _0024jO;

		public void _0024oQ(AScroll _1, int _1, string _1, Sprite _1, Action _1 = null)
		{
		}

		public void _0024OQ(bool _1)
		{
		}

		public void _0024pQ(Sprite _1)
		{
		}

		protected override void _0024CgA()
		{
		}
	}
}
