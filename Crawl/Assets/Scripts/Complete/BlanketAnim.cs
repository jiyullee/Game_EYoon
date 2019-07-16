﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlanketAnim : MonoBehaviour
{

    public float lifeTime = 5.0f;
    public GameObject dark;
    public GameObject black;
    private void OnEnable()
    {
        StartCoroutine(DestroySelf());
    }

    public IEnumerator DestroySelf()
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }

 
 
 

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            InputManager.Instance.isReverse = true;

            InputManager.Instance.ChangeSideMove();

        }
    }
  
}
