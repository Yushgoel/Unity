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
	// Use this for initialization
	private int num_bullets = 5;
	public Text bull;
	void Start () {
		spawn = transform.position;
		bull.text = "";
	}

	// Update is called once per frame
	void FixedUpdate () {
		input = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical"));
		if (num_bullets > 0) {
			bull.text = "Ammo: " + num_bullets;
		} else {
			bull.text = "OUT OF AMMO";
		}
		bull.text = "Ammo: " + num_bullets;
		GetComponent<Rigidbody> ().AddRelativeForce (input * speed);
		if (transform.position.y < -1) {
			transform.position = spawn;
		}

		/*if(Input.GetKeyUp(KeyCode.Space))
		{
			//Instantiate (Bullet, transform.position, Quaternion.identity);
			i ++;
			//
			print ("Up" + i);

			Instantiate (Bullet, transform.position, Bullet.transform.rotation);


		}*/
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
	//IEnumerator(float duration)
	//{
	//	yield return new WaitForSeconds();
	//}
}
