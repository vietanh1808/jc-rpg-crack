using System;
using _0024l;
using UnityEngine;

namespace JoyCraftSDK.Progression
{
	[Serializable]
	public class LadderLevelEntry : _0024YD
	{
		[SerializeField]
		private int level;

		[SerializeField]
		private long requirement;

		[SerializeField]
		private float statDelta;

		public int Level => _0024Af();

		public long Requirement => _0024bf();

		public float StatDelta => _0024Bf();

		public int _0024Af()
		{
			return 0;
		}

		public long _0024bf()
		{
			return 0L;
		}

		public float _0024Bf()
		{
			return 0f;
		}

		public LadderLevelEntry _0024cf(int _1, long _1, float _1)
		{
			return null;
		}
	}
}
