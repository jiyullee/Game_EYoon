﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Copper : Item
{
    static int count = 0;
    static int maxCount = 100;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            IncreaseCount(get_jewerly_multiple);
            UIManager.Instance.SetCount(1, count);
            Destroy(gameObject);
        }
    }
    public override int GetCount()
    {
        return count;
    }
    public override int GetMaxCount()
    {
        return maxCount;
    }
    public override void SetMaxCount(int n)
    {
        maxCount = n;
    }
    public override void DecreaseMaxCount(int n)
    {
        maxCount -= n;
        if (maxCount <= 1)
            maxCount = 1;
    }
    public override void IncreaseMaxCount(int n)
    {
        maxCount += n;
    }
    public override void IncreaseCount(int n)
    {
        count += n;
        if(count >= maxCount)
        {
            UIManager.Instance.OnSkillUI(0);
            count -= maxCount;
        }
        
    }
    public override void ResetCount()
    {
        count = 0;
    }
}
