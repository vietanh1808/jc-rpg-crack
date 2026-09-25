using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[CreateAssetMenu(fileName = "LevelData", menuName = "GameSDK/LevelData")]
	public class LevelData : ALevelData
	{
		[SerializeField]
		private ReleaseDifficulty releaseDifficulty;

		[Tooltip("ON: cát spawn với Color0Darken (ngẫu nhiên tối pixel -> grainy look). OFF: màu phẳng Color0.")]
		[SerializeField]
		private bool grainyLook;

		public override ReleaseDifficulty _0024a => _0024hDA();

		public override bool _0024A => _0024HDA();

		public override ReleaseDifficulty _0024hDA()
		{
			return (ReleaseDifficulty)0;
		}

		public override bool _0024HDA()
		{
			return false;
		}

		public void _0024IG(bool _1)
		{
		}
	}
}
