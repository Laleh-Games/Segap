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
    public float timeRemaining = 10f;
    public float timer = 20f;
    public Text _Timer;
    public int kay = 0;
    public GameObject game_Over;
    public GameObject start;
    void Start()
    {
        Time.timeScale = 1f;
        _Timer.text = "";
        Colorchanger();




    }

    
    void Update()
    {
        if (timer>0)
        {
            timer -= Time.deltaTime;
            _Timer.text = "0:" + ((int)timer).ToString();
        }
        else
        {
            for (int i = 0; i < 6; i++)
            {
                Litecolor[i].material.color = Color.white;
            }
            if (start.active)
            {
                start.SetActive(false);
            }
            
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                _Timer.text = "0:" + ((int)timeRemaining).ToString();
            }
            else
            {
                game_Over.SetActive(true);
                Time.timeScale = 0;


            }
        }


        //if (timeRemaining > 0)
        //{
        //    timeRemaining -= Time.deltaTime;
        //    _Timer.text = "0:" +((int) timeRemaining).ToString();
        //}else
        //{
        //    game_Over.Game_over_s();


        //}

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
