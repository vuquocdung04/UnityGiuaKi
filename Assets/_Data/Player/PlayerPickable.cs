using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(BoxCollider2D))]

public class PlayerPickable : LoadAutoComponents
{

    [SerializeField] protected BoxCollider2D boxCollider2D;
    public BoxCollider2D BoxCollider => boxCollider2D;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCollider();
    }

    protected virtual void LoadCollider()
    {
        if (boxCollider2D != null) return;
        this.boxCollider2D = GetComponent<BoxCollider2D>();
        this.boxCollider2D.isTrigger = true;
        Debug.LogWarning(transform.name + "LoadCollider");
    }
}
