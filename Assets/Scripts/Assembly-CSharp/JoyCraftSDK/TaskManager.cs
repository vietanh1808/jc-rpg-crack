using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace JoyCraftSDK
{
	public class TaskManager : ATaskManager
	{
		[StructLayout((LayoutKind)3)]
		private struct _0024NB : IAsyncStateMachine
		{
			public int _0024cg;

			public AsyncUniTaskVoidMethodBuilder _0024Cg;

			public uint _0024dg;

			public CancellationToken _0024Dg;

			public Action _0024eg;

			private UniTask.Awaiter _0024Eg;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024WJA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $WJA
				this._0024WJA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024oB : IAsyncStateMachine
		{
			public int _0024fg;

			public AsyncUniTaskVoidMethodBuilder _0024Fg;

			public float _0024gg;

			public bool _0024Gg;

			public CancellationToken _0024hg;

			public Action _0024Hg;

			private UniTask.Awaiter _0024ig;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024YJA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $YJA
				this._0024YJA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024OB : IAsyncStateMachine
		{
			public int _0024Ig;

			public AsyncUniTaskVoidMethodBuilder _0024jg;

			public float _0024Jg;

			public bool _0024kg;

			public CancellationToken _0024Kg;

			public Action _0024lg;

			public Action<Exception> _0024Lg;

			private UniTask.Awaiter _0024mg;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024zJA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $zJA
				this._0024zJA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024pB : IAsyncStateMachine
		{
			public int _0024Mg;

			public AsyncUniTaskVoidMethodBuilder _0024ng;

			public MonoBehaviour _0024Ng;

			public CancellationToken _0024eN;

			public Action _0024og;

			private UniTask.Awaiter _0024Og;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024ZJA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $ZJA
				this._0024ZJA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024PB : IAsyncStateMachine
		{
			public int _0024pg;

			public AsyncUniTaskVoidMethodBuilder _0024Pg;

			public Func<bool> _0024qg;

			public CancellationToken _0024EN;

			public Action _0024Qg;

			private UniTask.Awaiter _0024rg;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024akA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $akA
				this._0024akA(_1);
			}
		}

		public override void _0024CBA(float _1, Action _1, CancellationToken _1 = default(CancellationToken))
		{
		}

		public override void _0024dBA(float _1, Action _1, CancellationToken _1 = default(CancellationToken))
		{
		}

		[AsyncStateMachine(typeof(_0024oB))]
		private UniTaskVoid _0024Oe(float _1, Action _1, bool _1, CancellationToken _1 = default(CancellationToken))
		{
			return default;
		}

		public override void _0024DBA(float _1, Action _1, Action<Exception> _1)
		{
		}

		public override void _0024eBA(float _1, Action _1, Action<Exception> _1)
		{
		}

		[AsyncStateMachine(typeof(_0024OB))]
		private static UniTaskVoid _0024pe(float _1, Action _1, Action<Exception> _1, bool _1, CancellationToken _1 = default(CancellationToken))
		{
			return default;
		}

		public override void _0024EBA(Action _1, CancellationToken _1 = default(CancellationToken))
		{
		}

		public override void _0024fBA(uint _1, Action _1, CancellationToken _1 = default(CancellationToken))
		{
		}

		[AsyncStateMachine(typeof(_0024NB))]
		private UniTaskVoid _0024Pe(uint _1, Action _1, CancellationToken _1 = default(CancellationToken))
		{
			return default;
		}

		public override void _0024lw(Action _1, MonoBehaviour _1 = null, CancellationToken _1 = default(CancellationToken))
		{
		}

		[AsyncStateMachine(typeof(_0024pB))]
		private UniTaskVoid _0024zF(Action _1, MonoBehaviour _1, CancellationToken _1 = default(CancellationToken))
		{
			return default;
		}

		public override void _0024Lw(Func<bool> _1, Action _1, CancellationToken _1 = default(CancellationToken))
		{
		}

		[AsyncStateMachine(typeof(_0024PB))]
		private UniTaskVoid _0024nG(Func<bool> _1, Action _1, CancellationToken _1 = default(CancellationToken))
		{
			return default;
		}

		public override void Awake()
		{
		}
	}
}
