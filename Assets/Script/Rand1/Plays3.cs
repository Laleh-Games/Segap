using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plays3 : MonoBehaviour
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
        if (other.gameObject.GetComponent<Renderer>().material.color == game_._color[2])
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
            game_.kay += 1;
            if (game_.kay == 6)
            {
                //game_obj
                if (GameObject.Find("Cube.070").GetComponent<AutomaticDoor>().Moving == false)
                {
                    GameObject.Find("Cube.070").GetComponent<AutomaticDoor>().Moving = true;
                }
                if (GameObject.Find("Cube.071").GetComponent<AutomaticDoor>().Moving == false)
                {
                    GameObject.Find("Cube.071").GetComponent<AutomaticDoor>().Moving = true;
                }

            }

        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;

            game_.kay -= 1;
        }


    }
}
