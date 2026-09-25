using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public abstract class ALevelData : JScriptableObject
	{
		public new abstract ReleaseDifficulty _0024a { get; }

		public new virtual bool _0024A => _0024HDA();

		public abstract ReleaseDifficulty _0024hDA();

		public virtual bool _0024HDA()
		{
			return false;
		}
	}
}
