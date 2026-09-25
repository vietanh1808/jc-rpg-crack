using System;
using _0024l;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public class FeatureItemRef : _0024YD
	{
		[SerializeField]
		private int holderIndex;

		[SerializeField]
		private int index;

		public int HolderIndex
		{
			get
			{
				return _0024ig();
			}
			set
			{
				_0024Ig(value);
			}
		}

		public int Index
		{
			get
			{
				return _0024jg();
			}
			set
			{
				_0024Jg(value);
			}
		}

		public int _0024ig()
		{
			return 0;
		}

		public void _0024Ig(int _1)
		{
		}

		public int _0024jg()
		{
			return 0;
		}

		public void _0024Jg(int _1)
		{
		}
	}
}
