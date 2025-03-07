using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenMovement : CircleMovement
{
    protected override float SetSpeed()
    {
        return CircleCtrl.CircleSO.GetCircleList(Circle.Green).speed;
    }

}
