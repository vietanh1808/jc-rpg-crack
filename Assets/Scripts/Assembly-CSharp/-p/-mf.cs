using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JoyCraftSDK.CloudSave;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;

namespace _0024P
{
	public class _0024mf : _0024Df
	{
		[StructLayout((LayoutKind)3)]
		private struct _0024Mf : IAsyncStateMachine
		{
			public int _0024xq;

			public AsyncUniTaskMethodBuilder<_0024df> _0024Xq;

			public _0024mf _0024yq;

			private ManifestPayload _0024ZM;

			private UniTask<Dictionary<string, Item>>.Awaiter _0024yQ;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024xkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $xkA
				this._0024xkA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024nf : IAsyncStateMachine
		{
			public int _0024Br;

			public AsyncUniTaskMethodBuilder<CloudPushResult> _0024Dr;

			public CloudSaveEnvelope _0024er;

			public _0024mf _0024Er;

			private int _0024Bn;

			private UniTask.Awaiter _0024Kr;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024XkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $XkA
				this._0024XkA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024Nf : IAsyncStateMachine
		{
			public int _0024lr;

			public AsyncUniTaskMethodBuilder _0024Lr;

			public CloudSaveEnvelope _0024mr;

			public _0024mf _0024Nr;

			private UniTask<Dictionary<string, string>>.Awaiter _0024aR;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024ykA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $ykA
				this._0024ykA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024of : IAsyncStateMachine
		{
			public int _0024FR;

			public AsyncUniTaskMethodBuilder _0024gR;

			public CloudSaveEnvelope _0024IR;

			public _0024mf _0024jR;

			private UniTask<Dictionary<string, string>>.Awaiter _0024RR;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024YkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $YkA
				this._0024YkA(_1);
			}
		}

		private static readonly double[] _0024Vq;

		private readonly Dictionary<string, string> _0024wq;

		private bool _0024Wq;

		public override string _0024a
		{
			protected get
			{
				return _0024PhA();
			}
		}

		protected override bool _0024A
		{
			public get
			{
				return _0024xJA();
			}
		}

		protected override string _0024PhA()
		{
			return null;
		}

		public override bool _0024xJA()
		{
			return false;
		}

		private static string _0024CdA(string _1)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_0024Mf))]
		public override UniTask<_0024df> _0024XJA()
		{
			return default;
		}

		protected virtual UniTask<Dictionary<string, Item>> _0024DkA(HashSet<string> _1)
		{
			return default;
		}

		public static CloudPullStatus _0024ddA(CloudSaveExceptionReason _1)
		{
			return CloudPullStatus.None;
		}

		[AsyncStateMachine(typeof(_0024nf))]
		public override UniTask<CloudPushResult> _0024yJA(CloudSaveEnvelope _1)
		{
			return default;
		}

		protected virtual UniTask _0024ekA(double _1)
		{
			return default;
		}

		public static PushExceptionClassification _0024DdA(CloudSaveExceptionReason _1, int _1)
		{
			return PushExceptionClassification.None;
		}

		[AsyncStateMachine(typeof(_0024Nf))]
		private UniTask _0024edA(CloudSaveEnvelope _1)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_0024of))]
		private UniTask _0024EdA(CloudSaveEnvelope _1)
		{
			return default;
		}

		protected virtual UniTask<Dictionary<string, string>> _0024EkA(Dictionary<string, SaveItem> _1)
		{
			return default;
		}

		private void _0024fdA(Dictionary<string, string> _1)
		{
		}

		private static string _0024FdA(CloudSaveException _1)
		{
			return null;
		}
	}
}
