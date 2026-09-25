using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

namespace JoyCraftSDK.DOTS.Authoring
{
	public class JcActorRegistryAuthoring : MonoBehaviour
	{
		public class JcActorRegistryBaker : Baker<JcActorRegistryAuthoring>
		{
			public override void Bake(JcActorRegistryAuthoring authoring)
			{
			}
		}

		[Tooltip("Index = ActorTypeId. Slot null hợp lệ: JcActorSpawnSystem rơi về entity trần.")]
		[SerializeField]
		private List<GameObject> actorPrefabs;

		public IReadOnlyList<GameObject> _0024a => _0024jw();

		public IReadOnlyList<GameObject> _0024jw()
		{
			return null;
		}
	}
}
