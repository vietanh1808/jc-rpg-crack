using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class LevelRoomView : JMonoBehaviour
	{
		[SerializeField]
		private int levelOffset;

		[SerializeField]
		private GameObject blue;

		[SerializeField]
		private GameObject red;

		[SerializeField]
		private GameObject purple;

		[SerializeField]
		private GameObject green;

		[SerializeField]
		private UIObjectType type;

		[SerializeField]
		private TextMeshProUGUI[] txtLevels;

		[SerializeField]
		private Image imgBtn;

		[FormerlySerializedAs("data")]
		[SerializeField]
		private DifficultyDataSO difficultyData;

		private Sprite _0024Mh;

		protected override void OnEnable()
		{
		}

		private void _0024nT()
		{
		}

		private void _0024Gw(string _1)
		{
		}
	}
}
