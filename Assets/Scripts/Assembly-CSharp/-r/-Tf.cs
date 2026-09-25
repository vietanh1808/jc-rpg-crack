using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using _0024P;
using _0024l;
using _0024s;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JoyCraftSDK;
using JoyCraftSDK.SaveSystem;

namespace _0024R
{
	public class _0024Tf : _0024YD
	{
		[StructLayout((LayoutKind)3)]
		private struct _0024xf : IAsyncStateMachine
		{
			public int _0024Pl;

			public AsyncUniTaskMethodBuilder _0024ql;

			public _0024Tf _0024Ql;

			public SavedGameData _0024rl;

			private UniTask.Awaiter _0024Vl;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024TkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $TkA
				this._0024TkA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024Xf : IAsyncStateMachine
		{
			public int _0024wl;

			public AsyncUniTaskMethodBuilder _0024Wl;

			public _0024Tf _0024Xl;

			public SavedGameData _0024Zl;

			public string _0024BM;

			private int _0024gM;

			private UniTask<JoyCraftSDK.CloudSave.CloudPushResult>.Awaiter _0024HM;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024ukA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $ukA
				this._0024ukA(_1);
			}
		}

		private readonly _0024If _0024BG;

		private readonly _0024Df _0024EG;

		private readonly Func<long> _0024fG;

		private readonly float _0024FG;

		private readonly Func<float, UniTask> _0024gG;

		private readonly _0024Vf _0024Jk;

		private readonly _0024uf _0024kk;

		private bool _0024GG;

		private SavedGameData _0024hG;

		private bool _0024HG;

		private bool _0024Oq;

		private bool _0024Kk;

		private SavedGameData _0024lk;

		private int _0024mk;

		public _0024Tf(_0024If envelopeSyncController, _0024Df cloudSaveService, Func<long> nowUtcProvider, float throttleIntervalSeconds = 2f, Func<float, UniTask> cooldownDelayAsync = null, _0024Vf telemetry = null, _0024uf breadcrumb = null)
		{
		}

		public void _0024xx()
		{
		}

		private void _0024Xx(ref AEventManager._0024QC _1)
		{
		}

		private void _0024Kf(ref AEventManager._0024sb _1)
		{
		}

		public void _0024zx(bool _1)
		{
		}

		[AsyncStateMachine(typeof(_0024xf))]
		public UniTask _0024yx(SavedGameData _1)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_0024Xf))]
		private UniTask _0024iw(SavedGameData _1, string _1)
		{
			return default;
		}

		private static bool _0024Iy(string _1)
		{
			return false;
		}
	}
}
