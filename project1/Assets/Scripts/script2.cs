using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script2 : MonoBehaviour {
	public GameObject player;
	public project1 playerScript;

	// Use this for initialization


	void Start () {
		playerScript = player.GetComponent<project1> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (playerScript.health <= 0){
			//print ("Cube is dead.");
		}

	}
}
