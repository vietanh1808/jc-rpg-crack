using System;
using System.Collections.Generic;
using _0024h;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedSettingData : JSaveData
	{
		[SerializeField]
		private bool enablePn;

		[SerializeField]
		private bool requestedPn;

		[SerializeField]
		private bool iosTrackingRequested;

		[SerializeField]
		private float bgmVolume;

		[SerializeField]
		private float sfxVolume;

		[SerializeField]
		private bool enableMusic;

		[SerializeField]
		private bool enableSfx;

		[SerializeField]
		private bool enableHaptic;

		[SerializeField]
		private bool highPerformance;

		public bool EnablePn
		{
			get
			{
				return _0024lJ();
			}
			set
			{
				_0024LJ(value);
			}
		}

		public bool RequestedPn
		{
			get
			{
				return _0024mJ();
			}
			set
			{
				_0024MJ(value);
			}
		}

		public bool EnableHaptic
		{
			get
			{
				return _0024nJ();
			}
			set
			{
				_0024NJ(value);
			}
		}

		public float BgmVolume
		{
			get
			{
				return _0024oJ();
			}
			set
			{
				_0024OJ(value);
			}
		}

		public float SfxVolume
		{
			get
			{
				return _0024pJ();
			}
			set
			{
				_0024PJ(value);
			}
		}

		public bool EnableMusic
		{
			get
			{
				return _0024qJ();
			}
			set
			{
				_0024QJ(value);
			}
		}

		public bool EnableSfx
		{
			get
			{
				return _0024rJ();
			}
			set
			{
				_0024RJ(value);
			}
		}

		public bool HighPerformance
		{
			get
			{
				return _0024tJ();
			}
			set
			{
				_0024TJ(value);
			}
		}

		public bool IosTrackingRequested
		{
			get
			{
				return _0024uJ();
			}
			set
			{
				_0024UJ(value);
			}
		}

		public bool _0024lJ()
		{
			return false;
		}

		public void _0024LJ(bool _1)
		{
		}

		public bool _0024mJ()
		{
			return false;
		}

		public void _0024MJ(bool _1)
		{
		}

		public bool _0024nJ()
		{
			return false;
		}

		public void _0024NJ(bool _1)
		{
		}

		public float _0024oJ()
		{
			return 0f;
		}

		public void _0024OJ(float _1)
		{
		}

		public float _0024pJ()
		{
			return 0f;
		}

		public void _0024PJ(float _1)
		{
		}

		public bool _0024qJ()
		{
			return false;
		}

		public void _0024QJ(bool _1)
		{
		}

		public bool _0024rJ()
		{
			return false;
		}

		public void _0024RJ(bool _1)
		{
		}

		public bool _0024tJ()
		{
			return false;
		}

		public void _0024TJ(bool _1)
		{
		}

		public bool _0024uJ()
		{
			return false;
		}

		public void _0024UJ(bool _1)
		{
		}

		public override int _0024SEA()
		{
			return 0;
		}

		public override List<_0024Gd> _0024tEA()
		{
			return null;
		}
	}
}
