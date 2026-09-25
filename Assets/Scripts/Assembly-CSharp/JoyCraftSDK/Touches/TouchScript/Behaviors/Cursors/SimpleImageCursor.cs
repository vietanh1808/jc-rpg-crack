using TouchScript.Behaviors.Cursors;
using TouchScript.Pointers;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.Touches.TouchScript.Behaviors.Cursors
{
	public class SimpleImageCursor : PointerCursor
	{
		[SerializeField]
		public Image CursorImage;

		private bool _0024uL;

		public override void Awake()
		{
		}

		protected override void updateOnce(IPointer pointer)
		{
		}

		private bool _0024Km(IPointer _1)
		{
			return false;
		}

		private void _0024lm()
		{
		}

		protected override uint getPointerHash(IPointer pointer)
		{
			return 0u;
		}

		protected override void hide()
		{
		}

		protected override void show()
		{
		}

		public bool _0024Lm()
		{
			return false;
		}
	}
}
