﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorLv1 : Item
{
    public override void Function()
    {
        Inventory3.Instance.InsertItem(itemImage, 1);
        player.GetComponent<Ability>().armor = 10;
    }
   
}
