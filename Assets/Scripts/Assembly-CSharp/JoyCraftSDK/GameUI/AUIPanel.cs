using System.Runtime.CompilerServices;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Serialization;

namespace JoyCraftSDK.GameUI
{
	public abstract class AUIPanel : JMonoBehaviour
	{
		[FormerlySerializedAs("root")]
		public Canvas _root;

		public APanelAnim panelAnimator;

		[SerializeField]
		private UILayer _defaultLayer;

		[CompilerGenerated]
		private bool _0024Pm;

		public new UILayer _0024a => _0024FM();

		public new bool _0024A
		{
			get
			{
				return _0024gM();
			}
			protected set
			{
				_0024GM(value);
			}
		}

		public UILayer _0024FM()
		{
			return UILayer.None;
		}

		public bool _0024gM()
		{
			return false;
		}

		protected void _0024GM(bool _1)
		{
		}

		public abstract UIPanelID _0024dgA();

		protected abstract void _0024mgA();

		public virtual void _0024MgA()
		{
		}

		public virtual void _0024ngA()
		{
		}

		public virtual void _0024NgA()
		{
		}

		public virtual void _0024ogA()
		{
		}
	}
}
