using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoMoveBeamAttackEnemy : MonoBehaviour
{
    public Vector2 Point;
    public Rigidbody2D rb;
    public float speed = 10f;
    public float Angle = 360;

    private void Update()
    {
    
    }

    private void FixedUpdate()
    {
        rb.MoveRotation(Angle * Time.fixedDeltaTime);
    }
}
