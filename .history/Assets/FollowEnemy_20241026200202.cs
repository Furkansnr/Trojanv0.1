using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowEnemy : MonoBehaviour
{
    public GameObject Player;
    public GameObject Bullet;
    private float attacktime = 1f;

    public Rigidbody2D rb;

    private float movetime = 1f;
    private float attacktimer;
    private float movetimer;

    private float X,Y;

    private Vector2 MoveVector;

    public Vector3 WorldSize;
    public float PlayerLenght;

    private void Awake()
    {
        
    }

    private void Update()
    {
        float timer = Time.deltaTime;
        movetimer += timer;

        if (movetimer > movetime)
        {
            X = UnityEngine.Random.Range(-1f,1f);
            Y = UnityEngine.Random.Range(-1f,1f);
            MoveVector = new Vector2(X,Y).normalized;
            movetime = UnityEngine.Random.Range(3f,5f);
            movetimer = 0f;
        }
    }
}
