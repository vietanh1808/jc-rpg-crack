using JoyCraftSDK.LiveEvent;
using JoyCraftSDK.SaveSystem;

namespace _0024C
{
	public class _0024ic : _0024hc
	{
		private readonly SavedTrackData _0024gH;

		public override bool _0024a => _0024ICA();

		public _0024ic(SavedTrackData savedTrackData)
		{
		}

		public override bool _0024ICA()
		{
			return false;
		}

		public void _0024Rf()
		{
		}
	}
	public readonly struct _0024Ic
	{
		public readonly int _0024hH;

		public readonly LiveEventMilestoneEntry _0024HH;

		public readonly LiveEventMilestoneEntry _0024iH;

		public _0024Ic(int tier, LiveEventMilestoneEntry freeEntry, LiveEventMilestoneEntry premiumEntry)
		{
			_0024hH = 0;
			_0024HH = null;
			_0024iH = null;
		}
	}
}
