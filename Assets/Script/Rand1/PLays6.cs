using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLays6 : MonoBehaviour
{
    public Game_maneger game_;
    public Vecsler vecsler;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.LogWarning(other.gameObject.GetComponent<Renderer>().material.color+"  : "+game_._color[5]);

        if (other.gameObject.GetComponent<Renderer>().material.color == game_.Box[5].material.color)
        {

            gameObject.GetComponent<Renderer>().material.color = Color.green; game_.kay += 1;
            game_.kay += 1;
            if (game_.kay == 7)
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
                vecsler.flage = false;
                vecsler.name = "level2";

            }

        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;

            game_.kay -= 1;

        }
        Debug.Log(game_.kay);

    }
}
