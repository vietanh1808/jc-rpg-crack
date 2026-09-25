using _0024J;
using JoyCraftSDK.Utilities;
using Sigtrap.Relays;
using UnityEngine.EventSystems;

namespace JoyCraftSDK.GameUI
{
	public class JoystickEvents : JMonoBehaviour, _0024cD, IPointerDownHandler, IEventSystemHandler, IDragHandler, IPointerUpHandler
	{
		public readonly Relay<PointerEventData> OnPressed;

		public readonly Relay<PointerEventData> OnDragged;

		public readonly Relay OnReleased;

		private bool _0024lN;

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}

		public void _0024agA()
		{
		}

		public bool _0024AgA()
		{
			return false;
		}

		public void _0024bgA(bool _1)
		{
		}

		public void _0024BgA()
		{
		}

		public int _0024cgA()
		{
			return 0;
		}
	}
}
