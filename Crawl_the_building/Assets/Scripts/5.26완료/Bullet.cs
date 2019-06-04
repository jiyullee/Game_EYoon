﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public GameObject target;
    public int damage;
    WindowHP windowhp;
    
    void Update()
    {
        transform.Translate(Vector3.up * speed);
    }

    public void ReferenceTarget(GameObject obj){
        target = obj;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        windowhp = target.GetComponent<WindowHP>();
        if (collider.gameObject == target)
        {
            windowhp.HP -= damage;
            windowhp.hpImage.fillAmount = windowhp.HP / windowhp.maxHP;
            Destroy(gameObject);
            windowhp.ChangeWindow();
        }
    }

}
