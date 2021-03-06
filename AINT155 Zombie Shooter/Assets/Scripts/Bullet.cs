﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public float movementSpeed = 500.0f;
    public int damage = 1;

	// Use this for initialization
	private void Start () {
        GetComponent<Rigidbody2D>().AddForce(transform.up * movementSpeed);
		
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
        Die();
    }
    private void OnBecameInvisible()
    {
        Die();
    }

    private void Die()
    {
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
