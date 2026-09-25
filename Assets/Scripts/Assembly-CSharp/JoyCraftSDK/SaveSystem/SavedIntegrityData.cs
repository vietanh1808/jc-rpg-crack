using System;
using System.Collections.Generic;
using _0024h;
using _0024p;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	[_0024tE]
	public class SavedIntegrityData : JSaveData
	{
		[SerializeField]
		private string signature;

		[SerializeField]
		private int signatureVersion;

		[SerializeField]
		private int generation;

		[SerializeField]
		private bool seededFromCloud;

		[SerializeField]
		private long lastLocalSaveUtc;

		public string Signature => _0024YK();

		public int SignatureVersion => _0024zK();

		public bool HasSignature => _0024ZK();

		public int Generation => _0024TM();

		public bool SeededFromCloud => _0024XN();

		public long LastLocalSaveUtc => _0024mBA();

		public string _0024YK()
		{
			return null;
		}

		public int _0024zK()
		{
			return 0;
		}

		public bool _0024ZK()
		{
			return false;
		}

		public int _0024TM()
		{
			return 0;
		}

		public bool _0024XN()
		{
			return false;
		}

		public long _0024mBA()
		{
			return 0L;
		}

		public void _0024co(bool _1)
		{
		}

		public void _0024cdA(long _1)
		{
		}

		public void _0024al(string _1, int _1)
		{
		}

		public void _0024Co(int _1)
		{
		}

		public void _0024Al()
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
	}
}
