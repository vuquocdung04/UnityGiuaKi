using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawner : LoadAutoComponents
{
    [SerializeField] protected Transform PoolHolders;
    [SerializeField] protected float timeSpawn = 0.5f;
    [SerializeField] protected List<CircleCtrl> circleCtrls;
    
    private void Start()
    {
        InvokeRepeating(nameof(Spawn), timeSpawn, timeSpawn);
    }

    protected virtual CircleCtrl Spawn()
    {
        int rand = Random.Range(0, circleCtrls.Count);
        CircleCtrl newObj = SimplePool2.Spawn(circleCtrls[rand], new Vector2(Random.Range(-8,8),6),Quaternion.identity);
        newObj.transform.SetParent(this.PoolHolders);
        newObj.gameObject.SetActive(true);
        return newObj;
    }


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadListCtrl();
        this.LoadPoolHolders();
    }

    protected virtual void LoadPoolHolders()
    {
        if (this.PoolHolders != null) return;
        this.PoolHolders = transform.Find("PoolHolders");

        if(this.PoolHolders == null)
        {
            this.PoolHolders = new GameObject("PoolHolders").transform;
            this.PoolHolders.SetParent(this.transform);
        }

        Debug.LogWarning(transform.name + " LoadPoolHolders");
    }
    protected virtual void LoadListCtrl()
    {
        if (this.circleCtrls.Count > 0 ) return;
        CircleCtrl[] circle = GetComponentsInChildren<CircleCtrl>();
        this.circleCtrls = new List<CircleCtrl>(circle);

        this.HidePrefabs();
        Debug.LogWarning(transform.name + "LoadListCtrl");
    }

    protected virtual void HidePrefabs()
    {
        foreach (var child in this.circleCtrls)
        {
            child.gameObject.SetActive(false);
        }
    }
}
