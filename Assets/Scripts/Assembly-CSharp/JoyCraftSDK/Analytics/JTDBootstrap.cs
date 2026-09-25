using System;
using System.Runtime.CompilerServices;
using System.Threading;
using _0024a;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Analytics
{
	[DefaultExecutionOrder(100)]
	public sealed class JTDBootstrap : JMonoBehaviour, global::_0024a._0024b
	{
		private static JTDBootstrap _0024CR;

		private bool _0024dR;

		private global::_0024a._0024B _0024DR;

		[CompilerGenerated]
		private Action<bool> _0024eR;

		[CompilerGenerated]
		private Action _0024ER;

		public new static global::_0024a._0024B _0024a => _0024GY();

		public new CancellationToken _0024A => _0024PAA();

		public new event Action<bool> _0024b
		{
			add
			{
				_0024qAA(value);
			}
			remove
			{
				_0024QAA(value);
			}
		}

		public new event Action _0024B
		{
			add
			{
				_0024rAA(value);
			}
			remove
			{
				_0024RAA(value);
			}
		}

		public static global::_0024a._0024B _0024GY()
		{
			return null;
		}

		public CancellationToken _0024PAA()
		{
			return default;
		}

		public void _0024qAA(Action<bool> _1)
		{
		}

		public void _0024QAA(Action<bool> _1)
		{
		}

		public void _0024rAA(Action _1)
		{
		}

		public void _0024RAA(Action _1)
		{
		}

		public override void Awake()
		{
		}

		private void Start()
		{
		}

		private void _0024hY()
		{
		}

		protected override void OnApplicationPause(bool pauseStatus)
		{
		}

		protected override void OnApplicationQuit()
		{
		}
	}
}
