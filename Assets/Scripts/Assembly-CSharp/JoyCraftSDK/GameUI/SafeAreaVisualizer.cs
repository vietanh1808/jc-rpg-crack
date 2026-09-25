using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	[RequireComponent(typeof(RectTransform))]
	[RequireComponent(typeof(Image))]
	public class SafeAreaVisualizer : JMonoBehaviour
	{
		[Header("Data")]
		[SerializeField]
		private SafeAreaData safeAreaData;

		[Header("Visual Settings")]
		[SerializeField]
		private Color borderColor;

		[SerializeField]
		private bool showInPlayMode;

		[SerializeField]
		private bool showInEditMode;

		private RectTransform _0024cM;

		private Image _0024CM;

		private Canvas _0024dM;

		private new Vector2 _0024a => _0024in();

		private new Vector2 _0024A => _0024In();

		private Vector2 _0024in()
		{
			return default;
		}

		private Vector2 _0024In()
		{
			return default;
		}

		public override void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnValidate()
		{
		}

		private void _0024jn()
		{
		}
	}
}
