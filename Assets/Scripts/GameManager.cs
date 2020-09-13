using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private const int CRITTER_MAX = 3;
    [SerializeField] private List<CritterStruct> allyCritterData, enemyCritterData;

    private List<GameObject> allyCrittersGO = new List<GameObject>();
    private List<GameObject> enemyCrittersGO = new List<GameObject>();

    GameObject allyPrefab, enemyPrefab;
    public Transform[] spawnsCrit;
    Transform[] deadSpawns;

    List<Critter> allyCritters = new List<Critter>(), enemyCritters = new List<Critter>();

    [SerializeField] float spawnOffset = 5;
    [SerializeField] float timeForEnemyAttack;

    Battleground battleground;
    Competitor character, enemy;
    Critter allyCrit;
    Critter enemyCrit;
    PanelManager ui;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        ui = FindObjectOfType<PanelManager>();

        allyPrefab = (GameObject)Resources.Load("Prefabs/AllyCrit", typeof(GameObject));
        enemyPrefab = (GameObject)Resources.Load("Prefabs/EnemyCrit", typeof(GameObject));

        spawnsCrit = GetComponentsInChildren<Transform>();

        LimitCritters();
        CreateCritters();

        character = new Competitor(allyCritters);
        enemy = new Competitor(enemyCritters);

        battleground = new Battleground(character, enemy, (ui as IObserver));
    }

    private void Update()
    {
        if (battleground.IsCharacterTurn == true)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                battleground.UseSkill(0);
                StartCoroutine(WaitForEnemyTurn());
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                battleground.UseSkill(1);
                StartCoroutine(WaitForEnemyTurn());
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                battleground.UseSkill(2);
                StartCoroutine(WaitForEnemyTurn());
            }
        }
    }

    private void CreateCritters()
    {
        GameObject instance = null;
        Critter instanceCrit = null;

        int selectSkill, selectAffinity;

        #region AllyCritters
        for (int i = 0; i < allyCritterData.Count; i++)
        {
            instance = Instantiate(allyPrefab, spawnsCrit[1].position, spawnsCrit[1].rotation);
            instanceCrit = instance.GetComponent<Critter>();
            instanceCrit.Create(allyCritterData[i]);
            allyCritters.Add(instanceCrit);

            for (int f = 0; f < 3; f++)
            {
                if (f == 0){ selectSkill = 1; }
                else { selectSkill = Random.Range(1, 5); }
                switch (selectSkill)
                {
                    case 1:
                        selectAffinity = Random.Range(1, 7);
                        switch (selectAffinity)
                        {
                            case 1:
                                instanceCrit.AddAttackSkill("Attack", EAffinities.fire, Random.Range(1, 11));
                                break;
                            case 2:
                                instanceCrit.AddAttackSkill("Attack", EAffinities.dark, Random.Range(1, 11));
                                break;
                            case 3:
                                instanceCrit.AddAttackSkill("Attack", EAffinities.earth, Random.Range(1, 11));
                                break;
                            case 4:
                                instanceCrit.AddAttackSkill("Attack", EAffinities.light, Random.Range(1, 11));
                                break;
                            case 5:
                                instanceCrit.AddAttackSkill("Attack", EAffinities.water, Random.Range(1, 11));
                                break;
                            case 6:
                                instanceCrit.AddAttackSkill("Attack", EAffinities.wind, Random.Range(1, 11));
                                break;
                        }
                        break;
                    case 2:
                        instanceCrit.AddSupportSkill("Attack Up", ESupSkillType.atkUp);
                        break;
                    case 3:
                        instanceCrit.AddSupportSkill("Defense up", ESupSkillType.defUp);
                        break;
                    case 4:
                        instanceCrit.AddSupportSkill("Speed down", ESupSkillType.spdDown);
                        break;
                }
                Debug.Log("allymoveset:" + instanceCrit.MoveSet[f].Name);
                Debug.Log("attack affinity: " + instanceCrit.moveSet[0].Affinity);
                Debug.Log("powah: " + instanceCrit.moveSet[0].Power);
            }

            allyCrittersGO.Add(instance);
            spawnsCrit[1].position += Vector3.forward * spawnOffset;
        }
        #endregion

        #region EnemyCritters
        for (int i = 0; i < enemyCritterData.Count; i++)
        {
            instance = Instantiate(enemyPrefab, spawnsCrit[2].position, spawnsCrit[2].rotation);
            instanceCrit = instance.GetComponent<Critter>();
            instanceCrit.Create(enemyCritterData[i]);
            enemyCritters.Add(instanceCrit);

            for (int f = 0; f < 3; f++)
            {
                if (f == 0) { selectSkill = 1; }
                else { selectSkill = Random.Range(1, 5); }
                switch (selectSkill)
                {
                    case 1:
                        selectAffinity = Random.Range(1, 7);
                        switch (selectAffinity)
                        {
                            case 1:
                                instanceCrit.AddAttackSkill("Attack", EAffinities.fire, Random.Range(1, 11));
                                break;
                            case 2:
                                instanceCrit.AddAttackSkill("Attack", EAffinities.dark, Random.Range(1, 11));
                                break;
                            case 3:
                                instanceCrit.AddAttackSkill("Attack", EAffinities.earth, Random.Range(1, 11));
                                break;
                            case 4:
                                instanceCrit.AddAttackSkill("Attack", EAffinities.light, Random.Range(1, 11));
                                break;
                            case 5:
                                instanceCrit.AddAttackSkill("Attack", EAffinities.water, Random.Range(1, 11));
                                break;
                            case 6:
                                instanceCrit.AddAttackSkill("Attack", EAffinities.wind, Random.Range(1, 11));
                                break;
                        }
                        break;
                    case 2:
                        instanceCrit.AddSupportSkill("Attack Up", ESupSkillType.atkUp);
                        break;
                    case 3:
                        instanceCrit.AddSupportSkill("Defense up", ESupSkillType.defUp);
                        break;
                    case 4:
                        instanceCrit.AddSupportSkill("Speed down", ESupSkillType.spdDown);
                        break;
                }
                Debug.Log("enemymoveset :" + instanceCrit.MoveSet[f].Name);
            }

            enemyCrittersGO.Add(instance);
            spawnsCrit[2].position += Vector3.forward * spawnOffset;
        }
        #endregion
    }

    IEnumerator WaitForEnemyTurn()
    {
        yield return new WaitForSeconds(timeForEnemyAttack);
        Battleground.Instance.UseSkill(Random.Range(0, 3));
    }

    public void LimitCritters()
    {
        if(allyCritterData.Count >= CRITTER_MAX)
        {
            for (int i = allyCritterData.Count - 1; i >= CRITTER_MAX; i--)
            {
                allyCritterData.RemoveAt(i);
            }
        }

        if (enemyCritterData.Count >= CRITTER_MAX)
        {
            for (int i = enemyCritterData.Count - 1; i >= CRITTER_MAX; i--)
            {
                enemyCritterData.RemoveAt(i);
            }
        }
    }
}
