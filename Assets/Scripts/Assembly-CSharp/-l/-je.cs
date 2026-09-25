using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine.UI;

namespace _0024l
{
	public static class _0024je
	{
		public static BoosterType _0024pW(this UnlockableType _1)
		{
			return BoosterType.None;
		}

		public static GameFeatureType _0024PW(this UnlockableType _1)
		{
			return GameFeatureType.None;
		}

		public static UnlockableType _0024qW(this BoosterType _1)
		{
			return UnlockableType.None;
		}

		public static UnlockableType _0024QW(this GameFeatureType _1)
		{
			return UnlockableType.None;
		}

		public static bool _0024rW(this UnlockableType _1)
		{
			return false;
		}

		public static bool _0024RW(this UnlockableType _1)
		{
			return false;
		}
	}
	public static class _0024Je
	{
		private sealed class _0024ke : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _0024pQ;

			private object _0024PQ;

			public float _0024qQ;

			public float _0024QQ;

			public Image _0024rQ;

			private float _0024Yp;

			private float _0024zp;

			private float _0024Zp;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return _0024cHA();
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return _0024dHA();
				}
			}

			[DebuggerHidden]
			public _0024ke(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void _0024BHA()
			{
			}

			void IDisposable.Dispose()
			{
				//ILSpy generated this explicit interface implementation from .override directive in $BHA
				this._0024BHA();
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
			private object _0024cHA()
			{
				return null;
			}

			[DebuggerHidden]
			private void _0024CHA()
			{
			}

			void IEnumerator.Reset()
			{
				//ILSpy generated this explicit interface implementation from .override directive in $CHA
				this._0024CHA();
			}

			[DebuggerHidden]
			private object _0024dHA()
			{
				return null;
			}
		}

		private sealed class _0024Ke : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _0024tQ;

			private object _0024TQ;

			public long _0024uQ;

			public long _0024UQ;

			public TMP_Text _0024vQ;

			private long _0024aP;

			private float _0024AP;

			private float _0024bP;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return _0024eHA();
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return _0024fHA();
				}
			}

			[DebuggerHidden]
			public _0024Ke(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void _0024DHA()
			{
			}

			void IDisposable.Dispose()
			{
				//ILSpy generated this explicit interface implementation from .override directive in $DHA
				this._0024DHA();
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
			private object _0024eHA()
			{
				return null;
			}

			[DebuggerHidden]
			private void _0024EHA()
			{
			}

			void IEnumerator.Reset()
			{
				//ILSpy generated this explicit interface implementation from .override directive in $EHA
				this._0024EHA();
			}

			[DebuggerHidden]
			private object _0024fHA()
			{
				return null;
			}
		}

		[IteratorStateMachine(typeof(_0024Ke))]
		public static IEnumerator _0024sW(TMP_Text _1, long _1, long _1)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_0024ke))]
		public static IEnumerator _0024SW(Image _1, float _1, float _1)
		{
			return null;
		}
	}
}
