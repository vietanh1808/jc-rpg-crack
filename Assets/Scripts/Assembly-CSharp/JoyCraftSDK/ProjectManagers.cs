using System.Runtime.CompilerServices;
using _0024B;
using _0024C;
using _0024D;
using _0024G;
using _0024I;
using _0024K;
using _0024N;
using _0024O;
using _0024P;
using _0024c;
using _0024d;
using _0024f;
using _0024g;
using _0024h;
using _0024i;
using _0024j;
using _0024k;
using _0024l;
using _0024p;
using JoyCraftSDK.DOTS.Bridge;
using JoyCraftSDK.Game;
using JoyCraftSDK.GameUI;
using JoyCraftSDK.JInput;
using JoyCraftSDK.SaveSystem;
using UnityEngine;
using UnityEngine.SceneManagement;
using VContainer;

namespace JoyCraftSDK
{
	public class ProjectManagers : MonoBehaviour
	{
		[CompilerGenerated]
		private AEcsWorldBridge _0024Cj;

		[CompilerGenerated]
		private _0024qB m__0024zC;

		[SerializeField]
		public AGameConfig GameConfig;

		[CompilerGenerated]
		private _0024Le m__0024UC;

		[CompilerGenerated]
		private AProjectInitManager m__0024vC;

		[CompilerGenerated]
		private AEventManager m__0024VC;

		[CompilerGenerated]
		private _0024eA m__0024wC;

		[CompilerGenerated]
		private _0024tB m__0024WC;

		[CompilerGenerated]
		private APoolManager m__0024xC;

		[CompilerGenerated]
		private ATaskManager m__0024XC;

		[CompilerGenerated]
		private AFrameRateManager m__0024yC;

		[CompilerGenerated]
		private AInternetManager m__0024YC;

		[CompilerGenerated]
		private AAudioManager m__0024ZC;

		[CompilerGenerated]
		private AHapticManager m__0024ad;

		[CompilerGenerated]
		private _0024WB m__0024Ad;

		[CompilerGenerated]
		private ASaveReferencesManager m__0024bd;

		[CompilerGenerated]
		private _0024zE _0024oH;

		[CompilerGenerated]
		private AGameDataManager m__0024cd;

		[CompilerGenerated]
		private ASaveDatabaseService _0024OH;

		[CompilerGenerated]
		private AGuiManager m__0024Cd;

		[CompilerGenerated]
		private _0024MD m__0024dd;

		[CompilerGenerated]
		private _0024sD m__0024Dd;

		[CompilerGenerated]
		private AJInputManager _0024ed;

		[CompilerGenerated]
		private _0024DA _0024Ed;

		[CompilerGenerated]
		private AAdNetworksManager m__0024fd;

		[CompilerGenerated]
		private _0024FB m__0024Fd;

		[CompilerGenerated]
		private _0024ye m__0024gd;

		[CompilerGenerated]
		private _0024iB m__0024Gd;

		[CompilerGenerated]
		private _0024jB m__0024hd;

		[CompilerGenerated]
		private _0024TC _0024sH;

		[CompilerGenerated]
		private _0024lB m__0024id;

		[CompilerGenerated]
		private _0024ze m__0024Id;

		[CompilerGenerated]
		private _0024Yd m__0024jd;

		[CompilerGenerated]
		private _0024Zd m__0024Jd;

		[CompilerGenerated]
		private _0024Od m__0024kd;

		[CompilerGenerated]
		private _0024LB m__0024Kd;

		[CompilerGenerated]
		private _0024vd m__0024ld;

		[CompilerGenerated]
		private _0024Df _0024SH;

		[CompilerGenerated]
		private _0024If _0024tH;

		[CompilerGenerated]
		private _0024Oc m__0024Ld;

		[CompilerGenerated]
		private _0024xD m__0024md;

		[CompilerGenerated]
		private _0024yD m__0024Md;

		[CompilerGenerated]
		private _0024EA m__0024nd;

		[CompilerGenerated]
		private _0024rE _0024TH;

		[CompilerGenerated]
		private _0024Xd m__0024Nd;

		[CompilerGenerated]
		private _0024ZC m__0024Od;

		[CompilerGenerated]
		private ATimeManager m__0024pd;

		[CompilerGenerated]
		private _0024DE m__0024Pd;

		[CompilerGenerated]
		private _0024nB m__0024qd;

		[CompilerGenerated]
		private _0024EB m__0024Qd;

		[CompilerGenerated]
		private _0024qc m__0024rd;

