using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStartVolume : MonoBehaviour {
    private MusicManager musicMgr;

	// Use this for initialization
	void Start () {
        musicMgr=GameObject.FindObjectOfType<MusicManager>();
        if(musicMgr)
        {
            float volume = PlayerPrefsManager.GetMasterVolume();
            musicMgr.ChangeVolume(volume);

        }
        else
        {
            Debug.LogWarning("No music manager found in start scene");
        }
        		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
