using System.Runtime.CompilerServices;
using _0024l;
using JoyCraftSDK.AdminTest;
using JoyCraftSDK.GameUI;
using JoyCraftSDK.RemoteConfig;
using JoyCraftSDK.Utilities;

namespace _0024k
{
	public class _0024wD : _0024YD
	{
		public static WinScreenKind _0024Ur(int _1, WinFlowConfig _1)
		{
			return WinScreenKind.AutoAdvance;
		}
	}
}
namespace _0024K
{
	public class _0024WD : _0024xD
	{
		private DevToolsData _0024ip;

		[CompilerGenerated]
		private bool _0024Ip;

		public override bool _0024a
		{
			get
			{
				return _0024LhA();
			}
			set
			{
				_0024mhA(value);
			}
		}

		public override DevToolsData _0024A
		{
			get
			{
				return _0024MhA();
			}
			protected set
			{
				_0024nhA(value);
			}
		}

		public override bool _0024LhA()
		{
			return false;
		}

		public override void _0024mhA(bool _1)
		{
		}

		public override DevToolsData _0024MhA()
		{
			return null;
		}

		protected override void _0024nhA(DevToolsData _1)
		{
		}

		public override void _0024NhA(BackgroundMode _1)
		{
		}
	}
}
