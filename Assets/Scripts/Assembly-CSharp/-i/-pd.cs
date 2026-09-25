using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using _0024l;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine.Networking;

namespace _0024i
{
	public static class _0024pd
	{
		public static _0024ld _0024ul()
		{
			return null;
		}
	}
	public class _0024Pd : _0024YD
	{
		[StructLayout((LayoutKind)3)]
		private struct _0024kC : IAsyncStateMachine
		{
			public int _0024dj;

			public AsyncUniTaskMethodBuilder<string> _0024Dj;

			public _0024Pd _0024vl;

			private string _0024dH;

			private UnityWebRequest _0024xl;

			private UnityAsyncExtensions.UnityWebRequestAsyncOperationAwaiter _0024Ep;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024okA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $okA
				this._0024okA(_1);
			}
		}

		private string m__0024Ul;

		private string _0024Dw()
		{
			return null;
		}

		public string _0024Ul()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_0024kC))]
		public UniTask<string> _0024vl()
		{
			return default;
		}
	}
}
