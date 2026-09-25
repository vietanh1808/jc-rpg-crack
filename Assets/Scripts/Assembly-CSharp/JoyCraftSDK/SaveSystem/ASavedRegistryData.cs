using System;
using System.Collections.Generic;
using _0024h;
using _0024l;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public abstract class ASavedRegistryData<TEntry> : JSaveData where TEntry : _0024YD
	{
		[SerializeField]
		private List<TEntry> entries;

		protected new IReadOnlyList<TEntry> _0024a => _0024bQ();

		protected abstract string _0024vJA(TEntry _1);

		protected IReadOnlyList<TEntry> _0024bQ()
		{
			return null;
		}

		protected TEntry _0024BQ(string _1)
		{
			return null;
		}

		protected TEntry _0024cQ(string _1, string _1, Func<TEntry> _1)
		{
			return null;
		}

		protected bool _0024CQ(string _1, string _1)
		{
			return false;
		}

		public override List<_0024Gd> _0024tEA()
		{
			return null;
		}
	}
}
