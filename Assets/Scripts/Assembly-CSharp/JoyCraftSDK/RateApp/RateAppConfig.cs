using UnityEngine;

namespace JoyCraftSDK.RateApp
{
	[CreateAssetMenu(fileName = "RateAppConfig", menuName = "GameSDK/RateAppConfig")]
	public class RateAppConfig : ARateAppConfig
	{
		[Tooltip("Ràng buộc cho lần hỏi ĐẦU TIÊN (promptCount == 0).")]
		[SerializeField]
		private RatePromptConstraint initialConstraint;

		[Tooltip("Ràng buộc cho lần hỏi kế (đã từng hỏi + app lên version mới).")]
		[SerializeField]
		private RatePromptConstraint repeatConstraint;

		[Tooltip("Để TRỐNG = zero-config (StoreLinkResolver tự suy từ Application.identifier). Chỉ điền khi bundleId khác store listing id.")]
		[SerializeField]
		private string storeIdOverride;

		public override RatePromptConstraint _0024a => _0024OfA();

		public override RatePromptConstraint _0024A => _0024pfA();

		public override string _0024b => _0024PfA();

		public override RatePromptConstraint _0024OfA()
		{
			return null;
		}

		public override RatePromptConstraint _0024pfA()
		{
			return null;
		}

		public override string _0024PfA()
		{
			return null;
		}
	}
}
