using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace JoyCraftSDK
{
	public class EventManager : AEventManager
	{
		[StructLayout((LayoutKind)3)]
		private new struct _0024CA : IAsyncStateMachine
		{
			public int _0024JF;

			public AsyncUniTaskVoidMethodBuilder _0024kF;

			public EventManager _0024KF;

			private UniTask.Awaiter _0024lF;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024Kf(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $Kf
				this._0024Kf(_1);
			}
		}

		public override void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void LateUpdate()
		{
		}

		protected override void OnApplicationFocus(bool hasFocus)
		{
		}

		protected override void OnApplicationPause(bool pauseStatus)
		{
		}

		protected override void OnApplicationQuit()
		{
		}

		[AsyncStateMachine(typeof(_0024CA))]
		private UniTaskVoid _0024nD()
		{
			return default;
		}
	}
}
