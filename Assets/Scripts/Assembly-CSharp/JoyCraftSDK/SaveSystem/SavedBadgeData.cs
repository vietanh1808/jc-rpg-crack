using System;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedBadgeData : ASavedRegistryData<BadgeEntry>
	{
		private sealed class _0024ZE
		{
			public string _0024BO;

			internal BadgeEntry _0024Uw()
			{
				return null;
			}
		}

		[NonSerialized]
		private int _0024bO;

		public int SnapshotTamperCount => _0024Tw();

		public override int _0024SEA()
		{
			return 0;
		}

		protected override string _0024vJA(BadgeEntry _1)
		{
			return null;
		}

		public BadgeEntry _0024eT(string _1)
		{
			return null;
		}

		public bool _0024ET(string _1, out BadgeEntry _1)
		{
			_1 = null;
			return false;
		}

		public long _0024rT(string _1)
		{
			return 0L;
		}

		public bool _0024tw(string _1)
		{
			return false;
		}

		public int _0024Tw()
		{
			return 0;
		}

		public bool _0024uw()
		{
			return false;
		}
	}
}
