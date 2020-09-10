using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefUp : MonoBehaviour
{
    Critter crit, enemyCrit;

    private void Awake()
    {
        crit = GetComponent<Critter>();
        enemyCrit = GetComponent<Critter>();
    }

    public void UseSkill()
    {
        crit.realDefense = ((crit.BaseDefense * 20) / 100) + crit.BaseDefense;
    }

    //public void UseSkill()
    //{
    //    if (crit.gameObject.CompareTag("player"))
    //    {
    //        enemyCrit.gameObject = gameObject.CompareTag("enemy");
    //        enemy.realSpeed = enemy.BaseSpeed - ((enemy.BaseSpeed* 30) / 100);
    //    }
    //}
}

