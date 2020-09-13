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
        //int noTurn = Battleground.Instance.NoTurn;
        texts[0].text = Battleground.Instance.currentCritters[turn].Name.ToString() + " has used " + Battleground.Instance.currentCritters[turn].MoveSet[skill].Name.ToString();

        if (Battleground.Instance.currentCharacters[0].Critters.Count == 0)
        {
            texts[0].text = "Jessie Team Critcket has won the battle!!!" + "Press [R] to restart the fight";

        }
        else if (Battleground.Instance.currentCharacters[1].Critters.Count == 0)
        {
            texts[0].text = "You have won the battle!!!" + "Press [R] to restart the fight";
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
        //while (Battleground.Instance.IsCharacterTurn)
        //{
        //    abilityButtonOne.SetActive(true);
        //    abilityButtonTwo.SetActive(true);
        //    abilityButtonThree.SetActive(true);
        //}
    }

    public void Receive(int skill)
    {
        UpdateCritterHealth();
        ShowUsedSkill(skill);
        HideAbilities();
    }

    //private void Awake()
    //{
    //    gameManager = FindObjectOfType<GameManager>();

    //}

    //[SerializeField] private TextMeshProUGUI gunPieceText;
    //[SerializeField] private TextMeshProUGUI suitPieceText;



    //[SerializeField] private TextMeshProUGUI ItemLifeText;
    //[SerializeField] private TextMeshProUGUI ItemStaminaText;
    //[SerializeField] private TextMeshProUGUI ItemShotText;

    //private InventoryManager inventory;
    //ConsuManager itemManager;


    //private void Start()
    //{
    //if (CurrencyManager.Instance != null)
    //{
    //Battleground.Instance.onCritterUpdate += new Battleground.OnCritterUpdate(OnCritterUpdate);
    //}
    //if (CraftSystem.Instance != null)
    //{
    //    CraftSystem.Instance.onCurrSpent += new CraftSystem.OnCurrencySpent(OnCurrSpent);
    //}
    //inventory = InventoryManager.Instance;
    //itemManager = ConsuManager.Instance;
    //}

    //void OnCritterUpdate()
    //{
    //    allyCritterHealth.text = "HP: " + Battleground.Instance.currentCritters[0].HP.ToString();
    //    Debug.Log(Battleground.Instance.currentCritters[0].HP);
    //    Debug.Log("holi");
    //    enemyCritterHealth.text = "HP: " + Battleground.Instance.currentCritters[1].HP.ToString();
    //    aliveAllyCritters.text = "Current living critters: " ;

    //    //currencyText.text = inventory.currentCurrency.ToString();
    //    //gunPieceText.text = inventory.currentGunPieces.ToString();
    //    //suitPieceText.text = inventory.currentSuitPieces.ToString();


    //    //ItemLifeText.text = itemManager.itemlifeRegen.ToString();
    //    //ItemStaminaText.text = itemManager.itemRunCooldown.ToString();
    //    //ItemShotText.text = itemManager.itemcooldown.ToString();
    //}
}
