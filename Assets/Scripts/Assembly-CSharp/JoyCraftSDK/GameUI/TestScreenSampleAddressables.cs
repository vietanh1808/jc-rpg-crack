using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class TestScreenSampleAddressables : JUIPanel
	{
		[StructLayout((LayoutKind)3)]
		private struct _0024CD : IAsyncStateMachine
		{
			public int _0024bm;

			public AsyncVoidMethodBuilder _0024Bm;

			public TestScreenSampleAddressables _0024cm;

			private UniTask<TextAsset>.Awaiter _0024Cm;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024ZkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $ZkA
				this._0024ZkA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024dD : IAsyncStateMachine
		{
			public int _0024dm;

			public AsyncVoidMethodBuilder _0024Dm;

			public TestScreenSampleAddressables _0024em;

			private UniTask<Sprite>.Awaiter _0024Em;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024aKA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $aKA
				this._0024aKA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024DD : IAsyncStateMachine
		{
			public int _0024fm;

			public AsyncVoidMethodBuilder _0024Fm;

			public TestScreenSampleAddressables _0024gm;

			private UniTask<AudioClip>.Awaiter _0024Gm;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024AKA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $AKA
				this._0024AKA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024eD : IAsyncStateMachine
		{
			public int _0024hm;

			public AsyncVoidMethodBuilder _0024Hm;

			public TestScreenSampleAddressables _0024im;

			private UniTask<TextAsset>.Awaiter _0024Im;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024bKA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $bKA
				this._0024bKA(_1);
			}
		}

		[SerializeField]
		private AssetReference duckImage;

		[SerializeField]
		private AssetReference textFile;

		[SerializeField]
		private AssetReference largeFile;

		[SerializeField]
		private AssetReference music;

		[SerializeField]
		private AudioSource audioManager;

		[SerializeField]
		private ABtnEvents loadDuckBtn;

		[SerializeField]
		private ABtnEvents loadOggBtn;

		[SerializeField]
		private ABtnEvents loadSampleTextBtn;

		[SerializeField]
		private ABtnEvents load50mbTextBTn;

		[SerializeField]
		private ABtnEvents unloadDuckBtn;

		[SerializeField]
		private ABtnEvents unloadOggBtn;

		[SerializeField]
		private ABtnEvents unloadSampleTextBtn;

		[SerializeField]
		private ABtnEvents unload50mbTextBTn;

		[SerializeField]
		private Image duckImageSprite;

		[AsyncStateMachine(typeof(_0024dD))]
		private void _0024Pm()
		{
		}

		private void _0024qm()
		{
		}

		[AsyncStateMachine(typeof(_0024DD))]
		private void _0024Qm()
		{
		}

		private void _0024rm()
		{
		}

		[AsyncStateMachine(typeof(_0024eD))]
		private void _0024Rm()
		{
		}

		private void _0024sm()
		{
		}

		[AsyncStateMachine(typeof(_0024CD))]
		private void _0024Sm()
		{
		}

		private void _0024tm()
		{
		}

		protected override void _0024hbA()
		{
		}

		protected override void _0024HbA()
		{
		}

		public override UIPanelID _0024dgA()
		{
			return UIPanelID.None;
		}
	}
}
