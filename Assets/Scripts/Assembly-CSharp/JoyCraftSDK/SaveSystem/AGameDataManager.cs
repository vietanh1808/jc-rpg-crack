using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.SaveSystem
{
	public abstract class AGameDataManager : JMonoBehaviour
	{
		public SavedGameData savedGameData;

		[CompilerGenerated]
		private HashSet<string> _0024Um;

		public new HashSet<string> _0024a
		{
			get
			{
				return _0024do();
			}
			protected set
			{
				_0024Do(value);
			}
		}

		public HashSet<string> _0024do()
		{
			return null;
		}

		protected void _0024Do(HashSet<string> _1)
		{
		}

		public abstract UniTask _0024IEA(Action _1 = null);

		public abstract void _0024jEA();

		public abstract UniTask _0024JEA(Action _1 = null);

		protected string _0024Ak()
		{
			return null;
		}
	}
}
