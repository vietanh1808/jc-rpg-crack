using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace _0024A
{
	internal static class _0024o
	{
		private sealed class _0024O
		{
			[CompilerGenerated]
			private int _0024Qb;

			[CompilerGenerated]
			private List<_0024i> _0024rb;

			[JsonProperty("v", Order = 0)]
			public int _0024a
			{
				get
				{
					return _0024lB();
				}
				set
				{
					_0024LB(value);
				}
			}

			[JsonProperty("items", Order = 1)]
			public List<_0024i> _0024A
			{
				get
				{
					return _0024mB();
				}
				set
				{
					_0024MB(value);
				}
			}

			public int _0024lB()
			{
				return 0;
			}

			public void _0024LB(int _1)
			{
			}

			public List<_0024i> _0024mB()
			{
				return null;
			}

			public void _0024MB(List<_0024i> _1)
			{
			}
		}

		private static readonly JsonSerializerSettings _0024qb;

		internal static string _0024kB(IReadOnlyList<_0024i> _1, int _1)
		{
			return null;
		}

		internal static List<_0024i> _0024KB(string _1, int _1)
		{
			return null;
		}
	}
}
