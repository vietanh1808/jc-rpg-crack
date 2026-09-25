using System;
using System.Collections.Generic;
using _0024G;
using _0024l;
using JoyCraftSDK.SaveSystem;

namespace _0024c
{
	public class _0024ac : _0024ZB
	{
		private readonly Dictionary<string, long> _0024uh;

		protected virtual SavedCounterData _0024scA()
		{
			return null;
		}

		protected virtual void _0024ScA(string _1, long _1, long _1)
		{
		}

		protected virtual DateTime _0024tcA()
		{
			return default;
		}

		public override long _0024QcA(string _1, CounterScope _1, long _1 = 1L, TimeSpan? _1 = null)
		{
			return 0L;
		}

		public override long _0024rcA(string _1)
		{
			return 0L;
		}

		public override void _0024RcA()
		{
		}
	}
	public class _0024Ac : _0024YD, _0024bc, _0024YC
	{
		private readonly Func<SavedCounterData> _0024mK;

		private readonly string _0024vh;

		private readonly CounterScope? _0024MK;

		public new long _0024a => _0024TcA();

		public new string _0024A => _0024ljA();

		public _0024Ac(Func<SavedCounterData> counterDataAccessor, string counterId, CounterScope? expectedScope = null)
		{
		}

		public long _0024TcA()
		{
			return 0L;
		}

		public string _0024ljA()
		{
			return null;
		}
	}
}
