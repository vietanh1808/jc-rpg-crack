using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class BattlePassRewardPreviewRouter : JMonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		[Tooltip("Image phủ toàn màn của CHÍNH node này — code bật/tắt Raycast Target để bắt click nền.")]
		[SerializeField]
		private Image blockerImage;

		private BattlePassMilestoneView _0024Pn;

		public void _0024KO(BattlePassMilestoneView _1)
		{
		}

		public void _0024lO()
		{
		}

		public void _0024LO(BattlePassMilestoneView _1)
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		protected override void OnDisable()
		{
		}

		private void _0024mO(bool _1)
		{
		}
	}
}
