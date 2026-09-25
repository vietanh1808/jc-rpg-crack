using _0024J;
using JoyCraftSDK.GameUI;
using TMPro;
using UnityEngine;

namespace JoyCraftSDK.Utilities
{
	[RequireComponent(typeof(ABtnEvents))]
	[RequireComponent(typeof(AButtonAnimController))]
	public abstract class AButton : JMonoBehaviour
	{
		[SerializeField]
		protected ABtnEvents button;

		[SerializeField]
		protected AButtonAnimController buttonAnimController;

		[SerializeField]
		public TextMeshProUGUI text;

		protected abstract void _0024CgA();

		protected virtual void OnValidate()
		{
		}

		public void _0024cu(string _1)
		{
		}

		public void _0024Cu(bool _1)
		{
		}

		public bool _0024du()
		{
			return false;
		}

		public void _0024Du(bool _1 = false)
		{
		}

		public void _0024eu(bool _1 = false)
		{
		}

		public bool _0024Eu()
		{
			return false;
		}

		public abstract _0024cD _0024UhA();
	}
}
