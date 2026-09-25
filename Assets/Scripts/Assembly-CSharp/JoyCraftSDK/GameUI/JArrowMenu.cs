using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class JArrowMenu<T> : AArrowMenu<T>
	{
		[Tooltip("List of options to navigate through")]
		[SerializeField]
		protected List<T> options;

		[Tooltip("Current index in the options list")]
		[SerializeField]
		protected int currentIndex;

		[Tooltip("Whether to wrap around when reaching the list boundaries")]
		[SerializeField]
		protected bool wrapAround;

		[SerializeField]
		protected ABtnEvents leftArrow;

		[SerializeField]
		protected ABtnEvents rightArrow;

		[SerializeField]
		protected TextMeshProUGUI textValue;

		public override T _0024a => _0024wgA();

		public override T _0024wgA()
		{
			return default;
		}

		protected virtual void Start()
		{
		}

		public override void _0024WgA()
		{
		}

		public override void _0024xgA()
		{
		}

		public override void _0024XgA()
		{
		}

		public override void _0024ygA(List<T> _1)
		{
		}

		public override void _0024YgA(int _1)
		{
		}

		public override void _0024zgA(int _1)
		{
		}

		public bool _0024Mn(T _1, bool _1 = false)
		{
			return false;
		}

		private void _0024nn()
		{
		}

		private void _0024Nn()
		{
		}

		public int _0024on()
		{
			return 0;
		}

		public List<T> _0024On()
		{
			return null;
		}

		public int _0024pn()
		{
			return 0;
		}

		protected override void _0024hbA()
		{
		}

		protected override void _0024HbA()
		{
		}
	}
}
