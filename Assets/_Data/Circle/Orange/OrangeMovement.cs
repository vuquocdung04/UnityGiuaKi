using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeMovement : CircleMovement
{
    protected override float SetSpeed()
    {
        return CircleCtrl.CircleSO.GetCircleList(Circle.Orange).speed;
    }
}
