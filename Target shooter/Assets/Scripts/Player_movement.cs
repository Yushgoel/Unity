using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_movement : MonoBehaviour {
	public float speed;
	private Vector3 input;
	private Vector3 spawn;
	public GameObject Bullet;
	private int times_pressed = 0;
	public int total_bull;
	// Use this for initialization
	private int num_bullets = 5;
	public Text bull;
	public GameObject particles;
	public Text reload;
	void Start () {
		spawn = transform.position;
		bull.text = "";
		reload.text = "";
	}

	// Update is called once per frame
	void FixedUpdate () {
		input = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical"));
		if (num_bullets == 0 & total_bull == 0) {
			bull.text = "OUT OF AMMO";
		} else {
			bull.text = "Ammo: " + num_bullets + " | " + total_bull;
			if (num_bullets != 5 & total_bull != 0) 
			{
				
				if (Input.GetKeyDown (KeyCode.R)) {
					num_bullets = 5;
					total_bull -= 5;
				}
			}
		}
		if (num_bullets == 0) {
			reload.text = "Press 'R' to reload";
		
		} else {
			reload.text = "";
		}
			
		GetComponent<Rigidbody> ().AddRelativeForce (input * speed);
		if (transform.position.y < -1) {
			transform.position = spawn;
		}


		if(Input.GetKeyDown(KeyCode.Space))
		{
			//Instantiate (Bullet, transform.position, Quaternion.identity);
			//
			times_pressed += 1;
			//print ("Hello" + times_pressed);
			if (times_pressed < 2) {
				if (num_bullets > 0){
					Instantiate (Bullet, transform.position, Bullet.transform.rotation);
					times_pressed += 1;
					num_bullets -= 1;
				}
				else
				{
					print ("Out of ammo");

				}

			}
			//Instantiate (Bullet, transform.position, Bullet.transform.rotation);


		}
		if (Input.GetKeyUp (KeyCode.Space)) {
			times_pressed = 0;
		}
	}
		void OnCollisionEnter(Collision other)
		{
			if(other.gameObject.tag == "Hit")
			{
			Instantiate (particles, transform.position, Quaternion.identity);
				transform.position = spawn;
			}
		}
}
