using System;
using _0024l;
using UnityEngine;

namespace JoyCraftSDK.FeatureChecklist
{
	[Serializable]
	public class FeatureChecklistStatusEntry : _0024YD
	{
		[SerializeField]
		private string entryId;

		[SerializeField]
		private TestStatus status;

		public string EntryId
		{
			get
			{
				return _0024XI();
			}
			set
			{
				_0024yI(value);
			}
		}

		public TestStatus Status
		{
			get
			{
				return _0024YI();
			}
			set
			{
				_0024zI(value);
			}
		}

		public string _0024XI()
		{
			return null;
		}

		public void _0024yI(string _1)
		{
		}

		public TestStatus _0024YI()
		{
			return TestStatus.NotDone;
		}

		public void _0024zI(TestStatus _1)
		{
		}
	}
}
