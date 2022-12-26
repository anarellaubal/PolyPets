using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Animal Stats", menuName = "LowPolyAnimals/NewAnimalStats", order = 1)]
public class AIStats : ScriptableObject
{
   
    [SerializeField, Tooltip("How many seconds this animal can run for before it gets tired.")]
    public float stamina = 10f;

    [SerializeField, Tooltip("How many seconds this animal can run for before it gets hungry.")]
    public float hunger = 10f;

    [SerializeField, Tooltip("How many pets this animal needs to be content.")]
    public float affection = 10f;

    [SerializeField, Tooltip("How many seconds this animal can run for before it gets dirty.")]
    public float cleanliness = 10f;

    [SerializeField, Tooltip("How much health this animal has.")]
    public float toughness = 5f;

}
