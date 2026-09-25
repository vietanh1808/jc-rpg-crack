using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using _0024d;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Serialization;

namespace JoyCraftSDK.Game
{
	public class JTutorialController : ATutorialController
	{
		private sealed class _0024JC
		{
			public TutorialType _0024cj;

			internal bool _0024kh(TutorialFlow _1)
			{
				return false;
			}
		}

		private sealed class _0024kC
		{
			public JTutorialController _0024Cj;

			public int _0024dj;

			public Func<TutorialFlow, bool> _0024Dj;

			internal void _0024Kh()
			{
			}

			internal bool _0024lh(TutorialFlow _1)
			{
				return false;
			}
		}

		private sealed class _0024KC : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _0024ej;

			private object _0024Ej;

			public JTutorialController _0024fj;

			public TutorialStep _0024Fj;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return _0024meA();
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return _0024neA();
				}
			}

			[DebuggerHidden]
			public _0024KC(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void _0024LeA()
			{
			}

			void IDisposable.Dispose()
			{
				//ILSpy generated this explicit interface implementation from .override directive in $LeA
				this._0024LeA();
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
			private object _0024meA()
			{
				return null;
			}

			[DebuggerHidden]
			private void _0024MeA()
			{
			}

			void IEnumerator.Reset()
			{
				//ILSpy generated this explicit interface implementation from .override directive in $MeA
				this._0024MeA();
			}

			[DebuggerHidden]
			private object _0024neA()
			{
				return null;
			}
		}

		[FormerlySerializedAs("data")]
		[SerializeField]
		private JTutorialMainData tutorialMainData;

		private TutorialFlow _0024Aj;

		private int _0024bj;

		private _0024IC _0024Bj;

		protected override void _0024hbA()
		{
		}

		protected override void _0024HbA()
		{
		}

		private void _0024gh()
		{
		}

		private void _0024Gh(ref AEventManager._0024tA _1)
		{
		}

		public override void _0024keA(TutorialFlow _1)
		{
		}

		public override void _0024JeA()
		{
		}

		public override void _0024KeA(TutorialType _1)
		{
		}

		private void _0024hh()
		{
		}

		private void _0024Hh(GameObject _1, TutorialStep _1)
		{
		}

		[IteratorStateMachine(typeof(_0024KC))]
		private IEnumerator _0024ih(TutorialStep _1)
		{
			return null;
		}

		public void _0024Ih()
		{
		}

		public void _0024jh()
		{
		}

		public override void _0024leA()
		{
		}
	}
}
