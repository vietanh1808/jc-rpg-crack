using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using _0024l;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JoyCraftSDK;
using JoyCraftSDK.AdminTest;
using JoyCraftSDK.Utilities;
using Sigtrap.Relays;
using UnityEngine;

namespace _0024K
{
	public abstract class _0024xD : _0024YD
	{
		public Relay<GameTheme> _0024jp;

		public Relay<Color> _0024Jp;

		public Relay<Sprite> _0024kp;

		public Relay<BackgroundMode> _0024Kp;

		public Relay<SoundType, AudioClip> _0024lp;

		public new abstract bool _0024a { get; set; }

		public new abstract DevToolsData _0024A { get; protected set; }

		public abstract bool _0024LhA();

		public abstract void _0024mhA(bool _1);

		public abstract DevToolsData _0024MhA();

		protected abstract void _0024nhA(DevToolsData _1);

		public abstract void _0024NhA(BackgroundMode _1);
	}
	public class _0024XD : _0024yD
	{
		[StructLayout((LayoutKind)3)]
		private struct _0024tf : IAsyncStateMachine
		{
			public int _0024YS;

			public AsyncUniTaskVoidMethodBuilder _0024zS;

			public _0024XD _0024ZS;

			private UniTask<bool>.Awaiter _0024bt;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024cKA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $cKA
				this._0024cKA(_1);
			}
		}

		private CheatData _0024Mp;

		private bool _0024np;

		public override CheatData _0024a
		{
			get
			{
				return _0024ohA();
			}
			protected set
			{
				_0024OhA(value);
			}
		}

		public override CheatData _0024ohA()
		{
			return null;
		}

		protected override void _0024OhA(CheatData _1)
		{
		}

		private void _0024Yr(ref AEventManager._0024yb _1)
		{
		}

		[AsyncStateMachine(typeof(_0024tf))]
		private UniTaskVoid _0024sx()
		{
			return default;
		}

		public override void _0024phA()
		{
		}
	}
}
