using JoyCraftSDK.Game;
using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class StaminaView : JMonoBehaviour
	{
		[SerializeField]
		private TMP_Text heartCountText;

		[SerializeField]
		private TMP_Text countdownText;

		[SerializeField]
		private GameObject moreHeartBtn;

		[SerializeField]
		private Image heartIcon;

		[SerializeField]
		private float tickIntervalSeconds;

		[SerializeField]
		private Sprite normalHeartSprite;

		[SerializeField]
		private Sprite infiniteHeartSprite;

		[SerializeField]
		private RegenResourceType resourceType;

		[SerializeField]
		private Button btn;

		private new float _0024os;

		private new int _0024Os;

		private new int _0024ps;

		private new bool _0024a => _0024GdA();

		private bool _0024GdA()
		{
			return false;
		}

		private void Start()
		{
		}

		private void _0024hdA()
		{
		}

		protected override void OnEnable()
		{
		}

		private void _0024kDA(int _1)
		{
		}

		private void _0024MDA()
		{
		}

		private void _0024gEA()
		{
		}

		private void _0024QEA()
		{
		}

		private static string _0024rEA(float _1)
		{
			return null;
		}

		private void _0024REA(ref AEventManager._0024Xc _1)
		{
		}

		private void _0024sEA(ref AEventManager._0024yb _1)
		{
		}

		protected override void _0024hbA()
		{
		}

		protected override void _0024HbA()
		{
		}
	}
}
