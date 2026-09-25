using System;
using _0024l;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.GameUI
{
	public abstract class APanelAnim : JMonoBehaviour
	{
		[Serializable]
		public enum AnimInType
		{
			None = 0,
			FromTop = 1,
			FromLeft = 2,
			FromRight = 3,
			FromBot = 4,
			FadeAlpha = 5,
			FromScale = 6
		}

		[Serializable]
		public enum AnimOutType
		{
			None = 0,
			ToTop = 1,
			ToLeft = 2,
			ToRight = 3,
			ToBot = 4,
			FadeAlpha = 5,
			ToScale = 6
		}

		public virtual void _0024IgA(_0024ie _1)
		{
		}

		public virtual void _0024jgA()
		{
		}

		public virtual void _0024JgA()
		{
		}

		public virtual void _0024kgA()
		{
		}

		public virtual void _0024KgA()
		{
		}

		public virtual bool _0024lgA()
		{
			return false;
		}
	}
}
