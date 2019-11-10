﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_Copper_BombAttack : Skill_Copper
{
    static int skill_Count = 0;
    private void Start()
    {
        skillUI = GetComponentInParent<UI_SkillUI>().gameObject;
        variation = new float[] { 1, 2, 3 };
    }
    public override void SkillFunction()
    {
        IncreaseCount();
        if (skill_Count < 3)
        {
            Player_AbilityManager.Instance.IncreaseStamina(variation[0]);
        }
        else if (skill_Count < 5)
        {
            Player_AbilityManager.Instance.IncreaseStamina(variation[1]);
        }
        else if (5 <= skill_Count)
        {
            LimitCount();
            Player_AbilityManager.Instance.IncreaseStamina(variation[2]);
        }
        skillUI.SetActive(false);
    }
    public override void LimitCount()
    {
        if (skill_Count >= 5)
        {
            skill_Count = 5;
        }
    }
    public override float GetVariation()
    {
        if (skill_Count <= 1)
            return variation[0];
        else if (2 <= skill_Count && skill_Count <= 3)
            return variation[1];
        else
            return variation[2];
    }
    public override void IncreaseCount()
    {
        skill_Count++;
    }
    public override int GetCount()
    {
        return skill_Count;
    }
    public override string GetSkillText()
    {
        return "폭탄 공격" + "(" + GetVariation() + "회)";
    }
}
