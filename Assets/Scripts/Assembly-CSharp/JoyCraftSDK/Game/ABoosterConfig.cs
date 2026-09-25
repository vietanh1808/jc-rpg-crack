using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Video;

namespace JoyCraftSDK.Game
{
	public abstract class ABoosterConfig : JScriptableObject
	{
		public new abstract float _0024a { get; }

		public new abstract float _0024A { get; }

		public abstract float _0024jCA();

		public abstract float _0024JCA();

		public abstract VideoClip _0024kCA(BoosterType _1);

		public abstract BoosterBtnData _0024KCA(BoosterType _1, bool _1);

		public abstract BoosterProgressIcons _0024lCA(BoosterType _1);

		public abstract Sprite _0024NCA();

		public abstract Sprite _0024mCA();

		public abstract Sprite _0024MCA();

		public abstract Sprite _0024nCA();
	}
}
