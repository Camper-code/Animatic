using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Animatic
{
    public class AnimationElement
    {
        public virtual IEnumerator Animation()
        {
            yield return null;
        }
    }
}