using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Analytics
{
	[CreateAssetMenu(fileName = "DatabucketsSettings", menuName = "Databuckets/Settings", order = 0)]
	public sealed class DatabucketsSettings : JScriptableObject
	{
		[Header("Ingest (Databuckets cấp — điền sau)")]
		[Tooltip("API endpoint Databuckets cấp cho JoyCraft. Trống → SDK KHÔNG init (no-op).")]
		[SerializeField]
		private string endpoint;

		[Header("API Keys (public-by-design — như JTD)")]
		[Tooltip("Test key: dataset test/chung. Editor luôn dùng key này.")]
		[SerializeField]
		private string testApiKey;

		[Tooltip("Prod key: dataset thật. Chỉ dùng trên device build khi forceTestKeyOnDevice=false.")]
		[SerializeField]
		private string prodApiKey;

		[Tooltip("CHỈ tác động device build (Editor luôn dùng test key). ON = APK dùng TEST key (QA smoke). Nhớ TẮT trước store release.")]
		[SerializeField]
		private bool forceTestKeyOnDevice;

		[Header("Debug")]
		[Tooltip("Bật log chi tiết init/record ra Console (Editor) / logcat (device).")]
		[SerializeField]
		private bool verbose;

		public new bool _0024a => _0024CY();

		public new string _0024A => _0024dY();

		public new bool _0024b => _0024DY();

		public new string _0024B => _0024eY();

		public new bool _0024c => _0024EY();

		public new bool _0024C => _0024fY();

		public bool _0024CY()
		{
			return false;
		}

		public string _0024dY()
		{
			return null;
		}

		public bool _0024DY()
		{
			return false;
		}

		public string _0024eY()
		{
			return null;
		}

		public bool _0024EY()
		{
			return false;
		}

		public bool _0024fY()
		{
			return false;
		}

		public static DatabucketsSettings _0024FY()
		{
			return null;
		}

		public bool _0024gY()
		{
			return false;
		}
	}
}
