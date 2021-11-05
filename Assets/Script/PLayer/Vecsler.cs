using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Vecsler : MonoBehaviour
{
    public float timer = 0;
    [SerializeField] private Text text_time;
    public bool flage=true;
    private bool strat=false;
    public string name;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (strat)
        {
            if (flage)
            {
                timer += Time.deltaTime; ;

            }
            else
            {
                PlayerPrefs.SetFloat(name, timer);
            }
        }
        
        

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            strat = true;
        }
         
    }
}
