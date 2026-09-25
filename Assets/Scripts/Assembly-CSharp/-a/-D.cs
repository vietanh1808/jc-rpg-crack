using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using _0024A;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace _0024a
{
	internal sealed class _0024D
	{
		[StructLayout((LayoutKind)3)]
		private struct _0024e : IAsyncStateMachine
		{
			public int _0024V;

			public AsyncUniTaskVoidMethodBuilder _0024w;

			public global::_0024A._0024i _0024W;

			public _0024D _0024x;

			private IEnumerator<global::_0024A._0024L> _0024GD;

			private UniTask<_0024c._0024C>.Awaiter _0024y;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024DJA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $DJA
				this._0024DJA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024E : IAsyncStateMachine
		{
			public int _0024Y;

			public AsyncUniTaskMethodBuilder _0024z;

			public _0024D _0024Z;

			public CancellationToken _0024aA;

			private int _0024NE;

			private UniTask<_0024c._0024C>.Awaiter _0024bA;

			private UniTask.Awaiter _0024BA;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024eJA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $eJA
				this._0024eJA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024f : IAsyncStateMachine
		{
			public int _0024cA;

			public AsyncUniTaskMethodBuilder _0024CA;

			public CancellationToken _0024dA;

			public _0024D _0024DA;

			private UniTask<int>.Awaiter _0024eA;

			private UniTask.Awaiter _0024EA;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024EJA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $EJA
				this._0024EJA(_1);
			}
		}

		internal const string _0024N = "jtd_queue";

		internal const string _0024o = "jtd_queue_version";

		internal const int _0024O = 1;

		private const int m__0024p = 30;

		private const int m__0024P = 100;

		private const int m__0024q = 500;

		private readonly _0024c _0024Q;

		private readonly _0024b _0024r;

		private readonly bool _0024R;

		private readonly bool _0024s;

		private readonly Action _0024S;

		private readonly List<global::_0024A._0024i> _0024t;

		private List<global::_0024A._0024i> _0024T;

		private bool _0024u;

		private bool _0024U;

		private UniTaskCompletionSource _0024v;

		internal _0024D(_0024c client, _0024b host, bool verbose = false, bool sendEnabled = true, Action onBeforePersist = null)
		{
		}

		internal void _0024g()
		{
		}

		internal void _0024G(global::_0024A._0024i _1)
		{
		}

		[AsyncStateMachine(typeof(_0024f))]
		private UniTask _0024h(CancellationToken _1)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_0024E))]
		internal UniTask _0024H(CancellationToken _1)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_0024e))]
		private UniTaskVoid _0024i(global::_0024A._0024i _1)
		{
			return default;
		}

		private void _0024I(bool _1)
		{
		}

		private void _0024j()
		{
		}

		private void _0024J()
		{
		}

		private void _0024k()
		{
		}

		private List<global::_0024A._0024i> _0024K(int _1)
		{
			return null;
		}

		private void _0024l(List<global::_0024A._0024i> _1)
		{
		}

		private void _0024L(IReadOnlyList<string> _1)
		{
		}

		private void _0024m(string _1)
		{
		}

		private int _0024M(_0024c._0024C _1, int _1)
		{
			return 0;
		}

		private void _0024n()
		{
		}

		internal void _0024N()
		{
		}

		private static IReadOnlyList<string> _0024o(List<global::_0024A._0024i> _1)
		{
			return null;
		}

		private static IReadOnlyDictionary<string, int> _0024O(List<global::_0024A._0024i> _1)
		{
			return null;
		}

		private void _0024p(_0024c._0024C _1)
		{
		}

		private static double _0024P()
		{
			return 0.0;
		}

		private static long _0024q()
		{
			return 0L;
		}
	}
}
