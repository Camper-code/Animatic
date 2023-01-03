using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Animatic
{
    public class Animate : AnimationElement
    {
        public Action<float> animator;
		public float duration;
		public override IEnumerator Animation()
		{
			for(float t = 0; t <= 1; t += Time.deltaTime / duration)
			{
				animator.Invoke(t);
				yield return null;
			}
			animator.Invoke(1);
		}
	}

	public static class AnimateCall
	{
		public static AnimationQueue Animate(this MonoBehaviour owner, Action<float> animator, float duration = 1)
		{
			return owner.Queue().Animate(animator, duration);
		}

		public static AnimationQueue Animate(this AnimationQueue queue, Action<float> animator, float duration = 1)
		{
			Animate animate = new Animate();
			animate.animator = animator;
			animate.duration = duration;

			queue.queue.Enqueue(animate);

			return queue;
		}
	}
}