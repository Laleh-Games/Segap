using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Maneger : MonoBehaviour
{
    public Vecsler vecsler;
    private int avreg = 0;
    [SerializeField] private Renderer renderer;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "daere")
        {
            avreg += 1;
            if (avreg == 6)
            {
                renderer.material.color = Color.green;
                if (GameObject.Find("Cube.143").GetComponent<AutomaticDoor>().Moving == false)
                {
                    GameObject.Find("Cube.143").GetComponent<AutomaticDoor>().Moving = true;
                }
                if (GameObject.Find("Cube.144").GetComponent<AutomaticDoor>().Moving == false)
                {
                    GameObject.Find("Cube.144").GetComponent<AutomaticDoor>().Moving = true;
                }
                vecsler.flage = false;
                vecsler.name = "level4";
            }
            else
            {

            }
            Debug.Log(avreg);
        }
        else if (collision.gameObject.name == "morbe")
        {
            avreg += 2;
            if (avreg == 6)
            {
                if (GameObject.Find("Cube.143").GetComponent<AutomaticDoor>().Moving == false)
                {
                    GameObject.Find("Cube.143").GetComponent<AutomaticDoor>().Moving = true;
                }
                if (GameObject.Find("Cube.144").GetComponent<AutomaticDoor>().Moving == false)
                {
                    GameObject.Find("Cube.144").GetComponent<AutomaticDoor>().Moving = true;
                }
                renderer.material.color = Color.green;
                Debug.Log("Good");
            }
            else
            {

            }
            Debug.Log(avreg);
        }
        else if (collision.gameObject.name == "mosalas")
        {
            avreg += 3;
            if (avreg == 6)

            {
                if (GameObject.Find("Cube.143").GetComponent<AutomaticDoor>().Moving == false)
                {
                    GameObject.Find("Cube.143").GetComponent<AutomaticDoor>().Moving = true;
                }
                if (GameObject.Find("Cube.144").GetComponent<AutomaticDoor>().Moving == false)
                {
                    GameObject.Find("Cube.144").GetComponent<AutomaticDoor>().Moving = true;
                }
                renderer.material.color = Color.green;
                Debug.Log("Good");
            }
            else
            {
            }
            Debug.Log(avreg);
        }



    }
    private void OnCollisionExit(Collision collision)
    {

        if (collision.gameObject.name == "daere")
        {
            avreg -= 1;
            Debug.Log(avreg);

        }
        else if (collision.gameObject.name == "morbe")
        {
            avreg -= 2;
            Debug.Log(avreg);

        }
        else if (collision.gameObject.name == "mosalas")
        {
            avreg -= 3;
            Debug.Log(avreg);


        }
    }
}





