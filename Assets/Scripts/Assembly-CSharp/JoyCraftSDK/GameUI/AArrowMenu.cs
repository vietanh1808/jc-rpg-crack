using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using Sigtrap.Relays;

namespace JoyCraftSDK.GameUI
{
	public abstract class AArrowMenu<T> : JMonoBehaviour
	{
		public readonly Relay<T> OnSelectionChanged;

		public new abstract T _0024a { get; }

		public abstract T _0024wgA();

		public abstract void _0024WgA();

		public abstract void _0024xgA();

		public abstract void _0024XgA();

		public abstract void _0024ygA(List<T> _1);

		public abstract void _0024YgA(int _1);

		public abstract void _0024zgA(int _1);
	}
}
