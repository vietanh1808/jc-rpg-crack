using System;
using System.Threading;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK
{
	public abstract class ATaskManager : JMonoBehaviour
	{
		public abstract void _0024CBA(float _1, Action _1, CancellationToken _1 = default(CancellationToken));

		public abstract void _0024dBA(float _1, Action _1, CancellationToken _1 = default(CancellationToken));

		public abstract void _0024DBA(float _1, Action _1, Action<Exception> _1);

		public abstract void _0024eBA(float _1, Action _1, Action<Exception> _1);

		public abstract void _0024EBA(Action _1, CancellationToken _1 = default(CancellationToken));

		public abstract void _0024fBA(uint _1, Action _1, CancellationToken _1 = default(CancellationToken));

		public abstract void _0024lw(Action _1, MonoBehaviour _1 = null, CancellationToken _1 = default(CancellationToken));

		public abstract void _0024Lw(Func<bool> _1, Action _1, CancellationToken _1 = default(CancellationToken));
	}
}
