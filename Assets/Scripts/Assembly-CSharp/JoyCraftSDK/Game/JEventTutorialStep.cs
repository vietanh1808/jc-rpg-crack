using System.Runtime.CompilerServices;
using _0024d;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace JoyCraftSDK.Game
{
	public abstract class JEventTutorialStep : JMonoBehaviour, _0024jC
	{
		public UnityEvent OnCompleteEvent;

		[CompilerGenerated]
		private TutorialStep _0024aj;

		public new TutorialStep _0024a
		{
			get
			{
				return _0024IeA();
			}
			set
			{
				_0024jeA(value);
			}
		}

		public TutorialStep _0024IeA()
		{
			return null;
		}

		public void _0024jeA(TutorialStep _1)
		{
		}

		public Vector3 _0024Fh(Vector3 _1)
		{
			return default;
		}
	}
}
