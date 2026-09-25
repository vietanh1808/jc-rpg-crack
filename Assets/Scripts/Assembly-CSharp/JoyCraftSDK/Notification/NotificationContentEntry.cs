using System;
using UnityEngine;

namespace JoyCraftSDK.Notification
{
	[Serializable]
	public class NotificationContentEntry
	{
		[Tooltip("Khớp với id mà INotificationSource điền vào request.")]
		[SerializeField]
		private int id;

		[Tooltip("Tiêu đề notification.")]
		[SerializeField]
		private string title;

		[Tooltip("Nội dung notification.")]
		[TextArea(2, 4)]
		[SerializeField]
		private string body;

		[Tooltip("Tên icon nhỏ đã khai ở Project Settings > Mobile Notifications. Trống = dùng icon app (Unity sẽ warn ở logcat).")]
		[SerializeField]
		private string smallIcon;

		[Tooltip("Bao nhiêu PHÚT sau khi user rời game thì bắn (1440 = 1 ngày). Chỉ dùng cho loại noti có mốc CỐ ĐỊNH; loại tính runtime (tim đầy) để 0.")]
		[SerializeField]
		private float delayMinutes;

		public int Id => _0024Zl();

		public string Title => _0024aL();

		public string Body => _0024AL();

		public string SmallIcon => _0024bL();

		public float DelayMinutes => _0024BL();

		public int _0024Zl()
		{
			return 0;
		}

		public string _0024aL()
		{
			return null;
		}

		public string _0024AL()
		{
			return null;
		}

		public string _0024bL()
		{
			return null;
		}

		public float _0024BL()
		{
			return 0f;
		}
	}
}
