using _0024l;
using JoyCraftSDK.Game;
using JoyCraftSDK.Game.SaveData;

namespace _0024d
{
	public abstract class _0024fC : _0024YD
	{
		private readonly RegenResourceType _0024tI;

		private readonly int _0024TI;

		private readonly int _0024uI;

		private readonly SavedRegenPoint _0024UI;

		public new RegenResourceType _0024a => _0024WG();

		public new int _0024A => _0024xG();

		public new int _0024b => _0024XG();

		protected new int _0024B
		{
			get
			{
				return _0024yG();
			}
			set
			{
				_0024YG(value);
			}
		}

		protected new long _0024c
		{
			get
			{
				return _0024zG();
			}
			set
			{
				_0024ZG(value);
			}
		}

		protected _0024fC(RegenResourceType type, int maxCount, int hardMaxCount, SavedRegenPoint savedRegenPoint)
		{
		}

		public RegenResourceType _0024WG()
		{
			return RegenResourceType.None;
		}

		public int _0024xG()
		{
			return 0;
		}

		public int _0024XG()
		{
			return 0;
		}

		protected int _0024yG()
		{
			return 0;
		}

		protected void _0024YG(int _1)
		{
		}

		protected long _0024zG()
		{
			return 0L;
		}

		protected void _0024ZG(long _1)
		{
		}

		public int _0024ah()
		{
			return 0;
		}

		public void _0024Ah(int _1)
		{
		}

		public bool _0024bh(int _1)
		{
			return false;
		}

		protected void _0024Bh(int _1, RegenChangeSource _1)
		{
		}

		public abstract void _0024xDA();

		public abstract float _0024XDA();

		public virtual float _0024yDA()
		{
			return 0f;
		}

		protected virtual void _0024YDA()
		{
		}

		public virtual void _0024zDA(int _1, float _1)
		{
		}
	}
	public class _0024FC : _0024fC
	{
		private readonly int _0024vI;

		private readonly _0024iC _0024VI;

		public _0024FC(RegenResourceType type, int maxCount, int hardMaxCount, int regenSeconds, SavedRegenPoint savedRegenPoint, _0024iC timedRegenService)
			: base(RegenResourceType.None, 0, 0, null)
		{
		}

		public override void _0024xDA()
		{
		}

		public override float _0024XDA()
		{
			return 0f;
		}

		public override float _0024yDA()
		{
			return 0f;
		}

		protected override void _0024YDA()
		{
		}

		public override void _0024zDA(int _1, float _1)
		{
		}
	}
}
