using System;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedCounterData : ASavedRegistryData<CounterEntry>
	{
		private sealed class _0024af
		{
			public string _0024cO;

			public CounterScope _0024CO;

			internal CounterEntry _0024vw()
			{
				return null;
			}
		}

		public override int _0024SEA()
		{
			return 0;
		}

		protected override string _0024vJA(CounterEntry _1)
		{
			return null;
		}

		public CounterEntry _0024UK(string _1, CounterScope _1)
		{
			return null;
		}

		public bool _0024vK(string _1, out CounterEntry _1)
		{
			_1 = null;
			return false;
		}
	}
}
