﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    Transform target;
    public GameObject service;
    public float dist;
    float x;
    float y;
    float z;

    void Start()
    {     
        x = transform.position.x;
        z = transform.position.z;
    }
    void LateUpdate()
    {
        target = service.GetComponent<LevelManager>().player.transform;
        y = target.position.y - dist;
        transform.position = new Vector3(x, y, z);                                   
    }
}
