using _0024l;
using Cysharp.Threading.Tasks;
using JoyCraftSDK.CloudSave;

namespace _0024P
{
	public class _0024df : _0024YD
	{
		public CloudPullStatus _0024up;

		public CloudSaveEnvelope _0024Up;

		public _0024df(CloudPullStatus status, CloudSaveEnvelope envelope = null)
		{
		}
	}
	public abstract class _0024Df : _0024YD
	{
		public new abstract bool _0024a { get; }

		public static bool _0024lY(string _1)
		{
			return false;
		}

		public abstract bool _0024xJA();

		public abstract UniTask<_0024df> _0024XJA();

		public abstract UniTask<CloudPushResult> _0024yJA(CloudSaveEnvelope _1);
	}
}
