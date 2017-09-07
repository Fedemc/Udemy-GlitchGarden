using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {
    public AudioClip[] LevelMusicChangeArray;



    private AudioSource audioSource;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Debug.Log("Dont destroy on load: " + name);
    }

    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
	}

    private void OnLevelWasLoaded(int level)
    {
        AudioClip thisLevelMusic = LevelMusicChangeArray[level];
        Debug.Log("Playing: " + LevelMusicChangeArray[level]);
        
        if(thisLevelMusic) //Si esta cargada la musica
        {
            audioSource.clip = thisLevelMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }
}
