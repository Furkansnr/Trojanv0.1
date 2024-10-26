using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector2 Point;
    public Rigidbody2D rb;
    public float speed = 10f;

    private void Awake()
    {
        Point = transform.position - GameObject.FindWithTag("Player").transform.position;
    }

    private void Update()
    {
        if(Random.RandomRange(0,100) <= 10)
        {
            speed*=-1;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = -Point.normalized * speed;
    }
}
