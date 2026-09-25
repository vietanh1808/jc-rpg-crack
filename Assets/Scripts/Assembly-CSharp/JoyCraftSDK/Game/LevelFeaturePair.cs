using System;
using _0024l;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public class LevelFeaturePair : _0024YD
	{
		[SerializeField]
		private int pairID;

		[SerializeField]
		private GameFeatureType feature;

		[SerializeField]
		private FeatureItemRef itemA;

		[SerializeField]
		private FeatureItemRef itemB;

		public int PairID
		{
			get
			{
				return _0024eg();
			}
			set
			{
				_0024Eg(value);
			}
		}

		public GameFeatureType Feature
		{
			get
			{
				return _0024fg();
			}
			set
			{
				_0024Fg(value);
			}
		}

		public FeatureItemRef ItemA
		{
			get
			{
				return _0024gg();
			}
			set
			{
				_0024Gg(value);
			}
		}

		public FeatureItemRef ItemB
		{
			get
			{
				return _0024hg();
			}
			set
			{
				_0024Hg(value);
			}
		}

		public int _0024eg()
		{
			return 0;
		}

		public void _0024Eg(int _1)
		{
		}

		public GameFeatureType _0024fg()
		{
			return GameFeatureType.None;
		}

		public void _0024Fg(GameFeatureType _1)
		{
		}

		public FeatureItemRef _0024gg()
		{
			return null;
		}

		public void _0024Gg(FeatureItemRef _1)
		{
		}

		public FeatureItemRef _0024hg()
		{
			return null;
		}

		public void _0024Hg(FeatureItemRef _1)
		{
		}
	}
}
