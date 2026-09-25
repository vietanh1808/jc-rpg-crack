using System;
using _0024H;
using _0024l;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class CurrencyEntry : _0024YD, ISerializationCallbackReceiver
	{
		[SerializeField]
		private string currencyId;

		[SerializeField]
		private long earned;

		[SerializeField]
		private long spent;

		[NonSerialized]
		private _0024PE _0024Zo;

		[NonSerialized]
		private _0024PE _0024aO;

		public string CurrencyId => _0024jK();

		public long Earned => _0024gQ();

		public long Spent => _0024GQ();

		public long Balance => _0024hQ();

		public string _0024jK()
		{
			return null;
		}

		public long _0024gQ()
		{
			return 0L;
		}

		public long _0024GQ()
		{
			return 0L;
		}

		public long _0024hQ()
		{
			return 0L;
		}

		internal CurrencyEntry _0024lK(string _1)
		{
			return null;
		}

		internal void _0024cR(long _1)
		{
		}

		internal void _0024nR(long _1)
		{
		}

		internal bool _0024NR()
		{
			return false;
		}

		private void _0024hs()
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
