using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Game_maneger : MonoBehaviour
{
    [SerializeField] public Renderer[] Litecolor = new Renderer[6];
    public Color[] _color = new Color[6];
    
    [SerializeField] public Renderer[] Box = new Renderer[6];
    public float timeRemaining = 50f;
    public float timer = 20f;
    public Text _Timer;
    void Start()
    {
        _Timer.text = "0:00";
        Colorchanger();




    }

    
    void Update()
    {
        if (timer>0)
        {
            timer -= Time.deltaTime;
        }else
        {
            for (int i = 0; i < 6; i++)
            {
                Litecolor[i].material.color = Color.white;
            }

        }


        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            _Timer.text = "0:" +((int) timeRemaining).ToString();
        }else
        {

        }

    }


    void Colorchanger()
    {
        for (int i = 0; i < 6; i++)
        {
            _color[i] = new Color(Random.value, Random.value, Random.value, 1.0f);
            Litecolor[i].material.color = _color[i];
            Box[i].material.color = _color[i];

        }

    }

    
}
