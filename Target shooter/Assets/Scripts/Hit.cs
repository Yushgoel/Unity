using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hit : MonoBehaviour {
	public int current_level;
	public GameObject Explosion;
	public Text win;

	// Use this for initialization
	void Start () {
		win.text = "";
	}

	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision other)
	{
		
		if(other.gameObject.tag == "Finish")
		{
			print ("You win!!!");
			Instantiate (Explosion, transform.position, Quaternion.identity);
			gameObject.SetActive (false);
			win.text = "You Win";
			if (current_level < 0)
			{
				current_level += 1;
				Application.LoadLevel(current_level);
			}

		}

		/**/

		}
	}
