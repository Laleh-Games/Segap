using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_camera : MonoBehaviour
{
    [SerializeField] private Transform pos;
  
    void Start()
    {
        
    }

   
    void Update()
    {
        gameObject.transform.position = new Vector3(pos.position.x, gameObject.transform.position.y, pos.position.z);
    }
}
