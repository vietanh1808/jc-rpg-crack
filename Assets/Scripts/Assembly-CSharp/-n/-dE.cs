using System.Runtime.CompilerServices;
using _0024l;
using JoyCraftSDK;
using JoyCraftSDK.Analytics;
using JoyCraftSDK.Utilities;

namespace _0024N
{
	public class _0024dE : _0024DE
	{
		[CompilerGenerated]
		private new SessionData _0024uR;

		[CompilerGenerated]
		private new LevelStatsData _0024UR;

		private _0024eE _0024vR;

		private new LevelPlayType _0024VR;

		private new LevelFinishReason _0024wR;

		private new int _0024WR;

		private new int _0024xR;

		private new bool _0024XR;

		public override SessionData _0024a
		{
			get
			{
				return _0024fiA();
			}
			protected set
			{
				_0024FiA(value);
			}
		}

		public override LevelStatsData _0024A
		{
			get
			{
				return _0024giA();
			}
			protected set
			{
				_0024GiA(value);
			}
		}

		public override string _0024b => _0024hiA();

		public override LevelPlayType _0024B => _0024HiA();

		public override int _0024c => _0024iiA();

		public override int _0024C => _0024IiA();

		public override int _0024d => _0024jiA();

		public override float _0024D => _0024JiA();

		public override string _0024e => _0024kiA();

		public override _0024eE _0024E => _0024KiA();

		public override bool _0024f => _0024liA();

		public override bool _0024F => _0024LiA();

		public override int _0024g => _0024miA();

		public override int _0024G => _0024MiA();

		public override SessionData _0024fiA()
		{
			return null;
		}

		protected override void _0024FiA(SessionData _1)
		{
		}

		public override LevelStatsData _0024giA()
		{
			return null;
		}

		protected override void _0024GiA(LevelStatsData _1)
		{
		}

		public override string _0024hiA()
		{
			return null;
		}

		public override LevelPlayType _0024HiA()
		{
			return LevelPlayType.Home;
		}

		public override int _0024iiA()
		{
			return 0;
		}

		public override int _0024IiA()
		{
			return 0;
		}

		public override int _0024jiA()
		{
			return 0;
		}

		public override float _0024JiA()
		{
			return 0f;
		}

		public override string _0024kiA()
		{
			return null;
		}

		public override _0024eE _0024KiA()
		{
			return default;
		}

		public override bool _0024liA()
		{
			return false;
		}

		public override bool _0024LiA()
		{
			return false;
		}

		public override int _0024miA()
		{
			return 0;
		}

		public override int _0024MiA()
		{
			return 0;
		}

		public override int _0024niA(int _1)
		{
			return 0;
		}

		public override void _0024NiA(LevelFinishReason _1, LevelFailReason _1)
		{
		}

		private void _0024gZ()
		{
		}

		private string _0024GZ()
		{
			return null;
		}

		private void _0024hZ(ref AEventManager._0024tA _1)
		{
		}

		private void _0024HZ(ref AEventManager._0024UA _1)
		{
		}

		private void _0024iZ(ref AEventManager._0024hb _1)
		{
		}

		public override void _0024oiA()
		{
		}

		private void _0024IZ()
		{
		}
	}
	public abstract class _0024DE : _0024YD
	{
		public new abstract SessionData _0024a { get; protected set; }

		public new abstract LevelStatsData _0024A { get; protected set; }

		public new abstract string _0024b { get; }

		public new abstract LevelPlayType _0024B { get; }

		public new abstract int _0024c { get; }

		public new abstract int _0024C { get; }

		public new abstract int _0024d { get; }

		public new abstract float _0024D { get; }

		public new abstract string _0024e { get; }

		public new abstract _0024eE _0024E { get; }

		public new abstract bool _0024f { get; }

		public new abstract bool _0024F { get; }

		public new abstract int _0024g { get; }

		public new abstract int _0024G { get; }

		public abstract void _0024oiA();

		public abstract SessionData _0024fiA();

		protected abstract void _0024FiA(SessionData _1);

		public abstract LevelStatsData _0024giA();

		protected abstract void _0024GiA(LevelStatsData _1);

		public abstract string _0024hiA();

		public abstract LevelPlayType _0024HiA();

		public abstract int _0024iiA();

		public abstract int _0024IiA();

		public abstract int _0024jiA();

		public abstract float _0024JiA();

		public abstract string _0024kiA();

		public abstract _0024eE _0024KiA();

		public abstract bool _0024liA();

		public abstract bool _0024LiA();

		public abstract int _0024miA();

		public abstract int _0024MiA();

		public abstract int _0024niA(int _1);

		public abstract void _0024NiA(LevelFinishReason _1, LevelFailReason _1);

		protected virtual void _0024OiA()
		{
		}
	}
}
