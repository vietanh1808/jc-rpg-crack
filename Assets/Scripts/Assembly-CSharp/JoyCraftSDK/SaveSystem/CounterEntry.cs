using System;
using _0024l;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class CounterEntry : _0024YD
	{
		[SerializeField]
		private string id;

		[SerializeField]
		private CounterScope scope;

		[SerializeField]
		private long value;

		[SerializeField]
		private DateTime lastResetUtc;

		public string Id => _0024gK();

		public CounterScope Scope => _0024GK();

		public long Value => _0024hK();

		public string _0024gK()
		{
			return null;
		}

		public CounterScope _0024GK()
		{
			return CounterScope.Lifetime;
		}

		public long _0024hK()
		{
			return 0L;
		}

		internal CounterEntry _0024HK(string _1, CounterScope _1)
		{
			return null;
		}

		public bool _0024iK(DateTime _1, TimeSpan? _1)
		{
			return false;
		}

		public void _0024IK(long _1)
		{
		}
	}
}
