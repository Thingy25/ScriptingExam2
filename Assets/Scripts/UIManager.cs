﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI allyCritterHealth;
    [SerializeField] private TextMeshProUGUI enemyCritterHealth;
    [SerializeField] private TextMeshProUGUI aliveCritters;

    //[SerializeField] private TextMeshProUGUI gunPieceText;
    //[SerializeField] private TextMeshProUGUI suitPieceText;



    //[SerializeField] private TextMeshProUGUI ItemLifeText;
    //[SerializeField] private TextMeshProUGUI ItemStaminaText;
    //[SerializeField] private TextMeshProUGUI ItemShotText;

    //private InventoryManager inventory;
    //ConsuManager itemManager;


    void Start()
    {
        //if (CurrencyManager.Instance != null)
        //{
        //    CurrencyManager.Instance.onCurrAdded += new CurrencyManager.OnCurrencyAdded(OnCurrAdded);
        //}
        //if (CraftSystem.Instance != null)
        //{
        //    CraftSystem.Instance.onCurrSpent += new CraftSystem.OnCurrencySpent(OnCurrSpent);
        //}
        //inventory = InventoryManager.Instance;
        //itemManager = ConsuManager.Instance;
    }

    void OnCurrAdded()
    {

        //currencyText.text = inventory.currentCurrency.ToString();
        //gunPieceText.text = inventory.currentGunPieces.ToString();
        //suitPieceText.text = inventory.currentSuitPieces.ToString();


        //ItemLifeText.text = itemManager.itemlifeRegen.ToString();
        //ItemStaminaText.text = itemManager.itemRunCooldown.ToString();
        //ItemShotText.text = itemManager.itemcooldown.ToString();
    }
}