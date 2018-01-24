using UnityEngine;
using System.Collections;

public class project1: MonoBehaviour {
	public int health;
	public string[] my_array;


	public enum WeaponType
	{
		Sword, Gun, Staff, Blade
	}

	public WeaponType primary_weapon;
	void Start() {
		StartCoroutine (Go(5f, "frame 1", "after 5 secs"));

		my_array = new string[3];
		my_array [0] = "Sword";
		my_array [1] = "Potion";
		my_array [2] = "Diamond";

		for (int i = 0; i < my_array.Length; i++) 
		{
			print(my_array[i]);
		}
	
	}
	


	void Damage_player(int damage)
	{
		health -= damage;

	}

	void Update() {
		switch(primary_weapon)
		{
		case WeaponType.Gun:
			print ("FIRE AT WILL!!!");
			break;
		case WeaponType.Blade:
			print ("Stab");
			break;
		case WeaponType.Staff:
			print ("Slam");
			break;
		case WeaponType.Sword:
			print ("Slice");
			break;
		}


		Damage_player (1);
		if (health <= 0) {
			health = 0;
			Destroy (gameObject, 2.5f);
			Debug.Log ("The player has died.");

		}

	}

	IEnumerator Go(float duration, string text1, string text2)
	{
		print (Time.time + " " + text1);
		yield return new WaitForSeconds (duration);
		print (Time.time + " " + text2);
	}
}
