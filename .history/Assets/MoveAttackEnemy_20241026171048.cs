using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAttackEnemy : MonoBehaviour
{
    public GameObject Bullet;
    private float attacktime = 1f;

    public Rigidbody2D rb;

    private float movetime = 1f;
    private float attacktimer;
    private float movetimer;

    private float X,Y;

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
            X = UnityEngine.Random.Range(3f,5f);
            movetime = UnityEngine.Random.Range(3f,5f);
            movetimer = 0f;
        }
    }


}
