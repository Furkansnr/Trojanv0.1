using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSpawnEnemy : MonoBehaviour
{
    public Vector3 WorldSize;
    public float PlayerLenght;
    public GameObject[] Enemy;

    private void Awake()
    {
        WorldSize = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,0)) + new Vector3(-PlayerLenght,-PlayerLenght,0);
        StartCoroutine(enumerator());
    }

    public IEnumerator enumerator()
    {
        Instantiate(Enemy[UnityEngine.Random.Range(0,Enemy.Length-1)], new Vector2(UnityEngine.Random.Range(-WorldSize.x,WorldSize.x), UnityEngine.Random.Range(-WorldSize.y,WorldSize.y)),quaternion.identity);
        yield return new WaitForSecondsRealtime(5f);
        StartCoroutine(enumerator());
    }
}
