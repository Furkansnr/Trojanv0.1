using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor.Tilemaps;
using UnityEngine;

public class NoMoveBeamAttackEnemy : MonoBehaviour
{
    public Vector2 Point;
    public Rigidbody2D rb;
    public float rotationSpeed = 10f;

     private void Update()
    {
        if(UnityEngine.Random.RandomRange(0,100) <= 1)
        {
            rotationSpeed*=-1;
        }
    }

    private void FixedUpdate()
    {
        rb.rotation += rotationSpeed;
    }
}
