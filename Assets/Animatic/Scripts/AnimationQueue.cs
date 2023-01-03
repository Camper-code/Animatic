using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Animatic
{
    public class AnimationQueue
    {
        public MonoBehaviour owner;
		public Queue<AnimationElement> queue = new Queue<AnimationElement>();
        
        public IEnumerator Animation()
        {
            yield return null;
            while (queue.TryDequeue(out AnimationElement element))
            {
                yield return element.Animation();
            }
        }
    }

    static class AnimationQueueCall
    {
		static public AnimationQueue Queue(this MonoBehaviour owner)
		{
            AnimationQueue queue = new AnimationQueue();
            queue.owner = owner;
			owner.StartCoroutine(queue.Animation());
			return queue;
		}
	}
}
