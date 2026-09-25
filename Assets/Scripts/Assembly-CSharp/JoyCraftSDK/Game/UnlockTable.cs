using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Serialization;

namespace JoyCraftSDK.Game
{
	[Serializable]
	[CreateAssetMenu(fileName = "UnlockTable", menuName = "GameSDK/UnlockTable")]
	public class UnlockTable : AUnlockTable
	{
		[FormerlySerializedAs("entries")]
		[SerializeField]
		private List<UnlockEntry> unlockEntries;

		private static readonly List<UnlockEntry> _0024qi;

		private Dictionary<int, List<UnlockEntry>> _0024Qi;

		private Dictionary<UnlockableType, UnlockEntry> _0024ri;

		private List<int> _0024Ri;

		public override IReadOnlyList<UnlockEntry> _0024TdA(int _1)
		{
			return null;
		}

		public override UnlockEntry _0024udA(UnlockableType _1)
		{
			return null;
		}

		public override int _0024UdA(UnlockableType _1)
		{
			return 0;
		}

		public override UnlockEntry _0024vdA(int _1)
		{
			return null;
		}

		public override UnlockEntry _0024VdA(int _1)
		{
			return null;
		}

		public override UnlockEntry _0024wdA(int _1)
		{
			return null;
		}

		public override UnlockEntry _0024WdA(int _1)
		{
			return null;
		}

		public override UnlockEntry _0024xdA(int _1, Func<UnlockEntry, bool> _1 = null)
		{
			return null;
		}

		public override UnlockEntry _0024XdA(int _1, Func<UnlockEntry, bool> _1 = null)
		{
			return null;
		}

		private static UnlockEntry _0024Qg(List<UnlockEntry> _1, Func<UnlockEntry, bool> _1)
		{
			return null;
		}

		private void _0024rg()
		{
		}
	}
}
