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
	public class EasyLocalDatabaseService : ALocalDatabaseService
	{
		[StructLayout((LayoutKind)3)]
		private struct _0024Ad : IAsyncStateMachine
		{
			public int _0024yk;

			public AsyncUniTaskMethodBuilder<SavedGameData> _0024Yk;

			public EasyLocalDatabaseService _0024zk;

			private UniTask<bool>.Awaiter _0024Zk;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024HkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $HkA
				this._0024HkA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024bd : IAsyncStateMachine
		{
			public int _0024aK;

			public AsyncUniTaskMethodBuilder<SavedGameData> _0024AK;

			public EasyLocalDatabaseService _0024bK;

			private UniTask.Awaiter _0024BK;

			private UniTask<SavedGameData>.Awaiter _0024cK;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024ikA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $ikA
				this._0024ikA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024Bd : IAsyncStateMachine
		{
			public int _0024CK;

			public AsyncUniTaskMethodBuilder<SavedGameData> _0024dK;

			public EasyLocalDatabaseService _0024DK;

			public SavedGameData _0024eK;

			private UniTask<bool>.Awaiter _0024EK;

			private UniTask<SavedGameData>.Awaiter _0024fK;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024IkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $IkA
				this._0024IkA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024cd : IAsyncStateMachine
		{
			public int _0024FK;

			public AsyncUniTaskMethodBuilder<bool> _0024gK;

			public SavedGameData _0024GK;

			public EasyLocalDatabaseService _0024hK;

			private UniTask.Awaiter _0024HK;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024jkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $jkA
				this._0024jkA(_1);
			}
		}

		[SerializeField]
		private SavedGameData loadedData;

		private bool _0024Wk;

		private ES3Settings _0024xk;

		private readonly _0024Jd _0024Xk;

		private new string _0024a => _0024Ek();

		private string _0024Ek()
		{
			return null;
		}

		public override void Awake()
		{
		}

		[AsyncStateMachine(typeof(_0024Bd))]
		public override UniTask<SavedGameData> _0024DfA(SavedGameData _1)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_0024cd))]
		private UniTask<bool> _0024fk(SavedGameData _1)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_0024bd))]
		private UniTask<SavedGameData> _0024Fk()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_0024Ad))]
		private UniTask<SavedGameData> _0024gk()
		{
			return default;
		}

		private void _0024Gk(Action _1 = null)
		{
		}
	}
}
