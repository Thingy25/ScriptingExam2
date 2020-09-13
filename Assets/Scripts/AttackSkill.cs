using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSkill : Skill
{
    public AttackSkill(string name, EAffinities affinity, float power) : base(name, affinity, power)
    {
        if (power >= 1 && power <= 10) Power = power;
        else Power = 1;
    }

    public override void UseSkill(Critter ally, Critter enemy)
    {
        float affMultiplier, dmgValue;
        affMultiplier = Utilities.Compare(Affinity, enemy.Affin);
        dmgValue = (ally.BaseAttack + Power) * affMultiplier;
        enemy.ReceiveDamage(dmgValue);
    }
}
