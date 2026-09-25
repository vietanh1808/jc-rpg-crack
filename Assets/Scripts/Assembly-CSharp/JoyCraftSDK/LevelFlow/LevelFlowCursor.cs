using System;

namespace JoyCraftSDK.LevelFlow
{
	[Serializable]
	public struct LevelFlowCursor
	{
		public int LevelIndex;

		public int RoomIndex;

		public int RoomsPerLevel;

		public int GlobalRoomIndex => _0024bP();

		public bool IsLastRoomOfLevel => _0024kP();

		public int _0024bP()
		{
			return 0;
		}

		public bool _0024kP()
		{
			return false;
		}

		public static LevelFlowCursor _0024KP(int _1, int _1)
		{
			return default;
		}

		public void _0024lP()
		{
		}

		public void _0024LP(int _1)
		{
		}

		public bool _0024vR()
		{
			return false;
		}
	}
}
