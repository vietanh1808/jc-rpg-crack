using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.FeatureChecklist
{
	public abstract class AFeatureChecklistData : JScriptableObject
	{
		[SerializeField]
		private ChecklistSource source;

		[SerializeField]
		private List<FeatureChecklistEntry> entries;

		public new ChecklistSource _0024a => _0024WI();

		public new List<FeatureChecklistEntry> _0024A => _0024xI();

		public ChecklistSource _0024WI()
		{
			return ChecklistSource.Sdk;
		}

		public List<FeatureChecklistEntry> _0024xI()
		{
			return null;
		}
	}
}
