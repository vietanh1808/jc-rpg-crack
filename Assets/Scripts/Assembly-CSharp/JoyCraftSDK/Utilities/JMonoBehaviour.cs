using System;
using System.Runtime.CompilerServices;
using System.Threading;
using _0024B;
using _0024D;
using _0024G;
using _0024I;
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
using GenericEventBus;
using JoyCraftSDK.DOTS.Bridge;
using JoyCraftSDK.Game;
using JoyCraftSDK.GameUI;
using JoyCraftSDK.JInput;
using JoyCraftSDK.SaveSystem;
using UnityEngine;

namespace JoyCraftSDK.Utilities
{
	public class JMonoBehaviour : MonoBehaviour
	{
		private sealed class _0024qd
		{
			public JMonoBehaviour _0024HS;

			public bool _0024iS;

			internal void _0024Kw()
			{
			}
		}

		private Transform _0024qp;

		[CompilerGenerated]
		private int _0024Qp;

		protected _0024iB _0024a => _0024fs();

		protected _0024FB _0024A => _0024Fs();

		protected AAdNetworksManager _0024b => _0024gs();

		protected _0024jB _0024B => _0024Gs();

		protected _0024TC _0024c => _0024dIA();

		protected _0024lB _0024C => _0024Hs();

		protected _0024ze _0024d => _0024is();

		protected _0024ye _0024D => _0024Is();

		protected _0024DE _0024e => _0024js();

		protected AProjectInitManager _0024E => _0024Js();

		protected _0024Le _0024f => _0024ks();

		protected APoolManager _0024F => _0024Ks();

		protected ATaskManager _0024g => _0024ls();

		protected _0024WB _0024G => _0024Ls();

		protected AInternetManager _0024h => _0024ms();

		protected AFrameRateManager _0024H => _0024Ms();

		protected ATimeManager _0024i => _0024ns();

		protected _0024eA _0024I => _0024Ns();

		protected _0024xD _0024j => _0024os();

		protected _0024yD _0024J => _0024Os();

		protected _0024vd _0024k => _0024ps();

		protected AEventManager _0024K => _0024Ps();

		protected GenericEventBus<_0024dB> _0024l => _0024qs();

		protected AAudioManager _0024L => _0024Qs();

		protected AHapticManager _0024m => _0024rs();

		protected AGameDataManager _0024M => _0024Rs();

		protected _0024Oc _0024n => _0024ss();

		protected _0024dd _0024N => _0024DIA();

		protected _0024zE _0024o => _0024eIA();

		protected _0024ZC _0024O => _0024Ts();

		protected _0024DA _0024p => _0024us();

		protected AGuiManager _0024P => _0024Us();

		protected _0024MD _0024q => _0024vs();

		protected ABackgroundUIManager _0024Q => _0024Vs();

		protected _0024nB _0024r => _0024ws();

		protected _0024sD _0024R => _0024Ws();

		protected _0024Xd _0024s => _0024xs();

		protected _0024Yd _0024S => _0024Xs();

		protected _0024Zd _0024t => _0024ys();

		protected _0024hC _0024T => _0024Ys();

		protected _0024DC _0024u => _0024zs();

		protected ATutorialController _0024U => _0024Zs();

		protected _0024EB _0024v => _0024aS();

		protected _0024qc _0024V => _0024AS();

		protected _0024lc _0024w => _0024bS();

		protected _0024xc _0024W => _0024BS();

		protected _0024SC _0024x => _0024cS();

		protected _0024iA _0024X => _0024CS();

		protected _0024hA _0024y => _0024dS();

		protected AGameSceneManager _0024Y => _0024DS();

		protected AEcsWorldBridge _0024z => _0024Jw();

		protected _0024qB _0024dA => _0024bHA();

		protected AJInputManager _0024Z => _0024ES();

		protected _0024EA _0024aA => _0024fS();

		protected bool _0024AA => _0024FS();

		protected AGameConfig _0024bA => _0024gS();

		protected SavedGameData _0024BA => _0024GS();

		protected SavedPlayerProgressData _0024cA => _0024hS();

		protected string _0024CA => _0024HS();

		protected bool _0024DA => _0024IS();

		protected bool _0024eA => _0024jS();

		protected SerializedDateTime _0024EA => _0024JS();

		protected float _0024fA => _0024kS();

		protected float _0024FA => _0024KS();

		protected Camera _0024gA => _0024lS();

		protected Camera _0024GA => _0024LS();

		protected int _0024hA => _0024mS();

		protected int _0024HA => _0024MS();

		public Transform _0024iA => _0024nS();

		public Vector3 _0024IA => _0024NS();

		public int _0024jA
		{
			get
			{
				return _0024oS();
			}
			private set
			{
				_0024OS(value);
			}
		}

		protected CancellationToken _0024JA => _0024pS();

		protected virtual string _0024kA => _0024aEA();

		protected _0024iB _0024fs()
		{
			return null;
		}

		protected _0024FB _0024Fs()
		{
			return null;
		}

		protected AAdNetworksManager _0024gs()
		{
			return null;
		}

		protected _0024jB _0024Gs()
		{
			return null;
		}

		protected _0024TC _0024dIA()
		{
			return null;
		}

		protected _0024lB _0024Hs()
		{
			return null;
		}