		[CompilerGenerated]
		private ATutorialController m__0024Rd;

		[CompilerGenerated]
		private _0024Wc m__0024sd;

		[CompilerGenerated]
		private _0024SC m__0024Sd;

		[CompilerGenerated]
		private _0024xc m__0024td;

		[CompilerGenerated]
		private _0024lc m__0024Td;

		[CompilerGenerated]
		private _0024iA m__0024ud;

		[CompilerGenerated]
		private _0024hC m__0024Ud;

		[CompilerGenerated]
		private _0024DC m__0024vd;

		[CompilerGenerated]
		private _0024hA m__0024Vd;

		[CompilerGenerated]
		private _0024Ec m__0024wd;

		[CompilerGenerated]
		private _0024ZB m__0024TC;

		[CompilerGenerated]
		private _0024cc m__0024uC;

		[CompilerGenerated]
		private _0024Ed _0024uH;

		[CompilerGenerated]
		private _0024VC _0024UH;

		[CompilerGenerated]
		private _0024Fd _0024ai;

		[CompilerGenerated]
		private _0024dd _0024Ai;

		[CompilerGenerated]
		private AGameSceneManager m__0024Wd;

		public Camera MainCamera;

		private ABackgroundCamera m__0024xd;

		private ABackgroundUIManager m__0024Xd;

		[CompilerGenerated]
		private bool m__0024yd;

		public static ProjectManagers _0024Yd;

		public AEcsWorldBridge _0024KA
		{
			get
			{
				return _0024nf();
			}
			private set
			{
				_0024Kh(value);
			}
		}

		public _0024qB _0024F
		{
			get
			{
				return _0024aC();
			}
			private set
			{
				_0024AC(value);
			}
		}

		public _0024Le _0024b
		{
			get
			{
				return _0024rc();
			}
			private set
			{
				_0024Rc(value);
			}
		}

		public AProjectInitManager _0024B
		{
			get
			{
				return _0024sc();
			}
			private set
			{
				_0024Sc(value);
			}
		}

		public AEventManager _0024c
		{
			get
			{
				return _0024tc();
			}
			private set
			{
				_0024Tc(value);
			}
		}

		public _0024eA _0024C
		{
			get
			{
				return _0024uc();
			}
			private set
			{
				_0024Uc(value);
			}
		}

		public _0024tB _0024d
		{
			get
			{
				return _0024vc();
			}
			private set
			{
				_0024Vc(value);
			}
		}

		public APoolManager _0024D
		{
			get
			{
				return _0024wc();
			}
			private set
			{
				_0024Wc(value);
			}
		}

		public ATaskManager _0024e
		{
			get
			{
				return _0024xc();
			}
			private set
			{
				_0024Xc(value);
			}
		}

		public AFrameRateManager _0024E
		{
			get
			{
				return _0024yc();
			}
			private set
			{
				_0024Yc(value);
			}
		}

		public AInternetManager _0024f
		{
			get
			{
				return _0024zc();
			}
			private set
			{
				_0024Zc(value);
			}
		}

		public AAudioManager _0024g
		{
			get
			{
				return _0024bC();
			}
			private set
			{
				_0024BC(value);
			}
		}

		public AHapticManager _0024G
		{
			get
			{
				return _0024cC();
			}
			private set
			{
				_0024CC(value);
			}
		}

		public _0024WB _0024h
		{
			get
			{
				return _0024dC();
			}
			private set
			{
				_0024DC(value);
			}
		}

		public ASaveReferencesManager _0024H
		{
			get
			{
				return _0024eC();
			}
			private set
			{
				_0024EC(value);
			}
		}

		public _0024zE _0024i
		{
			get
			{
				return _0024Of();
			}
			private set
			{
				_0024RF(value);
			}
		}

		public AGameDataManager _0024I
		{
			get
			{
				return _0024gC();
			}
			private set
			{
				_0024GC(value);
			}
		}

		public ASaveDatabaseService _0024o
		{
			get
			{
				return _0024sF();
			}
			private set
			{
				_0024wF(value);
			}
		}

		public AGuiManager _0024j
		{
			get
			{
				return _0024hC();
			}
			private set
			{
				_0024HC(value);
			}
		}

		public _0024MD _0024J
		{
			get
			{
				return _0024iC();
			}
			private set
			{
				_0024IC(value);
			}
		}

		public _0024sD _0024k
		{
			get
			{
				return _0024jC();
			}
			private set
			{
				_0024JC(value);
			}
		}

