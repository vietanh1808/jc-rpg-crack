using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using _0024B;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace JoyCraftSDK
{
	public class TimeManager : ATimeManager
	{
		[StructLayout((LayoutKind)3)]
		private new struct _0024CA : IAsyncStateMachine
		{
			public int _0024Vm;

			public AsyncUniTaskMethodBuilder _0024wm;

			public TimeManager _0024Wm;

			private DateTime? _0024Wh;

			private UniTask<DateTime?>.Awaiter _0024GM;

			private SwitchToMainThreadAwaitable.Awaiter _0024hM;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024FkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $FkA
				this._0024FkA(_1);
			}
		}

		[SerializeField]
		private float _totalGameTime;

		[SerializeField]
		private float _totalLevelTime;

		[SerializeField]
		[Range(0.1f, 5f)]
		private float _gameSpeed;

		private float _0024Hh;

		private bool _0024ih;

		private int _0024Ih;

		private TimeSpan _0024jh;

		private readonly _0024XB _0024Jh;

		private bool _0024kh;

		private float _0024Kh;

		public override float _0024a
		{
			get
			{
				return _0024jcA();
			}
			set
			{
				_0024JcA(value);
			}
		}

		public override bool _0024A => _0024kcA();

		public override float _0024b => _0024KcA();

		public override float _0024B => _0024lcA();

		public override float _0024c => _0024LcA();

		public override float _0024C => _0024mcA();

		public override DateTime _0024d => _0024ocA();

		public override float _0024jcA()
		{
			return 0f;
		}

		public override void _0024JcA(float _1)
		{
		}

		public override bool _0024kcA()
		{
			return false;
		}

		public override float _0024KcA()
		{
			return 0f;
		}

		public override float _0024lcA()
		{
			return 0f;
		}

		public override float _0024LcA()
		{
			return 0f;
		}

		public override float _0024mcA()
		{
			return 0f;
		}

		private void _0024UE(ref AEventManager._0024xb _1)
		{
		}

		private void _0024vE(ref AEventManager._0024ub _1)
		{
		}

		private void _0024VE(ref AEventManager._0024UA _1)
		{
		}

		protected override void _0024hbA()
		{
		}

		protected override void _0024HbA()
		{
		}

		private void _0024wE(ref AEventManager._0024Yb _1)
		{
		}

		public override void _0024McA()
		{
		}

		public override void _0024ncA()
		{
		}

		public override void _0024NcA()
		{
		}

		public override DateTime _0024ocA()
		{
			return default;
		}

		protected virtual UniTask<DateTime?> _0024Gy()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_0024CA))]
		public override UniTask _0024OcA()
		{
			return default;
		}

		protected override void OnApplicationPause(bool pauseStatus)
		{
		}
	}
}
