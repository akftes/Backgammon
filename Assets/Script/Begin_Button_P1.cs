using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begin_Button_P1 : MonoBehaviour {
	static byte Number;
	public GameObject dice1_p1,dice2_p1;
	public GameObject this_text;
	// Use this for initialization
	public void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//--------------------------------------------------------
	public void Onclick_of_begin (/*ref GameObject[] white_Nutes,ref GameObject[] red_Nutes*/) 
	{

		//Number_1=GameObject.Find ("dice1").GetComponent<Visiblity_Dice> ().Throw ();
		//Number_2=GameObject.Find ("dice2").GetComponent<Visiblity_Dice> ().Throw ();
		//Game_Controller.dice_Number1 = Number_1;
		//Game_Controller.dice_Number2 = Number_2;
		Number=dice1_p1.GetComponent<Visiblity_Dice> ().Throw_of_Beginning_mode();
		Game_Controller.Player1_First_Number_Get = Number;
		Game_Controller.Player1_First_throws_true = true;
		dice2_p1.SetActive (false);
		dice1_p1.GetComponent<Visiblity_Dice> ().un_faint ();
		this_text.GetComponent<Transparent> ().stop_Transparency ();
		this.gameObject.SetActive (false);



		//}


	}//end of Onclick_of_begin()
	//-------------------------------------------------------
	public void Onclick_of_continue (/*ref GameObject[] white_Nutes,ref GameObject[] red_Nutes*/) 
	{

		//Number_1=GameObject.Find ("dice1").GetComponent<Visiblity_Dice> ().Throw ();
		//Number_2=GameObject.Find ("dice2").GetComponent<Visiblity_Dice> ().Throw ();
		//Game_Controller.dice_Number1 = Number_1;
		//Game_Controller.dice_Number2 = Number_2;
		Number=dice1_p1.GetComponent<Visiblity_Dice> ().Throw();
		Game_Controller.dice_Number1 = Number;
	

		dice1_p1.GetComponent<Visiblity_Dice> ().un_faint ();
		dice2_p1.GetComponent<Visiblity_Dice> ().un_faint ();
		this_text.GetComponent<Transparent> ().stop_Transparency ();
		this.gameObject.SetActive (false);



		//}


	}//end of Onclick_of_begin()
}
