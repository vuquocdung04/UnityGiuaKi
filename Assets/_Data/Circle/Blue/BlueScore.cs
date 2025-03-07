using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueScore : CircleScore
{
    protected override void OnTriggerEnter2D()
    {
        ObserverManager<int>.Notify(ObserverEnum.Score, this.CircleCtrl.CircleSO.GetCircleList(Circle.Blue).score);
        base.OnTriggerEnter2D();
    }
}
