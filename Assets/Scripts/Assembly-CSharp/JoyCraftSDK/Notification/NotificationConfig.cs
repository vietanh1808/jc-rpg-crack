using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.Notification
{
	[CreateAssetMenu(fileName = "NotificationConfig", menuName = "GameSDK/NotificationConfig")]
	public class NotificationConfig : ANotificationConfig
	{
		[Tooltip("Channel Android dùng chung cho mọi notification của game.")]
		[SerializeField]
		private NotificationChannelData notificationChannel;

		[Tooltip("Nội dung theo từng id. Thiếu id nào thì noti của id đó KHÔNG được bắn.")]
		[SerializeField]
		private List<NotificationContentEntry> contentEntries;

		public override NotificationChannelData _0024a => _0024xfA();

		public override NotificationChannelData _0024xfA()
		{
			return null;
		}

		public override bool _0024XfA(NotificationRequest _1)
		{
			return false;
		}

		public override bool _0024yfA(int _1, out float _1)
		{
			_1 = default;
			return false;
		}

		public override bool _0024YfA(int _1, out string _1)
		{
			_1 = null;
			return false;
		}

		private NotificationContentEntry _0024zl(int _1)
		{
			return null;
		}
	}
}
