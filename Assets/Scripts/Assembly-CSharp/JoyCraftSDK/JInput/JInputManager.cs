using System;
using System.Collections.Generic;
using _0024J;
using UnityEngine;
using UnityEngine.InputSystem;

namespace JoyCraftSDK.JInput
{
	public class JInputManager : AJInputManager
	{
		[Header("Input Actions")]
		[SerializeField]
		private InputActionAsset inputActions;

		[Header("State")]
		[SerializeField]
		private bool isInputEnabled;

		private InputAction _0024UL;

		private InputAction _0024vL;

		private Vector2 _0024VL;

		private readonly HashSet<int> _0024wL;

		private readonly List<string> _0024WL;

		public override bool _0024a
		{
			get
			{
				return _0024VFA();
			}
			set
			{
				_0024wFA(value);
			}
		}

		public override Vector2 _0024A => _0024WFA();

		public override InputAction _0024b => _0024xFA();

		public override bool _0024VFA()
		{
			return false;
		}

		public override void _0024wFA(bool _1)
		{
		}

		public override Vector2 _0024WFA()
		{
			return default;
		}

		public override InputAction _0024xFA()
		{
			return null;
		}

		public override void Awake()
		{
		}

		private void _0024mm()
		{
		}

		public override void _0024XFA(Action _1 = null)
		{
		}

		public override void _0024yFA(_0024cD _1, float _1 = 0f)
		{
		}

		public override void _0024YFA(List<_0024cD> _1, float _1 = 0f)
		{
		}

		public override void _0024zFA()
		{
		}

		public override bool _0024ZFA(_0024cD _1)
		{
			return false;
		}

		protected override void _0024hbA()
		{
		}

		protected override void _0024HbA()
		{
		}

		private void _0024Mm(ref AEventManager._0024yb _1)
		{
		}
	}
}
