﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorLv5 : Item
{
   
    public override void Function()
    {
        Inventory3.Instance.InsertItem(itemImage, 5);
        player.GetComponent<Ability>().armor = 10;
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Function();
            Destroy(gameObject);
        }

    }
}
