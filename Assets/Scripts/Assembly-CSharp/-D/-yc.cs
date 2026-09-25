using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JoyCraftSDK;
using JoyCraftSDK.Game;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace _0024d
{
	public interface _0024yc
	{
		UniTask<ALevelData> _0024JDA(int _1);

		ReleaseDifficulty _0024jDA(int _1);
	}
	public class _0024Yc : _0024xc
	{
		private sealed class _0024zc
		{
			public _0024Yc _0024hI;

			public int _0024HI;

			public LevelPlayType _0024iI;

			internal void _0024iG()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024Zc : IAsyncStateMachine
		{
			public int _0024II;

			public AsyncUniTaskVoidMethodBuilder _0024jI;

			public _0024Yc _0024JI;

			public int _0024kI;

			public LevelPlayType _0024KI;

			private UniTask<ALevelData>.Awaiter _0024lI;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024GkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $GkA
				this._0024GkA(_1);
			}
		}

		private bool _0024dI;

		private bool _0024DI;

		private bool _0024eI;

		private ALevelDatabase _0024EI;

		private bool _0024fI;

		private Transform _0024FI;

		[CompilerGenerated]
		private ALevelData _0024gI;

		[CompilerGenerated]
		private readonly ColorDefinitionSO _0024GI;

		private new int _0024a
		{
			get
			{
				return _0024Yg();
			}
			set
			{
				_0024zg(value);
			}
		}

		private new float _0024A
		{
			get
			{
				return _0024Zg();
			}
			set
			{
				_0024aG(value);
			}
		}

		protected override ALevelDatabase _0024b
		{
			get
			{
				return _0024ZdA();
			}
			set
			{
				_0024aDA(value);
			}
		}

		public new bool _0024B => _0024AG();

		public override ALevelData _0024c
		{
			get
			{
				return _0024ADA();
			}
			protected set
			{
				_0024bDA(value);
			}
		}

		protected override ColorDefinitionSO _0024C
		{
			public get
			{
				return _0024BDA();
			}
		}

		private int _0024Yg()
		{
			return 0;
		}

		private void _0024zg(int _1)
		{
		}

		private float _0024Zg()
		{
			return 0f;
		}

		private void _0024aG(float _1)
		{
		}

		protected override ALevelDatabase _0024ZdA()
		{
			return null;
		}

		protected override void _0024aDA(ALevelDatabase _1)
		{
		}

		public bool _0024AG()
		{
			return false;
		}

		public override ALevelData _0024ADA()
		{
			return null;
		}

		protected override void _0024bDA(ALevelData _1)
		{
		}

		public override ColorDefinitionSO _0024BDA()
		{
			return null;
		}

		public override int _0024cDA()
		{
			return 0;
		}

		public override int _0024CDA()
		{
			return 0;
		}

		public override bool _0024dDA()
		{
			return false;
		}

		public override bool _0024DDA()
		{
			return false;
		}

		public override bool _0024eDA()
		{
			return false;
		}

		public override ReleaseDifficulty _0024EDA(int _1 = -1)
		{
			return (ReleaseDifficulty)0;
		}

		public override void _0024fDA(LevelPlayType _1)
		{
		}

		public override void _0024FDA(int _1)
		{
		}

		public override void _0024gDA()
		{
		}

		public override void _0024GDA(bool _1)
		{
		}

		public void _0024bG(LevelPlayType _1)
		{
		}

		public ALevelData _0024BG(int _1)
		{
			return null;
		}

		public void _0024cG(int _1)
		{
		}

		public void _0024CG()
		{
		}

		private void _0024dG()
		{
		}

		private void _0024DG()
		{
		}

		private int _0024eG(int _1 = 1)
		{
			return 0;
		}

		private void _0024EG(int _1, LevelPlayType _1)
		{
		}

		[AsyncStateMachine(typeof(_0024Zc))]
		private UniTaskVoid _0024fG(int _1, LevelPlayType _1)
		{
			return default;
		}

		private Transform _0024FG()
		{
			return null;
		}

		private void _0024gG()
		{
		}

		private void _0024GG(LevelPlayType _1)
		{
		}

		private void _0024hG(ref AEventManager._0024Wb _1)
		{
		}

		private void _0024HG(ref AEventManager._0024UA _1)
		{
		}

		protected virtual void _0024KDA(LevelFinishReason _1)
		{
		}

		protected virtual int _0024lDA()
		{
			return 0;
		}

		protected virtual void _0024LDA(int _1)
		{
		}

		protected virtual void _0024mDA()
		{
		}

		public override void _0024zdA()
		{
		}
	}
}
