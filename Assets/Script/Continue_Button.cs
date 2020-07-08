using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continue_Button : MonoBehaviour {
	public GameObject dice1_p1,dice2_p1,dice1_p2,dice2_p2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//-----------------------------------------------
	public void onclick()
	{

		Game_Controller.dice_number1_gone = false;
		Game_Controller.dice_number2_gone = false;
		Game_Controller.dice_sum_gone = false;		
		Game_Controller.Different_numbers_on_the_dice_flag = false;
		byte Number_1, Number_2;
		 
		 if (Game_Controller.P2Turn) {
			Game_Controller.P1Turn = true;
			Game_Controller.P2Turn = false;
			dice1_p1.SetActive (true);
			dice2_p1.SetActive (true);
			dice2_p1.GetComponent<Visiblity_Dice> ().showing ();
			dice1_p1.GetComponent<Visiblity_Dice> ().un_faint ();
			dice2_p1.GetComponent<Visiblity_Dice> ().un_faint ();
			Number_1=dice1_p1.GetComponent<Visiblity_Dice> ().Throw ();
			Game_Controller.dice_Number1 = Number_1;
			Number_2=dice2_p1.GetComponent<Visiblity_Dice> ().Throw ();
			Game_Controller.dice_Number2 = Number_2;


		} 
		else if (Game_Controller.P1Turn)
		{
			Game_Controller.P1Turn = false;
			Game_Controller.P2Turn = true;
			dice1_p2.SetActive (true);
			dice2_p2.SetActive (true);

			dice1_p2.GetComponent<Visiblity_Dice> ().un_faint ();
			dice2_p2.GetComponent<Visiblity_Dice> ().un_faint ();
			Number_1=dice1_p2.GetComponent<Visiblity_Dice> ().Throw ();
			Game_Controller.dice_Number1 = Number_1;
			Number_2=dice2_p2.GetComponent<Visiblity_Dice> ().Throw ();
			Game_Controller.dice_Number2 = Number_2;


		}
		Game_Controller.Different_numbers_on_the_dice_flag = true;
		this.gameObject.SetActive (false);

		GameObject.Find("Queue_System").GetComponent<Queue_System> ().Show_Player ();

		//}
	}
}
