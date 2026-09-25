using System;
using UnityEngine;

namespace BucketKnight.Flow.Data
{
	[Serializable]
	public class ScriptedSpawnEntry
	{
		[SerializeField]
		private Vector3 position;

		[SerializeField]
		private int count;

		public Vector3 Position => _0024NX();

		public int Count => _0024oX();

		public Vector3 _0024NX()
		{
			return default;
		}

		public int _0024oX()
		{
			return 0;
		}
	}
}
