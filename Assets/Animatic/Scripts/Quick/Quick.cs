using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Animatic;

namespace Animatic.Quick
{
    public static class Quick
    {
        public static AnimationQueue MoveTo(this AnimationQueue queue, Vector3 targetPosition, float duration = 1)
        {
            Transform ownerTransform = queue.owner.transform;
            Vector3 startPosition = ownerTransform.position;
			queue.Animate(t => ownerTransform.position = Vector3.Lerp(startPosition, targetPosition, t), duration);
            return queue;
        }

		public static AnimationQueue ScaleTo(this AnimationQueue queue, float targetscale, float duration = 1)
		{
			Transform ownerTransform = queue.owner.transform;
			Vector3 startScale = ownerTransform.localScale;
			Vector3 endScale = Vector3.one * targetscale;
			queue.Animate(t => ownerTransform.localScale = Vector3.Lerp(startScale, endScale, t), duration);
			return queue;
		}
	}
}