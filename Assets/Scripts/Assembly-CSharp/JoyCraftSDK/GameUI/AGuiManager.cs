using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public abstract class AGuiManager : JMonoBehaviour
	{
		public new abstract UILayerManagerEffect _0024a { get; }

		public abstract UILayerManagerEffect _0024MEA();

		public abstract bool _0024nEA(UILayer _1);

		public abstract Canvas _0024NEA(UILayer _1);

		public abstract AUIPanel _0024kEA(UIPanelID _1);

		public abstract AUIPanel _0024KEA(UIPanelID _1, UILayer _1);

		public abstract void _0024lEA(UIPanelID _1);

		public abstract void _0024LEA();

		public abstract bool _0024oEA(UIPanelID _1, out AUIPanel _1, out UILayer _1);

		public abstract void _0024OEA();

		public abstract UIPanelID _0024mEA();

		public abstract void _0024pEA();

		public abstract void _0024PEA(bool _1);

		public abstract void _0024qEA(float _1, float _1);
	}
}
