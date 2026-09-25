using System;
using _0024H;
using _0024l;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class CycleEntry : _0024YD, ISerializationCallbackReceiver
	{
		[SerializeField]
		private string cycleId;

		[SerializeField]
		private DateTime periodStartUtc;

		[SerializeField]
		private int used;

		[NonSerialized]
		private _0024PE _0024AO;

		public string CycleId => _0024Ss();

		public DateTime PeriodStartUtc => _0024ts();

		public int Used => _0024iS();

		public string _0024Ss()
		{
			return null;
		}

		public DateTime _0024ts()
		{
			return default;
		}

		public int _0024iS()
		{
			return 0;
		}

		internal CycleEntry _0024US(string _1)
		{
			return null;
		}

		public bool _0024wS(DateTime _1)
		{
			return false;
		}

		public void _0024ft(int _1)
		{
		}

		internal bool _0024Ft()
		{
			return false;
		}

		private void _0024St()
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
