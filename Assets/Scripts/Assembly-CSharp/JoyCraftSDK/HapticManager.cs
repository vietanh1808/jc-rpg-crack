using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Lofelt.NiceVibrations;

namespace JoyCraftSDK
{
	public class HapticManager : AHapticManager
	{
		[StructLayout((LayoutKind)3)]
		private struct _0024RB : IAsyncStateMachine
		{
			public int _0024yg;

			public AsyncUniTaskVoidMethodBuilder _0024Yg;

			public HapticManager _0024zg;

			public HapticPatterns.PresetType _0024Zg;

			public float _0024aG;

			public CancellationToken _0024AG;

			public float _0024bG;

			private float _0024bh;

			private UniTask.Awaiter _0024cG;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024AkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $AkA
				this._0024AkA(_1);
			}
		}

		private CancellationTokenSource _0024xg;

		private float _0024Xg;

		private new bool _0024a => _0024Ze();

		private bool _0024Ze()
		{
			return false;
		}

		public override void Awake()
		{
		}

		private bool _0024aE(bool _1)
		{
			return false;
		}

		private void _0024AE(HapticPatterns.PresetType _1, bool _1 = true)
		{
		}

		[Conditional("UNITY_EDITOR")]
		private void _0024bE()
		{
		}

		[Conditional("UNITY_EDITOR")]
		private void _0024BE(string _1)
		{
		}

		private void _0024cE(ref AEventManager._0024LA _1)
		{
		}

		private void _0024CE(ref AEventManager._0024UA _1)
		{
		}

		public override void _0024MBA(HapticPatterns.PresetType _1, float _1, float _1 = 0.08f)
		{
		}

		[AsyncStateMachine(typeof(_0024RB))]
		private UniTaskVoid _0024dE(HapticPatterns.PresetType _1, float _1, float _1, CancellationToken _1)
		{
			return default;
		}

		public override void _0024nBA()
		{
		}

		public override void _0024NBA()
		{
		}

		public override void _0024oBA()
		{
		}

		public override void _0024OBA()
		{
		}

		public override void _0024pBA()
		{
		}

		public override void _0024PBA()
		{
		}

		public override void _0024qBA()
		{
		}

		public override void _0024QBA()
		{
		}

		public override void _0024rBA()
		{
		}

		public override void _0024RBA()
		{
		}

		public override void _0024sBA(float _1, float _1 = 0.5f)
		{
		}

		public override void _0024SBA()
		{
		}

		public override void _0024tBA(float _1, float _1 = 0.5f, float _1 = 0.5f)
		{
		}

		public override void _0024TBA()
		{
		}

		protected override void _0024hbA()
		{
		}

		protected override void _0024HbA()
		{
		}
	}
}
