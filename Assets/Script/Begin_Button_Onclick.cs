
using UnityEngine;
using System.Collections;

public class Begin_Button_Onclick : MonoBehaviour {
	


	public GameObject dice1_p1,dice2_p1;
	static byte Number;
	public GameObject throw_text;
	//------------------------------------------------------------


	public void Start () {


								

	}

	void Awake()
	{
		
		
	}

	// Update is called once per frame
	void Update () {

	}
	//------------------------------------------------------------
	public void On_click (ref GameObject[] white_Nutes,ref GameObject[] red_Nutes) 
	{
		
		//Number_1=GameObject.Find ("dice1").GetComponent<Visiblity_Dice> ().Throw ();
		//Number_2=GameObject.Find ("dice2").GetComponent<Visiblity_Dice> ().Throw ();
		//Game_Controller.dice_Number1 = Number_1;
		//Game_Controller.dice_Number2 = Number_2;
		Number=GameObject.Find ("dice1_P1").GetComponent<Visiblity_Dice> ().Throw ();
		/*if (Number_1 >= Number_2) {
			Game_Controller.P1Turn = true;
			Game_Controller.P2Turn = false;
				
		} 
		else if (Number_1 < Number_2)
		{
			Game_Controller.P1Turn = false;
			Game_Controller.P2Turn = true;
		} */

		throw_text.SetActive (false);
		Game_Controller.Different_numbers_on_the_dice_flag = true;
		this.gameObject.SetActive (false);
		GameObject.Find("Queue_System").GetComponent<Queue_System> ().Show_Player ();

			
		//}


	}//End Of onclick ()
}//End Of class Begin_Button_Onclick