		public AJInputManager _0024K
		{
			get
			{
				return _0024kC();
			}
			private set
			{
				_0024KC(value);
			}
		}

		public _0024DA _0024l
		{
			get
			{
				return _0024lC();
			}
			private set
			{
				_0024LC(value);
			}
		}

		public AAdNetworksManager _0024L
		{
			get
			{
				return _0024mC();
			}
			private set
			{
				_0024MC(value);
			}
		}

		public _0024FB _0024m
		{
			get
			{
				return _0024nC();
			}
			private set
			{
				_0024NC(value);
			}
		}

		public _0024ye _0024M
		{
			get
			{
				return _0024oC();
			}
			private set
			{
				_0024OC(value);
			}
		}

		public _0024iB _0024n
		{
			get
			{
				return _0024pC();
			}
			private set
			{
				_0024PC(value);
			}
		}

		public _0024jB _0024N
		{
			get
			{
				return _0024qC();
			}
			private set
			{
				_0024QC(value);
			}
		}

		public _0024TC _0024U
		{
			get
			{
				return _0024WF();
			}
			private set
			{
				_0024xF(value);
			}
		}

		public _0024lB _0024O
		{
			get
			{
				return _0024sC();
			}
			private set
			{
				_0024SC(value);
			}
		}

		public _0024ze _0024p
		{
			get
			{
				return _0024tC();
			}
			private set
			{
				_0024TC(value);
			}
		}

		public _0024Yd _0024P
		{
			get
			{
				return _0024uC();
			}
			private set
			{
				_0024UC(value);
			}
		}

		public _0024Zd _0024q
		{
			get
			{
				return _0024vC();
			}
			private set
			{
				_0024VC(value);
			}
		}

		public _0024Od _0024Q
		{
			get
			{
				return _0024wC();
			}
			private set
			{
				_0024WC(value);
			}
		}

		public _0024LB _0024r
		{
			get
			{
				return _0024xC();
			}
			private set
			{
				_0024XC(value);
			}
		}

		public _0024vd _0024R
		{
			get
			{
				return _0024yC();
			}
			private set
			{
				_0024YC(value);
			}
		}

		public _0024Df _0024hA
		{
			get
			{
				return _0024XF();
			}
			private set
			{
				_0024yF(value);
			}
		}

		public _0024If _0024HA
		{
			get
			{
				return _0024YF();
			}
			private set
			{
				_0024Tg(value);
			}
		}

		public _0024Oc _0024s
		{
			get
			{
				return _0024zC();
			}
			private set
			{
				_0024ZC(value);
			}
		}

		public _0024xD _0024S
		{
			get
			{
				return _0024ad();
			}
			private set
			{
				_0024Ad(value);
			}
		}

		public _0024yD _0024t
		{
			get
			{
				return _0024bd();
			}
			private set
			{
				_0024Bd(value);
			}
		}

		public _0024EA _0024T
		{
			get
			{
				return _0024cd();
			}
			private set
			{
				_0024Cd(value);
			}
		}

		public _0024rE _0024iA
		{
			get
			{
				return _0024ug();
			}
			private set
			{
				_0024xg(value);
			}
		}

		public _0024Xd _0024u
		{
			get
			{
				return _0024dd();
			}
			private set
			{
				_0024Dd(value);
			}
		}

		public _0024ZC _0024v
		{
			get
			{
				return _0024fd();
			}
			private set
			{
				_0024Fd(value);
			}
		}

		public ATimeManager _0024V
		{
			get
			{
				return _0024gd();
			}
			private set
			{
				_0024Gd(value);
			}
		}

		public _0024DE _0024w
		{
			get
			{
				return _0024hd();
			}
			private set
			{
				_0024Hd(value);
			}
		}

		public _0024nB _0024W
		{
			get
			{
				return _0024id();
			}
			private set
			{
				_0024Id(value);
			}
		}

		public _0024EB _0024x
		{
			get
			{
				return _0024jd();
			}
			private set
			{
				_0024Jd(value);
			}
		}

		public _0024qc _0024X
		{
			get
			{
				return _0024kd();
			}
			private set
			{
				_0024Kd(value);
			}
		}

		public ATutorialController _0024y
		{
			get
			{
				return _0024ld();
			}
			private set
			{
				_0024Ld(value);
			}
		}

		public _0024Wc _0024Y
		{
			get
			{
				return _0024md();
			}
			private set
			{
				_0024Md(value);
			}
		}

		public _0024SC _0024z
		{
			get
			{
				return _0024nd();
			}
			private set
			{
				_0024Nd(value);
			}
		}

