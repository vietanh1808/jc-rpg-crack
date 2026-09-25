using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[CreateAssetMenu(fileName = "ColorDefinitionSO", menuName = "JoyCraft/Configs/ColorDefinitionSO")]
	public class ColorDefinitionSO : JScriptableObject
	{
		[SerializeField]
		private ColorDefinition objectColor;

		[Tooltip("Material của HIDDEN BOX (box sinh ra giấu màu, chỉ lộ khi lên hàng đầu — ColorJarData.hidden). Bỏ trống -> box ẩn hiện material màu THẬT (lộ bài), có LogError báo.")]
		[SerializeField]
		private Material hiddenObjectMaterial;

		[SerializeField]
		private ColorDefinition_Sand sandColor;

		public Material _0024TF(GameObjectColor _1)
		{
			return null;
		}

		public Material _0024uF()
		{
			return null;
		}

		public Color _0024UF(GameObjectColor _1)
		{
			return default;
		}

		public bool _0024vF(GameObjectColor _1, out Color _1)
		{
			_1 = default;
			return false;
		}

		private static Color _0024VF(Color _1)
		{
			return default;
		}
	}
}
