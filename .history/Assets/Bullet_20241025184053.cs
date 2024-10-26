using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Vector2 Point;

    private void Awake()
    {
        Point = transform.position - GameObject.FindWithTag("Player").transform.position;
    }
}
