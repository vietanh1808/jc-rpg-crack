using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public abstract class AUnlockTable : JScriptableObject
	{
		public abstract IReadOnlyList<UnlockEntry> _0024TdA(int _1);

		public abstract UnlockEntry _0024udA(UnlockableType _1);

		public abstract int _0024UdA(UnlockableType _1);

		public abstract UnlockEntry _0024vdA(int _1);

		public abstract UnlockEntry _0024VdA(int _1);

		public abstract UnlockEntry _0024wdA(int _1);

		public abstract UnlockEntry _0024WdA(int _1);

		public abstract UnlockEntry _0024xdA(int _1, Func<UnlockEntry, bool> _1 = null);

		public abstract UnlockEntry _0024XdA(int _1, Func<UnlockEntry, bool> _1 = null);
	}
}
