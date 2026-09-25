using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using _0024l;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace _0024B
{
	public class _0024XB : _0024YD
	{
		[StructLayout((LayoutKind)3)]
		private struct _0024yB : IAsyncStateMachine
		{
			public int _0024dh;

			public AsyncUniTaskMethodBuilder<DateTime?> _0024Dh;

			public int _0024eh;

			public string _0024Eh;

			public _0024XB _0024fh;

			private UdpClient _0024Fh;

			private TimeSpan _0024gh;

			private UniTask<int>.Awaiter _0024Gh;

			private UniTask<UdpReceiveResult>.Awaiter _0024hh;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024fkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $fkA
				this._0024fkA(_1);
			}
		}

		private static readonly DateTime _0024Ch;

		[AsyncStateMachine(typeof(_0024yB))]
		public UniTask<DateTime?> _0024uE(string _1, int _1)
		{
			return default;
		}

		public static DateTime? _0024Wx(byte[] _1)
		{
			return null;
		}
	}
}
