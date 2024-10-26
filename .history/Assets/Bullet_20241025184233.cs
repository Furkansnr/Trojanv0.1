using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector2 Point;
    public Rigidbody2D rb;

    private void Awake()
    {
        Point = transform.position - GameObject.FindWithTag("Player").transform.position;
    }

    private void FixedUpdate() {
        rb.velocity = Point.normalized;
    }
}
