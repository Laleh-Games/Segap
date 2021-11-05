using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Game_over : MonoBehaviour
{
 private string Home_name = "MainMenu";

    public GameObject pausePanel;
    public GameObject Over_obj;
    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void  reset_scene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    public void Go_home()
    {

        SceneManager.LoadScene(Home_name);

    }

    public void ResumeBtn()
    {
        Time.timeScale = 1f;
        GameObject.Find("PauseCanvas").SetActive(false);
    }

    public void PauseBtn()
    {
        Debug.Log("Entered!!!");
        pausePanel.SetActive(true);
        //Time.timeScale = 0f;
    }
    public void Game_over_s()
    {
        Over_obj.SetActive(true);
        Time.timeScale = 0f;
    }

}
