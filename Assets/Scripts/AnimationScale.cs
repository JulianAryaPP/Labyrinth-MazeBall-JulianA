using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Animation Scale", menuName ="Custom Asset/Animation/Scale")]
public class AnimationScale : BaseAnimation
{
    public override void Animate(Transform visual)
    {
        base.Animate(visual);
        visual.parent.DOScale(1.2f,base.duration).SetLoops(-1,LoopType.Yoyo);
    }
}
