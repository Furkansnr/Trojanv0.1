using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSpawnEnemy : MonoBehaviour
{
    public GameObject[] Enemy;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            int a = UnityEngine.Random.Range(0,3);
            if(a == 0)
            {
                Instantiate(Enemy[UnityEngine.Random.Range(0,Enemy.Length-1)], transform.position + new Vector3(1.4f,0,0),Quaternion.identity);
            }
            else if(a == 1)
            {
                Instantiate(Enemy[UnityEngine.Random.Range(0,Enemy.Length-1)], transform.position + new Vector3(1.4f,0,0),Quaternion.identity);
                Instantiate(Enemy[UnityEngine.Random.Range(0,Enemy.Length-1)], transform.position + new Vector3(-1.4f,0,0),Quaternion.identity);
            }
            else if(a == 2)
            {
                Instantiate(Enemy[UnityEngine.Random.Range(0,Enemy.Length-1)], transform.position + new Vector3(1.4f,0,0),Quaternion.identity);
                Instantiate(Enemy[UnityEngine.Random.Range(0,Enemy.Length-1)], transform.position + new Vector3(-1,-1,0),Quaternion.identity);
                Instantiate(Enemy[UnityEngine.Random.Range(0,Enemy.Length-1)], transform.position + new Vector3(+1,-1,0),Quaternion.identity);
            }
            Destroy(gameObject);
        }
    }
}
