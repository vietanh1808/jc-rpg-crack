using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK
{
	public abstract class APoolManager : JMonoBehaviour
	{
		public abstract GameObject _0024dcA(GameObject _1, Vector3 _1, Quaternion _1, Transform _1 = null);

		public T _0024pE<T>(T _1, Vector3 _1, Quaternion _1, Transform _1 = null) where T : MonoBehaviour
		{
			return null;
		}

		public abstract GameObject _0024DcA(GameObject _1, Vector3 _1, Transform _1 = null);

		public T _0024PE<T>(T _1, Vector3 _1, Transform _1 = null) where T : Component
		{
			return null;
		}

		public abstract GameObject _0024ecA(GameObject _1, Vector3 _1, Quaternion _1, Transform _1);

		public T _0024qE<T>(T _1, Vector3 _1, Quaternion _1, Transform _1) where T : MonoBehaviour
		{
			return null;
		}

		public abstract void _0024EcA(GameObject _1);

		public void _0024QE<T>(T _1) where T : Component
		{
		}

		public abstract void _0024fcA(GameObject _1, float _1);

		public void _0024rE<T>(T _1, float _1) where T : MonoBehaviour
		{
		}

		public abstract void _0024FcA(GameObject _1);

		public void _0024RE<T>(T _1) where T : MonoBehaviour
		{
		}

		public abstract void _0024gcA();

		public abstract void _0024GcA(GameObject _1, int _1 = -1);

		public void _0024sE<T>(T _1, int _1 = -1) where T : MonoBehaviour
		{
		}

		public abstract void _0024hcA(IEnumerable<GameObject> _1, int _1 = -1);

		public void _0024SE<T>(IEnumerable<T> _1, int _1 = -1) where T : MonoBehaviour
		{
		}

		public abstract int _0024HcA(GameObject _1);

		public int _0024tE<T>(T _1) where T : MonoBehaviour
		{
			return 0;
		}

		public abstract int _0024icA(GameObject _1);

		public int _0024TE<T>(T _1) where T : MonoBehaviour
		{
			return 0;
		}
	}
}
