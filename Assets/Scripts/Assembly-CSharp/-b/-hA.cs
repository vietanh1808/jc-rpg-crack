using System;
using System.Collections.Generic;
using _0024l;
using JoyCraftSDK;
using JoyCraftSDK.GameUI;
using UnityEngine;

namespace _0024B
{
	public abstract class _0024hA : _0024YD
	{
		public abstract void _0024KbA(EffectType _1, Transform _1);

		public abstract void _0024lbA(EffectType _1, Transform _1);

		public abstract Transform _0024LbA(EffectType _1);
	}
	public class _0024HA : _0024iA
	{
		private readonly Dictionary<EffectType, AWinEffect> _0024gD;

		private new AGuiManager _0024a => _0024jD();

		private AGuiManager _0024jD()
		{
			return null;
		}

		private AWinEffect _0024JD(EffectType _1)
		{
			return null;
		}

		public override void _0024mbA(EffectType _1, Transform _1, Action _1 = null)
		{
		}

		public override void _0024MbA(EffectType _1, Vector3 _1, Action _1 = null)
		{
		}
	}
}
