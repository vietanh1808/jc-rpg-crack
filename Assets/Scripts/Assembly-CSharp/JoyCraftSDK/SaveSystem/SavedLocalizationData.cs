using System;
using System.Collections.Generic;
using _0024h;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedLocalizationData : JSaveData
	{
		[SerializeField]
		private LocalizationLocale activeLocale;

		public void _0024ak(LocalizationLocale _1)
		{
		}

		public override int _0024SEA()
		{
			return 0;
		}

		public override List<_0024Gd> _0024tEA()
		{
			return null;
		}

		protected override void _0024bfA()
		{
		}
	}
}
