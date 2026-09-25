using System.Runtime.CompilerServices;
using _0024l;
using JoyCraftSDK.AdminTest;
using Sigtrap.Relays;

namespace _0024K
{
	public abstract class _0024yD : _0024YD
	{
		public Relay<int> _0024Np;

		public Relay<int> _0024op;

		public Relay<bool> _0024Op;

		public Relay<bool> _0024pp;

		[CompilerGenerated]
		private bool _0024Pp;

		public new abstract CheatData _0024a { get; protected set; }

		public new bool _0024A
		{
			get
			{
				return _0024zr();
			}
			set
			{
				_0024Zr(value);
			}
		}

		public abstract void _0024phA();

		public abstract CheatData _0024ohA();

		protected abstract void _0024OhA(CheatData _1);

		public bool _0024zr()
		{
			return false;
		}

		public void _0024Zr(bool _1)
		{
		}
	}
}
