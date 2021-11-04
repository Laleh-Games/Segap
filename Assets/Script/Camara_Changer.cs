using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara_Changer : MonoBehaviour
{
    [SerializeField] private Camera mane_comera;
    [SerializeField] private Camera mape;
    private bool flalg = false;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {

            if (flalg)
            {

                mane_comera.enabled = true;
                mape.enabled = false;

                flalg = false;
            }else
            {
                mane_comera.enabled = false;
                mape.enabled = true;
                flalg = true;
            }
        }

    }
}
