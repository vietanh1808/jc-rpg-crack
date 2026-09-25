using System;
using System.Collections.Generic;
using _0024h;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedPendingAbandonData : JSaveData
	{
		[SerializeField]
		private bool hasPending;

		[SerializeField]
		private long backgroundUtcTicks;

		[SerializeField]
		private string sessionId;

		[SerializeField]
		private float timeSpent;

		[SerializeField]
		private int itemsTotal;

		[SerializeField]
		private int itemsCleared;

		[SerializeField]
		private LevelPlayType playType;

		public bool HasPending => _0024Rk();

		public long BackgroundUtcTicks => _0024sk();

		public string SessionId => _0024Sk();

		public float TimeSpent => _0024tk();

		public int ItemsTotal => _0024Tk();

		public int ItemsCleared => _0024uk();

		public LevelPlayType PlayType => _0024Uk();

		public override int _0024SEA()
		{
			return 0;
		}

		public override List<_0024Gd> _0024tEA()
		{
			return null;
		}

		public bool _0024Rk()
		{
			return false;
		}

		public long _0024sk()
		{
			return 0L;
		}

		public string _0024Sk()
		{
			return null;
		}

		public float _0024tk()
		{
			return 0f;
		}

		public int _0024Tk()
		{
			return 0;
		}

		public int _0024uk()
		{
			return 0;
		}

		public LevelPlayType _0024Uk()
		{
			return LevelPlayType.Home;
		}

		public void _0024vk(long _1, string _1, float _1, int _1, int _1, LevelPlayType _1)
		{
		}

		public void _0024Vk()
		{
		}
	}
}
