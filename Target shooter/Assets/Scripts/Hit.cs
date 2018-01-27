using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hit : MonoBehaviour {
	public int current_level;
	public GameObject particles;
	public Text Win_text;

	// Use this for initialization
	void Start () {
		Win_text.text = "";
	}

	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "Hit")
		{
			print ("You win!!!");

			Instantiate (particles, other.transform.position, Quaternion.identity);
			if (current_level < 0)
			{
				current_level += 1;
				Application.LoadLevel(current_level);
			}
			else
			{
				Win_text.text = "You win";
				gameObject.SetActive(false);
			}
		}



		}
	}
