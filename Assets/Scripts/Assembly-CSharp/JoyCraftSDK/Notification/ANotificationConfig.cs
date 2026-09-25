using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Notification
{
	public abstract class ANotificationConfig : JScriptableObject
	{
		public new abstract NotificationChannelData _0024a { get; }

		public abstract NotificationChannelData _0024xfA();

		public abstract bool _0024XfA(NotificationRequest _1);

		public abstract bool _0024yfA(int _1, out float _1);

		public abstract bool _0024YfA(int _1, out string _1);
	}
}
