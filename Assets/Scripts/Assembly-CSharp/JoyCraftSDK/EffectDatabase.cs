using System;
using System.Collections.Generic;
using JoyCraftSDK.GameUI;
using UnityEngine;

namespace JoyCraftSDK
{
	[CreateAssetMenu(fileName = "EffectDatabase", menuName = "GameSDK/EffectDatabase")]
	public class EffectDatabase : AEffectDatabase
	{
		[Serializable]
		public struct EffectEntry
		{
			public EffectType type;

			public AWinEffect prefab;
		}

		[SerializeField]
		private List<EffectEntry> entries;

		public override AWinEffect _0024kbA(EffectType _1)
		{
			return null;
		}
	}
}
