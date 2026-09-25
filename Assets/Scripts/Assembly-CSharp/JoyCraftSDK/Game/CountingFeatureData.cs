using System;
using _0024l;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public class CountingFeatureData : _0024YD
	{
		[SerializeField]
		private int fulfilledCount;

		[SerializeField]
		private int index;

		public int FulfilledCount
		{
			get
			{
				return _0024kg();
			}
			set
			{
				_0024Kg(value);
			}
		}

		public int Index
		{
			get
			{
				return _0024lg();
			}
			set
			{
				_0024Lg(value);
			}
		}

		public int _0024kg()
		{
			return 0;
		}

		public void _0024Kg(int _1)
		{
		}

		public int _0024lg()
		{
			return 0;
		}

		public void _0024Lg(int _1)
		{
		}
	}
}
