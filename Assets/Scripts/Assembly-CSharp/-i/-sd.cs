using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using _0024l;
using JoyCraftSDK.Notification;

namespace _0024I
{
	public class _0024sd : _0024YD, _0024Qd
	{
		private sealed class _0024Sd
		{
			public int _0024zl;

			internal bool _0024xl(NotificationRequest _1)
			{
				return false;
			}
		}

		private readonly List<NotificationRequest> _0024yl;

		[CompilerGenerated]
		private int _0024Yl;

		public new string _0024a => _0024RfA();

		public new bool _0024A => _0024sfA();

		public new NotificationPermissionStatus _0024b => _0024SfA();

		public new IReadOnlyList<NotificationRequest> _0024B => _0024Vl();

		public new int _0024c
		{
			get
			{
				return _0024wl();
			}
			set
			{
				_0024Wl(value);
			}
		}

		public string _0024RfA()
		{
			return null;
		}

		public bool _0024sfA()
		{
			return false;
		}

		public NotificationPermissionStatus _0024SfA()
		{
			return NotificationPermissionStatus.Unknown;
		}

		public IReadOnlyList<NotificationRequest> _0024Vl()
		{
			return null;
		}

		public int _0024wl()
		{
			return 0;
		}

		public void _0024Wl(int _1)
		{
		}

		public void _0024tfA(NotificationChannelData _1)
		{
		}

		public void _0024TfA(Action<NotificationPermissionStatus> _1)
		{
		}

		public void _0024ufA()
		{
		}

		public void _0024UfA(NotificationRequest _1)
		{
		}

		public bool _0024vfA(out int _1)
		{
			_1 = default;
			return false;
		}

		public void _0024VfA(int _1)
		{
		}

		public void _0024wfA()
		{
		}

		public void _0024WfA()
		{
		}
	}
}
