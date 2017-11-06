using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Attacker))]

public class Fox : MonoBehaviour {

    private Animator anim;
    private Attacker attacker;

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
        attacker = GetComponent<Attacker>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter2D(Collider2D collider)
    {
        //Me guardo el gameobject contra el que estoy colisionando, lo guardo en "obj"
        GameObject obj = collider.gameObject;
        
        //Si no colisiono contra un miembro de Defender
        if(!obj.GetComponent<Defender>())
        {
            return;
        }

        //Si es un defender y es la piedra
        if(obj.GetComponent<Stone>())
        {
            anim.SetTrigger("jumpTrigger");
        }
        //Si no es la piedra
        else
        {
            anim.SetBool("isAttacking", true);
            attacker.Attack(obj);
        }

        Debug.Log("Fox collided with " + collider);
    }
}
