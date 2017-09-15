using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInPanel : MonoBehaviour {
    public float FadeInTime;

    private Image fadePanel;
    private Color currentColor= Color.black;


	// Use this for initialization
	void Start () {
        fadePanel = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Time.timeSinceLevelLoad < FadeInTime)
        {
            //Aca hay que hacer el fade in
            float alphaCange = Time.deltaTime / FadeInTime;
            currentColor.a -= alphaCange;
            fadePanel.color = currentColor;
        }
        else
        {
            gameObject.SetActive (false);
        }
        
    }
}
