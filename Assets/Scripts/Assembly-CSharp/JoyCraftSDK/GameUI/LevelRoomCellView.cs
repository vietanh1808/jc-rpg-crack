using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class LevelRoomCellView : JCellView
	{
		[FormerlySerializedAs("blue")]
		[SerializeField]
		private GameObject ringNormal;

		[FormerlySerializedAs("red")]
		[SerializeField]
		private GameObject ringVeryHard;

		[FormerlySerializedAs("purple")]
		[SerializeField]
		private GameObject ringHard;

		[FormerlySerializedAs("green")]
		[SerializeField]
		private GameObject ringCurrent;

		[SerializeField]
		private UIObjectType type;

		[SerializeField]
		private TextMeshProUGUI[] txtLevels;

		[SerializeField]
		private Image imgBtn;

		[FormerlySerializedAs("data")]
		[SerializeField]
		private DifficultyDataSO difficultyData;

		public void _0024eS(int _1)
		{
		}

		private void _0024jt(string _1)
		{
		}
	}
}
