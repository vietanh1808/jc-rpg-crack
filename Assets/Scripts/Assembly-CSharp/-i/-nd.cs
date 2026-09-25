using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using _0024l;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace _0024i
{
	public class _0024nd : _0024YD, _0024ld
	{
		[StructLayout((LayoutKind)3)]
		private struct _0024Nd : IAsyncStateMachine
		{
			public int _0024sl;

			public AsyncUniTaskVoidMethodBuilder _0024Sl;

			public _0024nd _0024tl;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024NkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $NkA
				this._0024NkA(_1);
			}
		}

		private readonly _0024Pd _0024Rl;

		public new bool _0024a => _0024nfA();

		public bool _0024nfA()
		{
			return false;
		}

		public void _0024NfA()
		{
		}

		[AsyncStateMachine(typeof(_0024Nd))]
		private UniTaskVoid _0024Ql()
		{
			return default;
		}
	}
}
