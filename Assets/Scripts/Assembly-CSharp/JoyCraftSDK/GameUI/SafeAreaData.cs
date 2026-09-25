using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	[CreateAssetMenu(fileName = "SafeAreaData", menuName = "GameSDK/SafeAreaData")]
	public class SafeAreaData : JScriptableObject
	{
		[Header("Viewport Coordinates (0-1)")]
		[SerializeField]
		private Vector2 viewportBottomLeft;

		[SerializeField]
		private Vector2 viewportTopRight;

		public new Vector2 _0024a => _0024cn();

		public new Vector2 _0024A => _0024Cn();

		public new float _0024b => _0024dn();

		public new float _0024B => _0024Dn();

		public new float _0024c => _0024en();

		public new float _0024C => _0024En();

		public new float _0024d => _0024fn();

		public new float _0024D => _0024Fn();

		private new string _0024e => _0024gn();

		private new Vector2 _0024E => _0024Gn();

		public Vector2 _0024cn()
		{
			return default;
		}

		public Vector2 _0024Cn()
		{
			return default;
		}

		public float _0024dn()
		{
			return 0f;
		}

		public float _0024Dn()
		{
			return 0f;
		}

		public float _0024en()
		{
			return 0f;
		}

		public float _0024En()
		{
			return 0f;
		}

		public float _0024fn()
		{
			return 0f;
		}

		public float _0024Fn()
		{
			return 0f;
		}

		private string _0024gn()
		{
			return null;
		}

		private Vector2 _0024Gn()
		{
			return default;
		}

		public bool _0024hn()
		{
			return false;
		}

		private bool _0024Hn(Vector2 _1)
		{
			return false;
		}
	}
}
