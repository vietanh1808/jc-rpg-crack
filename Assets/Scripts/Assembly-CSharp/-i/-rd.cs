using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using _0024l;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JoyCraftSDK.Notification;
using Unity.Notifications.Android;
using UnityEngine;

namespace _0024I
{
	public interface _0024rd
	{
		string _0024a { get; }

		bool _0024A { get; }

		string _0024nDA();

		bool _0024NDA();

		void _0024oDA(List<NotificationRequest> _1, DateTime _1);
	}
	public class _0024Rd : _0024YD, _0024Qd
	{
		[StructLayout((LayoutKind)3)]
		private struct _0024rB : IAsyncStateMachine
		{
			public int _0024Zi;

			public AsyncUniTaskVoidMethodBuilder _0024aI;

			public Action<NotificationPermissionStatus> _0024AI;

			private PermissionRequest _0024GH;

			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _0024BI;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024OkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $OkA
				this._0024OkA(_1);
			}
		}

		public new string _0024a => _0024RfA();

		public new bool _0024A => _0024sfA();

		public new NotificationPermissionStatus _0024b => _0024SfA();

		public string _0024RfA()
		{
			return null;
		}

		public bool _0024sfA()
		{
			return false;
		}

		public NotificationPermissionStatus _0024SfA()
		{
			return NotificationPermissionStatus.Unknown;
		}

		public void _0024tfA(NotificationChannelData _1)
		{
		}

		public void _0024TfA(Action<NotificationPermissionStatus> _1)
		{
		}

		public void _0024ufA()
		{
		}

		public void _0024UfA(NotificationRequest _1)
		{
		}

		public bool _0024vfA(out int _1)
		{
			_1 = default;
			return false;
		}

		public void _0024VfA(int _1)
		{
		}

		public void _0024wfA()
		{
		}

		public void _0024WfA()
		{
		}

		private bool _0024ye(AndroidJavaObject _1, string _1, string _1, string _1)
		{
			return false;
		}

		[AsyncStateMachine(typeof(_0024rB))]
		private UniTaskVoid _0024Ye(Action<NotificationPermissionStatus> _1)
		{
			return default;
		}

		private static NotificationPermissionStatus _0024ze(PermissionStatus _1)
		{
			return NotificationPermissionStatus.Unknown;
		}
	}
}
