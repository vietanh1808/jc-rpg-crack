using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using _0024l;
using JoyCraftSDK.RemoteConfig;

namespace _0024B
{
	public abstract class _0024lB : _0024YD
	{
		[CompilerGenerated]
		private List<LevelOrderConfig> _0024zF;

		[CompilerGenerated]
		private List<EconomyData> _0024ZF;

		[CompilerGenerated]
		private WinFlowConfig _0024ag;

		[CompilerGenerated]
		private LiveEventRemoteConfig _0024Ag;

		[CompilerGenerated]
		private string _0024bg;

		public new List<LevelOrderConfig> _0024a
		{
			get
			{
				return _0024Ie();
			}
			protected set
			{
				_0024je(value);
			}
		}

		public new List<EconomyData> _0024A
		{
			get
			{
				return _0024Je();
			}
			protected set
			{
				_0024ke(value);
			}
		}

		public new WinFlowConfig _0024b
		{
			get
			{
				return _0024Ke();
			}
			protected set
			{
				_0024le(value);
			}
		}

		public new LiveEventRemoteConfig _0024B
		{
			get
			{
				return _0024Le();
			}
			protected set
			{
				_0024me(value);
			}
		}

		public new string _0024c
		{
			get
			{
				return _0024Me();
			}
			protected set
			{
				_0024ne(value);
			}
		}

		public List<LevelOrderConfig> _0024Ie()
		{
			return null;
		}

		protected void _0024je(List<LevelOrderConfig> _1)
		{
		}

		public List<EconomyData> _0024Je()
		{
			return null;
		}

		protected void _0024ke(List<EconomyData> _1)
		{
		}

		public WinFlowConfig _0024Ke()
		{
			return null;
		}

		protected void _0024le(WinFlowConfig _1)
		{
		}

		public LiveEventRemoteConfig _0024Le()
		{
			return null;
		}

		protected void _0024me(LiveEventRemoteConfig _1)
		{
		}

		public string _0024Me()
		{
			return null;
		}

		protected void _0024ne(string _1)
		{
		}

		public abstract void _0024xbA(Action _1 = null);

		public bool _0024Ne()
		{
			return false;
		}
	}
	public abstract class _0024LB : _0024YD
	{
		public abstract void _0024XbA();
	}
}
