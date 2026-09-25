using System.Collections.Generic;
using _0024C;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.LiveEvent
{
	public abstract class ALiveEventConfig : JScriptableObject
	{
		[Tooltip("Id event — vào payload bus, phân biệt event; KHÔNG đổi sau ship.")]
		[SerializeField]
		private string eventId;

		[SerializeField]
		private TrackMode trackMode;

		[Tooltip("Feature-gate: event chỉ mở khi Level người chơi ≥ giá trị này. 0 = không gate (mở ngay).")]
		[SerializeField]
		private int unlockAtLevel;

		[Tooltip("Mỗi hàng tự mang số tier; track render theo tier TĂNG DẦN, không theo thứ tự trong list. milestoneId phải STABLE + unique (giá trị ghi vào save khi claim).")]
		[SerializeField]
		private List<LiveEventMilestoneRow> milestoneRows;

		[HideInInspector]
		[SerializeField]
		private List<LiveEventMilestoneEntry> milestoneEntries;

		public new string _0024a => _0024hf();

		public new TrackMode _0024A => _0024Hf();

		public new int _0024b => _0024if();

		public new IReadOnlyList<LiveEventMilestoneEntry> _0024B => _0024If();

		public string _0024hf()
		{
			return null;
		}

		public TrackMode _0024Hf()
		{
			return TrackMode.Spend;
		}

		public int _0024if()
		{
			return 0;
		}

		public IReadOnlyList<LiveEventMilestoneEntry> _0024If()
		{
			return null;
		}

		public bool _0024jf(int _1)
		{
			return false;
		}

		public IReadOnlyList<_0024Ic> _0024Jf()
		{
			return null;
		}

		private bool _0024kf()
		{
			return false;
		}
	}
}
