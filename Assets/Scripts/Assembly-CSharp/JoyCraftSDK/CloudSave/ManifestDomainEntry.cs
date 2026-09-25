using System;
using _0024l;

namespace JoyCraftSDK.CloudSave
{
	[Serializable]
	internal class ManifestDomainEntry : _0024YD
	{
		public string domainKey;

		public int cloudSchemaVersion;

		public long savedAtUtc;

		public string stampHash;
	}
}