		protected _0024ze _0024is()
		{
			return null;
		}

		protected _0024ye _0024Is()
		{
			return null;
		}

		protected _0024DE _0024js()
		{
			return null;
		}

		protected AProjectInitManager _0024Js()
		{
			return null;
		}

		protected _0024Le _0024ks()
		{
			return null;
		}

		protected APoolManager _0024Ks()
		{
			return null;
		}

		protected ATaskManager _0024ls()
		{
			return null;
		}

		protected _0024WB _0024Ls()
		{
			return null;
		}

		protected AInternetManager _0024ms()
		{
			return null;
		}

		protected AFrameRateManager _0024Ms()
		{
			return null;
		}

		protected ATimeManager _0024ns()
		{
			return null;
		}

		protected _0024eA _0024Ns()
		{
			return null;
		}

		protected _0024xD _0024os()
		{
			return null;
		}

		protected _0024yD _0024Os()
		{
			return null;
		}

		protected _0024vd _0024ps()
		{
			return null;
		}

		protected AEventManager _0024Ps()
		{
			return null;
		}

		protected GenericEventBus<_0024dB> _0024qs()
		{
			return null;
		}

		protected AAudioManager _0024Qs()
		{
			return null;
		}

		protected AHapticManager _0024rs()
		{
			return null;
		}

		protected AGameDataManager _0024Rs()
		{
			return null;
		}

		protected _0024Oc _0024ss()
		{
			return null;
		}

		protected _0024dd _0024DIA()
		{
			return null;
		}

		protected _0024zE _0024eIA()
		{
			return null;
		}

		protected _0024ZC _0024Ts()
		{
			return null;
		}

		protected _0024DA _0024us()
		{
			return null;
		}

		protected AGuiManager _0024Us()
		{
			return null;
		}

		protected _0024MD _0024vs()
		{
			return null;
		}

		protected ABackgroundUIManager _0024Vs()
		{
			return null;
		}

		protected _0024nB _0024ws()
		{
			return null;
		}

		protected _0024sD _0024Ws()
		{
			return null;
		}

		protected _0024Xd _0024xs()
		{
			return null;
		}

		protected _0024Yd _0024Xs()
		{
			return null;
		}

		protected _0024Zd _0024ys()
		{
			return null;
		}

		protected _0024hC _0024Ys()
		{
			return null;
		}

		protected _0024DC _0024zs()
		{
			return null;
		}

		protected ATutorialController _0024Zs()
		{
			return null;
		}

		protected _0024EB _0024aS()
		{
			return null;
		}

		protected _0024qc _0024AS()
		{
			return null;
		}

		protected _0024lc _0024bS()
		{
			return null;
		}

		protected _0024xc _0024BS()
		{
			return null;
		}

		protected _0024SC _0024cS()
		{
			return null;
		}

		protected _0024iA _0024CS()
		{
			return null;
		}

		protected _0024hA _0024dS()
		{
			return null;
		}

		protected AGameSceneManager _0024DS()
		{
			return null;
		}

		protected AEcsWorldBridge _0024Jw()
		{
			return null;
		}

		protected _0024qB _0024bHA()
		{
			return null;
		}

		protected AJInputManager _0024ES()
		{
			return null;
		}

		protected _0024EA _0024fS()
		{
			return null;
		}

		protected bool _0024FS()
		{
			return false;
		}

		protected AGameConfig _0024gS()
		{
			return null;
		}

		protected SavedGameData _0024GS()
		{
			return null;
		}

		protected SavedPlayerProgressData _0024hS()
		{
			return null;
		}

		protected string _0024HS()
		{
			return null;
		}

		protected bool _0024IS()
		{
			return false;
		}

		protected bool _0024jS()
		{
			return false;
		}

		protected SerializedDateTime _0024JS()
		{
			return null;
		}

		protected float _0024kS()
		{
			return 0f;
		}

		protected float _0024KS()
		{
			return 0f;
		}

		protected Camera _0024lS()
		{
			return null;
		}

		protected Camera _0024LS()
		{
			return null;
		}

		protected int _0024mS()
		{
			return 0;
		}

		protected int _0024MS()
		{
			return 0;
		}

		public Transform _0024nS()
		{
			return null;
		}

		public Vector3 _0024NS()
		{
			return default;
		}

		public int _0024oS()
		{
			return 0;
		}

		private void _0024OS(int _1)
		{
		}

		protected CancellationToken _0024pS()
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

		protected virtual void OnDestroy()
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

		protected virtual void _0024hbA()
		{
		}

		protected virtual void _0024HbA()
		{
		}

		protected void _0024PS(float _1, Action _1)
		{
		}

		protected void _0024qS(float _1, Action _1)
		{
		}

		protected void _0024QS(Action _1)
		{
		}

		protected AUIConfig _0024rS()
		{
			return null;
		}

		protected virtual string _0024aEA()
		{
			return null;
		}

		protected virtual bool _0024QhA()
		{
			return false;
		}

		protected void _0024RS(string _1)
		{
		}

		protected void _0024sS(string _1)
		{
		}

		protected void _0024SS(string _1)
		{
		}

		public void _0024tS(bool _1)
		{
		}

		public void _0024TS(GameObject _1, bool _1)
		{
		}

		public void _0024uS(bool _1, float _1)
		{
		}
	}
}
