using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSpawnEnemy : MonoBehaviour
{
    public Vector3 WorldSize;
    public float PlayerLenght;
    public GameObject[] Enemy;
    public float SpawnDistance;

    private void Awake()
    {
        WorldSize = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,0)) + new Vector3(-PlayerLenght,-PlayerLenght,0);
        StartCoroutine(enumerator());
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            
            Instantiate(Enemy[UnityEngine.Random.Range(0,Enemy.Length-1)], transform.position + new Vector3(1.4f,0,0)),Quaternion.identity);
        }
    }
}