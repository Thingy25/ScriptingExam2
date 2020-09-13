using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Critter : MonoBehaviour
{
    public static Action<Critter> OnCritterDeath;

    public string Name { get; protected set; }
    public float BaseAttack { get; protected set; }
    public float BaseDefense { get; protected set; }
    public float BaseSpeed { get; protected set; }
    public EAffinities Affin { get; protected set; }
    public float HP { get; protected set; }

    public List<Skill> moveSet = new List<Skill>();
    public List<Skill> MoveSet { get => moveSet; }

    public int attackCounter = 0;
    public int defenseCounter = 0;
    public int speedCounter = 0;

    public float realAttack;
    public float realDefense;
    public float realSpeed;

    public void Create(CritterStruct critStruct)
    {
        this.Affin = critStruct.affinity;
        Name = critStruct.name;
        if (critStruct.baseAttack >= 10 && critStruct.baseAttack <= 100) BaseAttack = critStruct.baseAttack;
        else BaseAttack = 10;
        if (critStruct.baseDefense >= 10 && critStruct.baseDefense <= 100) BaseDefense = critStruct.baseDefense;
        else BaseDefense = 10;
        if (critStruct.baseSpeed >= 1 && critStruct.baseSpeed <= 50) BaseSpeed = critStruct.baseSpeed;
        else BaseSpeed = 1;
        HP = 100;
    }

    public void AddSupportSkill(string name, ESupSkillType type)
    {
        if (MoveSet.Count < 3)
        {
            MoveSet.Add(new SupportSkill(name, type));
        }
        else
        {
            //No hay espacios de skill disponibles
        }
    }

    public void AddAttackSkill(string name, EAffinities affinity, float power)
    {
        if (MoveSet.Count < 3)
        {
            MoveSet.Add(new AttackSkill(name, affinity, power));
        }
        else
        {
            //No hay espacios de skill disponibles
        }
    }

    public void ReceiveDamage(float dmgValue)
    {
        HP -= dmgValue;
        if (HP <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        HP = 0;
        if (true)   
        OnCritterDeath(this);
    }
}
