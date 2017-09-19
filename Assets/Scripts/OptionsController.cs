using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {
    public Slider VolumeSlider;
    public Slider DifficultySlider;
    public LevelManager LvlManager;
 

    private MusicManager MusicMgr;


	// Use this for initialization
	void Start ()
    {
        MusicMgr = GameObject.FindObjectOfType<MusicManager>();
        VolumeSlider.value = PlayerPrefsManager.GetMasterVolume();
        DifficultySlider.value = PlayerPrefsManager.GetDifficulty();
	}
	
	// Update is called once per frame
	void Update ()
    {
        MusicMgr.ChangeVolume(VolumeSlider.value);
        
	}

    public void SaveAndExit()
    {
        PlayerPrefsManager.SetMasterVolume(VolumeSlider.value);
        PlayerPrefsManager.SetDifficulty(DifficultySlider.value);

        LvlManager.LoadLevel("01a Start");
    }

    public void SetDefaults()
    {
        VolumeSlider.value = 0.8f;
        DifficultySlider.value = 2f;
    }
}
