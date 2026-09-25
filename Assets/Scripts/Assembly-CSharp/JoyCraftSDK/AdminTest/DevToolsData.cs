using System;
using _0024l;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.AdminTest
{
	[Serializable]
	public class DevToolsData : _0024YD
	{
		[SerializeField]
		public float cameraRotationX;

		[SerializeField]
		public Color backgroundColor;

		[SerializeField]
		public Sprite backgroundImage;

		[SerializeField]
		public BackgroundMode backgroundMode;
	}
}
