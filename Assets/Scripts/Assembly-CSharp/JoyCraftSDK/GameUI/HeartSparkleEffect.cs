using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class HeartSparkleEffect : JMonoBehaviour
	{
		private sealed class _0024PD
		{
			public HeartSparkleEffect _0024Ro;

			public Image _0024so;

			internal void _0024wq()
			{
			}
		}

		[Tooltip("Tâm sinh hạt — RT của HeartPulse (ổn định hơn Big Heart vì Big Heart bị DOScale từ 0 lúc mở popup).")]
		[SerializeField]
		private RectTransform spawnCenter;

		[Tooltip("Image mẫu (để inactive trong prefab) — được clone thành pool hạt lúc runtime.")]
		[SerializeField]
		private Image sparkleTemplate;

		[Tooltip("Image của heart — hạt tự lấy màu chủ đạo từ sprite này (đổi ảnh heart sang màu khác thì hạt đổi theo, không cần chỉnh gì).")]
		[SerializeField]
		private Image heartImage;

		[Tooltip("Số hạt tồn tại đồng thời (pool cố định, không đẻ thêm lúc chạy).")]
		[SerializeField]
		private int sparkleCount;

		[Tooltip("Độ lệch random của ĐIỂM BẮN quanh tâm heart: x = ngang, y = dọc (px). 0 = mọi hạt bắn đúng từ tâm; để nhỏ (~20×15) cho cảm giác burst tụ tâm.")]
		[SerializeField]
		private Vector2 spawnRadius;

		[Tooltip("Quãng đường hạt BẮN RA từ tâm mỗi vòng đời, random trong [x..y] (px).")]
		[FormerlySerializedAs("riseDistanceRange")]
		[SerializeField]
		private Vector2 burstDistanceRange;

		[Tooltip("Thời gian sống 1 vòng đời của hạt, random trong [x..y] (giây). Ngắn = hạt gấp gáp, dài = trôi chậm.")]
		[SerializeField]
		private Vector2 durationRange;

		[Tooltip("Scale random của mỗi hạt trong [x..y] (1 = đúng size template).")]
		[SerializeField]
		private Vector2 scaleRange;

		[Tooltip("Delay random tối đa (giây) trước khi hạt bắt đầu vòng đời tiếp theo — tạo nhịp thưa/dày tự nhiên.")]
		[SerializeField]
		private float maxRespawnDelay;

		private readonly List<Image> _0024Po;

		private Color _0024qo;

		private Sprite _0024Qo;

		private Color _0024ro;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void _0024uq()
		{
		}

		private void _0024Uq()
		{
		}

		private Color _0024vq(Sprite _1)
		{
			return default;
		}

		private void _0024Vq(Image _1, float _1)
		{
		}
	}
}
