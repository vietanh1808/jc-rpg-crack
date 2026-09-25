using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.SaveSystem
{
	public abstract class ASaveDatabaseService : JMonoBehaviour
	{
		[CompilerGenerated]
		private SaveIntegrityStatus _0024wk;

		public new SaveIntegrityStatus _0024a
		{
			get
			{
				return _0024bk();
			}
			protected set
			{
				_0024Bk(value);
			}
		}

		public new abstract ALocalDatabaseService _0024A { get; }

		public SaveIntegrityStatus _0024bk()
		{
			return SaveIntegrityStatus.Unknown;
		}

		protected void _0024Bk(SaveIntegrityStatus _1)
		{
		}

		public abstract UniTask _0024BfA(SavedGameData _1);

		public abstract UniTask<SavedGameData> _0024cfA();

		public abstract UniTask _0024CfA(Action _1 = null);

		public abstract ALocalDatabaseService _0024dfA();
	}
}
