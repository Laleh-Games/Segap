using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLays4 : MonoBehaviour
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
        Debug.LogWarning(other.gameObject.GetComponent<Renderer>().material.color + "  : " + game_._color[3]);
        if (other.gameObject.GetComponent<Renderer>().material.color == game_.Box[3].material.color)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;

        }


    }
}
