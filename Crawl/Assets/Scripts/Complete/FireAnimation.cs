﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAnimation : MonoBehaviour
{
    public GameObject fire;
    public GameObject bullet;
    float hp;
    public float decrease;
    float armor;
    float maxArmor;
    GameObject player;
    float bulletDamage;
    public float lifeTime = 5.0f;

    private void OnEnable()
    {
        StartCoroutine(DestroySelf());
    }

    public IEnumerator DestroySelf()
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        maxArmor = player.GetComponent<Ability>().maxArmor;
        armor = player.GetComponent<Ability>().armor;       
        decrease = decrease * (1 - (armor / maxArmor));           
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {        
        if (collider.gameObject.tag == "Player")
        {                     
                Function();                               
        }
        
    }

    void Function()
    {              
        player.GetComponent<Health>().hp -= (int)decrease;
        StartCoroutine(Damage());
    }

    IEnumerator Damage()
    {            
        for(int i = 0; i < 5; i++)
        {
            player.GetComponent<Health>().hp -= (int)decrease;
            yield return new WaitForSeconds(1.0f);
        }       
    }
   
}