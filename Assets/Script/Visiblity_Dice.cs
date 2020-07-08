using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Visiblity_Dice : MonoBehaviour {

	int Random_Number;

	//------------------------------------------------------------------
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	//------------------------------------------------------------------
	public void showing()
	{
		foreach(Transform  child in this.transform)
		{
			child.gameObject.SetActive (true);
		}

	}
//-------------------------------------------------------------------------
	public void hiding()
	{
		foreach(Transform  child in this.transform)
		{
			child.gameObject.SetActive (false);
		}

	}
//-------------------------------------------------------------------------
	public void faint()
	{
		foreach (Transform child in this.transform) {
			Color temp = child.gameObject.GetComponent<SpriteRenderer> ().material.color;
			temp.a = 0.15f;
			child.gameObject.GetComponent<SpriteRenderer> ().material.color = temp;

		}
	}
	public void un_faint()
	{
		foreach (Transform child in this.transform) {
			Color temp = child.gameObject.GetComponent<SpriteRenderer> ().material.color;
			temp.a = 1f;
			child.gameObject.GetComponent<SpriteRenderer> ().material.color = temp;
			}
			
	}
//-----------------------------------------------------------------------
	public byte Throw()
	{
		byte Random_Number=0;
		GameObject side1 = this.transform.GetChild(0).gameObject;
		GameObject side2 = this.transform.GetChild(1).gameObject;
		GameObject side3 = this.transform.GetChild(2).gameObject;
		GameObject side4 = this.transform.GetChild(3).gameObject;
		GameObject side5 = this.transform.GetChild(4).gameObject;
		GameObject side6 = this.transform.GetChild(5).gameObject;
		//-----------------------------------------------------------------
		if((Game_Controller.dice_Number1 != 0) ||(Game_Controller.dice_Number2 !=0))
		{
			Debug.Log ("I Enter to  if((Game_Controller.dice_Number1 != 0) ||(Game_Controller.dice_Number2 !=0)) in Throw method");
			if(Game_Controller.dice_Number1 != 0)
			{
				do
				{
					Random_Number=(byte)Random.Range (1,6);
				}while(Random_Number==Game_Controller.dice_Number1);
			}
			else if(Game_Controller.dice_Number2 != 0)
			{
				do
				{
					Random_Number=(byte)Random.Range (1,6);
				}while(Random_Number==Game_Controller.dice_Number2);

			}


		}
		else{
			Random_Number=(byte)Random.Range (1,6);
		}
		//Random_Number=(byte)Random.Range (1,6);
		//-----------------------------------------------------------------
		switch (Random_Number) { default:
		case (1):
			side1.SetActive (true);
			side2.SetActive (false);
			side3.SetActive (false);
			side4.SetActive (false);
			side5.SetActive (false);
			side6.SetActive (false);
			break;
		case (2): 
			side1.SetActive (false);
			side2.SetActive (true);
			side3.SetActive (false);
			side4.SetActive (false);
			side5.SetActive (false);
			side6.SetActive (false);
			break;
		case (3):
			side1.SetActive (false);
			side2.SetActive (false);
			side3.SetActive (true);
			side4.SetActive (false);
			side5.SetActive (false);
			side6.SetActive (false);
			break;
		case (4): 
			side1.SetActive (false);
			side2.SetActive (false);
			side3.SetActive (false);
			side4.SetActive (true);
			side5.SetActive (false);
			side6.SetActive (false);
			break;
		case (5):
			side1.SetActive (false);
			side2.SetActive (false);
			side3.SetActive (false);
			side4.SetActive (false);
			side5.SetActive (true);
			side6.SetActive (false);
			break;
		case (6):
			side1.SetActive (false);
			side2.SetActive (false);
			side3.SetActive (false);
			side4.SetActive (false);
			side5.SetActive (false);
			side6.SetActive (true);
			break;
		}

		return Random_Number;
	}
	//----------------------------------------
	public void show_dice_from_out(byte number) 
	{
		GameObject side1 = this.transform.GetChild(0).gameObject;
		GameObject side2 = this.transform.GetChild(1).gameObject;
		GameObject side3 = this.transform.GetChild(2).gameObject;
		GameObject side4 = this.transform.GetChild(3).gameObject;
		GameObject side5 = this.transform.GetChild(4).gameObject;
		GameObject side6 = this.transform.GetChild(5).gameObject;
		switch (number) { default:
		case (1):
			side1.SetActive (true);
			side2.SetActive (false);
			side3.SetActive (false);
			side4.SetActive (false);
			side5.SetActive (false);
			side6.SetActive (false);
			break;
		case (2): 
			side1.SetActive (false);
			side2.SetActive (true);
			side3.SetActive (false);
			side4.SetActive (false);
			side5.SetActive (false);
			side6.SetActive (false);
			break;
		case (3):
			side1.SetActive (false);
			side2.SetActive (false);
			side3.SetActive (true);
			side4.SetActive (false);
			side5.SetActive (false);
			side6.SetActive (false);
			break;
		case (4): 
			side1.SetActive (false);
			side2.SetActive (false);
			side3.SetActive (false);
			side4.SetActive (true);
			side5.SetActive (false);
			side6.SetActive (false);
			break;
		case (5):
			side1.SetActive (false);
			side2.SetActive (false);
			side3.SetActive (false);
			side4.SetActive (false);
			side5.SetActive (true);
			side6.SetActive (false);
			break;
		case (6):
			side1.SetActive (false);
			side2.SetActive (false);
			side3.SetActive (false);
			side4.SetActive (false);
			side5.SetActive (false);
			side6.SetActive (true);
			break;
	}
	}//end of public void show_dice_from_out(byte number)
	//-------------------------------------
	public byte  Throw_of_Beginning_mode()
	{
		byte Random_Number=0;
		GameObject side1 = this.transform.GetChild(0).gameObject;
		GameObject side2 = this.transform.GetChild(1).gameObject;
		GameObject side3 = this.transform.GetChild(2).gameObject;
		GameObject side4 = this.transform.GetChild(3).gameObject;
		GameObject side5 = this.transform.GetChild(4).gameObject;
		GameObject side6 = this.transform.GetChild(5).gameObject;
		//-----------------------------------------------------------------
		if((Game_Controller.Player1_First_Number_Get != 0) ||(Game_Controller.Player2_Frist_Number_Get !=0))
		{
			if(Game_Controller.Player1_First_Number_Get != 0)
			{
				do
				{
					Random_Number=(byte)Random.Range (1,6);
				}while(Random_Number==Game_Controller.Player1_First_Number_Get);
			}
			else if(Game_Controller.Player2_Frist_Number_Get != 0)
			{
				do
				{
					Random_Number=(byte)Random.Range (1,6);
				}while(Random_Number==Game_Controller.Player2_Frist_Number_Get);
			
			}


		}
		else{
			Random_Number=(byte)Random.Range (1,6);
		}
		//-----------------------------------------------------------------
		switch (Random_Number) { default:
		case (1):
			side1.SetActive (true);
			side2.SetActive (false);
			side3.SetActive (false);
			side4.SetActive (false);
			side5.SetActive (false);
			side6.SetActive (false);
			break;
		case (2): 
			side1.SetActive (false);
			side2.SetActive (true);
			side3.SetActive (false);
			side4.SetActive (false);
			side5.SetActive (false);
			side6.SetActive (false);
			break;
		case (3):
			side1.SetActive (false);
			side2.SetActive (false);
			side3.SetActive (true);
			side4.SetActive (false);
			side5.SetActive (false);
			side6.SetActive (false);
			break;
		case (4): 
			side1.SetActive (false);
			side2.SetActive (false);
			side3.SetActive (false);
			side4.SetActive (true);
			side5.SetActive (false);
			side6.SetActive (false);
			break;
		case (5):
			side1.SetActive (false);
			side2.SetActive (false);
			side3.SetActive (false);
			side4.SetActive (false);
			side5.SetActive (true);
			side6.SetActive (false);
			break;
		case (6):
			side1.SetActive (false);
			side2.SetActive (false);
			side3.SetActive (false);
			side4.SetActive (false);
			side5.SetActive (false);
			side6.SetActive (true);
			break;
		}

		return Random_Number;
	
		
	}//end of public void public Throw_of_Beginning_mode()
}
