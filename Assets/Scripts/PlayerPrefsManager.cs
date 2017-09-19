using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour {
    const string MASTER_VOLUME_KEY = "master_volume";
    const string DIFFICULTY_KEY = "difficulty";
    const string LEVEL_KEY = "level_unlocked_";

    public static void SetMasterVolume(float vol)
    {
        if (vol > 0f && vol <= 1f)
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, vol);
        else
            Debug.LogError("Master volume out of range!");
    }

    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

    public static void SetUnlockedLevel(int lvl)
    {
        if (lvl <= Application.levelCount - 1)
            PlayerPrefs.SetInt(LEVEL_KEY + lvl.ToString(), 1);      //1 se usa como un TRUE
        else
            Debug.Log("Trying to unlock level not in build order");
    }

    public static bool GetLevelUnlocked(int lvl)
    {
        bool retorno = false;
        if (lvl <= Application.levelCount - 1)
        {
            if (PlayerPrefs.GetInt(LEVEL_KEY + lvl.ToString()) == 1)
                retorno = true;
        }
        else
        {
            Debug.Log("Level does not exist in build order range");
        }

        return retorno;
            
    }

    public static void SetDifficulty(float dif)
    {
        if (dif >= 1f && dif <= 3f)
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, dif);
        else
            Debug.LogError("Difficulty out of range!");
    }

    public static float GetDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }



}
