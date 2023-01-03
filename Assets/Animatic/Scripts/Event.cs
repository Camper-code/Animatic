using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Animatic
{
    public class Event : AnimationElement
    {
        public Action @event;
		public override IEnumerator Animation()
		{
			@event.Invoke();
			yield return null;
		}
	}

	public static class EventCall
	{
		public static AnimationQueue Event(this AnimationQueue queue, Action @event)
		{
			Event @eventInstance = new Event();
			eventInstance.@event = @event;

			queue.queue.Enqueue(@eventInstance);

			return queue;
		}
	}
}