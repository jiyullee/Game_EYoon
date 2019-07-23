﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    GameObject target;
    public GameObject service;
    public float xDistance;
    public float yDistance;
    float x;
    float y;
    float z;

    void Start()
    {
        target = service.GetComponent<LevelManager>().player;
        x = transform.position.x;
        z = transform.position.z;
    }
    void LateUpdate()
    {
        if (360 - target.transform.position.x < 42 && 360- target.transform.position.x > -42)
        {
            
            y = target.transform.position.y - yDistance;
        }
        else
        {
            x = target.transform.position.x - xDistance;
            y = target.transform.position.y - yDistance;
        }
        transform.position = new Vector3(x, y, z);                                   
    }
}
