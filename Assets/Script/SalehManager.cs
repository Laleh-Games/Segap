using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalehManager : MonoBehaviour
{
    public AudioClip two;
    public AudioSource salehM;
     void Start()
    {
        
    }


    void OnTriggerEnter(Collider obj){
        if (obj.transform.name == "SecondSound")
        {
            if (!salehM.isPlaying)
            {
                salehM.clip = two;
                salehM.Play();
            }
            
        }
    }

    
}
