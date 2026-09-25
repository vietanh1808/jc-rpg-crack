using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	[RequireComponent(typeof(Graphic))]
	public class ClickBlocker : JMonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		public void OnPointerClick(PointerEventData eventData)
		{
		}
	}
}
