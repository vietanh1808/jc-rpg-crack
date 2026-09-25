using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class BtnAddSpeedUpTime : JButton
	{
		[Tooltip("Số GIÂY speed-up cộng thêm mỗi lần xem xong ads (3600 = 1 giờ).")]
		[SerializeField]
		[Min(1f)]
		private int rewardSeconds;

		[Tooltip("Panel chứa nút này — nhận thưởng xong thì đóng. Để trống = không tự đóng.")]
		[SerializeField]
		private JUIPanel panel;

		[Tooltip("Nhận thưởng xong bật x2 luôn (người chơi bấm xem ads là đang MUỐN tăng tốc).")]
		[SerializeField]
		private bool autoSpeedUpAfterReward;

		private bool _0024vn;

		protected override void OnEnable()
		{
		}

		protected override void _0024CgA()
		{
		}

		private void _0024ap()
		{
		}

		private void _0024Ap(ref AEventManager._0024Nb _1)
		{
		}

		protected override void _0024hbA()
		{
		}

		protected override void _0024HbA()
		{
		}
	}
}
