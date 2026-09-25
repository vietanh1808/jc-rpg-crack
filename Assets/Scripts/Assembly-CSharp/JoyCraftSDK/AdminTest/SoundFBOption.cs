using JoyCraftSDK.Utilities;
using MoreMountains.Feedbacks;
using UnityEngine;

namespace JoyCraftSDK.AdminTest
{
	public class SoundFBOption : ASoundFBOption
	{
		[SerializeField]
		private SoundType type;

		[SerializeField]
		private MMF_Player mmfPlayer;

		private AudioClip _0024Lp;

		private new MMF_MMSoundManagerSound _0024a => _0024Vr();

		private MMF_MMSoundManagerSound _0024Vr()
		{
			return null;
		}

		private void _0024wr(SoundType _1, AudioClip _1)
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void _0024hbA()
		{
		}

		protected override void _0024HbA()
		{
		}

		private void OnValidate()
		{
		}
	}
}
