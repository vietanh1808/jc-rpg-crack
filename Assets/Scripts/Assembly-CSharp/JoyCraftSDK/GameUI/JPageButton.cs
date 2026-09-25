using System;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace JoyCraftSDK.GameUI
{
	public class JPageButton : JButton
	{
		[SerializeField]
		private GameObject activeArea;

		[SerializeField]
		private GameObject deactiveArea;

		[SerializeField]
		private UnityEvent<bool> onSelectedChanged;

		[SerializeField]
		private APageButtonSetup _setup;

		private bool _0024WM;

		private Action _0024xM;

		private void _0024UN()
		{
		}

		public void _0024vN(Action _1)
		{
		}

		public void _0024VN(float _1)
		{
		}

		public void _0024wN(bool _1)
		{
		}

		protected override void _0024CgA()
		{
		}
	}
}
