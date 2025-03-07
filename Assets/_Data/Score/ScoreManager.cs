using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : LoadAutoComponents
{
    [SerializeField] protected TMP_Text textScore;
    int scoreCount;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadTMP();
    }
    protected virtual void LoadTMP()
    {
        if (textScore != null) return;
        this.textScore = GetComponentInChildren<TMP_Text>();
        Debug.LogWarning(transform.name + "LoadTMP");
    }
    protected void Start()
    {
        ObserverManager<int>.AddObserver(ObserverEnum.Score, UpdateSore);
    }

    public void UpdateSore(int score)
    {
        scoreCount += score;
        this.textScore.text = scoreCount.ToString();
    }
}
