using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] PlayerInputs _inputs;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float moveSpeed = 5f;  
    
    private void FixedUpdate()
    {
        Vector2 moveDir = new Vector2(_inputs.moveInput.x, _inputs.moveInput.y);
        _rigidbody2D.velocity = moveDir * moveSpeed * Time.deltaTime;
    }
}
