using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class BtnRetry : JButton
	{
		[SerializeField]
		private Image btnImg;

		[SerializeField]
		private UIObjectType type;

		[FormerlySerializedAs("data")]
		[SerializeField]
		private DifficultyDataSO difficultyData;

		protected override void _0024CgA()
		{
		}

		private void _0024yq(ref AEventManager._0024tA _1)
		{
		}

		protected override void _0024hbA()
		{
		}

		protected override void _0024HbA()
		{
		}

		protected override void OnEnable()
		{
		}
	}
}
