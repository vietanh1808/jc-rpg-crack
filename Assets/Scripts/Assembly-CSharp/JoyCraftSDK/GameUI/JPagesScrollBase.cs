using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EnhancedUI.EnhancedScroller;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace JoyCraftSDK.GameUI
{
	public abstract class JPagesScrollBase : AScroll, IBeginDragHandler, IEventSystemHandler, IEndDragHandler
	{
		private sealed class _0024ID
		{
			public int _0024uM;

			public JPagesScrollBase _0024UM;

			internal void _0024uN()
			{
			}
		}

		private sealed class _0024jD : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _0024vM;

			private object _0024VM;

			public JPagesScrollBase _0024wM;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return _0024JGA();
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return _0024KGA();
				}
			}

			[DebuggerHidden]
			public _0024jD(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void _0024jGA()
			{
			}

			void IDisposable.Dispose()
			{
				//ILSpy generated this explicit interface implementation from .override directive in $jGA
				this._0024jGA();
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			private object _0024JGA()
			{
				return null;
			}

			[DebuggerHidden]
			private void _0024kGA()
			{
			}

			void IEnumerator.Reset()
			{
				//ILSpy generated this explicit interface implementation from .override directive in $kGA
				this._0024kGA();
			}

			[DebuggerHidden]
			private object _0024KGA()
			{
				return null;
			}
		}

		[SerializeField]
		protected List<JPageCellView> pages;

		[SerializeField]
		public RectTransform viewport;

		[SerializeField]
		private GameObject buttons;

		[SerializeField]
		private List<JPageButton> pageButtons;

		[SerializeField]
		private APageIndicator pageIndicator;

		[SerializeField]
		private int defaultPage;

		[SerializeField]
		private bool prewarmAll;

		[SerializeField]
		private bool fitPageToViewport;

		[HideInInspector]
		public EnhancedScroller.TweenType jumpTweenType;

		[HideInInspector]
		public float jumpTweenTime;

		[HideInInspector]
		public float swipeThreshold;

		[HideInInspector]
		public float flickVelocity;

		[HideInInspector]
		public float minFlickPercent;

		[HideInInspector]
		public UnityEvent<int> onPageChanged;

		[CompilerGenerated]
		private int _0024qM;

		private readonly Dictionary<int, JPageCellView> _0024QM;

		[CompilerGenerated]
		private float _0024rM;

		private float _0024RM;

		private Vector2 _0024sM;

		private float _0024SM;

		private bool _0024tM;

		private float _0024TM;

		protected new abstract EnhancedScroller.ScrollDirectionEnum _0024a { get; }

		public new int _0024A
		{
			get
			{
				return _0024IN();
			}
			private set
			{
				_0024jN(value);
			}
		}

		public new JPageCellView _0024b => _0024JN();

		public new float _0024B
		{
			get
			{
				return _0024kN();
			}
			private set
			{
				_0024KN(value);
			}
		}

		protected abstract EnhancedScroller.ScrollDirectionEnum _0024HGA();

		protected abstract float _0024iGA(Vector2 _1);

		protected abstract int _0024IGA(float _1);

		public int _0024IN()
		{
			return 0;
		}

		private void _0024jN(int _1)
		{
		}

		public JPageCellView _0024JN()
		{
			return null;
		}

		public float _0024kN()
		{
			return 0f;
		}

		private void _0024KN(float _1)
		{
		}

		private float _0024lN()
		{
			return 0f;
		}

		private void _0024LN(bool _1 = false)
		{
		}

		protected override void _0024hbA()
		{
		}

		protected override void _0024HbA()
		{
		}

		protected override void Start()
		{
		}

		[IteratorStateMachine(typeof(_0024jD))]
		private IEnumerator _0024mN()
		{
			return null;
		}

		private void _0024MN()
		{
		}

		private void _0024nN()
		{
		}

		private void _0024NN(int _1)
		{
		}

		private void _0024oN()
		{
		}

		private void _0024ON()
		{
		}

		public override int GetNumberOfCells(EnhancedScroller scroller)
		{
			return 0;
		}

		protected float _0024pN(int _1)
		{
			return 0f;
		}

		public override float GetCellViewSize(EnhancedScroller scroller, int dataIndex)
		{
			return 0f;
		}

		private float _0024PN(int _1)
		{
			return 0f;
		}

		public override EnhancedScrollerCellView GetCellView(EnhancedScroller scroller, int dataIndex, int cellIndex)
		{
			return null;
		}

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}

		private void _0024qN(ref AEventManager._0024zb _1)
		{
		}

		private void _0024QN()
		{
		}

		public void _0024rN(int _1, bool _1 = true)
		{
		}

		private void _0024RN()
		{
		}

		public void _0024sN(int _1)
		{
		}

		public void _0024SN()
		{
		}

		public void _0024tN()
		{
		}

		public bool _0024TN<T>(bool _1 = true) where T : JPageCellView
		{
			return false;
		}
	}
}
