using System;
using System.Collections.Generic;
using JoyCraftSDK;
using JoyCraftSDK.Notification;
using JoyCraftSDK.SaveSystem;

namespace _0024I
{
	public class _0024ud : _0024vd
	{
		private sealed class _0024Ud
		{
			public Action<NotificationPermissionStatus> _0024CL;

			public Action<NotificationPermissionStatus> _0024dL;

			internal void _0024FL(NotificationPermissionStatus _1)
			{
			}
		}

		private readonly List<_0024Qd> _0024aL;

		private readonly List<_0024rd> _0024AL;

		private readonly List<NotificationRequest> _0024bL;

		private bool _0024BL;

		private bool m__0024cL;

		private new SavedSettingData _0024a => _0024cL();

		private new ANotificationConfig _0024A => _0024CL();

		public override bool _0024b => _0024zfA();

		protected override bool _0024B
		{
			public get
			{
				return _0024ZfA();
			}
		}

		protected override NotificationPermissionStatus _0024c
		{
			public get
			{
				return _0024aFA();
			}
		}

		private SavedSettingData _0024cL()
		{
			return null;
		}

		private ANotificationConfig _0024CL()
		{
			return null;
		}

		public override bool _0024zfA()
		{
			return false;
		}

		public override bool _0024ZfA()
		{
			return false;
		}

		public override NotificationPermissionStatus _0024aFA()
		{
			return NotificationPermissionStatus.Unknown;
		}

		public override void _0024AFA(Action _1 = null)
		{
		}

		public override void _0024bFA()
		{
		}

		private void _0024dL()
		{
		}

		public override void _0024BFA(_0024Qd _1)
		{
		}

		public override void _0024cFA(_0024rd _1)
		{
		}

		private void _0024DL()
		{
		}

		private void _0024eL(ref AEventManager._0024sb _1)
		{
		}

		private void _0024EL(ref AEventManager._0024Sb _1)
		{
		}

		public override void _0024CFA()
		{
		}

		public override void _0024dFA()
		{
		}

		public override void _0024DFA(Action<NotificationPermissionStatus> _1 = null)
		{
		}

		public override void _0024eFA()
		{
		}

		public override void _0024EFA(bool _1)
		{
		}

		private string _0024fL()
		{
			return null;
		}
	}
}
