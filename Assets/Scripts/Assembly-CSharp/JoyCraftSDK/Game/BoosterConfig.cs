using System.Collections.Generic;
using JoyCraftSDK.GameUI;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Video;

namespace JoyCraftSDK.Game
{
	[CreateAssetMenu(menuName = "GameSDK/BoosterConfig", fileName = "Config")]
	public class BoosterConfig : ABoosterConfig
	{
		[SerializeField]
		private List<BoosterConfigData> configData;

		[SerializeField]
		private SpriteData btnBg;

		[SerializeField]
		private Sprite btnLockedBg;

		[SerializeField]
		private Sprite lockedLevelBg;

		[SerializeField]
		private Sprite countBg;

		[SerializeField]
		private Sprite revokeBg;

		[SerializeField]
		private Sprite watchAdBg;

		[SerializeField]
		private float alphaRate;

		[SerializeField]
		private float showTime;

		public override float _0024a => _0024jCA();

		public override float _0024A => _0024JCA();

		public override float _0024jCA()
		{
			return 0f;
		}

		public override float _0024JCA()
		{
			return 0f;
		}

		public override VideoClip _0024kCA(BoosterType _1)
		{
			return null;
		}

		public override BoosterBtnData _0024KCA(BoosterType _1, bool _1)
		{
			return null;
		}

		public override BoosterProgressIcons _0024lCA(BoosterType _1)
		{
			return null;
		}

		protected virtual ReleaseDifficulty _0024LCA()
		{
			return (ReleaseDifficulty)0;
		}

		public override Sprite _0024mCA()
		{
			return null;
		}

		public override Sprite _0024MCA()
		{
			return null;
		}

		public override Sprite _0024nCA()
		{
			return null;
		}

		public override Sprite _0024NCA()
		{
			return null;
		}

		private Sprite _0024gF(BoosterType _1, bool _1)
		{
			return null;
		}

		private VideoClip _0024GF(BoosterType _1)
		{
			return null;
		}
	}
}
