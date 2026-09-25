using System;
using System.Collections.Generic;
using _0024l;

namespace _0024j
{
	public readonly struct _0024zd
	{
		public readonly string _0024PL;

		public readonly int _0024qL;

		public _0024zd(string rewardID, int amount)
		{
			_0024PL = null;
			_0024qL = 0;
		}
	}
	public abstract class _0024Zd : _0024YD
	{
		public new abstract event Action<string> _0024a;

		public new abstract event Action<string> _0024A;

		public new abstract event Action<bool> _0024b;

		public new abstract event Action _0024B;

		public new abstract event Action _0024c;

		public abstract void _0024IFA(Action<string> _1);

		public abstract void _0024jFA(Action<string> _1);

		public abstract void _0024JFA(Action<string> _1);

		public abstract void _0024kFA(Action<string> _1);

		public abstract void _0024KFA(Action<bool> _1);

		public abstract void _0024lFA(Action<bool> _1);

		public abstract void _0024LFA(Action _1);

		public abstract void _0024mFA(Action _1);

		public abstract void _0024MFA(string _1);

		public abstract void _0024nFA(Action<bool> _1);

		public abstract bool _0024NFA(string _1);

		public abstract bool _0024oFA(string _1);

		public abstract bool _0024OFA(string _1);

		public abstract bool _0024pFA(string _1);

		public abstract bool _0024PFA(string _1);

		public abstract bool _0024qFA(string _1, out int _1);

		public abstract void _0024QFA(string _1, int _1);

		public abstract void _0024rFA();

		public abstract void _0024RFA(Action _1);

		public abstract void _0024sFA(Action _1);

		public abstract bool _0024SFA(string _1, out double _1, out string _1);

		public abstract bool _0024tFA(string _1, out string _1);

		public abstract string _0024TFA(string _1);

		public abstract bool _0024uFA(string _1, out IReadOnlyList<_0024zd> _1);

		public abstract IReadOnlyList<string> _0024UFA();

		public abstract void _0024vFA(string _1);
	}
}
