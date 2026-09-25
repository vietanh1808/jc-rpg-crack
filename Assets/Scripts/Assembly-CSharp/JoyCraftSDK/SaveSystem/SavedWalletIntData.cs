using System;
using System.Collections.Generic;
using _0024h;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedWalletIntData : JSaveData, _0024Id
	{
		[SerializeField]
		private int earned;

		[SerializeField]
		private int spent;

		public int Earned => _0024eK();

		public int Spent => _0024EK();

		public int Balance => _0024fK();

		public override int _0024SEA()
		{
			return 0;
		}

		public override List<_0024Gd> _0024tEA()
		{
			return null;
		}

		public int _0024eK()
		{
			return 0;
		}

		public int _0024EK()
		{
			return 0;
		}

		public int _0024fK()
		{
			return 0;
		}

		public void _0024FK(int _1)
		{
		}

		public void _0024LfA()
		{
		}
	}
}
