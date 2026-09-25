using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using _0024l;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JoyCraftSDK.GameUI;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace _0024B
{
	public abstract class _0024tB : _0024YD
	{
		public abstract bool _0024wBA(string _1);

		public abstract void _0024WBA(string _1);

		public abstract void _0024xBA(string _1);

		public abstract string _0024XBA(SceneIndex _1);
	}
	public class _0024TB : _0024WB
	{
		[StructLayout((LayoutKind)3)]
		private struct _0024uB : IAsyncStateMachine
		{
			public int _0024JG;

			public AsyncUniTaskVoidMethodBuilder _0024kG;

			public string _0024KG;

			public _0024TB _0024lG;

			public Action _0024LG;

			private Awaitable.Awaiter _0024mG;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024bkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $bkA
				this._0024bkA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024UB : IAsyncStateMachine
		{
			public int _0024MG;

			public AsyncUniTaskVoidMethodBuilder _0024nG;

			public _0024TB _0024NG;

			public SceneIndex _0024oG;

			private Stopwatch _0024Bh;

			private AsyncOperation _0024pG;

			private AsyncOperation _0024ch;

			private UniTask.Awaiter _0024qG;

			private Awaitable.Awaiter _0024QG;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024BkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $BkA
				this._0024BkA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024vB : IAsyncStateMachine
		{
			public int _0024rG;

			public AsyncUniTaskMethodBuilder _0024RG;

			public _0024TB _0024sG;

			public SceneIndex _0024SG;

			private UniTask.Awaiter _0024tG;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024ckA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $ckA
				this._0024ckA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024VB : IAsyncStateMachine
		{
			public int _0024TG;

			public AsyncUniTaskVoidMethodBuilder _0024uG;

			public _0024TB _0024UG;

			private UniTask.Awaiter _0024vG;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024CkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $CkA
				this._0024CkA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024wB : IAsyncStateMachine
		{
			public int _0024VG;

			public AsyncUniTaskVoidMethodBuilder _0024wG;

			public string _0024WG;

			public _0024TB _0024xG;

			public Action _0024XG;

			private Awaitable.Awaiter _0024yG;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024dkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $dkA
				this._0024dkA(_1);
			}
		}

		private readonly Dictionary<SceneIndex, Action> _0024iG;

		[CompilerGenerated]
		private bool _0024IG;

		private float _0024jG;

		private new bool _0024a
		{
			get
			{
				return _0024GE();
			}
			set
			{
				_0024hE(value);
			}
		}

		protected new AGuiManager _0024A => _0024HE();

		private new _0024tB _0024b => _0024iE();

		private bool _0024GE()
		{
			return false;
		}

		private void _0024hE(bool _1)
		{
		}

		protected AGuiManager _0024HE()
		{
			return null;
		}

		private _0024tB _0024iE()
		{
			return null;
		}

		private void _0024IE(SceneIndex _1, Action _1)
		{
		}

		public override void _0024yBA(SceneIndex _1, SceneIndex _1, Action _1 = null)
		{
		}

		[AsyncStateMachine(typeof(_0024VB))]
		public override UniTaskVoid _0024YBA()
		{
			return default;
		}

		public override void _0024zBA()
		{
		}

		private void _0024jE(SceneIndex _1, Action _1 = null, bool _1 = false)
		{
		}

		[AsyncStateMachine(typeof(_0024UB))]
		private UniTaskVoid _0024JE(SceneIndex _1)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_0024vB))]
		private UniTask _0024kE(SceneIndex _1)
		{
			return default;
		}

		public override void _0024ZBA(SceneIndex _1, Action _1 = null)
		{
		}

		public override void _0024acA(SceneIndex _1, Action _1 = null)
		{
		}

		[AsyncStateMachine(typeof(_0024uB))]
		private UniTaskVoid _0024KE(string _1, Action _1)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_0024wB))]
		private UniTaskVoid _0024lE(string _1, Action _1)
		{
			return default;
		}
	}
}
