using System;
using System.Collections.Generic;
using _0024l;
using UnityEngine;

namespace JoyCraftSDK.FeatureChecklist
{
	[Serializable]
	public class FeatureChecklistEntry : _0024YD
	{
		[SerializeField]
		private string id;

		[SerializeField]
		private ChecklistSource source;

		[SerializeField]
		private List<string> categories;

		[SerializeField]
		private string title;

		[TextArea(2, 6)]
		[SerializeField]
		private string description;

		[SerializeField]
		private int order;

		[SerializeField]
		private string flowKey;

		[SerializeField]
		private string note;

		public string Id
		{
			get
			{
				return _0024pI();
			}
			set
			{
				_0024PI(value);
			}
		}

		public ChecklistSource Source
		{
			get
			{
				return _0024qI();
			}
			set
			{
				_0024QI(value);
			}
		}

		public List<string> Categories => _0024rI();

		public string Title
		{
			get
			{
				return _0024RI();
			}
			set
			{
				_0024sI(value);
			}
		}

		public string Description
		{
			get
			{
				return _0024SI();
			}
			set
			{
				_0024tI(value);
			}
		}

		public int Order
		{
			get
			{
				return _0024TI();
			}
			set
			{
				_0024uI(value);
			}
		}

		public string FlowKey
		{
			get
			{
				return _0024UI();
			}
			set
			{
				_0024vI(value);
			}
		}

		public string Note
		{
			get
			{
				return _0024VI();
			}
			set
			{
				_0024wI(value);
			}
		}

		public string _0024pI()
		{
			return null;
		}

		public void _0024PI(string _1)
		{
		}

		public ChecklistSource _0024qI()
		{
			return ChecklistSource.Sdk;
		}

		public void _0024QI(ChecklistSource _1)
		{
		}

		public List<string> _0024rI()
		{
			return null;
		}

		public string _0024RI()
		{
			return null;
		}

		public void _0024sI(string _1)
		{
		}

		public string _0024SI()
		{
			return null;
		}

		public void _0024tI(string _1)
		{
		}

		public int _0024TI()
		{
			return 0;
		}

		public void _0024uI(int _1)
		{
		}

		public string _0024UI()
		{
			return null;
		}

		public void _0024vI(string _1)
		{
		}

		public string _0024VI()
		{
			return null;
		}

		public void _0024wI(string _1)
		{
		}
	}
}
