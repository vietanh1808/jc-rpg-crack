using System;
using TMPro;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class PopupMessage : JUIPanel
	{
		private sealed class _0024nD
		{
			public int _0024Io;

			public PopupMessage _0024jo;

			internal void _0024rq()
			{
			}
		}

		private sealed class _0024ND
		{
			public Action _0024Jo;

			public PopupMessage _0024ko;

			internal void _0024Rq()
			{
			}
		}

		[SerializeField]
		private TextMeshProUGUI _txtTitle;

		[SerializeField]
		private TextMeshProUGUI _txtMessage;

		[SerializeField]
		private BtnPopupAction _btnAction;

		[SerializeField]
		private GameObject[] _decorations;

		private Action _0024Ho;

		private int _0024io;

		protected override void _0024mgA()
		{
		}

		public override UIPanelID _0024dgA()
		{
			return UIPanelID.None;
		}

		public void _0024Nq(string _1, string _1 = "", Action _1 = null)
		{
		}

		public void _0024oq(string _1, string _1, string _1, Action _1, Action _1)
		{
		}

		public void _0024Oq(string _1, float _1 = 0f, Action _1 = null)
		{
		}

		public void _0024pq()
		{
		}

		private void _0024Pq()
		{
		}

		private void _0024qq(bool _1)
		{
		}

		private void _0024Qq(float _1)
		{
		}
	}
}
