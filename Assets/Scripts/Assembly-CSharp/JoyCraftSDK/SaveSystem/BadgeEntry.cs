using System;
using _0024H;
using _0024l;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class BadgeEntry : _0024YD, ISerializationCallbackReceiver
	{
		[SerializeField]
		private string badgeId;

		[SerializeField]
		private long seenStamp;

		[NonSerialized]
		private _0024PE _0024zo;

		public string BadgeId => _0024dQ();

		public long SeenStamp => _0024DQ();

		public string _0024dQ()
		{
			return null;
		}

		public long _0024DQ()
		{
			return 0L;
		}

		internal BadgeEntry _0024eQ(string _1)
		{
			return null;
		}

		public bool _0024EQ(long _1)
		{
			return false;
		}

		internal bool _0024fQ()
		{
			return false;
		}

		private void _0024FQ()
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
