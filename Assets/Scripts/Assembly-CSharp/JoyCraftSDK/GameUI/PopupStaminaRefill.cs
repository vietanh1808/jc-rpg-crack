using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JoyCraftSDK.Game;
using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class PopupStaminaRefill : JUIPanel
	{
		[StructLayout((LayoutKind)3)]
		private struct _0024Pf : IAsyncStateMachine
		{
			public int _0024ws;

			public AsyncUniTaskVoidMethodBuilder _0024Ws;

			public PopupStaminaRefill _0024Xs;

			public CancellationToken _0024xs;

			private UniTask.Awaiter _0024ys;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024BKA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $BKA
				this._0024BKA(_1);
			}
		}

		[FormerlySerializedAs("data")]
		public PopupHeartRefillData heartRefillData;

		public TMP_Text totalUserHeartTxt;

		public TMP_Text bonusHeartTxt;

		public TMP_Text buyCoinTxt;

		public TMP_Text nextTimeTxt;

		public RectTransform clockArrowRect;

		public EasingType clockArrowEase;

		public Button buyBtn;

		public Button watchAdsBtn;

		private new static readonly UIPanelID[] _0024Rs;

		private new readonly List<AUIPanel> _0024ss;

		private bool _0024Ss;

		private CancellationTokenSource _0024ts;

		private new HeartRefillAction _0024Ts;

		private new Action _0024us;

		private new LevelPlayType _0024Us;

		private new RegenResourceType _0024vs;

		private new bool _0024Vs;

		public void _0024EgA(RegenResourceType _1, HeartRefillAction _1, Action _1, LevelPlayType _1)
		{
		}

		public override UIPanelID _0024dgA()
		{
			return UIPanelID.None;
		}

		private void Start()
		{
		}

		protected override void _0024hbA()
		{
		}

		protected override void _0024HbA()
		{
		}

		private void _0024fgA(ref AEventManager._0024nb _1)
		{
		}

		private void _0024pgA()
		{
		}

		private void _0024PgA()
		{
		}

		private void _0024qgA()
		{
		}

		private void _0024QgA()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void _0024mgA()
		{
		}

		public override void _0024ngA()
		{
		}

		private void _0024rgA()
		{
		}

		private void _0024ZGA()
		{
		}

		private void _0024aiA()
		{
		}

		private void _0024ziA()
		{
		}

		[AsyncStateMachine(typeof(_0024Pf))]
		private UniTaskVoid _0024ZiA(CancellationToken _1)
		{
			return default;
		}

		private void _0024aIA()
		{
		}

		private string _0024AIA()
		{
			return null;
		}
	}
}
