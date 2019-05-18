﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class getItem : MonoBehaviour
{
    Text hp;
    int temp;
    Image playerHp;
    string[] item = { "NewBullet", "Healtem" };
    private void OnTriggerEnter2D(Collider2D collider)
    {
        int i;
        for (i = 0; i < item.Length; i++)
        {
            if (collider.gameObject.name == item[i])
                break;
        }
        switch (i)
        {
            case 0:
                Bullet(collider.gameObject);
                break;
            case 1:
                Heal(collider.gameObject); 
                break;
        }

        Debug.Log(1);
    }

    
    void Bullet(GameObject gameObject)
    {
        temp = gameObject.GetComponent<UI>().temp + 3;
        gameObject.GetComponent<UI>().NOBullet.text = temp.ToString();
        Destroy(gameObject);
    }
    void Heal(GameObject gameObject)
    {
        temp = int.Parse(gameObject.GetComponent<UI>().HPValue.text) + 20;
        gameObject.GetComponent<UI>().HPValue.text = temp.ToString();
        gameObject.GetComponent<Health>().HP.fillAmount = (float)temp / 100;
        Destroy(gameObject);
    }
}
