using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject Sating_Panel;
    [SerializeField] private GameObject fide;
    [SerializeField] private string _level;

    public GameObject setting;
    // Start is called before the first frame update
    void Start()
    {
        fide.SetActive(false);
        Sating_Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void start_Clike()
    {
        fide.SetActive(true);
        SceneManager.LoadScene(_level);


    }
    public void sting_clike()
    {
        Sating_Panel.SetActive(true);

    }
    
    public void exit()
    {
        Application.Quit();
    }

    public void SettingPressed()
    {
        setting.SetActive(true);
        /*GameObject.Find("settings").GetComponent<Animator>()*/setting.GetComponent<Animator>().SetBool("Settings", true);
    }

    public void QuitSettingPressed()
    {
        /*GameObject.Find("settings").GetComponent<Animator>()*/
        setting.GetComponent<Animator>().SetBool("Settings", false);
       // setting.SetActive(false);

    }


}
