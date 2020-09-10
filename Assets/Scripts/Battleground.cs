using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battleground : MonoBehaviour
{
    private bool isPlayerTurn;
    private Competitor[] currentPlayers = new Competitor[2];
    private Critter[] currentCritters = new Critter[2];
    private int Turn { get => (isPlayerTurn) ? 0 : 1; }
    private int NoTurn { get => (isPlayerTurn) ? 1 : 0; }
    private GameObject[] crits;
    private int indx;
    Renderer mat;

    private Color color = Color.white;

        //hacer lo mismo que indicó Jose con el transform para acceder a los Critters, tener un índice que indique el Critter seleccionado y cuando 
        //los HP de este sean cero, aumentar tal indice.


    private void Awake()
    {
        Transform[] _crits = GetComponentsInChildren<Transform>();
        crits = new GameObject[_crits.Length];
        for (int i = 0; i < crits.Length; i++)
        {
            crits[i] = _crits[i].gameObject;
        }
        //mat.material.SetColor("_Color", Color.red);
        Debug.Log(crits.Length);
        //foreach (GameObject crit in crits)
        //{
           
        //}

    }


    private void InitiateTurn()
    {
        int skillIndex = 0;
        if (isPlayerTurn)
        {
          //Habilitar botones del critter activo
          //
        }
        else
        {
            //Enemigo ataca

            //Console.WriteLine("\nThe enemy's turn!");
            //Random rand = new Random();
            //skillIndex = rand.Next(0, currentCritters[Turn].MoveSet.Count);
            //Console.WriteLine("The enemy has used: {0}", currentCritters[Turn].MoveSet[skillIndex].Name);
        }
        //currentCritters[Turn].MoveSet[skillIndex].UseSkill(currentCritters[Turn], currentCritters[NoTurn]);
        ChangeTurn();

    }

    private void ChangeTurn()
    {
        if (currentPlayers[NoTurn].Critters.Count > 0)
        {
            if (currentPlayers[NoTurn].Critters[0].HP > 0)
            {
                isPlayerTurn = !isPlayerTurn;
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
}
