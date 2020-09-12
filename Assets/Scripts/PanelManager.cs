using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PanelManager : MonoBehaviour, IObserver
{
    //GameManager gameManager;

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

        texts[1].text = "HP: " + Battleground.Instance.currentCritters[0].HP.ToString();
        texts[4].text = "HP: " + Battleground.Instance.currentCritters[1].HP.ToString();

        foreach(var item in Battleground.Instance.currentCharacters[0].Critters)
        {
            if(item.HP > 0)
            {
                counter++;
            }
        }
        texts[2].text = "Living critters: " + counter;

        counter = 0;
        foreach (var item in Battleground.Instance.currentCharacters[1].Critters)
        {
            if (item.HP > 0)
            {
                counter++;
            }
        }
        texts[3].text = "Living critters: " + counter;
    }

    public void Receive()
    {
        UpdateCritterHealth();
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
