using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace JoyCraftSDK.Utilities
{
	[Serializable]
	public class SerializedDateTime : ISerializationCallbackReceiver, IComparable, IComparable<DateTime>, IEquatable<DateTime>, IFormattable
	{
		[HideInInspector]
		public DateTime dateTime;

		[SerializeField]
		private string _dateTime;

		public override string ToString()
		{
			return null;
		}

		public void OnAfterDeserialize()
		{
		}

		public void OnBeforeSerialize()
		{
		}

		[SpecialName]
		public static DateTime _0024zw(SerializedDateTime _1)
		{
			return default;
		}

		[SpecialName]
		public static SerializedDateTime _0024Zw(DateTime _1)
		{
			return null;
		}

		public int CompareTo(object obj)
		{
			return 0;
		}

		public int CompareTo(DateTime other)
		{
			return 0;
		}

		public bool Equals(DateTime other)
		{
			return false;
		}

		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		public string _0024aW(string _1)
		{
			return null;
		}

		public string _0024AW(IFormatProvider _1)
		{
			return null;
		}

		[SpecialName]
		public static bool _0024bW(SerializedDateTime _1, SerializedDateTime _1)
		{
			return false;
		}

		[SpecialName]
		public static bool _0024BW(SerializedDateTime _1, SerializedDateTime _1)
		{
			return false;
		}

		[SpecialName]
		public static bool _0024cW(SerializedDateTime _1, SerializedDateTime _1)
		{
			return false;
		}

		[SpecialName]
		public static bool _0024CW(SerializedDateTime _1, SerializedDateTime _1)
		{
			return false;
		}

		[SpecialName]
		public static bool _0024dW(SerializedDateTime _1, SerializedDateTime _1)
		{
			return false;
		}

		[SpecialName]
		public static bool _0024DW(SerializedDateTime _1, SerializedDateTime _1)
		{
			return false;
		}

		[SpecialName]
		public static bool _0024eW(SerializedDateTime _1, DateTime _1)
		{
			return false;
		}

		[SpecialName]
		public static bool _0024EW(SerializedDateTime _1, DateTime _1)
		{
			return false;
		}

		[SpecialName]
		public static bool _0024fW(SerializedDateTime _1, DateTime _1)
		{
			return false;
		}

		[SpecialName]
		public static bool _0024FW(SerializedDateTime _1, DateTime _1)
		{
			return false;
		}

		[SpecialName]
		public static bool _0024gW(SerializedDateTime _1, DateTime _1)
		{
			return false;
		}

		[SpecialName]
		public static bool _0024GW(SerializedDateTime _1, DateTime _1)
		{
			return false;
		}

		[SpecialName]
		public static bool _0024hW(DateTime _1, SerializedDateTime _1)
		{
			return false;
		}

		[SpecialName]
		public static bool _0024HW(DateTime _1, SerializedDateTime _1)
		{
			return false;
		}

		[SpecialName]
		public static bool _0024iW(DateTime _1, SerializedDateTime _1)
		{
			return false;
		}

		[SpecialName]
		public static bool _0024IW(DateTime _1, SerializedDateTime _1)
		{
			return false;
		}

		[SpecialName]
		public static bool _0024jW(DateTime _1, SerializedDateTime _1)
		{
			return false;
		}

		[SpecialName]
		public static bool _0024JW(DateTime _1, SerializedDateTime _1)
		{
			return false;
		}

		[SpecialName]
		public static SerializedDateTime _0024kW(SerializedDateTime _1, TimeSpan _1)
		{
			return null;
		}

		[SpecialName]
		public static SerializedDateTime _0024KW(SerializedDateTime _1, TimeSpan _1)
		{
			return null;
		}

		[SpecialName]
		public static TimeSpan _0024lW(SerializedDateTime _1, SerializedDateTime _1)
		{
			return default;
		}

		[SpecialName]
		public static TimeSpan _0024LW(SerializedDateTime _1, DateTime _1)
		{
			return default;
		}

		[SpecialName]
		public static TimeSpan _0024mW(DateTime _1, SerializedDateTime _1)
		{
			return default;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
