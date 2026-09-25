using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GooglePlayGames.BasicApi;
using JoyCraftSDK;

namespace _0024g
{
	public class _0024UC : _0024TC
	{
		private sealed class _0024Ne
		{
			public UniTaskCompletionSource<SignInStatus> _0024ak;

			internal void _0024sw(SignInStatus _1)
			{
			}
		}

		private sealed class _0024qf
		{
			public UniTaskCompletionSource<string> _0024IS;

			internal void _0024Sw(string _1)
			{
			}
		}

		private sealed class _0024Rf
		{
			public UniTaskCompletionSource<SignInStatus> _0024jS;

			internal void _0024Rx(SignInStatus _1)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024sf : IAsyncStateMachine
		{
			public int _0024JS;

			public AsyncUniTaskMethodBuilder<string> _0024kS;

			public _0024UC _0024KS;

			private UniTask<SignInStatus>.Awaiter _0024NS;

			private UniTask<string>.Awaiter _0024oS;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024UJA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $UJA
				this._0024UJA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024vC : IAsyncStateMachine
		{
			public int _0024YJ;

			public AsyncUniTaskMethodBuilder _0024zJ;

			public _0024UC _0024ZJ;

			private UniTask.Awaiter _0024Ak;

			private UniTask<string>.Awaiter _0024SS;

			private bool _0024Ah;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024VJA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $VJA
				this._0024VJA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024Sf : IAsyncStateMachine
		{
			public int _0024tS;

			public AsyncUniTaskMethodBuilder<bool> _0024TS;

			public _0024UC _0024uS;

			private UniTask<SignInStatus>.Awaiter _0024xS;

			private UniTask<string>.Awaiter _0024XS;

			private UniTask.Awaiter _0024yS;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024wJA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $wJA
				this._0024wJA(_1);
			}
		}

		private string _0024xJ;

		private bool _0024XJ;

		private AuthState _0024yJ;

		public override string _0024a
		{
			protected get
			{
				return _0024PhA();
			}
		}

		public override string _0024A => _0024VIA();

		public override bool _0024b => _0024wIA();

		protected override AuthState _0024B
		{
			public get
			{
				return _0024WIA();
			}
		}

		protected override string _0024PhA()
		{
			return null;
		}

		public override string _0024VIA()
		{
			return null;
		}

		public override bool _0024wIA()
		{
			return false;
		}

		public override AuthState _0024WIA()
		{
			return AuthState.NotInitialized;
		}

		[AsyncStateMachine(typeof(_0024vC))]
		public override UniTask _0024xIA()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_0024Sf))]
		public override UniTask<bool> _0024Sx()
		{
			return default;
		}

		protected virtual UniTask _0024XIA()
		{
			return default;
		}

		protected virtual bool _0024tx()
		{
			return false;
		}

		protected virtual UniTask _0024yIA()
		{
			return default;
		}

		protected virtual string _0024YIA()
		{
			return null;
		}

		protected virtual bool _0024zIA()
		{
			return false;
		}

		protected virtual bool _0024Tx()
		{
			return false;
		}

		protected virtual bool _0024ux()
		{
			return false;
		}

		[AsyncStateMachine(typeof(_0024sf))]
		protected virtual UniTask<string> _0024Ux()
		{
			return default;
		}

		private UniTask<string> _0024Rw()
		{
			return default;
		}

		protected virtual UniTask<SignInStatus> _0024vx()
		{
			return default;
		}

		protected virtual UniTask _0024Vx(string _1)
		{
			return default;
		}

		protected virtual UniTask _0024wx(string _1)
		{
			return default;
		}

		private void _0024TH(AuthState _1)
		{
		}
	}
}
