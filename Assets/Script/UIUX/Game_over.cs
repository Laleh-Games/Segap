using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Game_over : MonoBehaviour
{
    [SerializeField] private string Home_name;

    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    public void  reset_scene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    public void Go_home()
    {

        SceneManager.LoadScene(Home_name);

    }


}
