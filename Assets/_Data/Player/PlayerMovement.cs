using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : LoadAutoComponents
{
    [SerializeField] protected float speed = 10f;

    [SerializeField] protected PlayerCtrl playerCtrl;


    private void Update()
    {
        if (Input.GetKey(KeyCode.A)) playerCtrl.Rigi.velocity = Vector2.left * speed;
        else if (Input.GetKey(KeyCode.D)) playerCtrl.Rigi.velocity = Vector2.right * speed;
        else playerCtrl.Rigi.velocity = Vector2.zero;
    }


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPlayerCtrl();
    }

    protected virtual void LoadPlayerCtrl()
    {
        if (playerCtrl != null) return;
        this.playerCtrl = GetComponentInParent<PlayerCtrl>();
        Debug.LogWarning(transform.name + "LoadPlayerCtrl");
    }



}
