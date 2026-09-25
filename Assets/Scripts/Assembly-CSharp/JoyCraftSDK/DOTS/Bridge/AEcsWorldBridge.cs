using System;
using System.Collections.Generic;
using _0024Q;
using JoyCraftSDK.Utilities;
using Unity.Entities;
using Unity.Entities.Serialization;
using UnityEngine;
using UnityEngine.Serialization;

namespace JoyCraftSDK.DOTS.Bridge
{
	public abstract class AEcsWorldBridge : JMonoBehaviour
	{
		[FormerlySerializedAs("forceRecreateWorldEachStage")]
		[SerializeField]
		protected bool forceRecreateWorldEachRoom;

		[Tooltip("SubScene bake sẵn (vd bảng prefab actor) nạp vào World gameplay. Generic — SDK không biết nội dung scene.")]
		[SerializeField]
		private EntitySceneReference[] entityScenesToLoad;

		private readonly List<Entity> _0024nh;

		protected readonly EcsWorldHost _0024Hp;

		protected bool _0024mp;

		protected float _0024ZQ;

		public new abstract bool _0024a { get; }

		protected new bool _0024A => _0024Ew();

		protected new virtual IReadOnlyList<Type> _0024b => _0024vHA();

		protected new virtual bool _0024B => _0024mw();

		public abstract bool _0024vIA();

		public abstract bool _0024AjA();

		public abstract void _0024ZIA(uint _1, int _1);

		public abstract void _0024ajA();

		public abstract void _0024cjA(in _0024QB _1);

		public abstract void _0024bjA(EcsRoomEndReason _1);

		public abstract void _0024BjA(EcsLevelEndReason _1);

		public abstract void _0024CjA(bool _1);

		public abstract void _0024djA(float _1);

		protected bool _0024Ew()
		{
			return false;
		}

		protected override void _0024hbA()
		{
		}

		protected override void _0024HbA()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void _0024fw(ref AEventManager._0024yb _1)
		{
		}

		protected virtual void _0024DjA(float _1)
		{
		}

		protected virtual IReadOnlyList<Type> _0024vHA()
		{
			return null;
		}

		private void _0024aX(string _1)
		{
		}

		private void _0024kw()
		{
		}

		protected virtual bool _0024mw()
		{
			return false;
		}

		protected void _0024Fw(string _1)
		{
		}

		protected void _0024gw()
		{
		}

		protected bool _0024Mw(string _1)
		{
			return false;
		}
	}
}
