using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlexibleEnemy : MonoBehaviour
{
    public Rigidbody2D rb;

    private void Start()
    {
        rb.velocity = new Vector2(UnityEngine.Random.Range(-1f,1f), UnityEngine.Random.Range(-1f,1f));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Left")
        {
            rb.velocity = new Vector2(-rb.velocity.x, rb.velocity.y);
        }
        if(other.gameObject.name == "Right")
        {
            rb.velocity = new Vector2(-rb.velocity.x, rb.velocity.y);
        }
        if(other.gameObject.name == "Up")
        {
            rb.velocity = new Vector2(rb.velocity.x, -rb.velocity.y);
        }
        if(other.gameObject.name == "Down")
        {
            rb.velocity = new Vector2(rb.velocity.x, -rb.velocity.y);
        }
    }
}
