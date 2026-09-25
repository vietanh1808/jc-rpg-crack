using System;
using System.Collections.Generic;
using _0024h;
using JoyCraftSDK.Game;
using JoyCraftSDK.Game.SaveData;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedBuffData : JSaveData
	{
		[SerializeField]
		private List<SavedBuffPoint> buffPoints;

		public override int _0024SEA()
		{
			return 0;
		}

		public override List<_0024Gd> _0024tEA()
		{
			return null;
		}

		public IReadOnlyList<SavedBuffPoint> _0024Ml()
		{
			return null;
		}

		public SavedBuffPoint _0024nl(BuffType _1)
		{
			return null;
		}

		public void _0024Nl(BuffType _1)
		{
		}
	}
}
