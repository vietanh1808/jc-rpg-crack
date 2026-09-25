using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace JoyCraftSDK.Utilities
{
	[Serializable]
	public abstract class SerializedDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, ISerializationCallbackReceiver
	{
		[NonSerialized]
		protected Dictionary<TKey, TValue> _0024zQ;

		[FormerlySerializedAs("keyData")]
		[SerializeField]
		private TKey[] m_Keys;

		[FormerlySerializedAs("valueData")]
		[SerializeField]
		private TValue[] m_Values;

		public int Count => 0;

		public ICollection<TKey> Keys => null;

		public ICollection<TValue> Values => null;

		public TValue this[TKey key]
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly => _0024NHA();

		private bool _0024NHA()
		{
			return false;
		}

		public void Add(TKey key, TValue value)
		{
		}

		public bool ContainsKey(TKey key)
		{
			return false;
		}

		public bool Remove(TKey key)
		{
			return false;
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			value = default;
			return false;
		}

		public void Clear()
		{
		}

		private void _0024oHA(KeyValuePair<TKey, TValue> _1)
		{
		}

		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> _1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in $oHA
			this._0024oHA(_1);
		}

		private bool _0024OHA(KeyValuePair<TKey, TValue> _1)
		{
			return false;
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> _1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in $OHA
			return this._0024OHA(_1);
		}

		private void _0024pHA(KeyValuePair<TKey, TValue>[] _1, int _1)
		{
		}

		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] _1, int _1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in $pHA
			this._0024pHA(_1, _1);
		}

		private bool _0024PHA(KeyValuePair<TKey, TValue> _1)
		{
			return false;
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> _1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in $PHA
			return this._0024PHA(_1);
		}

		public Dictionary<TKey, TValue>.Enumerator _0024rx()
		{
			return default;
		}

		private IEnumerator _0024qHA()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in $qHA
			return this._0024qHA();
		}

		private IEnumerator<KeyValuePair<TKey, TValue>> _0024QHA()
		{
			return null;
		}

		IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in $QHA
			return this._0024QHA();
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		protected virtual void _0024rHA()
		{
		}

		protected virtual void _0024RHA()
		{
		}
	}
}
