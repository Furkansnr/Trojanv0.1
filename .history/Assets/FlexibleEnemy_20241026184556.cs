using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlexibleEnemy : MonoBehaviour
{
    public Rigidbody2D rb;

    private void Awake()
    {
        rb.velocity = new Vector2(UnityEngine.Random.Range(-1f,1f), UnityEngine.Random.Range(-1f,1f));
    }
}
