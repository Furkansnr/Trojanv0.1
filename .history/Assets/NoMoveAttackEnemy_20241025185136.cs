using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoMoveAttackEnemy : MonoBehaviour
{
    public GameObject Bullet;
    private float attacktime;
    private float time;

    private void Update()
    {
        float timer = Time.deltaTime;
        time += timer;

        if (time > attacktime)
        {
            Instantiate(Bullet,transform.position,Quaternion.identity);  
        }
    }
}
