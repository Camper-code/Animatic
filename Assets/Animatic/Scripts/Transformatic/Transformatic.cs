using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Animatic.Transformatic
{
	static class Transformatic
	{
		public static void SetX(this Transform transform, float value)
		{
			Vector3 pos = transform.position;
			pos.x = value;
			transform.position = pos;
		}

		public static void SetY(this Transform transform, float value)
		{
			Vector3 pos = transform.position;
			pos.y = value;
			transform.position = pos;
		}

		public static void SetZ(this Transform transform, float value)
		{
			Vector3 pos = transform.position;
			pos.z = value;
			transform.position = pos;
		}

		public static void SetLocalX(this Transform transform, float value)
		{
			Vector3 pos = transform.localPosition;
			pos.x = value;
			transform.localPosition = pos;
		}

		public static void SetLocalY(this Transform transform, float value)
		{
			Vector3 pos = transform.localPosition;
			pos.y = value;
			transform.localPosition = pos;
		}

		public static void SetLocalZ(this Transform transform, float value)
		{
			Vector3 pos = transform.localPosition;
			pos.z = value;
			transform.localPosition = pos;
		}

		public static void SetScale(this Transform transform, float scale)
		{
			transform.localScale = Vector3.one * scale;
		}
	}
}