using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtkUp : MonoBehaviour
{
    Critter crit;
    private void Awake()
    {
        crit = GetComponent<Critter>();
    }

    public void UseSkill()
    {
        crit.realAttack = ((crit.BaseAttack * 20) / 100) + crit.BaseAttack;
    }
}
