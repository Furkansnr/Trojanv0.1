using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowEnemy : MonoBehaviour
{
    public GameObject Player;
    public GameObject Bullet;
    public Rigidbody2D rb;
    private float movetime = 1f;
    private float movetimer;
    private Vector2 MoveVector;
    public Vector3 WorldSize;
    public float PlayerLenght;

    private void Awake()
    {
        Player = GameObject.FindWithTag("Player");
    }

    private void Update()
    {
        float timer = Time.deltaTime;
        movetimer += timer;

        if (movetimer > movetime)
        {
            MoveVector = new Vector2(Player.transform.position.x,Player.transform.position.y);
            movetime = UnityEngine.Random.Range(3f,5f);
            movetimer = 0f;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = MoveVector.normalized;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Left")
        {
            MoveVector = new Vector2(-rb.velocity.x, rb.velocity.y);
        }
        if(other.gameObject.name == "Right")
        {
            MoveVector = new Vector2(-rb.velocity.x, rb.velocity.y);
        }
        if(other.gameObject.name == "Up")
        {
            MoveVector = new Vector2(rb.velocity.x, -rb.velocity.y);
        }
        if(other.gameObject.name == "Down")
        {
            MoveVector = new Vector2(rb.velocity.x, -rb.velocity.y);
        }
    }
}
