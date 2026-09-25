using System;
using System.Runtime.CompilerServices;
using System.Threading;
using _0024B;
using _0024G;
using _0024K;
using _0024N;
using _0024d;
using _0024f;
using _0024g;
using _0024h;
using _0024j;
using _0024k;
using _0024l;
using _0024p;
using EnhancedUI.EnhancedScroller;
using GenericEventBus;
using JoyCraftSDK.Game;
using JoyCraftSDK.GameUI;
using JoyCraftSDK.JInput;
using JoyCraftSDK.SaveSystem;
using UnityEngine;

namespace JoyCraftSDK.Utilities
{
	public abstract class JCellView : EnhancedScrollerCellView
	{
		private Transform _0024sp;

		[CompilerGenerated]
		private int _0024Sp;

		protected _0024iB _0024a => _0024rt();

		protected AAdNetworksManager _0024A => _0024Rt();

		protected _0024jB _0024b => _0024st();

		protected _0024TC _0024B => _0024gIA();

		protected _0024lB _0024c => _0024tt();

		protected _0024ze _0024C => _0024Tt();

		protected _0024FB _0024d => _0024ut();

		protected _0024ye _0024D => _0024Ut();

		protected _0024DE _0024e => _0024vt();

		protected AProjectInitManager _0024E => _0024Vt();

		protected _0024Le _0024f => _0024wt();

		protected APoolManager _0024F => _0024Wt();

		protected ATaskManager _0024g => _0024xt();

		protected _0024WB _0024G => _0024Xt();

		protected AInternetManager _0024h => _0024yt();

		protected AFrameRateManager _0024H => _0024Yt();

		protected ATimeManager _0024i => _0024zt();

		protected _0024eA _0024I => _0024Zt();

		protected _0024xD _0024j => _0024aT();

		protected _0024yD _0024J => _0024AT();

		protected AEventManager _0024k => _0024bT();

		protected GenericEventBus<_0024dB> _0024K => _0024BT();

		protected AAudioManager _0024l => _0024cT();

		protected AHapticManager _0024L => _0024CT();

		protected AGameDataManager _0024m => _0024dT();

		protected _0024Oc _0024M => _0024DT();

		protected _0024dd _0024n => _0024GIA();

		protected _0024zE _0024N => _0024hIA();

		protected _0024ZC _0024o => _0024fT();

		protected _0024DA _0024O => _0024FT();

		protected AGuiManager _0024p => _0024gT();

		protected _0024MD _0024P => _0024GT();

		protected ABackgroundUIManager _0024q => _0024hT();

		protected _0024nB _0024Q => _0024HT();

		protected _0024Xd _0024r => _0024iT();

		protected _0024hC _0024R => _0024IT();

		protected ATutorialController _0024s => _0024jT();

		protected _0024EB _0024S => _0024JT();

		protected _0024qc _0024t => _0024kT();

		protected _0024lc _0024T => _0024KT();

		protected _0024xc _0024u => _0024lT();

		protected _0024SC _0024U => _0024LT();

		protected _0024iA _0024v => _0024mT();

		protected AGameSceneManager _0024V => _0024MT();

		protected AJInputManager _0024W => _0024NT();

		protected _0024EA _0024x => _0024oT();

		protected bool _0024X => _0024OT();

		protected AGameConfig _0024y => _0024pT();

		protected SavedGameData _0024Y => _0024PT();

		protected SavedPlayerProgressData _0024z => _0024qT();

		protected string _0024Z => _0024QT();

		protected bool _0024AA => _0024RT();

		protected bool _0024bA => _0024sT();

		protected SerializedDateTime _0024BA => _0024ST();

		protected float _0024cA => _0024tT();

		protected float _0024CA => _0024TT();

		protected Camera _0024dA => _0024uT();

		protected Camera _0024DA => _0024UT();

		protected int _0024eA => _0024vT();

		protected int _0024EA => _0024VT();

		public Transform _0024fA => _0024wT();

		public int _0024FA
		{
			get
			{
				return _0024WT();
			}
			private set
			{
				_0024xT(value);
			}
		}

		protected CancellationToken _0024gA => _0024XT();

		protected virtual string _0024GA => _0024ThA();

		protected _0024iB _0024rt()
		{
			return null;
		}

		protected AAdNetworksManager _0024Rt()
		{
			return null;
		}

		protected _0024jB _0024st()
		{
			return null;
		}

		protected _0024TC _0024gIA()
		{
			return null;
		}

		protected _0024lB _0024tt()
		{
			return null;
		}

		protected _0024ze _0024Tt()
		{
			return null;
		}

		protected _0024FB _0024ut()
		{
			return null;
		}

