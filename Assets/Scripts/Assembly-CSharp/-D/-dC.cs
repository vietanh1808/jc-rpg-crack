using System.Collections.Generic;
using _0024l;
using JoyCraftSDK.Game;
using JoyCraftSDK.SaveSystem;

namespace _0024d
{
	public class _0024dC : _0024DC
	{
		private readonly Dictionary<BuffType, _0024cC> _0024RI;

		private readonly _0024eC _0024sI;

		private bool _0024SI;

		private new SavedBuffData _0024a => _0024TG();

		private SavedBuffData _0024TG()
		{
			return null;
		}

		private void _0024uG()
		{
		}

		public override void _0024RDA()
		{
		}

		public override void _0024sDA(BuffType _1, float _1)
		{
		}

		public override void _0024SDA(BuffType _1)
		{
		}

		public override bool _0024tDA(BuffType _1)
		{
			return false;
		}

		public override float _0024TDA(BuffType _1)
		{
			return 0f;
		}

		public override float _0024uDA(BuffType _1)
		{
			return 0f;
		}

		public override IReadOnlyCollection<BuffType> _0024UDA()
		{
			return null;
		}

		private _0024cC _0024UG(BuffType _1)
		{
			return null;
		}

		private _0024cC _0024vG(BuffType _1)
		{
			return null;
		}

		private void _0024VG(BuffType _1)
		{
		}

		private float _0024wG(BuffType _1)
		{
			return 0f;
		}
	}
	public abstract class _0024DC : _0024YD
	{
		public abstract void _0024RDA();

		public abstract void _0024sDA(BuffType _1, float _1);

		public abstract void _0024SDA(BuffType _1);

		public abstract bool _0024tDA(BuffType _1);

		public abstract float _0024TDA(BuffType _1);

		public abstract float _0024uDA(BuffType _1);

		public abstract IReadOnlyCollection<BuffType> _0024UDA();
	}
}
