using UnityEngine;
using UnityEngine.AI;

public class ControlScipt : MonoBehaviour
{

    public Camera cam;
    public NavMeshAgent player;
    public Animator playerAnimator;
    public GameObject targetDestination;

    public GameObject water;

    public Transform spawnWater;
   
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitPoint;

            if(Physics.Raycast(ray, out hitPoint))
            {
                targetDestination.transform.position = hitPoint.point;
                player.SetDestination(hitPoint.point);
            }
        }

        if(player.velocity != Vector3.zero)
        {
            playerAnimator.SetBool("isWalking", true);
        }
        
        else if (player.velocity == Vector3.zero)
        {
            playerAnimator.SetBool("isWalking", false);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.transform.gameObject.tag == "FoodBox")
        {
            playerAnimator.SetBool("isEating", true);
        }
            
        else
        {
           playerAnimator.SetBool("isEating", false);
        }

         if(col.transform.gameObject.tag == "Bed")
        {
            playerAnimator.SetBool("isSleeping", true);
        }
            
        else
        {
           playerAnimator.SetBool("isSleeping", false);
        }

        if(col.transform.gameObject.tag == "Playmat")
        {
            playerAnimator.SetBool("isPlaying", true);
        }
            
        else
        {
           playerAnimator.SetBool("isPlaying", false);
        }

        if(col.transform.gameObject.tag == "Shower")
        {
            Instantiate(water, spawnWater.position, Quaternion.identity);
        }

        else
        {
            Destroy(water);
        }

    }
    
    void OnTriggerExit(Collider col)
    {
        if(col.transform.gameObject.tag == "FoodBox")
        {
            playerAnimator.SetBool("isEating", false);
        }

        if(col.transform.gameObject.tag == "Bed")
        {
            playerAnimator.SetBool("isSleeping", false);
        }

         if(col.transform.gameObject.tag == "Playmat")
        {
            playerAnimator.SetBool("isPlaying", false);
        }

    }
}
