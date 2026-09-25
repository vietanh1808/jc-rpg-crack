using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class BtnSpeedUp : JButton
	{
		[Tooltip("Popup mời xem ads đổi thêm giờ speed-up, mở khi quota trong ngày đã hết. None = chưa gán -> báo lỗi.")]
		[SerializeField]
		private UIPanelID outOfTimePanel;

		[Tooltip("Text đếm ngược mm:ss quota còn lại. CHỈ hiện khi đang x2 do NGƯỜI CHƠI bấm; x2 do rule level (ForceSpeedUp) không trừ giờ nên ẩn. Để trống = không hiển thị đếm ngược.")]
		[SerializeField]
		private TMP_Text countdownText;

		private int _0024wn;

		[Tooltip("Icon đổi theo trạng thái. Để trống nếu nút chỉ dùng text.")]
		[SerializeField]
		private Image icon;

		protected override void _0024CgA()
		{
		}

		protected override void OnEnable()
		{
		}

		private void _0024Dp(ref AEventManager._0024tA _1)
		{
		}

		private void _0024ep(ref AEventManager._0024yb _1)
		{
		}

		protected override void _0024hbA()
		{
		}

		protected override void _0024HbA()
		{
		}

		private void _0024Ep()
		{
		}

		private void _0024fp()
		{
		}
	}
}
