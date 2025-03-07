using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleCtrl : LoadAutoComponents
{
    [SerializeField] protected CircleSO circleSO;
    public CircleSO CircleSO => circleSO;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCircleSO();
    }

    protected virtual void LoadCircleSO()
    {
        if (circleSO != null) return;
        this.circleSO = Resources.Load<CircleSO>("Circle/Circle");
    }
}
