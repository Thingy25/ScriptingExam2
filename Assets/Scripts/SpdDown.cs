using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpdDown : MonoBehaviour
{
    Critter crit;
    private void Awake()
    {
        crit = GetComponent<Critter>();
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