		public _0024xc _0024Z
		{
			get
			{
				return _0024od();
			}
			private set
			{
				_0024Od(value);
			}
		}

		public _0024lc _0024aA
		{
			get
			{
				return _0024pd();
			}
			private set
			{
				_0024Pd(value);
			}
		}

		public _0024iA _0024AA
		{
			get
			{
				return _0024qd();
			}
			private set
			{
				_0024Qd(value);
			}
		}

		public _0024hC _0024bA
		{
			get
			{
				return _0024rd();
			}
			private set
			{
				_0024Rd(value);
			}
		}

		public _0024DC _0024BA
		{
			get
			{
				return _0024sd();
			}
			private set
			{
				_0024Sd(value);
			}
		}

		public _0024hA _0024cA
		{
			get
			{
				return _0024td();
			}
			private set
			{
				_0024Td(value);
			}
		}

		public _0024Ec _0024CA
		{
			get
			{
				return _0024ud();
			}
			private set
			{
				_0024Ud(value);
			}
		}

		public _0024ZB _0024a
		{
			get
			{
				return _0024Oc();
			}
			private set
			{
				_0024pc(value);
			}
		}

		public _0024cc _0024A
		{
			get
			{
				return _0024Pc();
			}
			private set
			{
				_0024qc(value);
			}
		}

		public _0024Ed _0024IA
		{
			get
			{
				return _0024jG();
			}
			private set
			{
				_0024JG(value);
			}
		}

		public _0024VC _0024jA
		{
			get
			{
				return _0024kG();
			}
			private set
			{
				_0024KG(value);
			}
		}

		public _0024Fd _0024JA
		{
			get
			{
				return _0024lG();
			}
			private set
			{
				_0024LG(value);
			}
		}

		public _0024dd _0024kA
		{
			get
			{
				return _0024mG();
			}
			private set
			{
				_0024MG(value);
			}
		}

		public AGameSceneManager _0024dA
		{
			get
			{
				return _0024vd();
			}
			private set
			{
				_0024Vd(value);
			}
		}

		public ABackgroundCamera _0024DA => _0024wd();

		public ABackgroundUIManager _0024eA => _0024Wd();

		public Camera _0024EA => _0024xd();

		public int _0024fA => _0024Xd();

		public int _0024FA => _0024yd();

		public bool _0024gA
		{
			get
			{
				return _0024Yd();
			}
			private set
			{
				_0024zd(value);
			}
		}

		protected virtual string _0024GA => _0024gbA();

		public AEcsWorldBridge _0024nf()
		{
			return null;
		}

		private void _0024Kh(AEcsWorldBridge _1)
		{
		}

		public _0024qB _0024aC()
		{
			return null;
		}

		private void _0024AC(_0024qB _1)
		{
		}

		[Inject]
		public void _0024qe(AEcsWorldBridge _1, _0024qB _1)
		{
		}

		public _0024Le _0024rc()
		{
			return null;
		}

		private void _0024Rc(_0024Le _1)
		{
		}

		public AProjectInitManager _0024sc()
		{
			return null;
		}

		private void _0024Sc(AProjectInitManager _1)
		{
		}

		public AEventManager _0024tc()
		{
			return null;
		}

		private void _0024Tc(AEventManager _1)
		{
		}

		public _0024eA _0024uc()
		{
			return null;
		}

		private void _0024Uc(_0024eA _1)
		{
		}

		public _0024tB _0024vc()
		{
			return null;
		}

		private void _0024Vc(_0024tB _1)
		{
		}

		public APoolManager _0024wc()
		{
			return null;
		}

		private void _0024Wc(APoolManager _1)
		{
		}

		public ATaskManager _0024xc()
		{
			return null;
		}

		private void _0024Xc(ATaskManager _1)
		{
		}

		public AFrameRateManager _0024yc()
		{
			return null;
		}

		private void _0024Yc(AFrameRateManager _1)
		{
		}

		public AInternetManager _0024zc()
		{
			return null;
		}

		private void _0024Zc(AInternetManager _1)
		{
		}

		public AAudioManager _0024bC()
		{
			return null;
		}

		private void _0024BC(AAudioManager _1)
		{
		}

		public AHapticManager _0024cC()
		{
			return null;
		}

		private void _0024CC(AHapticManager _1)
		{
		}

		public _0024WB _0024dC()
		{
			return null;
		}

		private void _0024DC(_0024WB _1)
		{
		}

