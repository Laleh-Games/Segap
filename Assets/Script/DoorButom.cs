using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButom : MonoBehaviour
{
    // Start is called before the first frame update
    private bool flag = true;
    [SerializeField] private Animator animator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cubes")
        {
            
                animator.SetBool("SmallDoor", true);
            //animshin
            Debug.Log(other.gameObject.tag);

        }
       
     


}
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag=="Cubes")
        {
            animator.SetBool("SmallDoor", false);
            //animshin
            Debug.Log(other.gameObject.tag);
        }
     
    }
}
