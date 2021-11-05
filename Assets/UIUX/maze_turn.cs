using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maze_turn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 0.1f;
        gameObject.transform.Rotate(new Vector3(0, 45.0f * Time.deltaTime * speed, 0));

    }
}
