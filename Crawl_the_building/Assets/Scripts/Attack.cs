﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Vector3 mousePosition;
    public Transform firePosition;
    [SerializeField]
    Camera Camera;
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject windowBullet;
    GameObject target;
    Transform bulletPosition;
    [SerializeField] int speed;
    
    void Update()

    {
        if (Input.GetMouseButtonDown(0))
        {
            CastRay();
        }
    
    }



    void CastRay() 

    {
        target = null;
       

        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 10f);
        
        if (hit.collider != null)
        {

            target = hit.collider.gameObject;
            
            if (target.tag == "Window" && target.GetComponent<SpriteRenderer>().sortingOrder == 2)
            {
                target.tag = "targetWindow";
                Debug.Log(target.tag);
                windowAttack();
            }
            else
                attack();
            Debug.Log(target.name);
        }
       

    }


   void attack()
    {
        
        mousePosition = Camera.ScreenToWorldPoint(Input.mousePosition);
        float dx = mousePosition.x - transform.position.x;
        float dy = mousePosition.y - transform.position.y;
        float angle = Mathf.Atan2(dx, dy) * Mathf.Rad2Deg;
        Quaternion Rotation = Quaternion.Euler(new Vector3(0, 0, -angle));
        Instantiate(bullet, firePosition.position, Rotation);
       
    }
    void windowAttack()
    {
        mousePosition = Camera.ScreenToWorldPoint(Input.mousePosition);
        float dx = mousePosition.x - transform.position.x;
        float dy = mousePosition.y - transform.position.y;
        float angle = Mathf.Atan2(dx, dy) * Mathf.Rad2Deg;
        Quaternion Rotation = Quaternion.Euler(new Vector3(0, 0, -angle));
        Instantiate(windowBullet, firePosition.position, Rotation);
    }


}