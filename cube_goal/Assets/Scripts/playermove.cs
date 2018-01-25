using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class playermove : MonoBehaviour {
	public float speed;
	private Vector3 input;
	private float maxspeed = 10f;
	private Vector3 spawn;
	public GameObject death_particles;

	// Use this for initialization
	void Start () {
		spawn = transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		input = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical"));
		if (GetComponent<Rigidbody> ().velocity.magnitude < maxspeed) {
			GetComponent<Rigidbody> ().AddForce (input * speed);
		}
		if (transform.position.y < 0) 
		{
			Die ();
		}
	}


	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Player") 
		{
			Die ();
		}	
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Goall")
		{
			Game_manager.CompleteLevel ();
		}	
	}
	void Die()
	{
		Instantiate (death_particles, transform.position, Quaternion.identity);
		transform.position = spawn;
	}

	
}
