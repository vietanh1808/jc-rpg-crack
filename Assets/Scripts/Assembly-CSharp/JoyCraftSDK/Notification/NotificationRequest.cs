using System;
using System.Runtime.CompilerServices;

namespace JoyCraftSDK.Notification
{
	[Serializable]
	public class NotificationRequest
	{
		[CompilerGenerated]
		private readonly int _0024DL;

		[CompilerGenerated]
		private readonly float _0024eL;

		[CompilerGenerated]
		private string _0024EL;

		[CompilerGenerated]
		private string _0024fL;

		[CompilerGenerated]
		private string _0024FL;

		[CompilerGenerated]
		private string _0024gL;

		public int Id => _0024GL();

		public float DelaySeconds => _0024hL();

		public string Title
		{
			get
			{
				return _0024HL();
			}
			private set
			{
				_0024iL(value);
			}
		}

		public string Body
		{
			get
			{
				return _0024IL();
			}
			private set
			{
				_0024jL(value);
			}
		}

		public string ChannelId
		{
			get
			{
				return _0024JL();
			}
			private set
			{
				_0024kL(value);
			}
		}

		public string SmallIcon
		{
			get
			{
				return _0024KL();
			}
			private set
			{
				_0024lL(value);
			}
		}

		public NotificationRequest(int id, float delaySeconds)
		{
		}

		public int _0024GL()
		{
			return 0;
		}

		public float _0024hL()
		{
			return 0f;
		}

		public string _0024HL()
		{
			return null;
		}

		private void _0024iL(string _1)
		{
		}

		public string _0024IL()
		{
			return null;
		}

		private void _0024jL(string _1)
		{
		}

		public string _0024JL()
		{
			return null;
		}

		private void _0024kL(string _1)
		{
		}

		public string _0024KL()
		{
			return null;
		}

		private void _0024lL(string _1)
		{
		}

		public void _0024LL(string _1, string _1, string _1, string _1)
		{
		}

		public bool _0024mL()
		{
			return false;
		}
	}
}