		protected _0024ye _0024Ut()
		{
			return null;
		}

		protected _0024DE _0024vt()
		{
			return null;
		}

		protected AProjectInitManager _0024Vt()
		{
			return null;
		}

		protected _0024Le _0024wt()
		{
			return null;
		}

		protected APoolManager _0024Wt()
		{
			return null;
		}

		protected ATaskManager _0024xt()
		{
			return null;
		}

		protected _0024WB _0024Xt()
		{
			return null;
		}

		protected AInternetManager _0024yt()
		{
			return null;
		}

		protected AFrameRateManager _0024Yt()
		{
			return null;
		}

		protected ATimeManager _0024zt()
		{
			return null;
		}

		protected _0024eA _0024Zt()
		{
			return null;
		}

		protected _0024xD _0024aT()
		{
			return null;
		}

		protected _0024yD _0024AT()
		{
			return null;
		}

		protected AEventManager _0024bT()
		{
			return null;
		}

		protected GenericEventBus<_0024dB> _0024BT()
		{
			return null;
		}

		protected AAudioManager _0024cT()
		{
			return null;
		}

		protected AHapticManager _0024CT()
		{
			return null;
		}

		protected AGameDataManager _0024dT()
		{
			return null;
		}

		protected _0024Oc _0024DT()
		{
			return null;
		}

		protected _0024dd _0024GIA()
		{
			return null;
		}

		protected _0024zE _0024hIA()
		{
			return null;
		}

		protected _0024ZC _0024fT()
		{
			return null;
		}

		protected _0024DA _0024FT()
		{
			return null;
		}

		protected AGuiManager _0024gT()
		{
			return null;
		}

		protected _0024MD _0024GT()
		{
			return null;
		}

		protected ABackgroundUIManager _0024hT()
		{
			return null;
		}

		protected _0024nB _0024HT()
		{
			return null;
		}

		protected _0024Xd _0024iT()
		{
			return null;
		}

		protected _0024hC _0024IT()
		{
			return null;
		}

		protected ATutorialController _0024jT()
		{
			return null;
		}

		protected _0024EB _0024JT()
		{
			return null;
		}

		protected _0024qc _0024kT()
		{
			return null;
		}

		protected _0024lc _0024KT()
		{
			return null;
		}

		protected _0024xc _0024lT()
		{
			return null;
		}

		protected _0024SC _0024LT()
		{
			return null;
		}

		protected _0024iA _0024mT()
		{
			return null;
		}

		protected AGameSceneManager _0024MT()
		{
			return null;
		}

		protected AJInputManager _0024NT()
		{
			return null;
		}

		protected _0024EA _0024oT()
		{
			return null;
		}

		protected bool _0024OT()
		{
			return false;
		}

		protected AGameConfig _0024pT()
		{
			return null;
		}

		protected SavedGameData _0024PT()
		{
			return null;
		}

		protected SavedPlayerProgressData _0024qT()
		{
			return null;
		}

		protected string _0024QT()
		{
			return null;
		}

		protected bool _0024RT()
		{
			return false;
		}

		protected bool _0024sT()
		{
			return false;
		}

		protected SerializedDateTime _0024ST()
		{
			return null;
		}

		protected float _0024tT()
		{
			return 0f;
		}

		protected float _0024TT()
		{
			return 0f;
		}

		protected Camera _0024uT()
		{
			return null;
		}

		protected Camera _0024UT()
		{
			return null;
		}

		protected int _0024vT()
		{
			return 0;
		}

		protected int _0024VT()
		{
			return 0;
		}

		public Transform _0024wT()
		{
			return null;
		}

		public int _0024WT()
		{
			return 0;
		}

		private void _0024xT(int _1)
		{
		}

		protected CancellationToken _0024XT()
		{
			return default;
		}

		public virtual void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void OnApplicationFocus(bool hasFocus)
		{
		}

		protected virtual void OnApplicationPause(bool pauseStatus)
		{
		}

		protected virtual void OnApplicationQuit()
		{
		}

		protected virtual void _0024ShA()
		{
		}

		protected virtual void _0024thA()
		{
		}

		protected void _0024yT(float _1, Action _1)
		{
		}

		protected void _0024YT(float _1, Action _1)
		{
		}

		protected AUIConfig _0024zT()
		{
			return null;
		}

		protected virtual string _0024ThA()
		{
			return null;
		}

		protected virtual bool _0024uhA()
		{
			return false;
		}

		protected void _0024ZT(string _1)
		{
		}

		protected void _0024au(string _1)
		{
		}

		protected void _0024Au(string _1)
		{
		}
	}
}
