using DG.Tweening;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class SmokeVfx : ASmokeVfx
	{
		[SerializeField]
		public ParticleSystem glowVfx;

		[SerializeField]
		private Light _glowLighting;

		[SerializeField]
		private float _lightingTime;

		[SerializeField]
		private float _lightingRange;

		private Tweener _0024Qj;

		public override ParticleSystem _0024a => _0024SeA();

		public override Light _0024A => _0024teA();

		public override ParticleSystem _0024SeA()
		{
			return null;
		}

		public override Light _0024teA()
		{
			return null;
		}

		public override void _0024TeA()
		{
		}
	}
}
