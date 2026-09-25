using System;
using System.Runtime.CompilerServices;
using _0024l;
using Sigtrap.Relays;
using UnityEngine;

namespace JoyCraftSDK.ToolBox
{
	[Serializable]
	public abstract class ATimer : _0024YD
	{
		[HideInInspector]
		public Relay<ATimer> OnTimerStarted;

		[HideInInspector]
		public Relay<ATimer> OnTimerPaused;

		[HideInInspector]
		public Relay<ATimer> OnTimerResumed;

		[HideInInspector]
		public Relay<ATimer> OnTimerReset;

		[HideInInspector]
		public Relay<ATimer> OnTimerUpdate;

		[HideInInspector]
		public Relay<ATimer> OnTimerFinished;

		[CompilerGenerated]
		private TimerState _0024Uj;

		[CompilerGenerated]
		private float _0024vj;

		[CompilerGenerated]
		private float _0024Vj;

		public TimerState State
		{
			get
			{
				return _0024Yh();
			}
			protected set
			{
				_0024zh(value);
			}
		}

		public float SecondsLeft
		{
			get
			{
				return _0024Zh();
			}
			protected set
			{
				_0024aH(value);
			}
		}

		public float TimeSpent => _0024AH();

		public float Duration
		{
			get
			{
				return _0024bH();
			}
			protected set
			{
				_0024BH(value);
			}
		}

		public float ProgressElapsed => _0024cH();

		public float ProgressLeft => _0024CH();

		public bool IsRunning => _0024dH();

		public bool IsPaused => _0024DH();

		public bool IsFinished => _0024eH();

		public bool IsIdle => _0024EH();

		public TimerState _0024Yh()
		{
			return TimerState.Idle;
		}

		protected void _0024zh(TimerState _1)
		{
		}

		public float _0024Zh()
		{
			return 0f;
		}

		protected void _0024aH(float _1)
		{
		}

		public float _0024AH()
		{
			return 0f;
		}

		public float _0024bH()
		{
			return 0f;
		}

		protected void _0024BH(float _1)
		{
		}

		public float _0024cH()
		{
			return 0f;
		}

		public float _0024CH()
		{
			return 0f;
		}

		public bool _0024dH()
		{
			return false;
		}

		public bool _0024DH()
		{
			return false;
		}

		public bool _0024eH()
		{
			return false;
		}

		public bool _0024EH()
		{
			return false;
		}

		public abstract void _0024ueA(float _1);

		public abstract void _0024UeA();

		public virtual void _0024veA(float _1)
		{
		}

		public abstract void _0024VeA();

		public abstract void _0024weA();

		public abstract void _0024WeA();

		public abstract void _0024xeA();

		public abstract void _0024XeA(float _1);

		public abstract void _0024yeA(float _1);
	}
}
