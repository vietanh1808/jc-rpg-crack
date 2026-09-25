using System;
using System.Collections.Generic;
using _0024J;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.InputSystem;

namespace JoyCraftSDK.JInput
{
	public abstract class AJInputManager : JMonoBehaviour
	{
		public new abstract bool _0024a { get; set; }

		public new abstract Vector2 _0024A { get; }

		public new abstract InputAction _0024b { get; }

		public abstract bool _0024VFA();

		public abstract void _0024wFA(bool _1);

		public abstract Vector2 _0024WFA();

		public abstract InputAction _0024xFA();

		public abstract void _0024XFA(Action _1 = null);

		public abstract void _0024yFA(_0024cD _1, float _1 = 0f);

		public abstract void _0024YFA(List<_0024cD> _1, float _1 = 0f);

		public abstract void _0024zFA();

		public abstract bool _0024ZFA(_0024cD _1);
	}
}
