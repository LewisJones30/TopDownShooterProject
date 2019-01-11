using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {

	[SerializeField]
	GameObject bullet;
    float fireRate;
    public float setFireRate; //User determines the firerate here.
	float nextFire;

	// Use this for initialization
	void Start () {
        fireRate = setFireRate;
		nextFire = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		CheckIfTimeToFire ();
	}

	void CheckIfTimeToFire()
	{
		if (Time.time > nextFire) {
			Instantiate (bullet, transform.position, transform.rotation);
			nextFire = Time.time + fireRate;
		}
		
	}

}
