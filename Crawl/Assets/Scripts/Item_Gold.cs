﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Gold : Item
{
    static int count = 0;
    protected int maxCount = 10;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            IncreaseCount(get_jewerly_multiple);
            UIManager.Instance.SetCount(3, count);
            Destroy(gameObject);
        }
    }
    public override int GetCount()
    {
        return count;
    }

    public override void IncreaseCount(int n)
    {
        count += n;
        if (count >= maxCount)
        {
            UIManager.Instance.OnSkillUI(2);
            count -= maxCount;
        }
        
    }
    public override void ResetCount()
    {
        count = 0;
    }
    public override void DecreaseMaxCount(int n)
    {
        maxCount -= n;
        if (maxCount <= 0)
            maxCount = 0;
    }
    public override void IncreaseMaxCount(int n)
    {
        maxCount += n;
    }
    public override int GetMaxCount()
    {
        return maxCount;
    }
    public override void SetMaxCount(int n)
    {
        maxCount = n;
    }
}
