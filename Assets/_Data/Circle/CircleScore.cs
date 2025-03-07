using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]

public abstract class CircleScore : LoadAutoComponents
{
    [SerializeField] protected CircleCollider2D circleCollider2D;
    public CircleCollider2D CircleCollider2D => circleCollider2D;

    [SerializeField] protected CircleCtrl circleCtrl;
    public CircleCtrl CircleCtrl => circleCtrl;
    protected virtual void OnTriggerEnter2D() {
        SimplePool2.Despawn(this.transform.parent.gameObject);
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCircleCtrl();
        this.LoadCollider();
    }
    protected virtual void LoadCollider()
    {
        if (circleCollider2D != null) return;
        this.circleCollider2D = GetComponent<CircleCollider2D>();
        this.circleCollider2D.isTrigger = true;
        Debug.LogWarning(transform.name + "LoadCollider");
    }
    protected virtual void LoadCircleCtrl()
    {
        if (circleCtrl != null) return;
        this.circleCtrl = GetComponentInParent<CircleCtrl>();
        Debug.LogWarning(transform.name + "LoadCircleCtrl");
    }
}
