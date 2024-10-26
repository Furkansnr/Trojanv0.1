using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAttackHardDeleteEnemy : MonoBehaviour
{
    public GameObject Bullet;
    private float attacktime = 1f;
    public Rigidbody2D rb;
    private float movetime = 1f;
    private float attacktimer;
    private float movetimer;
    private float deletetimer;
    private float X,Y;
    private Vector2 MoveVector;
    public bool DeleteStarted = false;

    private void Update()
    {
        float timer = Time.deltaTime;
        attacktimer += timer;
        movetimer += timer;

        if (attacktimer > attacktime)
        {
            Instantiate(Bullet,transform.position, Quaternion.identity);
            attacktime = UnityEngine.Random.Range(1f,5f);
            attacktimer = 0f;
        }

        if (movetimer > movetime)
        {
            X = UnityEngine.Random.Range(-1f,1f);
            Y = UnityEngine.Random.Range(-1f,1f);
            MoveVector = new Vector2(X,Y).normalized;
            movetime = UnityEngine.Random.Range(3f,5f);
            movetimer = 0f;
        }

        if (DeleteStarted == true)
        {
            deletetimer += timer;
            attacktimer = 0;
            if(deletetimer > 2f)
            {
                Destroy(gameObject);
            }
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

        if(other.gameObject.name == "Player")
        {
            DeleteStarted = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.name == "Player")
        {
            DeleteStarted = false;
        }
    }
}
