using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void Bathroom()
    {
        SceneManager.LoadScene("Bathroom");
    }

    public void Attic()
    {
        SceneManager.LoadScene("Attic");
    }

     public void Bedroom()
    {
        SceneManager.LoadScene("Bedroom");
    }

    public void livingRoom()
    {
        SceneManager.LoadScene("LivingRoom");
    }

}
