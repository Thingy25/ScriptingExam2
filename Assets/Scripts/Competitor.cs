using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Competitor
{
    private List<Critter> critters = new List<Critter>();
    public List<Critter> Critters { get => critters; }

    public Competitor(List<Critter> crits)
    {
        critters = crits;
    }
    public void RemoveBattlegroundCritter()
    {
        critters.RemoveAt(0);
    }

    public void AddCritter(Critter crit)
    {
        critters.Add(crit);
    }
}
