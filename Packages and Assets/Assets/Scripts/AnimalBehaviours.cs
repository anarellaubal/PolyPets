using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalBehaviours : MonoBehaviour
{
   void Start() 
   {
    Pets blackCat = new Pets();
    blackCat.type = "Black Cat";
    blackCat.hunger = 100;
    blackCat.hygiene = 50;
    blackCat.energy = 20;
    blackCat.affection = 80;
    blackCat.excercise = 100;

    Debug.Log(" Type: " + blackCat.type + " Hunger: " + blackCat.hunger + " Hygiene: " + blackCat.hygiene + "Energy:" + blackCat.energy + " Affection: " + blackCat.affection + " Excercise: " + blackCat.excercise);


    Pets brownRabbit = new Pets();
    brownRabbit.type = "Brown Rabbit";
    brownRabbit.hunger = 80;
    brownRabbit.hygiene = 100;
    brownRabbit.energy = 100;
    brownRabbit.affection = 20;
    brownRabbit.excercise = 10;

    Debug.Log(" Type: " + brownRabbit.type + " Hunger: " + brownRabbit.hunger + " Hygiene: " + brownRabbit.hygiene + "Energy:" + brownRabbit.energy + " Affection: " + brownRabbit.affection + " Excercise: " + brownRabbit.excercise);


    Cat catSounds = new Cat();
    catSounds.CatHappySound();
    
    Rabbit rabbitSounds = new Rabbit();
    rabbitSounds.RabbitEatingSound();

   }

   void Update()
   {
    Cat blackCat = new Cat();
    Rabbit brownRabbit = new Rabbit();

    if(Input.GetKeyDown(KeyCode.L))
    {
        blackCat.Love();
        brownRabbit.Love();
    }
   }
}
