using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource _audS;
  public void Play()
  {
    SceneManager.LoadScene(1);
  }

  public void Pause()
  {
    SceneManager.LoadScene(0);
  }

  public void ExitGame()
  {
    Application.Quit();
  }

  public void ButtonSound(AudioClip _clip)
  {
    _audS.clip = _clip;
    _audS.Play();
  }
}
