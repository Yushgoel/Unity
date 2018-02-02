using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_move : MonoBehaviour {
	private float y_value;
	private float x_value;
	private float z_value;
	public float pos_neg;

	private Vector3 New_position;
	// Use this for initialization
	void Start () {
		New_position = transform.position;
		x_value = transform.position.x;
		y_value = transform.position.y;
		z_value = transform.position.z;
	}

	// Update is called once per frame
	void FixedUpdate () {
		Move ();
	}

	void Move()
	{
		z_value += pos_neg;
		New_position = new Vector3 (x_value, y_value, z_value);
		transform.position = New_position;
	}
}
