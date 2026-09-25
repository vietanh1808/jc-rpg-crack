using System;
using System.Collections.Generic;
using System.Threading;
using _0024A;
using _0024N;
using JTD;

namespace _0024a
{
	public interface _0024b
	{
		CancellationToken _0024a { get; }

		event Action<bool> _0024A;

		event Action _0024b;

		CancellationToken _0024PAA();

		void _0024qAA(Action<bool> _1);

		void _0024QAA(Action<bool> _1);

		void _0024rAA(Action _1);

		void _0024RAA(Action _1);
	}
	public sealed class _0024B : _0024a
	{
		private readonly JTDSettings m__0024B;

		private readonly _0024b m__0024c;

		private _0024g m__0024C;

		private _0024D m__0024d;

		private readonly global::_0024A._0024q m__0024D;

		private bool _0024e;

		private IReadOnlyDictionary<string, string> _0024E;

		public override string _0024a => _0024jAA();

		public new string _0024A => _0024d();

		public override string _0024jAA()
		{
			return null;
		}

		public _0024B(JTDSettings settings, _0024b host)
		{
		}

		public override void _0024kAA(Action _1 = null)
		{
		}

		public new void _0024b()
		{
		}

		protected override void _0024LAA(_0024cE _1)
		{
		}

		private void _0024B(_0024F _1, long _1)
		{
		}

		public void _0024c()
		{
		}

		private void _0024C(global::_0024A._0024q._0024Q _1)
		{
		}

		public override void _0024KAA(string _1)
		{
		}

		public string _0024d()
		{
			return null;
		}

		public void _0024D(IDictionary<string, string> _1)
		{
		}
	}
}
