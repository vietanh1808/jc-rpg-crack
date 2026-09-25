using System;
using Cysharp.Threading.Tasks;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK
{
	public abstract class ATimeManager : JMonoBehaviour
	{
		public new abstract float _0024a { get; set; }

		public new abstract bool _0024A { get; }

		public new abstract float _0024b { get; }

		public new abstract float _0024B { get; }

		public new abstract float _0024c { get; }

		public new abstract float _0024C { get; }

		public new float _0024d => _0024WE();

		public new float _0024D => _0024xE();

		public new SerializedDateTime _0024e => _0024XE();

		public new virtual DateTime _0024E => _0024ocA();

		public abstract float _0024jcA();

		public abstract void _0024JcA(float _1);

		public abstract bool _0024kcA();

		public abstract float _0024KcA();

		public abstract float _0024lcA();

		public abstract float _0024LcA();

		public abstract float _0024mcA();

		public float _0024WE()
		{
			return 0f;
		}

		public float _0024xE()
		{
			return 0f;
		}

		public SerializedDateTime _0024XE()
		{
			return null;
		}

		public virtual DateTime _0024ocA()
		{
			return default;
		}

		public virtual UniTask _0024OcA()
		{
			return default;
		}

		public abstract void _0024ncA();

		public abstract void _0024McA();

		public abstract void _0024NcA();
	}
}
