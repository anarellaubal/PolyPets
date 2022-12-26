using UnityEngine;

public class Cat : Pets

{
public void CatHappySound()
{
    Debug.Log("Meow!");
}

public override void Love()
{
    Debug.Log("Cat purrs");
}
}