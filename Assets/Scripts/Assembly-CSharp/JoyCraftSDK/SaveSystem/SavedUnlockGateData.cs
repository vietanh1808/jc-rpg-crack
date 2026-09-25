using System;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedUnlockGateData : ASavedRegistryData<UnlockGateEntry>
	{
		private sealed class _0024Cf
		{
			public string _0024HO;

			internal UnlockGateEntry _0024JY()
			{
				return null;
			}
		}

		[NonSerialized]
		private int _0024hO;

		public int SnapshotTamperCount => _0024IY();

		public override int _0024SEA()
		{
			return 0;
		}

		protected override string _0024vJA(UnlockGateEntry _1)
		{
			return null;
		}

		public UnlockGateEntry _0024wy(string _1)
		{
			return null;
		}

		public bool _0024AY(string _1, out UnlockGateEntry _1)
		{
			_1 = null;
			return false;
		}

		public bool _0024Jl(string _1)
		{
			return false;
		}

		public int _0024IY()
		{
			return 0;
		}

		public bool _0024jY()
		{
			return false;
		}
	}
}
