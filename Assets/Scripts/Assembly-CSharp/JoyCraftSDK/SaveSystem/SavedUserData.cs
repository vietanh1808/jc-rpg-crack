using System;
using System.Collections.Generic;
using _0024h;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedUserData : JSaveData
	{
		[SerializeField]
		private string userId;

		[SerializeField]
		private SerializedDateTime lastTimeLogin;

		[SerializeField]
		private SerializedDateTime lastTimeLogout;

		[SerializeField]
		public int sessionsPlayed;

		[SerializeField]
		private SerializedDateTime lastTimeClaimedAds;

		public SerializedDateTime LastTimeLogin
		{
			get
			{
				return _0024vJ();
			}
			set
			{
				_0024VJ(value);
			}
		}

		public SerializedDateTime LastTimeLogout
		{
			get
			{
				return _0024wJ();
			}
			set
			{
				_0024WJ(value);
			}
		}

		public int SessionsPlayed
		{
			get
			{
				return _0024xJ();
			}
			set
			{
				_0024XJ(value);
			}
		}

		public SerializedDateTime LastTimeClaimedAds
		{
			get
			{
				return _0024yJ();
			}
			set
			{
				_0024YJ(value);
			}
		}

		public string UserId
		{
			get
			{
				return _0024zJ();
			}
			set
			{
				_0024ZJ(value);
			}
		}

		public SerializedDateTime _0024vJ()
		{
			return null;
		}

		public void _0024VJ(SerializedDateTime _1)
		{
		}

		public SerializedDateTime _0024wJ()
		{
			return null;
		}

		public void _0024WJ(SerializedDateTime _1)
		{
		}

		public int _0024xJ()
		{
			return 0;
		}

		public void _0024XJ(int _1)
		{
		}

		public SerializedDateTime _0024yJ()
		{
			return null;
		}

		public void _0024YJ(SerializedDateTime _1)
		{
		}

		public string _0024zJ()
		{
			return null;
		}

		public void _0024ZJ(string _1)
		{
		}

		public override int _0024SEA()
		{
			return 0;
		}

		public override List<_0024Gd> _0024tEA()
		{
			return null;
		}
	}
}
