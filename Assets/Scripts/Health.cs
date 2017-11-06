using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    public float HealthAmount=100f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DecreaseHealth(float dmgDone)
    {
        if( (HealthAmount -= dmgDone) > 0 )
        {
            HealthAmount -= dmgDone;
        }
        else
        {
            //Opcional: Animacion de muerte aca y luego usar un animation event al final de esa animacion para llamar al DestroyObject
            DestroyObject();
        }
    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}
