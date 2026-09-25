using _0024l;
using JoyCraftSDK.Utilities;

namespace _0024B
{
	public class _0024eB : _0024EB
	{
		private GameFeatureType _0024nF;

		public override GameFeatureType _0024a => _0024NbA();

		public override GameFeatureType _0024A => _0024obA();

		public override GameFeatureType _0024NbA()
		{
			return GameFeatureType.None;
		}

		public override GameFeatureType _0024obA()
		{
			return GameFeatureType.None;
		}

		public override void _0024ObA(GameFeatureType _1)
		{
		}

		public override float _0024pbA()
		{
			return 0f;
		}

		public override float _0024PbA()
		{
			return 0f;
		}

		public override void _0024qbA(GameFeatureType _1)
		{
		}

		private float _0024ND(int _1)
		{
			return 0f;
		}
	}
	public abstract class _0024EB : _0024YD
	{
		public new abstract GameFeatureType _0024a { get; }

		public new abstract GameFeatureType _0024A { get; }

		public abstract GameFeatureType _0024NbA();

		public abstract GameFeatureType _0024obA();

		public abstract void _0024ObA(GameFeatureType _1);

		public abstract float _0024pbA();

		public abstract float _0024PbA();

		public abstract void _0024qbA(GameFeatureType _1);
	}
}
