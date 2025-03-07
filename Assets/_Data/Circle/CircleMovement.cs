using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CircleMovement : LoadAutoComponents
{
    [SerializeField] protected CircleCtrl circleCtrl;
    public CircleCtrl CircleCtrl => circleCtrl;


    private void Update()
    {
        this.transform.parent.Translate(Vector2.down * SetSpeed() * Time.deltaTime);
    }

    protected abstract float SetSpeed();
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCircleCtrl();
    }


    protected virtual void LoadCircleCtrl()
    {
        if (circleCtrl != null) return;
        this.circleCtrl = GetComponentInParent<CircleCtrl>();
        Debug.LogWarning(transform.name + "LoadCircleCtrl");
    }


}
