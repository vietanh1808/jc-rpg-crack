namespace JoyCraftSDK.Utilities
{
	public class Singleton<T> : JMonoBehaviour where T : JMonoBehaviour
	{
		private static T _0024cr;

		private static readonly object _0024Cr;

		protected static bool _0024dr;

		public new static T _0024a => _0024gX();

		public static T _0024gX()
		{
			return null;
		}

		public override void Awake()
		{
		}

		public new virtual void OnApplicationQuit()
		{
		}
	}
}
