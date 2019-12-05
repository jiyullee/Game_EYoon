﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Attack_Range : MonoBehaviour
{
    [SerializeField] float attackRange;
    float maxAttackRange = 15;
    Player_Circle_Move circle;
    public float tempRange;
    void Start()
    {
        tempRange = attackRange;
        circle = GetComponentInChildren<Player_Circle_Move>();
    }

    // Update is called once per frame
    void Update()
    {
        if (LevelManager.Instance.OnBoss)
        {
            attackRange = 15;
        }
        else
        {
            attackRange = tempRange;
        }
        transform.localScale = new Vector3(attackRange, attackRange,1);
        circle.setRadius(attackRange * 26.25f);
    }
   
    public float GetAttackRange()
    {
        return attackRange;
    }
    public void IncreaseAttackRange(float n)
    {
        attackRange += n;
        if (attackRange > maxAttackRange)
            attackRange = maxAttackRange;
    }
}
