using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLays6 : MonoBehaviour
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
        Debug.LogWarning(other.gameObject.GetComponent<Renderer>().material.color+"  : "+game_._color[5]);

        if (other.gameObject.GetComponent<Renderer>().material.color == game_.Box[5].material.color)
        {

            gameObject.GetComponent<Renderer>().material.color = Color.green;
            game_.kay += 1;
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            game_.kay -= 1;


        }


    }
}
