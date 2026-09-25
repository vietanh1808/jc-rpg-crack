using System;
using _0024k;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class AUIPrefabConfig : JScriptableObject
	{
		public GameObject prefabCanvas;

		public GameObject prefabScreen;

		public GameObject prefabPopup;

		public GameObject prefabTutorial;

		public GameObject prefabLocalizedButton;

		public GameObject prefabNonLocalizedButton;

		public GameObject prefabLocalizedText;

		public GameObject prefabNonLocalizedText;

		public GameObject prefabImage;

		public GameObject prefabSlider;

		public GameObject prefabSliderWithTexts;

		public GameObject prefabInputField;

		public GameObject prefabDropdown;

		public GameObject prefabToggle;

		public GameObject prefabSwitchToggle;

		public GameObject prefabVerticalScroll;

		public GameObject prefabHorizontalScroll;

		public GameObject prefabTab;

		public GameObject prefabTabPage;

		public GameObject prefabArrowMenu;

		[Obsolete("Use GetScreenPrefab(PanelCreationType) instead")]
		public GameObject _0024bn(bool _1)
		{
			return null;
		}

		public GameObject _0024Bn(_0024hD _1)
		{
			return null;
		}
	}
}
