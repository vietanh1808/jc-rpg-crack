using System;
using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.Build
{
	[Serializable]
	[CreateAssetMenu(fileName = "ReleaseChecklistConfig", menuName = "JoyCraft/J Build Tool/Release Checklist Config")]
	public class ReleaseChecklistConfig : AReleaseChecklistConfig
	{
		[Header("Versioning")]
		[Tooltip("Bundle version code của lần release gần nhất. Build mới phải lớn hơn số này.")]
		[SerializeField]
		private int lastReleasedBundleVersionCode;

		[Tooltip("Build number (CFBundleVersion) của lần release iOS gần nhất.")]
		[SerializeField]
		private int iosBuildNumber;

		[Header("Firebase")]
		[Tooltip("Firebase App ID (Android) cho crashlytics:symbols:upload. VD: 1:123:android:abc.")]
		[SerializeField]
		private string firebaseAndroidAppId;

		[Tooltip("Đường (relative repo-root) tới ledger symbol-upload git-tracked. Rỗng = mặc định Docs/Game/Release/symbol-upload-log.txt.")]
		[SerializeField]
		private string symbolUploadLogPath;

		[Header("After-Build Reminders (log đỏ sau khi build xong)")]
		[SerializeField]
		private List<AfterBuildReminder> afterBuildReminders;

		public override int LastReleasedBundleVersionCode
		{
			get
			{
				return _0024piA();
			}
			set
			{
				_0024PiA(value);
			}
		}

		public override int IosBuildNumber
		{
			get
			{
				return _0024qiA();
			}
			set
			{
				_0024QiA(value);
			}
		}

		public override string FirebaseAndroidAppId => _0024riA();

		public override string SymbolUploadLogPath => _0024RiA();

		public override List<AfterBuildReminder> AfterBuildReminders => _0024siA();

		public override int _0024piA()
		{
			return 0;
		}

		public override void _0024PiA(int _1)
		{
		}

		public override int _0024qiA()
		{
			return 0;
		}

		public override void _0024QiA(int _1)
		{
		}

		public override string _0024riA()
		{
			return null;
		}

		public override string _0024RiA()
		{
			return null;
		}

		public override List<AfterBuildReminder> _0024siA()
		{
			return null;
		}
	}
}
