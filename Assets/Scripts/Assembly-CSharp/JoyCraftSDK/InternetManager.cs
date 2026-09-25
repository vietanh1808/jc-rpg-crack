using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK
{
	public class InternetManager : AInternetManager
	{
		public static readonly bool _0024CG;

		private Action _0024dG;

		public override NetworkReachability _0024a => _0024UBA();

		public override InternetStatus _0024A => _0024vBA();

		public override NetworkReachability _0024UBA()
		{
			return NetworkReachability.NotReachable;
		}

		public override InternetStatus _0024vBA()
		{
			return InternetStatus.PendingCheck;
		}

		public override void _0024VBA(Action _1 = null)
		{
		}

		public override void Awake()
		{
		}

		protected override void _0024hbA()
		{
		}

		protected override void _0024HbA()
		{
		}

		private void _0024DE()
		{
		}

		private void _0024eE()
		{
		}

		private void _0024EE()
		{
		}

		private void _0024fE()
		{
		}
	}
}
