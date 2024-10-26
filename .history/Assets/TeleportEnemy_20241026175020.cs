using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportEnemy : MonoBehaviour
{
    public GameObject Bullet;
    private float attacktime = 1f;
    private float time;
    public int Health = 3;
    public Vector3 WorldSize;
    public float PlayerLenght;

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
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Teleport()
    {
        WorldSize = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,0)) + new Vector3(-PlayerLenght,-PlayerLenght,0);
        transform.position = new Vector2(UnityEngine.Random.Range(-WorldSize.x,WorldSize.x), UnityEngine.Random.Range(-WorldSize.y,WorldSize.y));
    }
}
