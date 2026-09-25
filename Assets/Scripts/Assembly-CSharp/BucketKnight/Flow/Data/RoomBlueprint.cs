using System;
using UnityEngine;

namespace BucketKnight.Flow.Data
{
	[Serializable]
	public class RoomBlueprint
	{
		[SerializeField]
		private RoomTemplate template;

		[SerializeField]
		private Vector3[] spawnPoints;

		[SerializeField]
		private WavePlanEntry[] waves;

		[SerializeField]
		private float countMultiplier;

		public RoomTemplate Template => _0024dX();

		public Vector3[] SpawnPoints => _0024DX();

		public WavePlanEntry[] Waves => _0024eX();

		public float CountMultiplier => _0024EX();

		public RoomTemplate _0024dX()
		{
			return RoomTemplate.Opening;
		}

		public Vector3[] _0024DX()
		{
			return null;
		}

		public WavePlanEntry[] _0024eX()
		{
			return null;
		}

		public float _0024EX()
		{
			return 0f;
		}
	}
}