		public ASaveReferencesManager _0024eC()
		{
			return null;
		}

		private void _0024EC(ASaveReferencesManager _1)
		{
		}

		public _0024zE _0024Of()
		{
			return null;
		}

		private void _0024RF(_0024zE _1)
		{
		}

		public AGameDataManager _0024gC()
		{
			return null;
		}

		private void _0024GC(AGameDataManager _1)
		{
		}

		public ASaveDatabaseService _0024sF()
		{
			return null;
		}

		private void _0024wF(ASaveDatabaseService _1)
		{
		}

		public AGuiManager _0024hC()
		{
			return null;
		}

		private void _0024HC(AGuiManager _1)
		{
		}

		public _0024MD _0024iC()
		{
			return null;
		}

		private void _0024IC(_0024MD _1)
		{
		}

		public _0024sD _0024jC()
		{
			return null;
		}

		private void _0024JC(_0024sD _1)
		{
		}

		public AJInputManager _0024kC()
		{
			return null;
		}

		private void _0024KC(AJInputManager _1)
		{
		}

		public _0024DA _0024lC()
		{
			return null;
		}

		private void _0024LC(_0024DA _1)
		{
		}

		public AAdNetworksManager _0024mC()
		{
			return null;
		}

		private void _0024MC(AAdNetworksManager _1)
		{
		}

		public _0024FB _0024nC()
		{
			return null;
		}

		private void _0024NC(_0024FB _1)
		{
		}

		public _0024ye _0024oC()
		{
			return null;
		}

		private void _0024OC(_0024ye _1)
		{
		}

		public _0024iB _0024pC()
		{
			return null;
		}

		private void _0024PC(_0024iB _1)
		{
		}

		public _0024jB _0024qC()
		{
			return null;
		}

		private void _0024QC(_0024jB _1)
		{
		}

		public _0024TC _0024WF()
		{
			return null;
		}

		private void _0024xF(_0024TC _1)
		{
		}

		public _0024lB _0024sC()
		{
			return null;
		}

		private void _0024SC(_0024lB _1)
		{
		}

		public _0024ze _0024tC()
		{
			return null;
		}

		private void _0024TC(_0024ze _1)
		{
		}

		public _0024Yd _0024uC()
		{
			return null;
		}

		private void _0024UC(_0024Yd _1)
		{
		}

		public _0024Zd _0024vC()
		{
			return null;
		}

		private void _0024VC(_0024Zd _1)
		{
		}

		public _0024Od _0024wC()
		{
			return null;
		}

		private void _0024WC(_0024Od _1)
		{
		}

		public _0024LB _0024xC()
		{
			return null;
		}

		private void _0024XC(_0024LB _1)
		{
		}

		public _0024vd _0024yC()
		{
			return null;
		}

		private void _0024YC(_0024vd _1)
		{
		}

		public _0024Df _0024XF()
		{
			return null;
		}

		private void _0024yF(_0024Df _1)
		{
		}

		public _0024If _0024YF()
		{
			return null;
		}

		private void _0024Tg(_0024If _1)
		{
		}

		public _0024Oc _0024zC()
		{
			return null;
		}

		private void _0024ZC(_0024Oc _1)
		{
		}

		public _0024xD _0024ad()
		{
			return null;
		}

		private void _0024Ad(_0024xD _1)
		{
		}

		public _0024yD _0024bd()
		{
			return null;
		}

		private void _0024Bd(_0024yD _1)
		{
		}

		public _0024EA _0024cd()
		{
			return null;
		}

		private void _0024Cd(_0024EA _1)
		{
		}

		public _0024rE _0024ug()
		{
			return null;
		}

		private void _0024xg(_0024rE _1)
		{
		}

		public _0024Xd _0024dd()
		{
			return null;
		}

		private void _0024Dd(_0024Xd _1)
		{
		}

		public _0024ZC _0024fd()
		{
			return null;
		}

		private void _0024Fd(_0024ZC _1)
		{
		}

		public ATimeManager _0024gd()
		{
			return null;
		}

		private void _0024Gd(ATimeManager _1)
		{
		}

		public _0024DE _0024hd()
		{
			return null;
		}

		private void _0024Hd(_0024DE _1)
		{
		}

		public _0024nB _0024id()
		{
			return null;
		}

		private void _0024Id(_0024nB _1)
		{
		}

		public _0024EB _0024jd()
		{
			return null;
		}

		private void _0024Jd(_0024EB _1)
		{
		}

		public _0024qc _0024kd()
		{
			return null;
		}

