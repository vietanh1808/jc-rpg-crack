using System.Collections.Generic;
using _0024h;
using _0024l;
using JoyCraftSDK.SaveSystem;

namespace _0024C
{
	public readonly struct _0024fc
	{
		public readonly bool _0024aH;

		public readonly int _0024AH;

		public readonly int _0024bH;

		public readonly int _0024BH;

		public readonly int _0024cH;

		public static _0024fc _0024a => _0024Gf();

		public _0024fc(int tier, int cost, int progress)
		{
			_0024aH = false;
			_0024AH = 0;
			_0024bH = 0;
			_0024BH = 0;
			_0024cH = 0;
		}

		public static _0024fc _0024Gf()
		{
			return default;
		}
	}
	public abstract class _0024Fc : _0024YD
	{
		public new abstract string _0024a { get; }

		public new virtual bool _0024A => _0024zcA();

		public new virtual bool _0024b => _0024ZcA();

		protected new abstract _0024kc _0024B { get; }

		protected new abstract JSaveData _0024c { get; }

		public abstract string _0024XcA();

		public abstract void _0024FCA();

		public virtual bool _0024zcA()
		{
			return false;
		}

		public virtual bool _0024ZcA()
		{
			return false;
		}

		protected abstract _0024kc _0024ycA();

		protected abstract JSaveData _0024YcA();

		protected virtual void _0024gCA()
		{
		}

		public bool _0024pf(int _1)
		{
			return false;
		}

		public bool _0024Pf(int _1)
		{
			return false;
		}

		public virtual void _0024GCA()
		{
		}

		private void _0024qf(List<_0024Gd> _1)
		{
		}

		protected virtual void _0024hCA(int _1)
		{
		}

		protected virtual void _0024HCA(int _1, int _1)
		{
		}
	}
}
