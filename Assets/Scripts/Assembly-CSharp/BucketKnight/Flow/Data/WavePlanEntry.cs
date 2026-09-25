using System;
using JoyCraftSDK.DOTS.Simulation;
using UnityEngine;

namespace BucketKnight.Flow.Data
{
	[Serializable]
	public class WavePlanEntry
	{
		[SerializeField]
		private JcWaveSpawnMode mode;

		[SerializeField]
		private uint holeMask;

		[SerializeField]
		private ScriptedSpawnEntry[] scripted;

		public JcWaveSpawnMode Mode => _0024fX();

		public uint HoleMask => _0024FX();

		public ScriptedSpawnEntry[] Scripted => _0024nX();

		public JcWaveSpawnMode _0024fX()
		{
			return JcWaveSpawnMode.Directed;
		}

		public uint _0024FX()
		{
			return 0u;
		}

		public ScriptedSpawnEntry[] _0024nX()
		{
			return null;
		}
	}
}
