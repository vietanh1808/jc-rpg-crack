using System;
using System.Collections.Generic;
using _0024h;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedPlayerProgressData : JSaveData
	{
		[SerializeField]
		private int level;

		[SerializeField]
		private int currentLevelAttempt;

		[SerializeField]
		private int currentLevelLoseIndex;

		[SerializeField]
		private int currentLevelExitIndex;

		[SerializeField]
		private float currentLevelDurationTotal;

		[SerializeField]
		private float lastAttemptProgressPosX;

		[SerializeField]
		private int winStreak;

		[SerializeField]
		private int loseStreak;

		[SerializeField]
		private int activeDayCount;

		[SerializeField]
		private string lastActiveDate;

		[SerializeField]
		private int loginStreak;

		[SerializeField]
		private int highestWinStreak;

		[SerializeField]
		private int firstTryWinCount;

		[SerializeField]
		private SavedBoosterData savedBoosterData;

		[SerializeField]
		private SavedFeatureData savedFeatureData;

		[SerializeField]
		private SavedTutorialData savedTutorialData;

		[SerializeField]
		private SavedRegenData savedRegenData;

		[SerializeField]
		private SavedBuffData savedBuffData;

		[SerializeField]
		private SavedRateAppData savedRateAppData;

		[SerializeField]
		private SavedPendingAbandonData savedPendingAbandonData;

		[SerializeField]
		private SavedBattlePassData savedBattlePassData;

		[SerializeField]
		private SavedLocalizationData savedLocalizationData;

		public int Level
		{
			get
			{
				return _0024Mj();
			}
			set
			{
				_0024nj(value);
			}
		}

		public int CompletedLevelCount => _0024Nj();

		public int CurrentLevelAttempt
		{
			get
			{
				return _0024oj();
			}
			set
			{
				_0024Oj(value);
			}
		}

		public int CurrentLevelLoseIndex
		{
			get
			{
				return _0024pj();
			}
			set
			{
				_0024Pj(value);
			}
		}

		public int CurrentLevelExitIndex
		{
			get
			{
				return _0024qj();
			}
			set
			{
				_0024Qj(value);
			}
		}

		public float CurrentLevelDurationTotal
		{
			get
			{
				return _0024rj();
			}
			set
			{
				_0024Rj(value);
			}
		}

		public float LastAttemptProgressPosX
		{
			get
			{
				return _0024sj();
			}
			set
			{
				_0024Sj(value);
			}
		}

		public int WinStreak
		{
			get
			{
				return _0024tj();
			}
			set
			{
				_0024Tj(value);
			}
		}

		public int LoseStreak
		{
			get
			{
				return _0024uj();
			}
			set
			{
				_0024Uj(value);
			}
		}

		public int ActiveDayCount
		{
			get
			{
				return _0024vj();
			}
			set
			{
				_0024Vj(value);
			}
		}

		public string LastActiveDate
		{
			get
			{
				return _0024wj();
			}
			set
			{
				_0024Wj(value);
			}
		}

		public int LoginStreak
		{
			get
			{
				return _0024xj();
			}
			set
			{
				_0024Xj(value);
			}
		}

		public int HighestWinStreak
		{
			get
			{
				return _0024yj();
			}
			set
			{
				_0024Yj(value);
			}
		}

		public int FirstTryWinCount
		{
			get
			{
				return _0024zj();
			}
			set
			{
				_0024Zj(value);
			}
		}

		public SavedBoosterData SavedBoosterData => _0024aJ();

		public SavedFeatureData SavedFeatureData => _0024AJ();

		public SavedTutorialData SavedTutorialData => _0024eJ();

		public SavedRegenData SavedRegenData => _0024bJ();

		public SavedBuffData SavedBuffData => _0024BJ();

		public SavedRateAppData SavedRateAppData => _0024cJ();

		public SavedPendingAbandonData SavedPendingAbandonData => _0024CJ();

		public SavedBattlePassData SavedBattlePassData => _0024dJ();

		public SavedLocalizationData SavedLocalizationData => _0024DJ();

		public int _0024Mj()
		{
			return 0;
		}

		public void _0024nj(int _1)
		{
		}

		public int _0024Nj()
		{
			return 0;
		}

		public int _0024oj()
		{
			return 0;
		}

		public void _0024Oj(int _1)
		{
		}

		public int _0024pj()
		{
			return 0;
		}

		public void _0024Pj(int _1)
		{
		}

		public int _0024qj()
		{
			return 0;
		}

		public void _0024Qj(int _1)
		{
		}

		public float _0024rj()
		{
			return 0f;
		}

		public void _0024Rj(float _1)
		{
		}

		public float _0024sj()
		{
			return 0f;
		}

		public void _0024Sj(float _1)
		{
		}

		public int _0024tj()
		{
			return 0;
		}

		public void _0024Tj(int _1)
		{
		}

		public int _0024uj()
		{
			return 0;
		}

		public void _0024Uj(int _1)
		{
		}

		public int _0024vj()
		{
			return 0;
		}

		public void _0024Vj(int _1)
		{
		}

		public string _0024wj()
		{
			return null;
		}

		public void _0024Wj(string _1)
		{
		}

		public int _0024xj()
		{
			return 0;
		}

		public void _0024Xj(int _1)
		{
		}

		public int _0024yj()
		{
			return 0;
		}

		public void _0024Yj(int _1)
		{
		}

		public int _0024zj()
		{
			return 0;
		}

		public void _0024Zj(int _1)
		{
		}

		public SavedBoosterData _0024aJ()
		{
			return null;
		}

		public SavedFeatureData _0024AJ()
		{
			return null;
		}

		public SavedTutorialData _0024eJ()
		{
			return null;
		}

		public SavedRegenData _0024bJ()
		{
			return null;
		}

		public SavedBuffData _0024BJ()
		{
			return null;
		}

		public SavedRateAppData _0024cJ()
		{
			return null;
		}

		public SavedPendingAbandonData _0024CJ()
		{
			return null;
		}

		public SavedBattlePassData _0024dJ()
		{
			return null;
		}

		public SavedLocalizationData _0024DJ()
		{
			return null;
		}

		public override int _0024SEA()
		{
			return 0;
		}

		public override bool _0024YEA(int _1)
		{
			return false;
		}

		public override List<_0024Gd> _0024tEA()
		{
			return null;
		}
	}
}
