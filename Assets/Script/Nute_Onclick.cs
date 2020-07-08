using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Nute_Onclick : MonoBehaviour {
	Detect_Movable_Nutes  detect_movable_Nutes_intfc  = new Detect_Movable_Nutes();

	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame

	void Update () {
		
	}
	//--------------------------------------
	public void onclick(int sented_indxi,int sented_indxj,string sented_tagname)
	{
		
		clear_Other_Nutes_Without_Me(sented_indxi,sented_indxj,sented_tagname);
		GameObject.Find ("Plane").GetComponent<Button> ().onClick.AddListener (()=> Background_Clicked());
		if (sented_tagname == "white")
			Detect_trgt_of_clicked_Nute_white (sented_indxi,sented_indxj);
		else
			Detect_trgt_of_clicked_Nute_red (sented_indxi,sented_indxj);
			
	}
	//***********************************************
	void clear_Other_Nutes_Without_Me(int i,int j,string getedtagname)
	{
		byte indexi, indexj;
		//-------------------
		for (indexi = 1; indexi <= 24; indexi++)
			for (indexj = 0; indexj < 15; indexj++) {
				if (Game_Controller.Database [indexi, indexj].Nute_M != null)
				if(detect_movable_Nutes_intfc.is_top(indexi,indexj)&&(Game_Controller.Database [indexi, indexj].Nute_M.CompareTag(getedtagname)))
				if ((Game_Controller.Database [indexi, indexj].Nute_M != Game_Controller.Database [i, j].Nute_M) &&(Game_Controller.Database [indexi, indexj].Nute_M.tag==getedtagname)) {
					
					Game_Controller.Database [indexi, indexj].Nute_M.GetComponent<Transparent_Of_Sprite> ().stop_Transparency ();
					Game_Controller.Database [indexi, indexj].Nute_M.GetComponent<Turn_on_off> ().turn_off ();
					//Game_Controller.Database [indexi, indexj].Nute_M.GetComponent<Button> ().onClick.RemoveAllListeners ();
					EventTrigger trigger =Game_Controller.Database [indexi, indexj].Nute_M.transform.GetChild(0).GetComponent<EventTrigger> ();


					List<EventTrigger.Entry> entriesToRemove = new List<EventTrigger.Entry>();
					if(trigger!=null){
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
					}//end of if for check trigger is null
					//trigger.triggers.Add (entry);				
				}//end of if (Game_Controller.Database [indexi, indexj].Nute_M != Game_Controller.Database [i, j].Nute_M) 
			}//End of for 
	}
	//**********************************************
	void Background_Clicked()
	{
		//hide_lights ();
		Need_Method_For_Game Need_Method_For_Game_intfc = new Need_Method_For_Game ();
		Need_Method_For_Game_intfc.hide_guide ();
		Need_Method_For_Game_intfc.Remove_all_Listener_from_Nutes ();
		//Need_Method_For_Game_intfc.turn_off_all_nute ();
		//Need_Method_For_Game_intfc.stop_transparency_of_all_nutes();
		Need_Method_For_Game_intfc.Refresh_Flag_Of_All_Nutes ();
		GameObject.Find ("Plane").GetComponent<Button> ().onClick.RemoveAllListeners ();

		if (Game_Controller.P1Turn) {
			

			detect_movable_Nutes_intfc.Turn_white_nute ();

		}
		else {
			

			detect_movable_Nutes_intfc.Turn_Red_nute ();


		}//end of Else 
		
	}//end of Background_Clicked
	//************************************************************************
	void Detect_trgt_of_clicked_Nute_white(int indxi,int indxj)
	{
		int targetnumber1;
		int targetnumber2;
		int targetsum;
		if (Game_Controller.Different_numbers_on_the_dice_flag) {

			targetnumber1 =  indxi +  Game_Controller.dice_Number1;
			targetnumber2 =  indxi + Game_Controller.dice_Number2;
			targetsum =  indxi+(Game_Controller.dice_Number1+Game_Controller.dice_Number2);
			if (Game_Controller.Database[indxi,indxj].have_with_dice1_flag){


					int m = targetnumber1;
					Game_Controller.guide [m].SetActive (true);
					Game_Controller.guide [m].GetComponent<Transparent_Of_Sprite> ().start_tranparecncy ();
					Game_Controller.guide [m].AddComponent(typeof(EventTrigger));
					EventTrigger trigger =Game_Controller.guide [m].GetComponent<EventTrigger> ();
					EventTrigger.Entry entry = new EventTrigger.Entry ();
					entry.eventID = EventTriggerType.PointerClick;
				    entry.callback.AddListener ((eventData) => Game_Controller.guide [m].GetComponent<guide_Onclick>().onclick(m,indxi,indxj,targetnumber1,targetnumber2,targetsum));
					trigger.triggers.Add (entry);

					


			}//end of check dice1 flags  
			if(Game_Controller.Database[indxi,indxj].have_with_dice2_flag)
				{
					int m = targetnumber2;
				Game_Controller.guide [m].SetActive (true);
				Game_Controller.guide [m].GetComponent<Transparent_Of_Sprite> ().start_tranparecncy ();
				Game_Controller.guide [m].AddComponent(typeof(EventTrigger));
				EventTrigger trigger =Game_Controller.guide [m].GetComponent<EventTrigger> ();
				EventTrigger.Entry entry = new EventTrigger.Entry ();
				entry.eventID = EventTriggerType.PointerClick;
				entry.callback.AddListener ((eventData) => Game_Controller.guide [m].GetComponent<guide_Onclick>().onclick(m,indxi,indxj,targetnumber1,targetnumber2,targetsum));
				trigger.triggers.Add (entry);

				}
			if (Game_Controller.Database[indxi,indxj].have_with_sum_dices_flag) {
				int m = targetsum;
				Game_Controller.guide [m].SetActive (true);
				Game_Controller.guide [m].GetComponent<Transparent_Of_Sprite> ().start_tranparecncy ();
				Game_Controller.guide [m].AddComponent(typeof(EventTrigger));
				EventTrigger trigger =Game_Controller.guide [m].GetComponent<EventTrigger> ();
				EventTrigger.Entry entry = new EventTrigger.Entry ();
				entry.eventID = EventTriggerType.PointerClick;
				entry.callback.AddListener ((eventData) => Game_Controller.guide [m].GetComponent<guide_Onclick>().onclick(m,indxi,indxj,targetnumber1,targetnumber2,targetsum));
				trigger.triggers.Add (entry);
			}

		}//end of check of defrent dice number 
		
	}
	//************************************************************************
	void Detect_trgt_of_clicked_Nute_red(int indxi,int indxj)
	{
		int targetnumber1;
		int targetnumber2;
		int targetsum;
		if (Game_Controller.Different_numbers_on_the_dice_flag) {

			targetnumber1 =  indxi -  Game_Controller.dice_Number1;
			targetnumber2 =  indxi - Game_Controller.dice_Number2;
			targetsum =  indxi+(-(Game_Controller.dice_Number1)+(-(Game_Controller.dice_Number2)));
			if (Game_Controller.Database[indxi,indxj].have_with_dice1_flag){


				int m = targetnumber1;
				Game_Controller.guide [m].SetActive (true);
				Game_Controller.guide [m].GetComponent<Transparent_Of_Sprite> ().start_tranparecncy ();
				Game_Controller.guide [m].AddComponent(typeof(EventTrigger));
				EventTrigger trigger =Game_Controller.guide [m].GetComponent<EventTrigger> ();
				EventTrigger.Entry entry = new EventTrigger.Entry ();
				entry.eventID = EventTriggerType.PointerClick;
				entry.callback.AddListener ((eventData) => Game_Controller.guide [m].GetComponent<guide_Onclick>().onclick(m,indxi,indxj,targetnumber1,targetnumber2,targetsum));
				trigger.triggers.Add (entry);

			}//end of check dice1 flags  
			if(Game_Controller.Database[indxi,indxj].have_with_dice2_flag)
			{
				int m = targetnumber2;
				Game_Controller.guide [m].SetActive (true);
				Game_Controller.guide [m].GetComponent<Transparent_Of_Sprite> ().start_tranparecncy ();
				Game_Controller.guide [m].AddComponent(typeof(EventTrigger));
				EventTrigger trigger =Game_Controller.guide [m].GetComponent<EventTrigger> ();
				EventTrigger.Entry entry = new EventTrigger.Entry ();
				entry.eventID = EventTriggerType.PointerClick;
				entry.callback.AddListener ((eventData) => Game_Controller.guide [m].GetComponent<guide_Onclick>().onclick(m,indxi,indxj,targetnumber1,targetnumber2,targetsum));
				trigger.triggers.Add (entry);

			}
			if (Game_Controller.Database[indxi,indxj].have_with_sum_dices_flag) {
				int m = targetsum;
				Game_Controller.guide [m].SetActive (true);
				Game_Controller.guide [m].GetComponent<Transparent_Of_Sprite> ().start_tranparecncy ();
				Game_Controller.guide [m].AddComponent(typeof(EventTrigger));
				EventTrigger trigger =Game_Controller.guide [m].GetComponent<EventTrigger> ();
				EventTrigger.Entry entry = new EventTrigger.Entry ();
				entry.eventID = EventTriggerType.PointerClick;
				entry.callback.AddListener ((eventData) => Game_Controller.guide [m].GetComponent<guide_Onclick>().onclick(m,indxi,indxj,targetnumber1,targetnumber2,targetsum));
				trigger.triggers.Add (entry);
			}

		}//end of check of defrent dice number
	}
	//************************************************************************

	


//-------------------------------------------------------------------
}