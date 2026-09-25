using System;
using System.Collections.Generic;
using System.Text;
using _0024B;
using _0024C;
using _0024E;
using _0024c;
using _0024l;
using JoyCraftSDK.LiveEvent;
using JoyCraftSDK.SaveSystem;
using JoyCraftSDK.Utilities;

namespace _0024d
{
	public class _0024nc : _0024YD, _0024Nc
	{
		public new bool _0024a => _0024xCA();

		public BoosterType _0024WCA()
		{
			return BoosterType.None;
		}

		public bool _0024xCA()
		{
			return false;
		}

		public void _0024XCA()
		{
		}

		public void _0024yCA()
		{
		}

		public void _0024YCA()
		{
		}
	}
	public interface _0024Nc
	{
		bool _0024a { get; }

		BoosterType _0024WCA();

		void _0024XCA();

		void _0024yCA();

		void _0024YCA();

		bool _0024xCA();
	}
	public class _0024nC : _0024eA
	{
		private bool _0024rj;

		private readonly _0024aC _0024Rj;

		private readonly StringBuilder _0024sj;

		public override void _0024ZAA(Action _1 = null)
		{
		}

		public override string _0024abA()
		{
			return null;
		}

		public override StringBuilder _0024AbA()
		{
			return null;
		}

		public override _0024Mc _0024bbA()
		{
			return null;
		}

		public override _0024mc _0024BbA()
		{
			return null;
		}

		public override _0024Lc _0024cbA()
		{
			return null;
		}

		public override _0024nc _0024CbA()
		{
			return null;
		}

		public override _0024rC _0024dbA()
		{
			return null;
		}

		public override _0024gc _0024DbA(SavedWalletIntData _1)
		{
			return null;
		}

		public override _0024kc _0024ebA(IReadOnlyList<LiveEventMilestoneEntry> _1, TrackMode _1, SavedTrackData _1, _0024Gc _1, _0024hc _1, _0024rC _1)
		{
			return null;
		}

		public override _0024ic _0024EbA(SavedTrackData _1)
		{
			return null;
		}

		public override _0024Hc _0024fbA()
		{
			return null;
		}

		public override _0024dc _0024TIA(string _1)
		{
			return null;
		}
	}
	public class _0024NC : _0024nB
	{
		protected virtual int _0024Ow()
		{
			return 0;
		}

		public override string _0024ybA()
		{
			return null;
		}

		public override string _0024YbA(float _1)
		{
			return null;
		}

		public override string _0024zbA(GameFeatureType _1)
		{
			return null;
		}

		public override string _0024ZbA(BoosterType _1)
		{
			return null;
		}

		public override string _0024aBA()
		{
			return null;
		}

		public override string _0024ABA()
		{
			return null;
		}

		public override string _0024bBA()
		{
			return null;
		}

		public override string _0024BBA(GameFeatureType _1)
		{
			return null;
		}

		public override string _0024cBA(BoosterType _1)
		{
			return null;
		}
	}
}
