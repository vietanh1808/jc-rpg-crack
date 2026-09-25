using System;
using UnityEngine;

namespace JoyCraftSDK.ExternalLink
{
	[Serializable]
	public class ExternalLinkEntry
	{
		[SerializeField]
		private ExternalLinkID id;

		[Tooltip("URL đầy đủ (https://... hoặc mailto:...). Để trống = link chưa cấu hình.")]
		[SerializeField]
		private string url;

		public ExternalLinkID ID => _0024ML();

		public string Url => _0024nL();

		public ExternalLinkID _0024ML()
		{
			return ExternalLinkID.None;
		}

		public string _0024nL()
		{
			return null;
		}
	}
}
