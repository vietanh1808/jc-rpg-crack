using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using _0024A;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine.Networking;

namespace _0024a
{
	internal sealed class _0024c
	{
		internal struct _0024C
		{
			public global::_0024A._0024K _0024H;

			public string _0024i;

			public long _0024I;

			public string _0024j;
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024d : IAsyncStateMachine
		{
			public int _0024J;

			public AsyncUniTaskMethodBuilder<_0024C> _0024k;

			public string _0024K;

			public string _0024l;

			public _0024c _0024L;

			public CancellationToken _0024m;

			private UnityWebRequest _0024Zd;

			private UniTask<UnityWebRequest>.Awaiter _0024n;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024gjA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $gjA
				this._0024gjA(_1);
			}
		}

		private const string m__0024f = "x-api-key";

		private const string m__0024F = "/v1/events";

		private const string _0024g = "/v1/events/single";

		private readonly string _0024G;

		private readonly string _0024h;

		internal _0024c(string endpoint, string apiKey)
		{
		}

		internal UniTask<_0024C> _0024E(IReadOnlyList<global::_0024A._0024i> _1, CancellationToken _1)
		{
			return default;
		}

		internal UniTask<_0024C> _0024f(global::_0024A._0024i _1, CancellationToken _1)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_0024d))]
		private UniTask<_0024C> _0024F(string _1, string _1, CancellationToken _1)
		{
			return default;
		}
	}
}
