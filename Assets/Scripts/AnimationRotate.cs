using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[CreateAssetMenu(fileName = "Animation Scale", menuName = "Custom Asset/Animation/Rotate")]
public class AnimationRotate : BaseAnimation
{
    public override void Animate(Transform visual)
    {
        base.Animate(visual);
        var seq = DOTween.Sequence();
        seq.Append(visual.DOLocalRotate(new Vector3(visual.eulerAngles.x, 180, 0), base.duration/2));
        seq.Append(visual.DOLocalRotate(new Vector3(visual.eulerAngles.x, 360, 0), base.duration/2));
        seq.SetLoops(-1);
    }
}
