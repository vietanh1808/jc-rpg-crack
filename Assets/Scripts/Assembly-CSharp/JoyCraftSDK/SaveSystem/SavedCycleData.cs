using System;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedCycleData : ASavedRegistryData<CycleEntry>
	{
		private sealed class _0024bf
		{
			public string _0024EO;

			internal CycleEntry _0024Sy()
			{
				return null;
			}
		}

		[NonSerialized]
		private int _0024eO;

		public int SnapshotTamperCount => _0024tX();

		public override int _0024SEA()
		{
			return 0;
		}

		protected override string _0024vJA(CycleEntry _1)
		{
			return null;
		}

		public CycleEntry _0024Lx(string _1)
		{
			return null;
		}

		public bool _0024SX(string _1, out CycleEntry _1)
		{
			_1 = null;
			return false;
		}

		public int _0024tX()
		{
			return 0;
		}

		public bool _0024TX()
		{
			return false;
		}
	}
}
