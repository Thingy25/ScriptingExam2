using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battleground 
{
    private bool isCharacterTurn;
    public bool IsCharacterTurn { get => isCharacterTurn; }
    private Competitor[] currentCharacters = new Competitor[2];
    public Critter[] currentCritters = new Critter[2];
    private int Turn { get => (isCharacterTurn) ? 0 : 1; }
    private int NoTurn { get => (isCharacterTurn) ? 1 : 0; }
    public delegate void OnCritterUpdate();
    public event OnCritterUpdate onCritterUpdate;
    public static Battleground Instance { get; private set; }

    public Battleground(Competitor character, Competitor enemy)
    {
        //Critter.InCritterDeath += SwapCritter;

        if (Instance == null)
        {
            Instance = this;
        }

        currentCharacters[0] = character;
        currentCharacters[1] = enemy;
        currentCritters[0] = character.Critters[0];
        currentCritters[1] = enemy.Critters[0];
        isCharacterTurn = currentCritters[0].BaseSpeed >= currentCritters[1].BaseSpeed;

        InitiateTurn();
    }

    private void InitiateTurn()
    {
        //int skillIndex = 0;
        if (isCharacterTurn)
        {
            //return;
            
            //Console.WriteLine("\nYour turn!");
            //Console.WriteLine("Choose your ability: (0), (1), (2)");
            //temp = Console.ReadLine();
            //int.TryParse(temp, out skillIndex);
        }
        else
        {
            //Console.WriteLine("\nThe enemy's turn!");
            UseSkill(Random.Range(0, 3));
            //skillIndex = rand.Next(0, currentCritters[Turn].MoveSet.Count);
            //Console.WriteLine("The enemy has used: {0}", currentCritters[Turn].MoveSet[skillIndex].Name);
        }
        //currentCritters[Turn].MoveSet[skillIndex].UseSkill(currentCritters[Turn], currentCritters[NoTurn]);
        //ChangeTurn();

    }

    private void ChangeTurn()
    {
        if (currentCharacters[NoTurn].Critters.Count > 0)
        {
            if (currentCharacters[NoTurn].Critters[0].HP > 0)
            {
                isCharacterTurn = !isCharacterTurn;
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
        Debug.Log("holi");
        ChangeTurn();
    }

    IEnumerator WaitForTurn()
    {
        yield return new WaitForSeconds(20f);
    }

    private void SwapCritter(Critter deadCrit)
    {
        //Console.WriteLine(deadCrit.Name + " is dead, it has a new slaver.");
        currentCharacters[NoTurn].RemoveBattlegroundCritter();
        currentCharacters[Turn].AddCritter(deadCrit);

        if (currentCharacters[NoTurn].Critters.Count > 0)
        {
            if (currentCharacters[NoTurn].Critters[0].HP > 0)
            {
                currentCritters[NoTurn] = currentCharacters[NoTurn].Critters[0];
                //Console.WriteLine("\n-----------------" + currentCritters[NoTurn].Name + " has entered the battle-----------------");
            }
        }
    }
}
