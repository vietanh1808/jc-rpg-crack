using System;
using System.Collections.Generic;
using _0024l;
using JoyCraftSDK;
using JoyCraftSDK.Progression;
using JoyCraftSDK.SaveSystem;
using JoyCraftSDK.Utilities;

namespace _0024G
{
	public class _0024ed : _0024dd
	{
		private bool _0024kr;

		protected new virtual SavedCurrencyData _0024a => _0024OjA();

		protected new virtual int _0024A => _0024PjA();

		public override void _0024Nw()
		{
		}

		protected virtual void _0024ow()
		{
		}

		protected void _0024hw(ref AEventManager._0024ZA _1)
		{
		}

		protected virtual SavedCurrencyData _0024OjA()
		{
			return null;
		}

		protected virtual void _0024pjA(AEventManager._0024GB _1)
		{
		}

		protected virtual int _0024PjA()
		{
			return 0;
		}

		public override long _0024LjA(string _1)
		{
			return 0L;
		}

		public override long _0024mjA(string _1)
		{
			return 0L;
		}

		public override long _0024MjA(string _1)
		{
			return 0L;
		}

		public override void _0024njA(string _1, long _1, ResourceEarnChannel _1, AnalyticsPlacement _1)
		{
		}

		public override bool _0024NjA(string _1, long _1, ResourceSpendChannel _1, AnalyticsPlacement _1)
		{
			return false;
		}

		public override bool _0024ojA(IReadOnlyList<_0024Dd> _1, ResourceSpendChannel _1, AnalyticsPlacement _1)
		{
			return false;
		}
	}
	public abstract class _0024Ed : _0024YD
	{
		public abstract bool _0024qjA(string _1, CycleSpec _1, int _1 = 1);

		public abstract int _0024QjA(string _1, CycleSpec _1);

		public abstract int _0024rjA(string _1, CycleSpec _1);

		public abstract bool _0024RjA(string _1, CycleSpec _1);

		public abstract DateTime _0024sjA(string _1, CycleSpec _1);
	}
}
