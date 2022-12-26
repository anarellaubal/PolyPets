using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pets : MonoBehaviour
{
    public string type;
    public int hunger;
    public int hygiene;
    public int energy;
    public int affection;
    public int excercise;

    public virtual void Love()
    {
        Debug.Log("Pet recieved love");
    }

}
