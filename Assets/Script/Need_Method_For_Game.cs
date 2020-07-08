using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Reflection;
public class Need_Method_For_Game  {


	//--------------------------------------------------------------------------------------
	public void hide_guide()
	{
		int i; 
		for (i = 0; i < 25; i++) {
			Game_Controller.guide[i].SetActive(false);

		}
	}
	public void Remove_all_Listener_from_Nutes ()
	{
		for (int i = 0; i < 26; i++)
			for (int j = 0; j < 15; j++) {
				if (Game_Controller.Database [i, j].Nute_M != null) {
					EventTrigger trigger =Game_Controller.Database [i, j].Nute_M.transform.GetChild(0).GetComponent<EventTrigger> ();
					if(trigger!=null){
					List<EventTrigger.Entry> entriesToRemove = new List<EventTrigger.Entry>();

					//finding required entry by eventId
					foreach (var entry in trigger.triggers)
					{        
						if (entry.eventID == EventTriggerType.PointerClick)
						{
							//remove listener from entry
							entry.callback.RemoveAllListeners();
							//add entry to transitional list
							entriesToRemove.Add(entry);
						}
					}

					//remove all entries satisfied condition from triggerlist
					foreach(var entry in entriesToRemove)
					{
						trigger.triggers.Remove(entry);
					}
					}//end of if trigger not null
				}//end of if
			}//end of for 
	}
	//---------------------------------------------------------------------------
	public void stop_transparency_of_all_nutes()
	{
		byte indexi, indexj;
	
		//-------------------
		for (indexi = 1; indexi <= 24; indexi++)
			for (indexj = 0; indexj < 15; indexj++) {
				if (Game_Controller.Database [indexi, indexj].Nute_M != null)

				
					Game_Controller.Database [indexi, indexj].Nute_M.GetComponent<Transparent_Of_Sprite> ().stop_Transparency ();
				
					
			
			}//End of for 
	}
	//---------------------------------------------------------------------------
	public void turn_off_all_nute()
	{
		for (int i = 0; i < 26; i++)
			for (int j = 0; j < 15; j++)
				if (Game_Controller.Database [i, j].Nute_M != null) {
					Game_Controller.Database [i, j].Nute_M.GetComponent<Turn_on_off> ().turn_off ();
				}//end of if (Game_Controller.Database [i, j].Nute_M != null) {

	}
	//--------------------------------------------------------------------
	public void Refresh_Flag()
	{
		Game_Controller.Different_numbers_on_the_dice_flag=false;
		Game_Controller.pairs_number_of_dice=false;
		Game_Controller.pairs_gone1 = false ;
		Game_Controller.pairs_gone2 = false ;
		Game_Controller.pairs_gone3 = false ;
		Game_Controller.pairs_gone3 = false ;
		Game_Controller.pairs_gone4 = false ;
		Game_Controller.dice_number1_gone = false;
		Game_Controller.dice_number2_gone = false;
		Game_Controller.dice_sum_gone=false ;
		Game_Controller.dice_Number1 = 0;
		Game_Controller.dice_Number2 = 0;
		Game_Controller.Player1_First_throws_true = false;
		Game_Controller.Player2_First_throws_true = false;
	}
	//-------------------------------------------------------------------
	public void Refresh_Flag_Of_All_Nutes()
	{
		for (int i = 0; i < 26; i++)
			for (int j = 0; j < 15; j++) {
				if (Game_Controller.Database [i, j].Nute_M != null) {
					Game_Controller.Database [i, j].have_with_dice1_flag = false;
					Game_Controller.Database [i, j].have_with_dice2_flag = false;
					Game_Controller.Database [i, j].have_with_sum_dices_flag = false;
				}
			}

	}
	//------------------------------------------
	public	void check_flag_status()
	{
		Debug.Log ("//---------------------------------------------------// ");
		Debug.Log ("Game_Controller.Different_numbers_on_the_dice_flag = "+Game_Controller.Different_numbers_on_the_dice_flag.ToString());
		Debug.Log ("pairs_number_of_dice = "+Game_Controller.pairs_number_of_dice.ToString());

		Debug.Log ("pairs_gone1 = " + Game_Controller.pairs_gone1.ToString ());
		Debug.Log ("pairs_gone2 = " + Game_Controller.pairs_gone2.ToString ());
		Debug.Log ("pairs_gone3 = " + Game_Controller.pairs_gone3.ToString ());
		Debug.Log ("pairs_gone4 = " + Game_Controller.pairs_gone4.ToString ());
		Debug.Log ("P1_Turn = " + Game_Controller.P1Turn.ToString ());
		Debug.Log ("P2_Turn = " + Game_Controller.P2Turn.ToString ());
		Debug.Log ("dice_Number1 = " + Game_Controller.dice_Number1.ToString ());
		Debug.Log ("dice_Number2 = " + Game_Controller.dice_Number2.ToString ());
		Debug.Log ("Player1_First_Number_Get = " + Game_Controller.Player1_First_Number_Get.ToString ());
		Debug.Log ("Player2_First_Number_Get = " + Game_Controller.Player2_Frist_Number_Get.ToString ());
		Debug.Log ("Player1_First_throws_true = " + Game_Controller.Player1_First_throws_true.ToString ());
		Debug.Log ("Player2_First_throws_true = " + Game_Controller.Player2_First_throws_true.ToString ());
		Debug.Log ("dice_number1_gone = " + Game_Controller.dice_number1_gone.ToString ());
		Debug.Log ("dice_number2_gone = " + Game_Controller.dice_number2_gone.ToString ());
		Debug.Log ("dice_sum_gone = " + Game_Controller.dice_sum_gone.ToString ());
		Debug.Log ("//---------------------------------------------------// ");


	}


		
	//------------------------------------------------------------------

}
