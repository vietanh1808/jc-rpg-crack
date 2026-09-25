using System;
using System.Runtime.CompilerServices;
using _0024l;
using JoyCraftSDK;
using JoyCraftSDK.GameUI;
using JoyCraftSDK.Utilities;

namespace _0024f
{
	public class _0024sC : _0024SC
	{
		private bool _0024hJ;

		private new AGuiManager _0024a => _0024XH();

		private AGuiManager _0024XH()
		{
			return null;
		}

		public override void _0024AEA(LevelFinishReason _1, LevelFailReason _1)
		{
		}

		private void _0024yH(ref AEventManager._0024tA _1)
		{
		}

		public override void _0024bEA()
		{
		}

		public override void _0024BEA(Action _1, LevelPlayType _1)
		{
		}

		public override void _0024cEA()
		{
		}

		public override void _0024CEA()
		{
		}

		public override void _0024dEA()
		{
		}

		public override void _0024DEA()
		{
		}

		public override void _0024eEA()
		{
		}

		public override void _0024EEA()
		{
		}

		public override void _0024fEA()
		{
		}

		public override void _0024FEA()
		{
		}
	}
	public abstract class _0024SC : _0024YD
	{
		private bool _0024HJ;

		private float _0024iJ;

		protected bool _0024IJ;

		[CompilerGenerated]
		private bool _0024jJ;

		public new bool _0024a
		{
			get
			{
				return _0024YH();
			}
			private set
			{
				_0024zH(value);
			}
		}

		public new float _0024A => _0024ZH();

		public new int _0024b => _0024ai();

		public new bool _0024B => _0024Ai();

		public new bool _0024c => _0024bi();

		public bool _0024YH()
		{
			return false;
		}

		private void _0024zH(bool _1)
		{
		}

		public float _0024ZH()
		{
			return 0f;
		}

		public int _0024ai()
		{
			return 0;
		}

		protected virtual int _0024pw()
		{
			return 0;
		}

		public bool _0024Ai()
		{
			return false;
		}

		public bool _0024bi()
		{
			return false;
		}

		public bool _0024Bi()
		{
			return false;
		}

		public void _0024ci()
		{
		}

		private void _0024Ci(bool _1)
		{
		}

		public void _0024di()
		{
		}

		protected virtual void _0024Pw(float _1)
		{
		}

		public bool _0024Di()
		{
			return false;
		}

		public void _0024ei(int _1)
		{
		}

		private void _0024Ei(ref AEventManager._0024yb _1)
		{
		}

		protected virtual bool _0024qw()
		{
			return false;
		}

		protected virtual float _0024Qw()
		{
			return 0f;
		}

		protected virtual bool _0024rw(int _1)
		{
			return false;
		}

		public virtual void _0024bEA()
		{
		}

		public abstract void _0024AEA(LevelFinishReason _1, LevelFailReason _1);

		public abstract void _0024BEA(Action _1, LevelPlayType _1);

		public abstract void _0024cEA();

		public abstract void _0024CEA();

		public abstract void _0024dEA();

		public abstract void _0024DEA();

		public abstract void _0024eEA();

		public virtual void _0024EEA()
		{
		}

		public abstract void _0024fEA();

		public abstract void _0024FEA();
	}
}
