using System;
using _0024l;

namespace JoyCraftSDK.CloudSave
{
	[Serializable]
	public class CloudDomainBlob : _0024YD
	{
		public string domainKey;

		public int cloudSchemaVersion;

		public long savedAtUtc;

		public string payloadJson;

		public string stampHash;
	}
}
