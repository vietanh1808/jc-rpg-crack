using System;
using System.Collections.Generic;
using _0024h;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedGameData : JSaveData, _0024Gd, _0024hd, _0024Hd
	{
		[SerializeField]
		private SavedPlayerProgressData savedPlayerProgressData;

		[SerializeField]
		private SavedUserData savedUserData;

		[SerializeField]
		private SavedBuyData savedBuyData;

		[SerializeField]
		private SavedSettingData savedSettingData;

		[SerializeField]
		private SavedProgressionData savedProgressionData;

		[ES3NonSerializable]
		private List<_0024Gd> _0024nk;

		[ES3NonSerializable]
		private bool _0024Nk;

		public SavedPlayerProgressData SavedPlayerProgressData => _0024Ej();

		public SavedUserData SavedUserData => _0024fj();

		public SavedBuyData SavedBuyData => _0024Fj();

		public SavedSettingData SavedSettingData => _0024gj();

		public SavedProgressionData SavedProgressionData => _0024Gj();

		public SavedPlayerProgressData _0024Ej()
		{
			return null;
		}

		public SavedUserData _0024fj()
		{
			return null;
		}

		public SavedBuyData _0024Fj()
		{
			return null;
		}

		public SavedSettingData _0024gj()
		{
			return null;
		}

		public SavedProgressionData _0024Gj()
		{
			return null;
		}

		internal void _0024rM(SavedPlayerProgressData _1)
		{
		}

		internal void _0024RM(SavedUserData _1)
		{
		}

		internal void _0024sM(SavedBuyData _1)
		{
		}

		internal void _0024SM(SavedSettingData _1)
		{
		}

		internal void _0024tM(SavedProgressionData _1)
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

		public override string ToString()
		{
			return null;
		}
	}
}
