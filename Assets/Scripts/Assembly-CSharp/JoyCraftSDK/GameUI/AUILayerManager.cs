using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public abstract class AUILayerManager : JMonoBehaviour
	{
		private sealed class _0024ED
		{
			public UIPanelID _0024Km;

			internal bool _0024wm(AUIPanel _1)
			{
				return false;
			}
		}

		private sealed class _0024fD
		{
			public UIPanelID _0024lm;

			internal bool _0024Wm(AUIPanel _1)
			{
				return false;
			}
		}

		[SerializeField]
		protected Canvas _layerCanvas;

		protected AGuiManager _0024jm;

		protected readonly List<AUIPanel> _0024Jm;

		protected readonly List<AUIPanel> _0024km;

		public new Canvas _0024a => _0024Tm();

		public Canvas _0024Tm()
		{
			return null;
		}

		public void _0024um(AGuiManager _1, Canvas _1)
		{
		}

		public virtual bool _0024FgA(out UIPanelID _1)
		{
			_1 = default;
			return false;
		}

		public virtual AUIPanel _0024ggA(UIPanelID _1, AUIPanel _1)
		{
			return null;
		}

		public virtual void _0024GgA(UIPanelID _1, AUIPanel _1)
		{
		}

		public virtual bool _0024hgA()
		{
			return false;
		}

		public virtual void _0024HgA()
		{
		}

		protected AUIPanel _0024Um(UIPanelID _1, AUIPanel _1)
		{
			return null;
		}

		protected AUIPanel _0024vm(AUIPanel _1)
		{
			return null;
		}

		protected void _0024Vm()
		{
		}
	}
}
