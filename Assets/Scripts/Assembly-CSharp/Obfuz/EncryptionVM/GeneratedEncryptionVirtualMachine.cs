using _0024o;

namespace Obfuz.EncryptionVM
{
	public class GeneratedEncryptionVirtualMachine : _0024IE
	{
		private const int kOpCodeBits = 8;

		private const int kOpCodeCount = 256;

		private const int kOpCodeMask = 255;

		private readonly int[] _secretKey;

		public override int OpCodeCount => 0;

		public GeneratedEncryptionVirtualMachine(byte[] secretKey)
		{
		}

		public override int Encrypt(int value, int opts, int salt)
		{
			return 0;
		}

		public override int Decrypt(int value, int opts, int salt)
		{
			return 0;
		}

		private int ExecuteEncrypt(int value, int opCode, int salt)
		{
			return 0;
		}

		private int ExecuteDecrypt(int value, int opCode, int salt)
		{
			return 0;
		}
	}
}
