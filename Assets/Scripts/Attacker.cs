using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class Attacker : MonoBehaviour {

    [Range(-1f, 1.5f)]
    public float CurrentSpeed;

    private GameObject currentTarget;

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

    public void Attack(GameObject obj)
    {
        currentTarget = obj;
    }
}
