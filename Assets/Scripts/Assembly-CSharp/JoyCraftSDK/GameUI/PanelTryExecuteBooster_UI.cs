using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class PanelTryExecuteBooster_UI : APanelTryExecuteBooster_UI
	{
		private BoosterType _0024Kn;

		public GameObject busPickerLabel;

		public GameObject colorPickerLabel;

		public GameObject shuffleLabel;

		public Button[] closeBtns;

		public GameObject BGFade_Plane;

		public GameObject BGFade_Passenger;

		public override BoosterType _0024a
		{
			get
			{
				return _0024qGA();
			}
			set
			{
				_0024QGA(value);
			}
		}

		public override BoosterType _0024qGA()
		{
			return BoosterType.None;
		}

		public override void _0024QGA(BoosterType _1)
		{
		}

		private void Start()
		{
		}

		public override void _0024rGA()
		{
		}

		public void _0024zo()
		{
		}

		public override void _0024RGA()
		{
		}
	}
}