		private void _0024Kd(_0024qc _1)
		{
		}

		public ATutorialController _0024ld()
		{
			return null;
		}

		private void _0024Ld(ATutorialController _1)
		{
		}

		public _0024Wc _0024md()
		{
			return null;
		}

		private void _0024Md(_0024Wc _1)
		{
		}

		public _0024SC _0024nd()
		{
			return null;
		}

		private void _0024Nd(_0024SC _1)
		{
		}

		public _0024xc _0024od()
		{
			return null;
		}

		private void _0024Od(_0024xc _1)
		{
		}

		public _0024lc _0024pd()
		{
			return null;
		}

		private void _0024Pd(_0024lc _1)
		{
		}

		public _0024iA _0024qd()
		{
			return null;
		}

		private void _0024Qd(_0024iA _1)
		{
		}

		public _0024hC _0024rd()
		{
			return null;
		}

		private void _0024Rd(_0024hC _1)
		{
		}

		public _0024DC _0024sd()
		{
			return null;
		}

		private void _0024Sd(_0024DC _1)
		{
		}

		public _0024hA _0024td()
		{
			return null;
		}

		private void _0024Td(_0024hA _1)
		{
		}

		public _0024Ec _0024ud()
		{
			return null;
		}

		private void _0024Ud(_0024Ec _1)
		{
		}

		public _0024ZB _0024Oc()
		{
			return null;
		}

		private void _0024pc(_0024ZB _1)
		{
		}

		public _0024cc _0024Pc()
		{
			return null;
		}

		private void _0024qc(_0024cc _1)
		{
		}

		public _0024Ed _0024jG()
		{
			return null;
		}

		private void _0024JG(_0024Ed _1)
		{
		}

		public _0024VC _0024kG()
		{
			return null;
		}

		private void _0024KG(_0024VC _1)
		{
		}

		public _0024Fd _0024lG()
		{
			return null;
		}

		private void _0024LG(_0024Fd _1)
		{
		}

		public _0024dd _0024mG()
		{
			return null;
		}

		private void _0024MG(_0024dd _1)
		{
		}

		public AGameSceneManager _0024vd()
		{
			return null;
		}

		private void _0024Vd(AGameSceneManager _1)
		{
		}

		public ABackgroundCamera _0024wd()
		{
			return null;
		}

		public ABackgroundUIManager _0024Wd()
		{
			return null;
		}

		public Camera _0024xd()
		{
			return null;
		}

		public int _0024Xd()
		{
			return 0;
		}

		public int _0024yd()
		{
			return 0;
		}

		public bool _0024Yd()
		{
			return false;
		}

		private void _0024zd(bool _1)
		{
		}

		[Inject]
		public void _0024Qe(_0024Le _1, AProjectInitManager _1, AEventManager _1, _0024eA _1, _0024tB _1, APoolManager _1, ATaskManager _1, AFrameRateManager _1, AInternetManager _1, AAudioManager _1, AHapticManager _1, _0024WB _1, ASaveReferencesManager _1, _0024zE _1, AGameDataManager _1, ASaveDatabaseService _1, AGuiManager _1, _0024MD _1, _0024sD _1, AJInputManager _1, _0024DA _1, AAdNetworksManager _1, _0024FB _1, _0024ye _1, _0024iB _1, _0024jB _1, _0024TC _1, _0024lB _1, _0024ze _1, _0024Yd _1, _0024Zd _1, _0024Od _1, _0024LB _1, _0024vd _1, _0024Df _1, _0024If _1, _0024Oc _1, _0024xD _1, _0024yD _1, _0024EA _1, _0024rE _1, _0024Xd _1, _0024ZC _1, ATimeManager _1, _0024DE _1, _0024nB _1, _0024EB _1, _0024qc _1, ATutorialController _1, _0024Wc _1, _0024SC _1, _0024xc _1, _0024lc _1, _0024iA _1, _0024hC _1, _0024DC _1, _0024hA _1, _0024Ec _1, _0024ZB _1, _0024cc _1, _0024Ed _1, _0024VC _1, _0024Fd _1, _0024dd _1)
		{
		}

		public void Awake()
		{
		}

		private void _0024aD(Scene _1, LoadSceneMode _1)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void _0024AD(ref AEventManager._0024Ub _1)
		{
		}

		protected virtual string _0024gbA()
		{
			return null;
		}

		protected void _0024bD(string _1)
		{
		}

		protected void _0024BD(string _1)
		{
		}

		protected void _0024cD(string _1)
		{
		}
	}
}
