﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorLv2 : Item
{

    public override void Function()
    {
        Inventory3.Instance.InsertItem(itemImage , 2);
        player.GetComponent<Ability>().armor = 10;
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player" )
        {
            Function();
            
        }

    }
}