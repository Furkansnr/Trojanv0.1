using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSetter : MonoBehaviour
{
    public GameObject LeftWall, RightWall, UpWall, DownWall;
    public Vector3 WorldSize;
    public float PlayerLenght;

    private void Start()
    {
        WorldSize = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,0)) + new Vector3(-PlayerLenght,-PlayerLenght,0);

        LeftWall.transform.position = new Vector3(-WorldSize.x,transform.position.y,transform.position.z);
        RightWall.transform.position = new Vector3(WorldSize.x,transform.position.y,transform.position.z);
    }
}
