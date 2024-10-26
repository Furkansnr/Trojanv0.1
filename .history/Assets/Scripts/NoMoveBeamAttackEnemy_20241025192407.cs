using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class NoMoveBeamAttackEnemy : MonoBehaviour
{
    public Vector2 Point;
    public Rigidbody2D rb;
    public float rotationSpeed = 10f;

    private void Update()
    {
    
    }

    private void FixedUpdate()
    {
        rb.rotation += Rotationspeed;
    }
}
