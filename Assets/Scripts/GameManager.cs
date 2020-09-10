using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private List<CritterStruct> CritterData = new List<CritterStruct> ();

    [SerializeField]
    private List<Critter> Critters = new List<Critter>();

    Competitor comp;

    Competitor player = new Competitor();
    Competitor enemy = new Competitor();
    Critter allyCrit;
    Critter enemyCrit;

    int selectSkill;

    private void Awake()
    {
        selectSkill = Random.Range(1, 101);

        //foreach (var item in comp.crits)
        //{
        //    item.GetComponent<Critter>();
        //    switch (selectSkill)
        //    {
        //        case 1:
        //            item.gameObject.add;
        //            break;
        //        case 2:
        //            break;
        //        case 3:
        //            break;
        //        case 4:
        //            break;
        //    }
        //}
        //allyCrit = new Critter("Critachu", selectSkill, selectSkill, rand.Next(1, 51), EAffinities.light);
        //allyCrit.AddSupportSkill("Critlightning", ESupSkillType.atkUp);
        //allyCrit.AddAttackSkill("Critfire", EAffinities.fire, 5);
        //allyCrit.AddAttackSkill("Critstorm", EAffinities.light, 10);
        //player.AddCritter(allyCrit);

        //allyCrit = new Critter("Critterpie", selectSkill, selectSkill, rand.Next(1, 51), EAffinities.earth);
        //allyCrit.AddSupportSkill("Critwall", ESupSkillType.defUp);
        //allyCrit.AddAttackSkill("Critrocks", EAffinities.earth, 2);
        //allyCrit.AddSupportSkill("Critsilk", ESupSkillType.spdDown);
        //player.AddCritter(allyCrit);

        //allyCrit = new Critter("Critmander", selectSkill, selectSkill, rand.Next(1, 51), EAffinities.fire);
        //allyCrit.AddAttackSkill("Critcatoa", EAffinities.fire, 6);
        //allyCrit.AddAttackSkill("Critflames", EAffinities.dark, 8);
        //allyCrit.AddAttackSkill("Crittail", EAffinities.wind, 3);
        //player.AddCritter(allyCrit);
    }

    private void Update()
    {
        //switch (selectSkill)
        //{
        //    case 1:
        //        AddAttackSkill();
        //        break;
        //    case 2:
        //        AddSupportSkill();
        //        break;
        //    case 3:
        //        AddSupportSkill();
        //        break;
        //    case 4:
        //        AddSupportSkill();
        //        break;
        //}
    }

   

    private void CreateCritters()
    {

    }

}
