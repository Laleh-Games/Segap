using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectMove : MonoBehaviour
{
    private void OnTriggerStay(Collider other){
        if (other.tag == "Door")
        {
            if (other.GetComponent<AutomaticDoor>().Moving == false)
            {
                other.GetComponent<AutomaticDoor>().Moving = true;
            }
        }
    }
}
