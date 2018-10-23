using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController2D : MonoBehaviour {
    public float speed = 5.0f;
    Rigidbody2D rigidbody2D;
	// Use this for initialization
	void Start () {
        rigidbody2D = GetComponent<Rigidbody2D>();
		
	}

    private void FixedUpdate() // This is used in Physics instead of using the update code.
    {
        float x = Input.GetAxis("Horizontal"); //Takes user's input of A/D or LEFT/RIGHT keys
        float y = Input.GetAxis("Vertical"); //Takes user's input of W/S or UP/DOWN keys
        rigidbody2D.velocity = new Vector2(x, y) * speed;
        rigidbody2D.angularVelocity = 0.0f;
        
    }





    // Update is called once per frame
    void Update () {
		
	}
}
