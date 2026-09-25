using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.SaveSystem
{
	public abstract class ALocalDatabaseService : JMonoBehaviour
	{
		[CompilerGenerated]
		private SaveIntegrityStatus _0024vm;

		public new SaveIntegrityStatus _0024a
		{
			get
			{
				return _0024eo();
			}
			protected set
			{
				_0024Eo(value);
			}
		}

		public SaveIntegrityStatus _0024eo()
		{
			return SaveIntegrityStatus.Unknown;
		}

		protected void _0024Eo(SaveIntegrityStatus _1)
		{
		}

		public abstract UniTask<SavedGameData> _0024DfA(SavedGameData _1);
	}
}
