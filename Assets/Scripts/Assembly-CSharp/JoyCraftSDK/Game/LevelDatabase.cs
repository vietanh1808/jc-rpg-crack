using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[CreateAssetMenu(fileName = "LevelDatabase", menuName = "GameSDK/LevelDatabase")]
	public class LevelDatabase : ALevelDatabase
	{
		[SerializeField]
		private List<ALevelData> levels;

		protected override int _0024c
		{
			public get
			{
				return _0024iDA();
			}
		}

		public override int _0024iDA()
		{
			return 0;
		}

		public override ALevelData _0024IDA(int _1)
		{
			return null;
		}
	}
}
