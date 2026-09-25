using System;
using System.Collections.Generic;
using _0024l;

namespace JoyCraftSDK.CloudSave
{
	[Serializable]
	public class CloudSaveEnvelope : _0024YD
	{
		public int envelopeVersion;

		public long savedAtUtc;

		public List<CloudDomainBlob> domains;

		public static string _0024WAA(string _1, int _1, long _1, string _1)
		{
			return null;
		}

		public static string _0024XHA(string _1)
		{
			return null;
		}
	}
}
