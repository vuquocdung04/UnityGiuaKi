using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeScore : CircleScore
{
    protected override void OnTriggerEnter2D()
    {
        ObserverManager<int>.Notify(ObserverEnum.Score, this.CircleCtrl.CircleSO.GetCircleList(Circle.Orange).score);
        base.OnTriggerEnter2D();
    }
}
