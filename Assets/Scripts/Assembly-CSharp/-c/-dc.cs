using System;
using System.Collections.Generic;
using _0024G;
using _0024l;
using JoyCraftSDK.Progression;
using JoyCraftSDK.SaveSystem;
using JoyCraftSDK.Utilities;

namespace _0024c
{
	public class _0024dc : _0024YD, _0024Cc
	{
		private readonly Func<_0024dd> _0024oK;

		private readonly string _0024Xh;

		private readonly ResourceSpendChannel _0024qK;

		private readonly AnalyticsPlacement _0024QK;

		public _0024dc(Func<_0024dd> currencyManagerAccessor, string currencyId, ResourceSpendChannel spendReason, AnalyticsPlacement placement)
		{
		}

		public bool _0024wcA(long _1)
		{
			return false;
		}
	}
	public class _0024Dc : _0024cc
	{
		protected virtual SavedLadderData _0024WcA()
		{
			return null;
		}

		protected virtual void _0024xcA(string _1, int _1, int _1)
		{
		}

		public override int _0024ucA(string _1)
		{
			return 0;
		}

		public override float _0024UcA(string _1, IReadOnlyList<LadderLevelEntry> _1)
		{
			return 0f;
		}

		public override int _0024vcA(string _1, IReadOnlyList<LadderLevelEntry> _1, long _1)
		{
			return 0;
		}

		public override bool _0024VcA(string _1, IReadOnlyList<LadderLevelEntry> _1, _0024Cc _1)
		{
			return false;
		}
	}
}
