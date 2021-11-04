using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishStates : MonoBehaviour
{
        // Start is called before the first frame update
    public string levelName;
    void OnTriggerEnter(Collider obj){
        if (obj.gameObject.name == "FinishPlace")
        {
            Debug.LogWarning("Entered!!!");
            SceneManager.LoadScene(levelName);
        }
    }
}
