using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Text>().text = "Your brain Test: " + Mathf.Floor(Random.Range(100f, 150f));

        //Mathf.Floor(Random.Range(100f, 150f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
