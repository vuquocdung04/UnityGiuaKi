using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleDespawn : LoadAutoComponents
{
    [SerializeField] protected float timeLife = 4f;
    [SerializeField] protected float currentTime = 4;

    private void OnDisable()
    {
        this.currentTime = this.timeLife;
    }

    private void FixedUpdate()
    {
        currentTime -= Time.fixedDeltaTime;
        if (currentTime < 0)
        {
            SimplePool2.Despawn(this.transform.parent.gameObject);
            this.currentTime = this.timeLife;
        }
    }
}
