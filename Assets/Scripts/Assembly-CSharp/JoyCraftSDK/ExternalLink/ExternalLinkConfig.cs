using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.ExternalLink
{
	[CreateAssetMenu(fileName = "ExternalLinkConfig", menuName = "GameSDK/ExternalLinkConfig")]
	public class ExternalLinkConfig : AExternalLinkConfig
	{
		[SerializeField]
		private List<ExternalLinkEntry> links;

		public override string _0024fFA(ExternalLinkID _1)
		{
			return null;
		}
	}
}
