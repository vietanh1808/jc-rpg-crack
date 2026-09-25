using System.Collections.Generic;
using _0024E;
using _0024j;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.IAP
{
	public class IAPApplyReward : JMonoBehaviour
	{
		[_0024BD]
		[SerializeField]
		private string noAdsProductID;

		[_0024BD]
		[SerializeField]
		private string removeAdsProductID;

		[_0024BD]
		[SerializeField]
		private string noAdsBundleProductID;

		[_0024BD]
		[SerializeField]
		private string subMonthlyProductID;

		[_0024BD]
		[SerializeField]
		private string subYearlyProductID;

		private _0024rC _0024LL;

		private new _0024rC _0024a => _0024WL();

		private _0024rC _0024WL()
		{
			return null;
		}

		protected override void _0024hbA()
		{
		}

		protected override void _0024HbA()
		{
		}

		private void _0024xL(ref AEventManager._0024UA _1)
		{
		}

		private void _0024XL(string _1)
		{
		}

		private void _0024yL(IReadOnlyList<_0024zd> _1)
		{
		}

		private void _0024YL(string _1)
		{
		}

		private static PaymentGateway _0024zL()
		{
			return PaymentGateway.Sandbox;
		}

		private static string _0024ZL(PaymentGateway _1)
		{
			return null;
		}

		private static string _0024am()
		{
			return null;
		}

		private static string _0024Am(string _1)
		{
			return null;
		}

		private void _0024bm(bool _1)
		{
		}

		private void _0024Bm()
		{
		}

		private void _0024cm()
		{
		}

		private void _0024Cm(string _1)
		{
		}
	}
}
