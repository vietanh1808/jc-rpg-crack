using _0024B;
using GenericEventBus;
using JoyCraftSDK.Game;
using JoyCraftSDK.GameUI;
using JoyCraftSDK.SaveSystem;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK
{
	public abstract class AEventManager : JMonoBehaviour
	{
		public new class _0024IA : _0024dB
		{
			public string _0024HD;

			public string _0024iD;

			public int _0024ID;
		}

		public new class _0024jA : _0024dB
		{
			public BoosterType _0024jD;

			public int _0024JD;
		}

		public new class _0024JA : _0024dB
		{
			public int _0024kD;

			public string _0024KD;
		}

		public new class _0024kA : _0024dB
		{
			public string _0024lD;
		}

		public class _0024KA : _0024dB
		{
			public int _0024LD;

			public int _0024mD;

			public bool _0024MD;
		}

		public class _0024lA : _0024dB
		{
			public int _0024nD;

			public string _0024ND;
		}

		public class _0024LA : _0024dB
		{
			public string _0024oD;
		}

		public class _0024mA : _0024dB
		{
			public string _0024OD;
		}

		public class _0024MA : _0024dB
		{
			public int _0024pD;
		}

		public class _0024nA : _0024dB
		{
			public string _0024PD;

			public string _0024qD;

			public string _0024QD;

			public string _0024rD;

			public string _0024RD;

			public string _0024sD;

			public string _0024SD;

			public double _0024tD;

			public double _0024TD;

			public string _0024uD;
		}

		public class _0024NA : _0024dB
		{
			public string _0024UD;

			public string _0024vD;

			public string _0024VD;

			public string _0024wD;

			public string _0024WD;

			public string _0024xD;

			public double _0024XD;

			public string _0024yD;

			public string _0024YD;

			public string _0024zD;

			public string _0024ZD;
		}

		public class _0024oA : _0024dB
		{
			public string _0024ae;

			public string _0024Ae;

			public int _0024be;

			public double _0024Be;

			public string _0024ce;

			public string _0024Ce;

			public string _0024de;
		}

		public class _0024OA : _0024dB
		{
			public string _0024De;

			public string _0024ee;

			public string _0024Ee;

			public string _0024fe;

			public string _0024Fe;

			public string _0024ge;

			public string _0024Ge;

			public double _0024he;
		}

		public class _0024pA : _0024dB
		{
			public string _0024He;

			public string _0024ie;

			public string _0024Ie;

			public string _0024je;

			public string _0024Je;
		}

		public class _0024PA : _0024dB
		{
			public string _0024ke;

			public string _0024Ke;

			public string _0024le;

			public string _0024Le;

			public string _0024me;

			public string _0024Me;

			public double _0024ne;
		}

		public class _0024qA : _0024dB
		{
			public string _0024Ne;

			public string _0024oe;

			public string _0024Oe;

			public int _0024pe;

			public string _0024Pe;
		}

		public class _0024QA : _0024dB
		{
			public string _0024qe;

			public string _0024Qe;

			public string _0024re;

			public string _0024Re;
		}

		public class _0024rA : _0024dB
		{
			public string _0024se;

			public string _0024Se;

			public string _0024te;

			public string _0024Te;

			public double _0024ue;

			public string _0024Ue;

			public string _0024ve;

			public string _0024Ve;

			public string _0024we;

			public string _0024We;

			public int _0024xe;
		}

		public class _0024RA : _0024dB
		{
			public string _0024Xe;

			public string _0024ye;

			public string _0024Ye;

			public string _0024ze;

			public double _0024Ze;

			public string _0024aE;

			public string _0024AE;

			public string _0024bE;

			public string _0024BE;

			public string _0024cE;

			public string _0024CE;

			public string _0024dE;

			public int _0024DE;
		}

		public class _0024sA : _0024dB
		{
			public string _0024eE;

			public string _0024EE;

			public string _0024fE;
		}

		public class _0024SA : _0024dB
		{
			public string _0024FE;

			public string _0024gE;

			public string _0024GE;

			public double _0024hE;
		}

		public class _0024tA : _0024dB
		{
			public LevelPlayType _0024HE;
		}

		public class _0024TA : _0024dB
		{
		}

		public class _0024uA : _0024dB
		{
			public bool _0024iE;
		}

		public class _0024UA : _0024dB
		{
			public LevelFinishReason _0024IE;

			public LevelFailReason _0024jE;
		}

		public class _0024vA : _0024dB
		{
			public LevelFailReason _0024JE;

			public int _0024kE;
		}

		public class _0024VA : _0024dB
		{
		}

		public class _0024wA : _0024dB
		{
		}

		public class _0024WA : _0024dB
		{
			public TutorialType _0024KE;
		}

		public class _0024xA : _0024dB
		{
			public TutorialType _0024lE;

			public int _0024LE;
		}

		public class _0024XA : _0024dB
		{
			public TutorialType _0024mE;
		}

		public class _0024yA : _0024dB
		{
			public double _0024ME;

			public bool _0024nE;
		}

		public class _0024GB : _0024dB
		{
			public string _0024bi;

			public bool _0024Bi;

			public string _0024ci;

			public long _0024Vi;

			public long _0024wi;

			public ResourceEarnChannel _0024bI;

			public ResourceSpendChannel _0024cI;

			public AnalyticsPlacement _0024CI;

			public int _0024LI;
		}

		public class _0024zA : _0024dB
		{
		}

		public class _0024ZA : _0024dB
		{
			public int _0024RE;

			public bool _0024sE;
		}

		public class _0024Xc : _0024dB
		{
			public RegenResourceType _0024mI;

			public bool _0024MI;

			public string _0024nI;

			public int _0024JJ;

			public int _0024kJ;

			public int _0024lJ;

			public ResourceEarnChannel _0024LJ;

			public AnalyticsPlacement _0024PJ;
		}

		public class _0024Bb : _0024dB
		{
			public RegenResourceType _0024bf;

			public int _0024Bf;

			public int _0024cf;

			public RegenChangeSource _0024Cf;
		}

		public class _0024cb : _0024dB
		{
			public BuffType _0024df;

			public bool _0024Df;

			public float _0024ef;

			public float _0024Ef;
		}

		public class _0024Cb : _0024dB
		{
			public BuffType _0024ff;
		}

		public class _0024db : _0024dB
		{
			public bool _0024Ff;
		}

		public class _0024Db : _0024dB
		{
			public bool _0024gf;
		}

		public class _0024eb : _0024dB
		{
			public bool _0024Gf;
		}

		public class _0024Eb : _0024dB
		{
			public BoosterType _0024hf;
		}

		public class _0024fb : _0024dB
		{
			public BoosterType _0024Hf;

			public string _0024if;

			public int _0024If;

			public int _0024jf;

			public BoosterEarnReason _0024Jf;

			public BoosterSpendReason _0024kf;

			public bool _0024Kf;

			public AnalyticsPlacement _0024lf;
		}

		public class _0024Fb : _0024dB
		{
			public BoosterType _0024Lf;
		}

		public class _0024gb : _0024dB
		{
			public bool _0024mf;

			public BoosterType _0024Mf;
		}

		public class _0024Gb : _0024dB
		{
			public BoosterType _0024nf;
		}

		public class _0024hb : _0024dB
		{
			public BoosterType _0024Nf;
		}

		public class _0024Hb : _0024dB
		{
		}

		public class _0024ib : _0024dB
		{
			public bool _0024of;
		}

		public class _0024Ib : _0024dB
		{
			public bool _0024Of;
		}

		public class _0024jb : _0024dB
		{
			public bool _0024pf;
		}

		public class _0024Jb : _0024dB
		{
			public BoosterType _0024Pf;

			public int _0024qf;
		}

		public class _0024kb : _0024dB
		{
		}

		public class _0024Kb : _0024dB
		{
			public ALevelDatabase _0024Qf;
		}

		public class _0024lb : _0024dB
		{
			public string _0024rf;

			public int _0024Rf;
		}

		public class _0024Lb : _0024dB
		{
			public string _0024sf;

			public int _0024Sf;

			public int _0024tf;
		}

		public class _0024mb : _0024dB
		{
			public string _0024Tf;
		}

		public class _0024Mb : _0024dB
		{
		}

		public class _0024nb : _0024dB
		{
		}

		public class _0024Nb : _0024dB
		{
		}

		public class _0024ob : _0024dB
		{
		}

		public class _0024Ob : _0024dB
		{
		}

		public class _0024pb : _0024dB
		{
		}

		public class _0024Pb : _0024dB
		{
		}

		public class _0024qb : _0024dB
		{
			public AdsFlowReason _0024uf;

			public string _0024Uf;
		}

		public class _0024Qb : _0024dB
		{
			public string _0024vf;

			public long _0024Vf;

			public long _0024wf;
		}

		public class _0024rb : _0024dB
		{
			public string _0024Wf;

			public int _0024xf;

			public int _0024Xf;
		}

		public class _0024OC : _0024dB
		{
			public string _0024qJ;

			public bool _0024QJ;
		}

		public class _0024PC : _0024dB
		{
			public int _0024rJ;
		}

		public class _0024Rb : _0024dB
		{
			public bool _0024yf;
		}

		public class _0024sb : _0024dB
		{
			public bool _0024Yf;
		}

		public class _0024Sb : _0024dB
		{
		}

		public class _0024tb : _0024dB
		{
		}

		public class _0024Tb : _0024dB
		{
			public SceneIndex _0024zf;

			public SceneIndex _0024Zf;
		}

		public class _0024ub : _0024dB
		{
			public SceneIndex _0024aF;

			public bool _0024AF;
		}

		public class _0024Ub : _0024dB
		{
			public SceneIndex _0024bF;
		}

		public class _0024vb : _0024dB
		{
			public SceneIndex _0024BF;
		}

		public class _0024Vb : _0024dB
		{
			public SceneIndex _0024cF;
		}

		public class _0024wb : _0024dB
		{
			public SceneIndex _0024CF;
		}

		public class _0024Wb : _0024dB
		{
			public SceneIndex _0024dF;
		}

		public class _0024xb : _0024dB
		{
			public SceneIndex _0024DF;
		}

		public class _0024Xb : _0024dB
		{
		}

		public class _0024yb : _0024dB
		{
		}

		public class _0024Yb : _0024dB
		{
		}

		public class _0024zb : _0024dB
		{
		}

		public class _0024Zb : _0024dB
		{
		}

		public class _0024aB : _0024dB
		{
		}

		public class _0024AB : _0024dB
		{
			public string _0024eF;

			public long _0024EF;

			public bool _0024fF;
		}

		public class _0024bB : _0024dB
		{
			public string _0024FF;

			public string _0024gF;

			public string _0024GF;
		}

		public class _0024BB : _0024dB
		{
			public UIPanelID _0024hF;

			public UILayer _0024HF;
		}

		public class _0024cB : _0024dB
		{
			public UIPanelID _0024iF;

			public UILayer _0024IF;
		}

		public class _0024CB : _0024dB
		{
			public string _0024jF;
		}

		public class _0024QC : _0024dB
		{
			public SavedGameData _0024xE;
		}

		public readonly GenericEventBus<_0024dB> EventBus;
	}
}
