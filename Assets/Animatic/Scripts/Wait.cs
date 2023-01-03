using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Animatic
{
    public class Wait : AnimationElement
    {
		public Func<bool> predicate;
		public override IEnumerator Animation()
		{
			yield return new WaitWhile(predicate);
		}
	}

	public static class WaitCall
	{
		public static AnimationQueue Wait(this AnimationQueue queue, Func<bool> predicate)
		{
			Wait wait = new Wait();
			wait.predicate = predicate;

			queue.queue.Enqueue(wait);

			return queue;
		}
	}
}