using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLays5 : MonoBehaviour
{
    public Game_maneger game_;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.LogWarning(other.gameObject.GetComponent<Renderer>().material.color + "  : " + game_._color[4]);
        if (other.gameObject.GetComponent<Renderer>().material.color == game_.Box[4].material.color)
        {
           
            gameObject.GetComponent<Renderer>().material.color = Color.green;
           
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
           

        }


    }
}
