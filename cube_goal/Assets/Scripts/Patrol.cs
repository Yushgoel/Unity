using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour {
	public Transform[] patrol_points;
	private int current_point;
	public float espeed;
	// Use this for initialization
	void Start () {
		transform.position = patrol_points [0].position;
		current_point = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position == patrol_points[current_point].position)
		{
			current_point++;
		}
		if (current_point == patrol_points.Length) 
		{
			current_point = 0;
		}
		transform.position = Vector3.MoveTowards (transform.position, patrol_points[current_point].position, espeed * Time.deltaTime);

	}


}
