using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Battleground : IObserverSubject
{
    private bool isCharacterTurn;
    public bool IsCharacterTurn { get => isCharacterTurn; }
    public Competitor[] currentCharacters = new Competitor[2];
    public Critter[] currentCritters = new Critter[2];
    public int Turn { get => (isCharacterTurn) ? 0 : 1; }
    public int NoTurn { get => (isCharacterTurn) ? 1 : 0; }

    IObserver UI;

    public static Battleground Instance { get; private set; }

    public delegate void OnCritterUpdate();
    public event OnCritterUpdate OnHealthChange;
    public event OnCritterUpdate OnDeath;

    public Battleground(Competitor character, Competitor enemy, IObserver ui)
    {
        Critter.OnCritterDeath += SwapCritter;  //me fui a mimir

        if (Instance == null)
        {
            Instance = this;
        }

        currentCharacters[0] = character;
        currentCharacters[1] = enemy;
        currentCritters[0] = character.Critters[0];
        currentCritters[1] = enemy.Critters[0];
        isCharacterTurn = currentCritters[0].BaseSpeed >= currentCritters[1].BaseSpeed;
        UI = ui;

        Notify();
        InitiateTurn();
    }

    private void InitiateTurn()
    {
        //int skillIndex = 0;
        if (isCharacterTurn) { }
        else
        {

        }
        //currentCritters[Turn].MoveSet[skillIndex].UseSkill(currentCritters[Turn], currentCritters[NoTurn]);
        //ChangeTurn();
    }

    public void ChangeTurn()
    {
        if (currentCharacters[NoTurn].Critters.Count > 0)
        {
            if (currentCharacters[NoTurn].Critters[0].HP > 0)
            {
                isCharacterTurn = !isCharacterTurn;
                Notify();
                InitiateTurn();
            }
            else
            {
                //Console.WriteLine("\n\nOne player does not have any critters alive, the battle has ended.");
                //Console.WriteLine("Thanks for playing, press any key to exit.");
            }
        }
        else
        {
            //Console.WriteLine("\n\nOne player does not have any critters alive, the battle has ended.");
            //Console.WriteLine("Thanks for playing, press any key to exit.");
        }
    }
    
    public void CharacterTurnFalse()
    {
        isCharacterTurn = false;
    }

    public void UseSkill(int skill)
    {
        currentCritters[Turn].MoveSet[skill].UseSkill(currentCritters[Turn], currentCritters[NoTurn]);
        //OnHealthChange();
        Notify(skill);
        ChangeTurn();
    }

    public void Notify(int skill)
    {
        UI.Receive(skill);
    }

    public void Notify()
    {
        UI.Receive();
    }

    private void SwapCritter(Critter deadCrit)
    {
        int offset = 25;
        currentCharacters[NoTurn].RemoveBattlegroundCritter();
        currentCharacters[Turn].AddCritter(deadCrit);

        //if (currentCharacters[NoTurn].Critters.Count > 0)
        //{
        //    if (currentCharacters[NoTurn].Critters[0].HP > 0)
        //    {
        //        currentCritters[NoTurn] = currentCharacters[NoTurn].Critters[0];
        //        if (isCharacterTurn)
        //        {
        //            currentCritters[NoTurn].transform.position = GameManager.Instance.spawnsCrit[4].transform.position;
        //            GameManager.Instance.spawnsCrit[4].position += Vector3.up * offset;
        //        }
        //        else
        //        {
        //            currentCritters[NoTurn].transform.position = GameManager.Instance.spawnsCrit[3].transform.position;
        //            GameManager.Instance.spawnsCrit[3].position += Vector3.up * offset;
        //        }
        //    }
        //}
    }
}
