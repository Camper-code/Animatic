using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Animatic
{
    public class Pause : AnimationElement
    {
		public float duration;
		public override IEnumerator Animation()
		{
			yield return new WaitForSeconds(duration);
		}
	}

	public static class PauseCall
	{
		public static AnimationQueue Pause(this AnimationQueue queue, float duration)
		{
			Pause pause = new Pause();
			pause.duration = duration;

			queue.queue.Enqueue(pause);

			return queue;
		}
	}
}