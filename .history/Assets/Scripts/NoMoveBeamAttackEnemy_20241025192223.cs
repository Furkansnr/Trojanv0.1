using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class NoMoveBeamAttackEnemy : MonoBehaviour
{
    public Vector2 Point;
    public Rigidbody2D rb;
    public float speed = 10f;

    private void Update()
    {
    
    }

    private void FixedUpdate()
    {
        Quaternion myRotation = Quaternion.identity;
        myRotation.eulerAngles += new Vector3(0,0,90);
        rb.rotation +=
    }
}
