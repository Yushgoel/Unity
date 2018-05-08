using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_1 : MonoBehaviour {
	public Rigidbody rb;
	public Transform Hand_rotate;
	public Transform Leg_rotate;
	public Transform ducker;
	[SerializeField]
	private float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKey(KeyCode.D))
		{
			float force = transform.position.z + speed;

			transform.position = new Vector3 (transform.position.x, transform.position.y, force);		
		}


		if(Input.GetKey(KeyCode.A))
		{

			float force = transform.position.z - speed;
			transform.position = new Vector3 (transform.position.x, transform.position.y, force);
		}


		if (Input.GetKey (KeyCode.S)) 
		{
			StartCoroutine (bend());
		}


		if (Input.GetKey (KeyCode.W)) 
		{
			jump();
		}

		if (Input.GetKey (KeyCode.Alpha1))
		{
			StartCoroutine (punch());
		}
		if (Input.GetKey (KeyCode.Alpha2))
		{
			StartCoroutine (kick());
		}


	}

	IEnumerator bend()
	{
		 

		ducker.transform.rotation = Quaternion.Lerp(ducker.transform.rotation, Quaternion.Euler(ducker.transform.rotation.x -70f, ducker.transform.rotation.y, ducker.transform.rotation.z), 2f);

		yield return new WaitForSeconds (1f);
		ducker.transform.rotation = Quaternion.Lerp(ducker.transform.rotation, Quaternion.Euler(0f, 0f, 0f), 2f);

		//while (transform.rotation.x != 0) {
			//Quaternion rotate = new Vector3 (transform.rotation.x + 1f, transform.rotation.y, transform.rotation.z);
	
		//}
	}

	void jump()
	{
		while (transform.position.y < 8f) {
			transform.position = new Vector3 (transform.position.x, transform.position.y + 0.1f, transform.position.z);
		}
	}

	IEnumerator punch()
	{
		Hand_rotate.transform.rotation = Quaternion.Lerp(Hand_rotate.transform.rotation, Quaternion.Euler(Hand_rotate.transform.rotation.x - 80f, Hand_rotate.transform.rotation.y, Hand_rotate.transform.rotation.z), 2f);

		yield return new WaitForSeconds (0.5f);
		Hand_rotate.transform.rotation = Quaternion.Lerp(Hand_rotate.transform.rotation, Quaternion.Euler(0f, 0f, 0f), 2f);
	}
	IEnumerator kick()
	{
		Leg_rotate.transform.rotation = Quaternion.Lerp(Leg_rotate.transform.rotation, Quaternion.Euler(Leg_rotate.transform.rotation.x - 85f, Leg_rotate.transform.rotation.y, Leg_rotate.transform.rotation.z), 2f);

		yield return new WaitForSeconds (0.5f);
		Leg_rotate.transform.rotation = Quaternion.Lerp(Leg_rotate.transform.rotation, Quaternion.Euler(0f, 0f, 0f), 2f);
	}
}
