using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] PlayerInputs _inputs;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float moveSpeed = 5f;

    private int Health = 5;
    
    private void FixedUpdate()
    {
        _rigidbody2D.velocity = new Vector2(_inputs.moveInput.x * moveSpeed,_inputs.moveInput.y * moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("NoMoveNoAttackEnemy"))
        {
            Destroy(other.gameObject);
        }
        if (other.CompareTag("NoMoveAttackEnemy"))
        {
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Bullet"))
        {
            Health--;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Beam"))
        {
            Health--;
            Destroy(other.gameObject);
        }
    }
}
