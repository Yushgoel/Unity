using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour {
	public int current_level;
	public GameObject Explosion;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "Finish")
		{
			print ("You win!!!");
			if (current_level < 0)
			{
				current_level += 1;
				Application.LoadLevel(current_level);
			}
			else
			{
				//print ("Lol");
			}
		}

		/**/

		}
	}
