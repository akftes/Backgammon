using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Queue_System_Of_Begin_Game : MonoBehaviour {
	private bool coroutineStarted;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

		if (!coroutineStarted && Game_Controller.Player1_First_throws_true && Game_Controller.Player2_First_throws_true) {
			coroutineStarted = true ;
			StartCoroutine (ExecuteAfterTime (1));
			
		}

	
	}
	//--------------------------------------
	public GameObject player1_icon,player2_icon,dice1_p1,dice2_p1,dice1_p2,dice2_p2;
	void determine_the_turn ()
	{
		
		if (Game_Controller.Player1_First_Number_Get > Game_Controller.Player2_Frist_Number_Get) {
			Game_Controller.P1Turn=true;
			dice1_p2.SetActive (false);
			dice2_p2.SetActive (false); 
			dice1_p1.SetActive (true);
			dice2_p1.SetActive (true); 
			dice1_p1.GetComponent<Visiblity_Dice> ().un_faint ();
			dice2_p1.GetComponent<Visiblity_Dice> ().un_faint ();
			Game_Controller.dice_Number1 = Game_Controller.Player1_First_Number_Get;
			Game_Controller.dice_Number2 = Game_Controller.Player2_Frist_Number_Get;
			dice1_p1.GetComponent<Visiblity_Dice> ().show_dice_from_out (Game_Controller.dice_Number1);
			dice2_p1.GetComponent<Visiblity_Dice> ().show_dice_from_out (Game_Controller.dice_Number2);
			dice2_p1.SetActive (true);
		}
		else if (Game_Controller.Player1_First_Number_Get < Game_Controller.Player2_Frist_Number_Get) {
			Game_Controller.P2Turn=true;
			dice1_p1.SetActive (false);
			dice2_p1.SetActive (false); 
			dice1_p2.SetActive (true);
			dice2_p2.SetActive (true);
			dice1_p2.GetComponent<Visiblity_Dice> ().un_faint ();
			dice2_p2.GetComponent<Visiblity_Dice> ().un_faint ();
			Game_Controller.dice_Number1 = Game_Controller.Player2_Frist_Number_Get;
			Game_Controller.dice_Number2 = Game_Controller.Player1_First_Number_Get;

			dice1_p2.GetComponent<Visiblity_Dice> ().show_dice_from_out (Game_Controller.Player2_Frist_Number_Get);
			dice2_p2.GetComponent<Visiblity_Dice> ().show_dice_from_out ( Game_Controller.Player1_First_Number_Get);

	}
		Game_Controller.Player1_First_throws_true = false;
		Game_Controller.Player2_First_throws_true = false;
		Game_Controller.Different_numbers_on_the_dice_flag = true;

		GameObject.Find("Queue_System").GetComponent<Queue_System> ().Show_Player ();
}

	IEnumerator ExecuteAfterTime(float time)
	{
		yield return new WaitForSeconds (time);

		determine_the_turn ();
	}
		

}
