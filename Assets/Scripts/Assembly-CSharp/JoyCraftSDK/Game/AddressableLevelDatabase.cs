using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using _0024d;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace JoyCraftSDK.Game
{
	[CreateAssetMenu(fileName = "AddressableLevelDatabase", menuName = "GameSDK/AddressableLevelDatabase")]
	public class AddressableLevelDatabase : ALevelDatabase, _0024yc
	{
		[StructLayout((LayoutKind)3)]
		private struct _0024dA : IAsyncStateMachine
		{
			public int _0024LF;

			public AsyncUniTaskMethodBuilder<ALevelData> _0024mF;

			public AddressableLevelDatabase _0024MF;

			public int _0024tg;

			private int _0024xh;

			private AsyncOperationHandle<ALevelData> _0024CH;

			private UniTask<ALevelData>.Awaiter _0024Ug;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024gkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $gkA
				this._0024gkA(_1);
			}
		}

		[SerializeField]
		private List<LevelAssetEntry> levels;

		[Tooltip("Length kỳ vọng = số entry thật (set qua BuildFromFolder). KHÔNG escape khi rỗng — length-guard phải bắt list bị xoá sạch (mirror GameAssets).")]
		[SerializeField]
		private int levelEntryExactLength;

		private readonly Dictionary<int, ALevelData> _0024Wi;

		private readonly Dictionary<int, AsyncOperationHandle<ALevelData>> _0024xi;

		private readonly List<int> _0024Xi;

		private bool _0024yi;

		public override int _0024a => _0024iDA();

		public new int _0024A => _0024Ug();

		public override int _0024iDA()
		{
			return 0;
		}

		public int _0024Ug()
		{
			return 0;
		}

		public override ALevelData _0024IDA(int _1)
		{
			return null;
		}

		public ReleaseDifficulty _0024jDA(int _1)
		{
			return (ReleaseDifficulty)0;
		}

		[AsyncStateMachine(typeof(_0024dA))]
		public UniTask<ALevelData> _0024JDA(int _1)
		{
			return default;
		}

		private int _0024vg(int _1)
		{
			return 0;
		}

		private void _0024Vg(int _1)
		{
		}

		private void _0024wg()
		{
		}

		private void _0024Wg()
		{
		}
	}
}
