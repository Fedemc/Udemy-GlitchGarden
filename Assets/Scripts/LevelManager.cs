using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    public float AutoLoadNextLevelAfter;

    private void Start()
    {
        if(AutoLoadNextLevelAfter == 0)
        {
            Debug.Log("Auto load level disabled!");
        }
        else
            Invoke("LoadNextLevel", AutoLoadNextLevelAfter);
    }

    public void LoadLevel(string name)
    {
        //Debug.Log("Level load requested for: "+name);
        Application.LoadLevel(name);
    }

    public void QuitLevel()
    {
        Debug.Log("Level quit requested");
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }

    
}
