using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMove : MonoBehaviour
{
    private bool flag = true;
    [SerializeField] private Animator animator1;
    [SerializeField] private Animator animator2;
    [SerializeField] private string name1;
    [SerializeField] private string name2;
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
                animator1.SetTrigger(name1);
                animator2.SetTrigger(name2);
                //animshin
                flag = false;
            }
        }
        else if (other.gameObject == null)
        {

            flag = true;
            ////anim
        }


    }
}
