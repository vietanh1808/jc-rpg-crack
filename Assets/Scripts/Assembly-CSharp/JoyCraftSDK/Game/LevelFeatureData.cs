using System;
using System.Collections.Generic;
using _0024l;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public class LevelFeatureData : _0024YD
	{
		[SerializeField]
		private List<LevelFeaturePair> pairs;

		[SerializeField]
		private List<CountingFeatureData> queues;

		[SerializeField]
		private List<CountingFeatureData> stations;

		public List<LevelFeaturePair> Pairs
		{
			get
			{
				return _0024bg();
			}
			set
			{
				_0024Bg(value);
			}
		}

		public List<CountingFeatureData> Queues
		{
			get
			{
				return _0024cg();
			}
			set
			{
				_0024Cg(value);
			}
		}

		public List<CountingFeatureData> Stations
		{
			get
			{
				return _0024dg();
			}
			set
			{
				_0024Dg(value);
			}
		}

		public List<LevelFeaturePair> _0024bg()
		{
			return null;
		}

		public void _0024Bg(List<LevelFeaturePair> _1)
		{
		}

		public List<CountingFeatureData> _0024cg()
		{
			return null;
		}

		public void _0024Cg(List<CountingFeatureData> _1)
		{
		}

		public List<CountingFeatureData> _0024dg()
		{
			return null;
		}

		public void _0024Dg(List<CountingFeatureData> _1)
		{
		}
	}
}
