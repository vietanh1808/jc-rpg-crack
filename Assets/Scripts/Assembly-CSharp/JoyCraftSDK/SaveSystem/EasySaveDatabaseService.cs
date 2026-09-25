using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using _0024h;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	public class EasySaveDatabaseService : ASaveDatabaseService
	{
		[StructLayout((LayoutKind)3)]
		private struct _0024TE : IAsyncStateMachine
		{
			public int _0024iM;

			public AsyncUniTaskMethodBuilder<SavedGameData> _0024IM;

			public EasySaveDatabaseService _0024nM;

			private UniTask.Awaiter _0024pM;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024JkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $JkA
				this._0024JkA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024uE : IAsyncStateMachine
		{
			public int _0024PM;

			public AsyncUniTaskMethodBuilder<SavedGameData> _0024XM;

			public EasySaveDatabaseService _0024yM;

			private UniTask.Awaiter _0024mn;

			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _0024Mn;

			private UniTask<SavedGameData>.Awaiter _0024nn;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024kkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $kkA
				this._0024kkA(_1);
			}
		}

		[SerializeField]
		private SavedGameData loadedData;

		private readonly float _0024iK;

		private ES3Settings _0024IK;

		private readonly _0024Jd _0024jK;

		[SerializeField]
		private ALocalDatabaseService easyLocalDatabaseService;

		private new string _0024a => _0024hk();

		public override ALocalDatabaseService _0024A => _0024dfA();

		private string _0024hk()
		{
			return null;
		}

		public override UniTask _0024BfA(SavedGameData _1)
		{
			return default;
		}

		private void _0024fo(SavedGameData _1)
		{
		}

		private void _0024Fo(SavedGameData _1)
		{
		}

		private SavedGameData _0024go(out int _1, out int _1)
		{
			_1 = default;
			_1 = default;
			return null;
		}

		[AsyncStateMachine(typeof(_0024uE))]
		public override UniTask<SavedGameData> _0024cfA()
		{
			return default;
		}

		private SavedGameData _0024Hk(Exception _1)
		{
			return null;
		}

		public override UniTask _0024CfA(Action _1 = null)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_0024TE))]
		private UniTask<SavedGameData> _0024ik()
		{
			return default;
		}

		public override ALocalDatabaseService _0024dfA()
		{
			return null;
		}

		private void OnValidate()
		{
		}
	}
}
