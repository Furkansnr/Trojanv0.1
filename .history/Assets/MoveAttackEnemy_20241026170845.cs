using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAttackEnemy : MonoBehaviour
{
    public GameObject Bullet;
    private float attacktime = 1f;

    private float movetime = 1f;
    private float attacktimer;
    private float movetimer;

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

        if (attacktimer > attacktime)
        {
            Instantiate(Bullet,transform.position, Quaternion.identity);
            attacktime = UnityEngine.Random.Range(1f,5f);
            attacktimer = 0f;
        }
    }


}