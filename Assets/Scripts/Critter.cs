using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Critter : MonoBehaviour
{
    public string Name;
    public float BaseAttack;
    public float BaseDefense;
    public float BaseSpeed;
    public EAffinities Affin;
    public float HP;

    //public string Name { get; protected set; }
    //public float BaseAttack { get; protected set; }
    //public float BaseDefense { get; protected set; }
    //public float BaseSpeed { get; protected set; }
    //public EAffinities Affin { get; protected set; }
    //public float HP { get; protected set; }

    private List<Skill> moveSet = new List<Skill>();
    public List<Skill> MoveSet { get => moveSet; }

    public int attackCounter = 0;
    public int defenseCounter = 0;
    public int speedCounter = 0;

    public float realAttack;
    public float realDefense;
    public float realSpeed;

    //public void CreateCritter(int baseAttack, int baseDefense, int baseSpeed, EAffinities affin)
    //{
    //    this.Affin = affin;
    //    Name = name;
    //    if (baseAttack >= 10 && baseAttack <= 100) BaseAttack = baseAttack;
    //    else BaseAttack = 10;
    //    if (baseDefense >= 10 && baseDefense <= 100) BaseDefense = baseDefense;
    //    else BaseDefense = 10;
    //    if (baseSpeed >= 1 && baseSpeed <= 50) BaseSpeed = baseSpeed;
    //    else BaseSpeed = 1;
    //    HP = 100;
    //}

    public void AddSupportSkill(string name, ESupSkillType type)
    {
        if (MoveSet.Count < 3)
        {
            //moveSet.Add(new SupportSkill(name, type));
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
            moveSet.Add(new AttackSkill(name, affinity, power));
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
       // InCritterDeath(this);
    }
}
