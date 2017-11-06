using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class Attacker : MonoBehaviour {

    [Range(-1f, 1.5f)]
    public float CurrentSpeed;

    private Animator attackerAnim;
    private GameObject currentTarget;

    private void Start()
    {
        attackerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update ()
    {
        transform.Translate(Vector3.left * CurrentSpeed * Time.deltaTime);
        if (!currentTarget)
            attackerAnim.SetBool("isAttacking", false);
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
        if(currentTarget)
        {
            Health targetHealth = currentTarget.GetComponent<Health>();
            if(targetHealth)
            {
                targetHealth.DecreaseHealth(damage);
            }
        }
        
    }

    public void Attack(GameObject obj)
    {
        currentTarget = obj;
    }
}
