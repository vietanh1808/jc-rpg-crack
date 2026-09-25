using _0024l;
using JoyCraftSDK.Game;
using JoyCraftSDK.Game.SaveData;

namespace _0024d
{
	public abstract class _0024cC : _0024YD
	{
		private readonly BuffType _0024qI;

		private readonly SavedBuffPoint _0024QI;

		protected readonly _0024EC _0024rI;

		public new BuffType _0024a => _0024PG();

		public new float _0024A => _0024qG();

		protected new long _0024b
		{
			get
			{
				return _0024QG();
			}
			set
			{
				_0024rG(value);
			}
		}

		protected new long _0024B
		{
			get
			{
				return _0024RG();
			}
			set
			{
				_0024sG(value);
			}
		}

		protected new float _0024c
		{
			get
			{
				return _0024SG();
			}
			set
			{
				_0024tG(value);
			}
		}

		protected _0024cC(BuffType type, SavedBuffPoint savedBuffPoint, _0024EC timedBuffService)
		{
		}

		public BuffType _0024PG()
		{
			return BuffType.None;
		}

		public float _0024qG()
		{
			return 0f;
		}

		protected long _0024QG()
		{
			return 0L;
		}

		protected void _0024rG(long _1)
		{
		}

		protected long _0024RG()
		{
			return 0L;
		}

		protected void _0024sG(long _1)
		{
		}

		protected float _0024SG()
		{
			return 0f;
		}

		protected void _0024tG(float _1)
		{
		}

		public abstract void _0024PDA(float _1, float _1);

		public abstract bool _0024qDA();

		public abstract float _0024QDA();

		public abstract void _0024rDA();
	}
	public class _0024CC : _0024cC
	{
		public _0024CC(BuffType type, SavedBuffPoint savedBuffPoint, _0024EC timedBuffService)
			: base(BuffType.None, null, null)
		{
		}

		public override void _0024PDA(float _1, float _1)
		{
		}

		public override bool _0024qDA()
		{
			return false;
		}

		public override float _0024QDA()
		{
			return 0f;
		}

		public override void _0024rDA()
		{
		}
	}
}
