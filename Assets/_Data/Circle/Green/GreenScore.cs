using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenScore : CircleScore
{
    protected override void OnTriggerEnter2D()
    {
        ObserverManager<int>.Notify(ObserverEnum.Score, this.CircleCtrl.CircleSO.GetCircleList(Circle.Green).score);
        base.OnTriggerEnter2D();
    }
}
