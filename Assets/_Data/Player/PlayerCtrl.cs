using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerCtrl : LoadAutoComponents
{
    [SerializeField] protected Rigidbody2D _rigi;
    public Rigidbody2D Rigi => _rigi;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadRigi();
    }
    protected virtual void LoadRigi()
    {
        if (_rigi != null) return;
        this._rigi = GetComponent<Rigidbody2D>();
        this._rigi.isKinematic = true;

        Debug.LogWarning(transform.name + "LoadRigi");
    }
}
