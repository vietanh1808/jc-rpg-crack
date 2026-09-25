using System;
using System.Collections.Generic;
using _0024l;

namespace JoyCraftSDK.CloudSave
{
	[Serializable]
	internal class ManifestPayload : _0024YD
	{
		public int envelopeVersion;

		public long savedAtUtc;

		public List<ManifestDomainEntry> domains;
	}
}
