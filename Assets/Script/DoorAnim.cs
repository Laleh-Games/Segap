using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnim : MonoBehaviour
{
    private bool flag=true;
    [SerializeField] private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (flag)
            {
                animator.SetTrigger("SetDoorOpen");
                GameObject.Find("Door1Sound").GetComponent<AudioSource>().Play();
                //animshin
                flag = false;
            }
        }else if(other.gameObject==null)
        {
          
            flag = true;
            ////anim
        }


    }



}
