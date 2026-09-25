using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class BtnTryExecuteBooster : JButton
	{
		[SerializeField]
		private BoosterType boosterType;

		[SerializeField]
		private TextMeshProUGUI countTxt;

		[SerializeField]
		private TextMeshProUGUI unlockLevelTxt;

		[SerializeField]
		private GameObject unlockLevelArea;

		[SerializeField]
		private BtnImage btnImages;

		[SerializeField]
		private LockShakeAnim lockShake;

		[SerializeField]
		private DifficultyDataSO difficultyData;

		[SerializeField]
		private Image faceImage;

		[SerializeField]
		private Sprite faceNormalSprite;

		[SerializeField]
		private Sprite faceLockedSprite;

		private bool _0024Hn;

		private bool _0024in;

		protected override bool _0024a => _0024PGA();

		protected override bool _0024PGA()
		{
			return false;
		}

		protected override void _0024CgA()
		{
		}

		private void _0024oo()
		{
		}

		private void _0024Oo()
		{
		}

		private Sprite _0024po()
		{
			return null;
		}

		private void _0024Po(bool _1)
		{
		}

		private void _0024qo(float _1, float _1)
		{
		}

		private void _0024Qo()
		{
		}

		private void _0024ro()
		{
		}

		private void _0024Ro()
		{
		}

		private void _0024so(ref AEventManager._0024VA _1)
		{
		}

		private void _0024So(ref AEventManager._0024wA _1)
		{
		}

		private void _0024to(ref AEventManager._0024vA _1)
		{
		}

		private void _0024To(ref AEventManager._0024Fb _1)
		{
		}

		private void _0024uo(ref AEventManager._0024Gb _1)
		{
		}

		private void _0024Uo(ref AEventManager._0024hb _1)
		{
		}

		private void _0024vo(ref AEventManager._0024Hb _1)
		{
		}

		private void _0024Vo(ref AEventManager._0024tA _1)
		{
		}

		private void _0024wo(ref AEventManager._0024fb _1)
		{
		}

		protected override void _0024hbA()
		{
		}

		protected override void _0024HbA()
		{
		}

		protected override void OnEnable()
		{
		}
	}
}
