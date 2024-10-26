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

        }
        if(other.gameObject.name == "Right")
        {

        }
        if(other.gameObject.name == "Up")
        {

        }
        if(other.gameObject.name == "Down")
        {

        }
    }
}
