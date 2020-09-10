using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skill : MonoBehaviour
{
    public string Name { get; protected set; }
    public EAffinities Affinity { get; protected set; }
    public float Power { get; protected set; }

    protected Skill(string name, ESupSkillType supSkill)
    {
        Name = name;
    }

    protected Skill(string name, EAffinities affinity, float power)
    {
        Name = name;
        this.Affinity = affinity;
        Power = power;
    }

    public abstract void UseSkill(Critter ally, Critter enemy);
}
