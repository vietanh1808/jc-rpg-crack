using System;
using System.Collections.Generic;
using _0024h;
using _0024l;
using UnityEngine;
using UnityEngine.Serialization;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public abstract class JSaveData : _0024YD, _0024Gd, _0024hd, _0024Hd
	{
		[FormerlySerializedAs("dataVersion")]
		[SerializeField]
		private int currentVersion;

		public virtual int CloudSchemaVersion => _0024oJA();

		public int _0024xEA()
		{
			return 0;
		}

		public void _0024XEA(int _1)
		{
		}

		public void _0024yEA()
		{
		}

		public virtual bool _0024YEA(int _1)
		{
			return false;
		}

		public virtual int _0024oJA()
		{
			return 0;
		}

		public void _0024zEA()
		{
		}

		public void _0024ZEA()
		{
		}

		public virtual bool _0024afA()
		{
			return false;
		}

		public abstract int _0024SEA();

		public abstract List<_0024Gd> _0024tEA();

		protected virtual void _0024AfA()
		{
		}

		protected virtual void _0024bfA()
		{
		}
	}
}
