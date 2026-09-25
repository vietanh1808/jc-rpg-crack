using System;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedCurrencyData : ASavedRegistryData<CurrencyEntry>
	{
		private sealed class _0024Af
		{
			public string _0024DO;

			internal CurrencyEntry _0024OW()
			{
				return null;
			}
		}

		[NonSerialized]
		private int _0024dO;

		public int SnapshotTamperCount => _0024yw();

		public override int _0024SEA()
		{
			return 0;
		}

		protected override string _0024vJA(CurrencyEntry _1)
		{
			return null;
		}

		public long _0024Vw(string _1)
		{
			return 0L;
		}

		public long _0024ww(string _1)
		{
			return 0L;
		}

		public long _0024Ww(string _1)
		{
			return 0L;
		}

		public void _0024xw(string _1, long _1)
		{
		}

		public bool _0024Xw(string _1, long _1)
		{
			return false;
		}

		public int _0024yw()
		{
			return 0;
		}

		public bool _0024Yw()
		{
			return false;
		}
	}
}
