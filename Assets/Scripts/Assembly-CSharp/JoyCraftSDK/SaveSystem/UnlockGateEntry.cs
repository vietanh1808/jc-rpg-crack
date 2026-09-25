using System;
using _0024H;
using _0024l;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class UnlockGateEntry : _0024YD, ISerializationCallbackReceiver
	{
		[SerializeField]
		private string gateId;

		[SerializeField]
		private bool unlocked;

		[SerializeField]
		private long unlockedAtValue;

		[NonSerialized]
		private _0024PE _0024MO;

		[NonSerialized]
		private _0024PE _0024UO;

		public string GateId => _0024kl();

		public bool IsUnlocked => _0024Kl();

		public long UnlockedAtValue => _0024ll();

		public string _0024kl()
		{
			return null;
		}

		public bool _0024Kl()
		{
			return false;
		}

		public long _0024ll()
		{
			return 0L;
		}

		internal UnlockGateEntry _0024Ll(string _1)
		{
			return null;
		}

		public void _0024ml(long _1)
		{
		}

		internal bool _0024kY()
		{
			return false;
		}

		private void _0024KY()
		{
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
