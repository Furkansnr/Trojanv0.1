using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void Awake()
    {
        Mathf.Atan2(transform.position, GameObject.FindWithTag("Player").transform.position);
    }
}
