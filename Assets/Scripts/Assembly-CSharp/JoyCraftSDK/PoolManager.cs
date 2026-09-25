using System.Collections.Generic;
using HellTap.PoolKit;
using UnityEngine;

namespace JoyCraftSDK
{
	public class PoolManager : APoolManager
	{
		private sealed class _0024xB
		{
			public Pool _0024zG;

			public GameObject _0024ZG;

			internal void _0024OE()
			{
			}
		}

		[Header("Default Settings")]
		[SerializeField]
		private int defaultPoolSize;

		[SerializeField]
		private PoolInput poolInput;

		[SerializeField]
		private bool enablePoolProtection;

		[SerializeField]
		private bool logPoolCreation;

		private readonly Dictionary<GameObject, Pool> _0024YG;

		public override void Awake()
		{
		}

		private void OnValidate()
		{
		}

		public override GameObject _0024dcA(GameObject _1, Vector3 _1, Quaternion _1, Transform _1 = null)
		{
			return null;
		}

		public override GameObject _0024DcA(GameObject _1, Vector3 _1, Transform _1 = null)
		{
			return null;
		}

		public override GameObject _0024ecA(GameObject _1, Vector3 _1, Quaternion _1, Transform _1)
		{
			return null;
		}

		public override void _0024EcA(GameObject _1)
		{
		}

		public override void _0024fcA(GameObject _1, float _1)
		{
		}

		public override void _0024FcA(GameObject _1)
		{
		}

		public override void _0024gcA()
		{
		}

		public override void _0024GcA(GameObject _1, int _1 = -1)
		{
		}

		public override void _0024hcA(IEnumerable<GameObject> _1, int _1 = -1)
		{
		}

		public bool _0024nE(GameObject _1)
		{
			return false;
		}

		public override int _0024HcA(GameObject _1)
		{
			return 0;
		}

		public override int _0024icA(GameObject _1)
		{
			return 0;
		}

		private Pool _0024NE(GameObject _1)
		{
			return null;
		}

		private Pool _0024oE(GameObject _1, int _1)
		{
			return null;
		}
	}
}
