using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_manager : MonoBehaviour {
	public static int score;
	public static int high_score;
	public static int current_level = 0;
	public static int unlocked_level;

	public static void CompleteLevel()
	{
		if (current_level < 2)
		{
			current_level += 1;
			Application.LoadLevel (current_level);
		}else
		{
			print("You win");
		}
	}


}
