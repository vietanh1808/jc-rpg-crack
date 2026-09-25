using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.FeatureChecklist
{
	public abstract class AFeatureChecklistStatusOverlay : JScriptableObject
	{
		[SerializeField]
		private string developer;

		[SerializeField]
		private List<FeatureChecklistStatusEntry> statuses;

		public new string _0024a => _0024ZI();

		public new List<FeatureChecklistStatusEntry> _0024A => _0024aj();

		public string _0024ZI()
		{
			return null;
		}

		public List<FeatureChecklistStatusEntry> _0024aj()
		{
			return null;
		}
	}
}
