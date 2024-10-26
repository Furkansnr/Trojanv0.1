using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class NoMoveAttackEnemy : MonoBehaviour
{
    public GameObject Bullet;
    private float attacktime = 1f;
    private float time;

    private void Update()
    {
        float timer = Time.deltaTime;
        time += timer;

        if (time > attacktime)
        {
            Instantiate(Bullet,transform.position, Quaternion.identity);
            attacktime = UnityEngine.Random.Range(1f,5f);
            time = 0f;
        }
    }
}
