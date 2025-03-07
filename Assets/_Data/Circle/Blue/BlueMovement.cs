using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueMovement : CircleMovement
{
    protected override float SetSpeed()
    {
        return CircleCtrl.CircleSO.GetCircleList(Circle.Blue).speed;
    }
}
