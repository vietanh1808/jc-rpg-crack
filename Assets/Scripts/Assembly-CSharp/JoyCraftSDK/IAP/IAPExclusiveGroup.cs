using System;
using System.Collections.Generic;
using _0024j;
using _0024l;
using UnityEngine;

namespace JoyCraftSDK.IAP
{
	[Serializable]
	public class IAPExclusiveGroup : _0024YD
	{
		[SerializeField]
		private string groupID;

		[_0024BD]
		[SerializeField]
		private List<string> productIDs;

		public string GroupID => _0024NL();

		public IReadOnlyList<string> ProductIDs => _0024oL();

		public string _0024NL()
		{
			return null;
		}

		public IReadOnlyList<string> _0024oL()
		{
			return null;
		}

		public bool _0024OL(string _1)
		{
			return false;
		}
	}
}
