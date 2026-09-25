using JoyCraftSDK.DOTS.Bridge;
using Unity.Entities;
using Unity.Entities.Serialization;
using UnityEngine;

namespace BucketKnight.Sandbox
{
	public class RukhankaAnimTestDriver : MonoBehaviour
	{
		[Header("Entity scene chứa nhân vật cần test")]
		[Tooltip("Trỏ tới AnimTest_Rukhanka_SubScene. Đổi model/animation thì sửa trong scene đó.")]
		[SerializeField]
		private EntitySceneReference _animTestScene;

		[Header("Chẩn đoán")]
		[Tooltip("Bật = log số rig Rukhanka bake được sau khi entity scene nạp xong.")]
		[SerializeField]
		private bool _logDiagnostics;

		private EcsWorldHost _0024M;

		private Entity _0024X;

		private bool _0024AA;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void _0024Qc()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
