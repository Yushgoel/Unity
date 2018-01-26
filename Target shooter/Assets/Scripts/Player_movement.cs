using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour {
	public float speed;
	private Vector3 input;
	private float maxspeed = 30f;
	private Vector3 spawn;
	public GameObject Bullet;

	// Use this for initialization


	void Start () {
		spawn = transform.position;
	}

	// Update is called once per frame
	void FixedUpdate () {
		input = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical"));

		GetComponent<Rigidbody> ().AddRelativeForce (input * speed);
		if (transform.position.y < -1) {
			transform.position = spawn;
		}

		if(Input.GetKeyUp(KeyCode.Space))
		{
			//Instantiate (Bullet, transform.position, Quaternion.identity);
			Instantiate (Bullet, transform.position, Bullet.transform.rotation);

		}





	}


	}
