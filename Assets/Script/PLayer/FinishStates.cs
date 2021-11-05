using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishStates : MonoBehaviour
{
        // Start is called before the first frame update
    public string levelName;

    public GameObject panel;
    void OnTriggerEnter(Collider obj){
        if (obj.gameObject.name == "FinishPlace")
        {
            Debug.LogWarning("Entered!!!");
            SceneManager.LoadScene(levelName);
        }

        if (obj.gameObject.name == "FinishPlace2")
        {
            Debug.LogWarning("Entered!!!");
            panel.SetActive(true);
            Invoke("Inbv", 5f);
        }
    }

    void Inbv()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
