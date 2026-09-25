using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class BackgroundCamera : ABackgroundCamera
	{
		[SerializeField]
		private Camera backgroundCam;

		public override Camera _0024a => _0024zCA();

		public override Camera _0024zCA()
		{
			return null;
		}

		private void OnValidate()
		{
		}
	}
}
