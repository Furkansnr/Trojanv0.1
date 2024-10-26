using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public Vector3 WorldSize;
    public float PlayerLenght;

    private void Update()
    {
        WorldSize = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,0)) + new Vector3(-PlayerLenght,-PlayerLenght,0);
    }
}
