using System.Collections.Generic;
using JoyCraftSDK.SaveSystem;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace JoyCraftSDK.Game
{
	[CreateAssetMenu(fileName = "TutorialFlow", menuName = "Tutorial/Flow")]
	public class TutorialFlow : ATutorialFlow
	{
		public TutorialType type;

		public int activeInLevel;

		public List<TutorialStep> steps;

		public UnityEvent OnCompleteEvent;

		public override bool _0024a => _0024oeA();

		public override bool _0024oeA()
		{
			return false;
		}

		public void _0024Oh()
		{
		}

		protected internal override void _0024OeA()
		{
		}

		protected virtual SavedTutorialData _0024peA()
		{
			return null;
		}
	}
}
