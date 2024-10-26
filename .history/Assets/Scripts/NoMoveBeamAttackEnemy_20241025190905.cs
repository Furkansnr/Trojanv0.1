using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoMoveBeamAttackEnemy : MonoBehaviour
{
    public Vector2 Point;

    private void Awake()
    {
        Point = transform.position - GameObject.FindWithTag("Player").transform.position;
    }
}
