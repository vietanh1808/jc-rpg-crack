using System;
using System.Collections.Generic;
using _0024h;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedRateAppData : JSaveData
	{
		[SerializeField]
		private int winsSinceLastPrompt;

		[SerializeField]
		private long lastPromptUtcTicks;

		[SerializeField]
		private int promptCount;

		[SerializeField]
		private string versionLastRated;

		public int WinsSinceLastPrompt => _0024Aj();

		public long LastPromptUtcTicks => _0024bj();

		public int PromptCount => _0024Bj();

		public string VersionLastRated => _0024cj();

		public override int _0024SEA()
		{
			return 0;
		}

		public override List<_0024Gd> _0024tEA()
		{
			return null;
		}

		public int _0024Aj()
		{
			return 0;
		}

		public long _0024bj()
		{
			return 0L;
		}

		public int _0024Bj()
		{
			return 0;
		}

		public string _0024cj()
		{
			return null;
		}

		public void _0024Cj()
		{
		}

		public void _0024dj(long _1, string _1)
		{
		}
	}
}
