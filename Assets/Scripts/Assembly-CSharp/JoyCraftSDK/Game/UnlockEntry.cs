using System;
using _0024l;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public class UnlockEntry : _0024YD
	{
		public UnlockableType unlockable;

		public int level;

		[SerializeReference]
		public AUnlockPayload payload;
	}
}
