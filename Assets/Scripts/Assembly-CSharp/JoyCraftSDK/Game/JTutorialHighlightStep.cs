using System.Runtime.CompilerServices;
using _0024d;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace JoyCraftSDK.Game
{
	public class JTutorialHighlightStep : JMonoBehaviour, _0024jC, _0024IC
	{
		[SerializeField]
		private UnityEvent OnStart;

		[SerializeField]
		private UnityEvent OnComplete;

		[SerializeField]
		private JButton highlightedButton;

		[CompilerGenerated]
		private bool _0024gj;

		[CompilerGenerated]
		private TutorialStep _0024Gj;

		public new bool _0024a
		{
			get
			{
				return _0024geA();
			}
			set
			{
				_0024GeA(value);
			}
		}

		public new TutorialStep _0024A
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

		public bool _0024geA()
		{
			return false;
		}

		public void _0024GeA(bool _1)
		{
		}

		public TutorialStep _0024IeA()
		{
			return null;
		}

		public void _0024jeA(TutorialStep _1)
		{
		}

		private void Start()
		{
		}

		protected override void _0024hbA()
		{
		}

		protected override void _0024HbA()
		{
		}

		public void _0024ieA()
		{
		}

		public void _0024heA()
		{
		}

		public void _0024HeA()
		{
		}
	}
}
