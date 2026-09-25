using System;
using _0024l;
using UnityEngine;

namespace JoyCraftSDK.Progression
{
	[Serializable]
	public class CycleSpec : _0024YD
	{
		[SerializeField]
		private CycleKind kind;

		[SerializeField]
		private int resetHourUtc;

		[SerializeField]
		private DayOfWeek weekStartDay;

		private TimeSpan _0024lK;

		private DateTime _0024LK;

		[SerializeField]
		private int quota;

		public CycleKind Kind => _0024iI();

		public int ResetHourUtc => _0024II();

		public DayOfWeek WeekStartDay => _0024jI();

		public TimeSpan WindowDuration => _0024JI();

		public DateTime WindowEpochUtc => _0024kI();

		public int Quota => _0024KI();

		public bool IsUnlimited => _0024lI();

		public CycleKind _0024iI()
		{
			return CycleKind.Daily;
		}

		public int _0024II()
		{
			return 0;
		}

		public DayOfWeek _0024jI()
		{
			return DayOfWeek.Sunday;
		}

		public TimeSpan _0024JI()
		{
			return default;
		}

		public DateTime _0024kI()
		{
			return default;
		}

		public int _0024KI()
		{
			return 0;
		}

		public bool _0024lI()
		{
			return false;
		}

		public static CycleSpec _0024LI(int _1 = 0, int _1 = 0)
		{
			return null;
		}

		public static CycleSpec _0024mI(DayOfWeek _1 = DayOfWeek.Monday, int _1 = 0, int _1 = 0)
		{
			return null;
		}

		public static CycleSpec _0024MI(DateTime _1, TimeSpan _1, int _1 = 0)
		{
			return null;
		}

		public DateTime _0024nI(DateTime _1)
		{
			return default;
		}

		public DateTime _0024NI(DateTime _1)
		{
			return default;
		}

		private DateTime _0024oI(DateTime _1)
		{
			return default;
		}

		private DateTime _0024OI(DateTime _1)
		{
			return default;
		}

		private DateTime _0024Dj(DateTime _1)
		{
			return default;
		}
	}
}
