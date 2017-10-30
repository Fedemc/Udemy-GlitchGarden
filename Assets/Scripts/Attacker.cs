using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour {

    [Range(-1f, 1.5f)]
    public float CurrentSpeed;

	// Use this for initialization
	void Start ()
    {
        Rigidbody2D myRigidBody = gameObject.AddComponent<Rigidbody2D>();
        myRigidBody.isKinematic = true;

		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.left * CurrentSpeed * Time.deltaTime);
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(name + " trigger enter");
    }

    public void ChangeSpeed(float speed)
    {
        CurrentSpeed = speed;
    }

    public void StrikeCurrentTarget(float damage)
    {
        Debug.Log(name + " deals " + damage + " damage");
    }
}
