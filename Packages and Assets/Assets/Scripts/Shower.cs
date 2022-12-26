using UnityEngine;
using UnityEngine.SceneManagement;

public class Shower : MonoBehaviour
{
	public GameObject water;

    public void OnTriggerEnter(Collider col)
    {
        if(col.transform.gameObject.tag == "Shower")
        {
            water.SetActive(true);
        }
            
        else
        {
           water.SetActive(false);
        }

    }
}