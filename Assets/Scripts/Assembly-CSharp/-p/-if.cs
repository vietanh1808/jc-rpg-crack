using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using _0024O;
using _0024h;
using _0024l;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JoyCraftSDK.CloudSave;
using JoyCraftSDK.SaveSystem;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace _0024P
{
	internal sealed class _0024if : DefaultContractResolver
	{
		protected override JsonObjectContract CreateObjectContract(Type objectType)
		{
			return null;
		}

		protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}
	}
	public class _0024If : _0024YD
	{
		private sealed class _0024jf
		{
			public Dictionary<string, _0024Gd> _0024tP;

			internal _0024Gd _0024oIA(string _1)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024Jf : IAsyncStateMachine
		{
			public int _0024TP;

			public AsyncUniTaskMethodBuilder<CloudPushResult> _0024uP;

			public _0024If _0024WP;

			public SavedGameData _0024UP;

			public long _0024vP;

			public CancellationToken _0024VP;

			private UniTask<CloudPushResult>.Awaiter _0024Gr;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024UkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $UkA
				this._0024UkA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024kf : IAsyncStateMachine
		{
			public int _0024xP;

			public AsyncUniTaskMethodBuilder<BootSyncOutcome> _0024XP;

			public _0024If _0024aq;

			public CancellationToken _0024ZP;

			public SavedGameData _0024yP;

			public HashSet<string> _0024YP;

			private UniTask<_0024df>.Awaiter _0024Cq;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024vkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $vkA
				this._0024vkA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024Kf : IAsyncStateMachine
		{
			public int _0024dq;

			public AsyncUniTaskVoidMethodBuilder _0024Dq;

			public _0024If _0024eq;

			private List<UniTaskCompletionSource<CloudPushResult>> _0024fq;

			private UniTask<CloudPushResult>.Awaiter _0024Hq;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024VkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $VkA
				this._0024VkA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024lf : IAsyncStateMachine
		{
			public int _0024iq;

			public AsyncUniTaskMethodBuilder<CloudPushResult> _0024Iq;

			public _0024If _0024Kq;

			public SavedGameData _0024jq;

			public CancellationToken _0024kq;

			private long _0024NM;

			private int _0024zM;

			private UniTask<CloudPushResult>.Awaiter _0024pq;

			private UniTask<_0024df>.Awaiter _0024Pq;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024wkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $wkA
				this._0024wkA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024Lf : IAsyncStateMachine
		{
			public int _0024qq;

			public AsyncUniTaskMethodBuilder<CloudPushResult> _0024Qq;

			public _0024If _0024Sq;

			public SavedGameData _0024rq;

			public long _0024Rq;

			public CancellationToken _0024sq;

			private UniTask<CloudPushResult>.Awaiter _0024vq;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024WkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $WkA
				this._0024WkA(_1);
			}
		}

		private readonly _0024Df _0024pP;

		private readonly _0024rE _0024PP;

		private bool _0024qP;

		private bool _0024QP;

		private (SavedGameData root, long nowUtc, CancellationToken cancellationToken)? _0024rP;

		private List<UniTaskCompletionSource<CloudPushResult>> _0024RP;

		[CompilerGenerated]
		private CloudSaveEnvelope _0024sP;

		public new CloudSaveEnvelope _0024a
		{
			get
			{
				return _0024nbA();
			}
			private set
			{
				_0024VbA(value);
			}
		}

		private new static string _0024A => _0024GBA();

		public CloudSaveEnvelope _0024nbA()
		{
			return null;
		}

		private void _0024VbA(CloudSaveEnvelope _1)
		{
		}

		public _0024If(_0024Df cloudSaveService, _0024rE cheatGuardManager = null)
		{
		}

		private static string _0024GBA()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_0024kf))]
		public UniTask<BootSyncOutcome> _0024hBA(SavedGameData _1, HashSet<string> _1, long _1, CancellationToken _1 = default(CancellationToken))
		{
			return default;
		}

		[AsyncStateMachine(typeof(_0024Lf))]
		public UniTask<CloudPushResult> _0024HBA(SavedGameData _1, long _1, CancellationToken _1 = default(CancellationToken))
		{
			return default;
		}

		[AsyncStateMachine(typeof(_0024Kf))]
		private UniTaskVoid _0024iBA()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_0024lf))]
		private UniTask<CloudPushResult> _0024IBA(SavedGameData _1, long _1, CancellationToken _1)
		{
			return default;
		}

		private long _0024nIA(SavedGameData _1)
		{
			return 0L;
		}

		private static long _0024NIA(CloudSaveEnvelope _1)
		{
			return 0L;
		}

		private void _0024uBA(CloudSaveEnvelope _1)
		{
		}

		public bool _0024AcA()
		{
			return false;
		}

		public bool _0024bcA(out CloudSaveEnvelope _1)
		{
			_1 = null;
			return false;
		}

		public void _0024BcA()
		{
		}

		public UniTask<BootSyncOutcome> _0024ccA(SavedGameData _1)
		{
			return default;
		}

		public bool _0024CcA()
		{
			return false;
		}

		[AsyncStateMachine(typeof(_0024Jf))]
		public UniTask<CloudPushResult> _0024IcA(SavedGameData _1, long _1, CancellationToken _1 = default(CancellationToken))
		{
			return default;
		}

		private CloudSaveEnvelope _0024pcA(CloudSaveEnvelope _1, CloudSaveEnvelope _1, SavedGameData _1, HashSet<string> _1)
		{
			return null;
		}

		private static Func<string, _0024Gd> _0024AdA(SavedGameData _1)
		{
			return null;
		}

		private void _0024bdA(CloudSaveEnvelope _1, SavedGameData _1)
		{
		}

		private static bool _0024BdA(CloudSaveEnvelope _1, CloudSaveEnvelope _1)
		{
			return false;
		}

		private static string _0024Yx(CloudSaveEnvelope _1)
		{
			return null;
		}

		private static string _0024EIA(string _1)
		{
			return null;
		}
	}
}
