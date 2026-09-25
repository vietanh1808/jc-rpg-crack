using System;
using _0024c;
using _0024l;
using UnityEngine;

namespace JoyCraftSDK.Progression
{
	[Serializable]
	public class BadgeSpec : _0024YD
	{
		[SerializeField]
		private string badgeId;

		[SerializeField]
		private BadgeMode mode;

		private _0024bc _0024rk;

		public string BadgeId => _0024wi();

		public BadgeMode Mode => _0024Wi();

		public _0024bc Source => _0024xi();

		public string _0024wi()
		{
			return null;
		}

		public BadgeMode _0024Wi()
		{
			return BadgeMode.Condition;
		}

		public _0024bc _0024xi()
		{
			return null;
		}

		public static BadgeSpec _0024Xi(string _1, _0024bc _1)
		{
			return null;
		}

		public static BadgeSpec _0024yi(string _1, _0024bc _1)
		{
			return null;
		}
	}
}
