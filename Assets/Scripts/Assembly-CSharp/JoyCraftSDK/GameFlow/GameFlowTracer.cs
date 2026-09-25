using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using _0024F;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.GameFlow
{
	public class GameFlowTracer : JMonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		private struct _0024DB : IAsyncStateMachine
		{
			public int _0024Vg;

			public AsyncUniTaskVoidMethodBuilder _0024wg;

			public GameFlowTracer _0024fH;

			private UniTask.Awaiter _0024Ui;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024hkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $hkA
				this._0024hkA(_1);
			}
		}

		[CompilerGenerated]
		private static GameFlowTracer _0024KJ;

		private readonly List<_0024uC> _0024mJ;

		private int _0024MJ;

		private string _0024nJ;

		private string _0024NJ;

		private string _0024oJ;

		private bool _0024OJ;

		public new static GameFlowTracer _0024a
		{
			get
			{
				return _0024Hi();
			}
			private set
			{
				_0024ii(value);
			}
		}

		public new static string _0024A => _0024Ii();

		public new static string _0024b => _0024ji();

		public new static string _0024B => _0024Ji();

		public static GameFlowTracer _0024Hi()
		{
			return null;
		}

		private static void _0024ii(GameFlowTracer _1)
		{
		}

		public static string _0024Ii()
		{
			return null;
		}

		public static string _0024ji()
		{
			return null;
		}

		public static string _0024Ji()
		{
			return null;
		}

		public override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnDestroy()
		{
		}

		[AsyncStateMachine(typeof(_0024DB))]
		private UniTaskVoid _0024ki()
		{
			return default;
		}

		protected override void _0024hbA()
		{
		}

		protected override void _0024HbA()
		{
		}

		public List<_0024uC> _0024Ki()
		{
			return null;
		}

		public void _0024li(string _1)
		{
		}

		private void _0024Li(ref AEventManager._0024BB _1)
		{
		}

		private void _0024mi(ref AEventManager._0024Vb _1)
		{
		}

		private void _0024Mi(ref AEventManager._0024tA _1)
		{
		}

		private void _0024ni(ref AEventManager._0024UA _1)
		{
		}

		private void _0024Ni(ref AEventManager._0024vA _1)
		{
		}

		private void _0024oi(ref AEventManager._0024CB _1)
		{
		}

		private void _0024Oi(ref AEventManager._0024mA _1)
		{
		}

		private void _0024pi(string _1, string _1)
		{
		}

		private int _0024Pi()
		{
			return 0;
		}

		private long _0024hl()
		{
			return 0L;
		}

		private int _0024Qi()
		{
			return 0;
		}

		private void _0024ri()
		{
		}

		private void _0024Ri(_0024uC _1)
		{
		}
	}
}
