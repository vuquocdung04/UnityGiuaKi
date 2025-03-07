using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Circle{
    
    None = 0,
    Green = 1,
    Blue = 2,
    Orange =3,
}


[CreateAssetMenu(menuName = "CircleSO/Properties")]
public class CircleSO : ScriptableObject
{
    [SerializeField] protected List<CircleList> circleList;

    public CircleList GetCircleList(Circle circleType)
    {
        return circleList.Find(circle => circle.circle == circleType);
    }
}

[System.Serializable]
public class CircleList
{
    public Circle circle;
    public float speed;
    public int score;
}
