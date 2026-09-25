using System.Runtime.CompilerServices;
using _0024l;
using JoyCraftSDK;
using JoyCraftSDK.SaveSystem;
using JoyCraftSDK.Security.CheatGuard;

namespace _0024O
{
	public abstract class _0024rE : _0024YD
	{
		[CompilerGenerated]
		private SaveIntegrityStatus _0024am;

		[CompilerGenerated]
		private int _0024Am;

		[CompilerGenerated]
		private int _0024Lm;

		[CompilerGenerated]
		private bool _0024mm;

		[CompilerGenerated]
		private int _0024Mm;

		[CompilerGenerated]
		private CheatGuardResponse _0024qm;

		[CompilerGenerated]
		private bool _0024Qm;

		public new SaveIntegrityStatus _0024a
		{
			get
			{
				return _0024il();
			}
			protected set
			{
				_0024Il(value);
			}
		}

		public new int _0024A
		{
			get
			{
				return _0024jl();
			}
			protected set
			{
				_0024ql(value);
			}
		}

		public new int _0024b
		{
			get
			{
				return _0024aM();
			}
			protected set
			{
				_0024AM(value);
			}
		}

		public new bool _0024B
		{
			get
			{
				return _0024bM();
			}
			protected set
			{
				_0024BM(value);
			}
		}

		public new int _0024c
		{
			get
			{
				return _0024EM();
			}
			protected set
			{
				_0024fM(value);
			}
		}

		public new CheatGuardResponse _0024C
		{
			get
			{
				return _0024iM();
			}
			protected set
			{
				_0024IM(value);
			}
		}

		public new bool _0024d
		{
			get
			{
				return _0024jM();
			}
			protected set
			{
				_0024JM(value);
			}
		}

		public new bool _0024D => _0024kM();

		public new abstract bool _0024e { get; }

		public SaveIntegrityStatus _0024il()
		{
			return SaveIntegrityStatus.Unknown;
		}

		protected void _0024Il(SaveIntegrityStatus _1)
		{
		}

		public int _0024jl()
		{
			return 0;
		}

		protected void _0024ql(int _1)
		{
		}

		public int _0024aM()
		{
			return 0;
		}

		protected void _0024AM(int _1)
		{
		}

		public bool _0024bM()
		{
			return false;
		}

		protected void _0024BM(bool _1)
		{
		}

		public int _0024EM()
		{
			return 0;
		}

		protected void _0024fM(int _1)
		{
		}

		public CheatGuardResponse _0024iM()
		{
			return CheatGuardResponse.None;
		}

		protected void _0024IM(CheatGuardResponse _1)
		{
		}

		public bool _0024jM()
		{
			return false;
		}

		protected void _0024JM(bool _1)
		{
		}

		public bool _0024kM()
		{
			return false;
		}

		public abstract bool _0024hJA();

		public abstract void _0024HJA(_0024sE _1);

		public abstract void _0024iJA();

		public abstract void _0024IJA();

		public abstract void _0024jJA(CheatGuardResponse _1);

		public abstract void _0024JJA();
	}
	public class _0024RE : _0024rE
	{
		private _0024sE _0024rm;

		private bool _0024Rm;

		public override bool _0024a => _0024hJA();

		public override bool _0024hJA()
		{
			return false;
		}

		public override void _0024HJA(_0024sE _1)
		{
		}

		public override void _0024iJA()
		{
		}

		public override void _0024IJA()
		{
		}

		public override void _0024jJA(CheatGuardResponse _1)
		{
		}

		public override void _0024JJA()
		{
		}

		protected virtual SaveIntegrityStatus _0024kJA()
		{
			return SaveIntegrityStatus.Unknown;
		}

		protected virtual void _0024KJA()
		{
		}

		private void _0024KM(ref AEventManager._0024PC _1)
		{
		}

		public void _0024lM()
		{
		}

		public void _0024LM(int _1)
		{
		}

		private void _0024mM()
		{
		}

		private void _0024MM()
		{
		}

		private void _0024nM()
		{
		}

		private void _0024NM()
		{
		}

		private static int _0024oM(SaveIntegrityStatus _1)
		{
			return 0;
		}

		private static bool _0024OM(SaveIntegrityStatus _1)
		{
			return false;
		}
	}
}
