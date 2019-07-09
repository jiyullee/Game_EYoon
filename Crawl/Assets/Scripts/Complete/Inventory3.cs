﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Inventory3 : Singleton<Inventory3>
{
    public Sprite inventoryImage;
    public int armorLevel=0;
   
    public void InsertItem(Sprite itemImage, int level)
    {
        if (level > armorLevel)
        {
            GetComponent<Image>().sprite = itemImage;
            armorLevel = level;
        }
        
    }
}