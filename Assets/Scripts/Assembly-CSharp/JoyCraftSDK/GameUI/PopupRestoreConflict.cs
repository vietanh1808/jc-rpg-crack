using System;
using TMPro;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class PopupRestoreConflict : JUIPanel
	{
		private sealed class _0024pf
		{
			public Action _0024Qs;

			public Action _0024rs;

			internal void _0024DgA()
			{
			}

			internal void _0024egA()
			{
			}
		}

		[SerializeField]
		private TextMeshProUGUI _txtTitle;

		[SerializeField]
		private TextMeshProUGUI _txtMessage;

		[SerializeField]
		private GameObject _mainChoiceGroup;

		[SerializeField]
		private BtnPopupAction _btnKeepServer;

		[SerializeField]
		private BtnPopupAction _btnKeepLocal;

		[SerializeField]
		private GameObject _localConfirmGroup;

		[SerializeField]
		private TextMeshProUGUI _txtLocalConfirmMessage;

		[SerializeField]
		private BtnPopupAction _btnConfirmLocal;

		[SerializeField]
		private BtnPopupAction _btnCancelLocalConfirm;

		protected override void _0024mgA()
		{
		}

		public override UIPanelID _0024dgA()
		{
			return UIPanelID.None;
		}

		public void _0024JfA(string _1, string _1, string _1, string _1, string _1, string _1, Action _1, Action _1)
		{
		}

		public void _0024lfA()
		{
		}

		private void _0024ofA()
		{
		}

		private void _0024rfA()
		{
		}
	}
}
