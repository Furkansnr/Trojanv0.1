using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSetter : MonoBehaviour
{
    public GameObject LeftWall, RightWall, UpWall, DownWall;
    public Vector3 WorldSize;

    private void Start()
    {
        WorldSize = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,0));

        LeftWall.transform.position = new Vector3(-WorldSize.x,transform.position.y,10);
        RightWall.transform.position = new Vector3(WorldSize.x,transform.position.y,10);
        UpWall.transform.position = new Vector3(transform.position.x,WorldSize.y,10);
        DownWall.transform.position = new Vector3(transform.position.x,-WorldSize.y,10);
    }
}
