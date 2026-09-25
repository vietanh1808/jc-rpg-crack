using System;
using System.Collections.Generic;
using _0024P;
using _0024h;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedBuyData : JSaveData, _0024gf
	{
		[SerializeField]
		private bool buyNoAds;

		[SerializeField]
		private bool rated;

		[SerializeField]
		private bool shownNoAdsOffer;

		[SerializeField]
		private List<string> ownedProductIDs;

		[SerializeField]
		private int iapCount;

		public bool BuyNoAds
		{
			get
			{
				return _0024fJ();
			}
			set
			{
				_0024FJ(value);
			}
		}

		public bool Rated
		{
			get
			{
				return _0024gJ();
			}
			set
			{
				_0024GJ(value);
			}
		}

		public bool ShownNoAdsOffer
		{
			get
			{
				return _0024hJ();
			}
			set
			{
				_0024HJ(value);
			}
		}

		public IReadOnlyList<string> OwnedProductIDs => _0024iJ();

		public int IapCount => _0024kJ();

		public bool _0024fJ()
		{
			return false;
		}

		public void _0024FJ(bool _1)
		{
		}

		public bool _0024gJ()
		{
			return false;
		}

		public void _0024GJ(bool _1)
		{
		}

		public bool _0024hJ()
		{
			return false;
		}

		public void _0024HJ(bool _1)
		{
		}

		public IReadOnlyList<string> _0024iJ()
		{
			return null;
		}

		public bool _0024IJ(string _1)
		{
			return false;
		}

		public void _0024jJ(string _1)
		{
		}

		public void _0024JJ()
		{
		}

		public int _0024kJ()
		{
			return 0;
		}

		public void _0024KJ()
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

		public string _0024OJA(string _1)
		{
			return null;
		}
	}
}
