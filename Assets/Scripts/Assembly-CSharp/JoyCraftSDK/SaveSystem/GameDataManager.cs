using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using VContainer;

namespace JoyCraftSDK.SaveSystem
{
	public class GameDataManager : AGameDataManager
	{
		[StructLayout((LayoutKind)3)]
		private struct _0024UE : IAsyncStateMachine
		{
			public int _0024Rn;

			public AsyncUniTaskMethodBuilder _0024sn;

			public GameDataManager _0024tn;

			public Action _0024Sn;

			private UniTask.Awaiter _0024un;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024KkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $KkA
				this._0024KkA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024vE : IAsyncStateMachine
		{
			public int _0024Un;

			public AsyncUniTaskMethodBuilder _0024Wn;

			public GameDataManager _0024Yn;

			public Action _0024yn;

			private UniTask<SavedGameData>.Awaiter _0024BN;

			private UniTask.Awaiter _0024cN;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024lkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $lkA
				this._0024lkA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024VE : IAsyncStateMachine
		{
			public int _0024fN;

			public AsyncUniTaskMethodBuilder _0024FN;

			public GameDataManager _0024HN;

			private UniTask.Awaiter _0024iN;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024LkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $LkA
				this._0024LkA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024wE : IAsyncStateMachine
		{
			public int _0024IN;

			public AsyncUniTaskMethodBuilder _0024jN;

			public GameDataManager _0024kN;

			private UniTask.Awaiter _0024rN;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024mkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $mkA
				this._0024mkA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024WE : IAsyncStateMachine
		{
			public int _0024vN;

			public AsyncUniTaskMethodBuilder _0024VN;

			public GameDataManager _0024Ao;

			public Action _0024ao;

			private UniTask<SavedGameData>.Awaiter _0024fo;

			private UniTask.Awaiter _0024Fo;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024MkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $MkA
				this._0024MkA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024xE : IAsyncStateMachine
		{
			public int _0024go;

			public AsyncUniTaskMethodBuilder _0024no;

			public GameDataManager _0024No;

			private UniTask.Awaiter _0024oo;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024nkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $nkA
				this._0024nkA(_1);
			}
		}

		private ASaveDatabaseService _0024OK;

		private bool _0024pK;

		private bool _0024PK;

		private new ALocalDatabaseService _0024a => _0024Ik();

		private ALocalDatabaseService _0024Ik()
		{
			return null;
		}

		[Inject]
		public void _0024kk(ASaveDatabaseService _1)
		{
		}

		[AsyncStateMachine(typeof(_0024UE))]
		public override UniTask _0024IEA(Action _1 = null)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_0024xE))]
		private UniTask _0024Kk()
		{
			return default;
		}

		public override void _0024jEA()
		{
		}

		[AsyncStateMachine(typeof(_0024WE))]
		public override UniTask _0024JEA(Action _1 = null)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_0024vE))]
		private UniTask _0024lk(Action _1 = null)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_0024wE))]
		private UniTask _0024Lk()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_0024VE))]
		private UniTask _0024mk()
		{
			return default;
		}

		protected override void OnApplicationPause(bool pauseStatus)
		{
		}

		protected override void OnApplicationQuit()
		{
		}

		private void _0024Ok()
		{
		}

		private bool _0024pk()
		{
			return false;
		}

		private void _0024Pk()
		{
		}
	}
}
