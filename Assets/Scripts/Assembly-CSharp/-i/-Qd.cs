using System;
using JoyCraftSDK.Notification;

namespace _0024I
{
	public interface _0024Qd
	{
		string _0024a { get; }

		bool _0024A { get; }

		NotificationPermissionStatus _0024b { get; }

		string _0024RfA();

		bool _0024sfA();

		NotificationPermissionStatus _0024SfA();

		void _0024tfA(NotificationChannelData _1);

		void _0024TfA(Action<NotificationPermissionStatus> _1);

		void _0024ufA();

		void _0024UfA(NotificationRequest _1);

		bool _0024vfA(out int _1);

		void _0024VfA(int _1);

		void _0024wfA();

		void _0024WfA();
	}
}
