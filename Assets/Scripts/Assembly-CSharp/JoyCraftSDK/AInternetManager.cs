using System;
using JoyCraftSDK.Utilities;
using Sigtrap.Relays;
using UnityEngine;

namespace JoyCraftSDK
{
	public abstract class AInternetManager : JMonoBehaviour
	{
		public Relay OnCheckStarted;

		public Relay OnCheckFinished;

		public Relay OnConnectionStatusChanged;

		public Relay OnCheckTimeout;

		public new abstract NetworkReachability _0024a { get; }

		public new abstract InternetStatus _0024A { get; }

		public abstract NetworkReachability _0024UBA();

		public abstract InternetStatus _0024vBA();

		public bool _0024FE()
		{
			return false;
		}

		public abstract void _0024VBA(Action _1 = null);
	}
}
