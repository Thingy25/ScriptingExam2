using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PanelManager : MonoBehaviour, IObserver
{
    //GameManager gameManager;

    [SerializeField] GameObject abilityButtonOne;
    [SerializeField] GameObject abilityButtonTwo;
    [SerializeField] GameObject abilityButtonThree;

    TextMeshProUGUI[] texts;

    private void Awake()
    {
        texts = GetComponentsInChildren<TextMeshProUGUI>();

        //Battleground.Instance.OnHealthChange += UpdateCritterHealth;

    }

    private void Start()
    {
        UpdateCritterHealth();
    }

    public void UpdateCritterHealth()
    {
        int counter = 0;

        texts[2].text = "HP: " + Battleground.Instance.currentCritters[0].HP.ToString();
        texts[5].text = "HP: " + Battleground.Instance.currentCritters[1].HP.ToString();

        foreach (var item in Battleground.Instance.currentCharacters[0].Critters)
        {
            if (item.HP > 0)
            {
                counter++;
            }
        }
        texts[3].text = "Living critters: " + counter;

        counter = 0;
        foreach (var item in Battleground.Instance.currentCharacters[1].Critters)
        {
            if (item.HP > 0)
            {
                counter++;
            }
        }
        texts[4].text = "Living critters: " + counter;
    }

    public void ShowUsedSkill(int skill)
    {
        int turn = Battleground.Instance.Turn;
        texts[0].text = Battleground.Instance.currentCritters[turn].Name.ToString() + " has used " + Battleground.Instance.currentCritters[turn].MoveSet[skill].Name.ToString();

        if (Battleground.Instance.currentCharacters[0].Critters.Count == 0)
        {
            texts[0].text = "Jessie Team Critcket has won the battle!!!";

        }
        else if (Battleground.Instance.currentCharacters[1].Critters.Count == 0)
        {
            texts[0].text = "You have won the battle!!!";
        }
    }

    public void NotifyDeadCritter()
    {
        if (true)
        {

        }
    }

    public void NotifyVictory()
    {
  
    }

    public void HideAbilities()
    {
        if (Battleground.Instance.IsCharacterTurn == true)
        {
            abilityButtonOne.SetActive(true);
            abilityButtonTwo.SetActive(true);
            abilityButtonThree.SetActive(true);
        }
        else
        {
            abilityButtonOne.SetActive(false);
            abilityButtonTwo.SetActive(false);
            abilityButtonThree.SetActive(false);
        }
    }

    public void Receive(int skill)
    {
        ShowUsedSkill(skill);
        UpdateCritterHealth();
    }

    public void Receive()
    {
        HideAbilities();
    }
}
