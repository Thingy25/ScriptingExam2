using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PanelManager : MonoBehaviour
{
    //GameManager gameManager;

    //[SerializeField] private TextMeshPro allyCritterHealth;
    //[SerializeField] private TextMeshProUGUI enemyCritterHealth;
    //[SerializeField] private TextMeshProUGUI aliveAllyCritters;
    //[SerializeField] private TextMeshProUGUI aliveEnemyCritters;

    TextMeshProUGUI[] texts;

    private void Awake()
    {
        texts = GetComponentsInChildren<TextMeshProUGUI>();
    }


    //private void Awake()
    //{
    //    gameManager = FindObjectOfType<GameManager>();

    //    Battleground.Instance.onCritterUpdate += new Battleground.OnCritterUpdate(OnCritterUpdate);
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
