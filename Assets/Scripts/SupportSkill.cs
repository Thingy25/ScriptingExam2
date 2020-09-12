using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupportSkill : Skill
{
    public ESupSkillType ESuppSkill { get; protected set; }

    public SupportSkill(string name, ESupSkillType suppSkill) : base(name, suppSkill)
    {
        Name = name;
        ESuppSkill = suppSkill;
        Power = 0;
    }

    public override void UseSkill(Critter ally, Critter enemy)
    {
        switch(ESuppSkill)
        {
            case ESupSkillType.atkUp:
                ally.realAttack = ((ally.BaseAttack * 20) / 100) + ally.BaseAttack;
                break;
            case ESupSkillType.defUp:
                ally.realDefense = ((ally.BaseDefense * 20) / 100) + ally.BaseDefense;
                break;
            case ESupSkillType.spdDown:
                enemy.realSpeed = enemy.BaseSpeed - ((enemy.BaseSpeed * 30) / 100);
                break;
        }
    }
}
