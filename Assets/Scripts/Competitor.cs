using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Competitor : MonoBehaviour
{
    private List<Critter> critters = new List<Critter>();
    public List<Critter> Critters { get => critters; }
    public GameObject[] crits;

    private int indx;
    TextMeshProUGUI text;

    private void Awake()
    {
        Transform[] _crits = GetComponentsInChildren<Transform>();
        crits = new GameObject[_crits.Length];
        for (int i = 0; i < crits.Length; i++)
        {
            crits[i] = _crits[i].gameObject;
        }
        foreach (GameObject crit in crits)
        {
            if (crit != this.gameObject)
            {
                //crit.SetActive(false);
            }
        }
        indx = 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && indx < crits.Length)
        {
            crits[indx].SetActive(true);
            indx++;
            Debug.Log("jeje");
        }
        else if(indx >= crits.Length)
        {
            Debug.Log("No tenes mas critters careverga!!!!!!!");  //Cambiar cuando se tenga UIManager
            Debug.Log(indx);
            Debug.Log(crits.Length);
        }
    }

    public void AddCritter(Critter crit)
    {
        if (Critters.Count < 3)
        {
            critters.Add(crit);
        }
        else
        {
            //Console.WriteLine("Critter limit exceeded");
        }
    }
    public void RemoveBattlegroundCritter()
    {
        critters.RemoveAt(0);
    }

    public void AddCritter(Critter crit, int i) //Se hace sobrecarga para agregar critters muertos ilimitados.
    {
        critters.Add(crit);
    }
}
