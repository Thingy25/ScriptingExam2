using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupportSkill : Skill
{
    public ESupSkillType ESuppSkill { get; protected set; }

    Critter crit;
    private void Awake()
    {
        crit = GetComponent<Critter>();
    }

    public SupportSkill(string name, ESupSkillType suppSkill) : base(name, suppSkill)
    {
        Name = name;
        ESuppSkill = suppSkill;
        Power = 0;
    }

    public override void UseSkill(Critter ally, Critter enemy)
    {
     
    }

    public void UseAttackUp()
    {
        crit.realAttack = ((crit.BaseAttack * 20) / 100) + crit.BaseAttack;
    }

    public void UseDefenseUp()
    {
        crit.realDefense = ((crit.BaseDefense * 20) / 100) + crit.BaseDefense;
    }

    public void UseSpeedDown()
    {
        if (crit.gameObject.CompareTag("player"))
        {
            //enemyCrit.gameObject = gameObject.CompareTag("enemy");
            //enemy.realSpeed = enemy.BaseSpeed - ((enemy.BaseSpeed * 30) / 100);
        }
    }
}
