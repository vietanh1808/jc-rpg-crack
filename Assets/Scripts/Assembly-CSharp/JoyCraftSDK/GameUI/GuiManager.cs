using System;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Serialization;

namespace JoyCraftSDK.GameUI
{
	public class GuiManager : AGuiManager
	{
		[Serializable]
		public struct ActivePanelEntry
		{
			public AUIPanel panel;

			public UILayer layer;
		}

		private struct _0024FD
		{
			public UILayer _0024Nm;

			public Canvas _0024om;

			public AUILayerManager _0024Om;
		}

		private sealed class _0024gD
		{
			public UIPanelID _0024pm;

			internal bool _0024cM(AUIPanel _1)
			{
				return false;
			}

			internal bool _0024CM(AUIPanel _1)
			{
				return false;
			}

			internal bool _0024dM(AUIPanel _1)
			{
				return false;
			}
		}

		[SerializeField]
		public Canvas layerBase;

		[SerializeField]
		public Canvas layerFlow;

		[FormerlySerializedAs("layerTop")]
		[SerializeField]
		public Canvas layerPopup;

		[SerializeField]
		public Canvas layerTutorial;

		[SerializeField]
		public Canvas layerEffect;

		[SerializeField]
		public AUILoading loadingUi;

		[SerializeField]
		private ActivePanelDict _activeRegistry;

		[SerializeField]
		private UILayerManagerBase _layerManagerBase;

		[SerializeField]
		private UILayerManagerFlow _layerManagerFlow;

		[SerializeField]
		private UILayerManagerTutorial _layerManagerTutorial;

		[FormerlySerializedAs("_layerManagerTop")]
		[SerializeField]
		private UILayerManagerPopup _layerManagerPopup;

		[SerializeField]
		private UILayerManagerEffect _layerManagerEffect;

		private _0024FD[] _0024nm;

		public override UILayerManagerEffect _0024a => _0024MEA();

		public override UILayerManagerEffect _0024MEA()
		{
			return null;
		}

		public override bool _0024nEA(UILayer _1)
		{
			return false;
		}

		public override Canvas _0024NEA(UILayer _1)
		{
			return null;
		}

		public override void Awake()
		{
		}

		private void _0024Xm()
		{
		}

		private void _0024ym()
		{
		}

		public override AUIPanel _0024kEA(UIPanelID _1)
		{
			return null;
		}

		public override AUIPanel _0024KEA(UIPanelID _1, UILayer _1)
		{
			return null;
		}

		public override void _0024lEA(UIPanelID _1)
		{
		}

		public override void _0024LEA()
		{
		}

		private void _0024Ym()
		{
		}

		public override bool _0024oEA(UIPanelID _1, out AUIPanel _1, out UILayer _1)
		{
			_1 = null;
			_1 = default;
			return false;
		}

		public override void _0024OEA()
		{
		}

		public override UIPanelID _0024mEA()
		{
			return UIPanelID.None;
		}

		private AUILayerManager _0024zm(UILayer _1)
		{
			return null;
		}

		public override void _0024PEA(bool _1)
		{
		}

		public override void _0024pEA()
		{
		}

		public override void _0024qEA(float _1, float _1)
		{
		}

		private AUIPanel _0024Zm(UIPanelID _1)
		{
			return null;
		}
	}
}
