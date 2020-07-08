using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Detect_Movable_Nutes  {
	Need_Method_For_Game  intfc_Need_Method_For_Game = new Need_Method_For_Game();

	//-----------------------------------------------
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

	}
	//-----------------------------------------------
	public void  Turn_white_nute()
	{
		intfc_Need_Method_For_Game.check_flag_status ();
		byte i=0, j=0;

		for (i = 1; i <= 24; i++)
			for (j = 0; j < 15; j++) {
				byte m, n;
				m = i;
				n = j;
				if (Game_Controller.Database [m, n].Nute_M != null) {
					if (Game_Controller.Database [m, n].Nute_M.CompareTag ("white")){
				if ((!Game_Controller.dice_number1_gone) && (!Game_Controller.dice_number2_gone) && (!Game_Controller.dice_sum_gone)) {
					


						if (is_top (m, n)) {
							int sum_of_dice = Game_Controller.dice_Number1 + Game_Controller.dice_Number2; 
							if (nute_have_move (Game_Controller.Database [i, j].Nute_M, Game_Controller.dice_Number1, m, n)) {
								Game_Controller.Database [m, n].Nute_M.GetComponent<Turn_on_off> ().turn_on ();
								Game_Controller.Database [m, n].Nute_M.GetComponent<Transparent_Of_Sprite> ().start_tranparecncy ();
								Game_Controller.Database [m, n].have_with_dice1_flag = true;

								//Game_Controller.Database [m, n].Nute_M.GetComponent<Button> ().onClick.AddListener (() => Game_Controller.Database [m, n].Nute_M.GetComponent<Nute_Onclick> ().onclick (m, n, "white"));

									Game_Controller.Database [m, n].Nute_M.transform.GetChild(0).gameObject.AddComponent(typeof(EventTrigger));
									EventTrigger trigger =Game_Controller.Database [m, n].Nute_M.transform.GetChild(0).GetComponent<EventTrigger> ();
									EventTrigger.Entry entry = new EventTrigger.Entry ();
									entry.eventID = EventTriggerType.PointerClick;
									entry.callback.AddListener ((eventData) => Game_Controller.Database [m, n].Nute_M.transform.GetChild(0).GetComponent<Nute_Onclick> ().onclick (m, n, "white"));

									trigger.triggers.Add (entry);

							}//end of have nute move with dice1
							if(nute_have_move(Game_Controller.Database [m, n].Nute_M, Game_Controller.dice_Number2, m, n))
								{
								Game_Controller.Database [m, n].Nute_M.GetComponent<Turn_on_off> ().turn_on ();
								Game_Controller.Database [m, n].Nute_M.GetComponent<Transparent_Of_Sprite> ().start_tranparecncy ();
									Game_Controller.Database [m, n].have_with_dice2_flag = true;

						//		Game_Controller.Database [m, n].Nute_M.GetComponent<Button> ().onClick.AddListener (() => Game_Controller.Database [m, n].Nute_M.GetComponent<Nute_Onclick> ().onclick (m, n, "white"));
									Game_Controller.Database [m, n].Nute_M.transform.GetChild(0).gameObject.AddComponent(typeof(EventTrigger));
									EventTrigger trigger =Game_Controller.Database [m, n].Nute_M.transform.GetChild(0).GetComponent<EventTrigger> ();
									EventTrigger.Entry entry = new EventTrigger.Entry ();
									entry.eventID = EventTriggerType.PointerClick;
									entry.callback.AddListener ((eventData) => Game_Controller.Database [m, n].Nute_M.transform.GetChild(0).GetComponent<Nute_Onclick> ().onclick (m, n, "white"));
									trigger.triggers.Add (entry);
									}
							if ((nute_have_move (Game_Controller.Database [m, n].Nute_M, Game_Controller.dice_Number2, m, n) || nute_have_move (Game_Controller.Database [m,n].Nute_M, Game_Controller.dice_Number1, m, n)) && (nute_have_move(Game_Controller.Database [m, n].Nute_M,sum_of_dice,m,n))) {
								Game_Controller.Database [m, n].Nute_M.GetComponent<Turn_on_off> ().turn_on ();
								Game_Controller.Database [m, n].Nute_M.GetComponent<Transparent_Of_Sprite> ().start_tranparecncy ();
								Game_Controller.Database [m, n].have_with_sum_dices_flag = true;

						//		Game_Controller.Database [m, n].Nute_M.GetComponent<Button> ().onClick.AddListener (() => Game_Controller.Database [m, n].Nute_M.GetComponent<Nute_Onclick> ().onclick (m, n, "white"));

									Game_Controller.Database [m, n].Nute_M.transform.GetChild(0).gameObject.AddComponent(typeof(EventTrigger));
									EventTrigger trigger =Game_Controller.Database [m, n].Nute_M.transform.GetChild(0).GetComponent<EventTrigger> ();
									EventTrigger.Entry entry = new EventTrigger.Entry ();
									entry.eventID = EventTriggerType.PointerClick;
									entry.callback.AddListener ((eventData) => Game_Controller.Database [m, n].Nute_M.transform.GetChild(0).GetComponent<Nute_Onclick> ().onclick (m, n, "white"));
									trigger.triggers.Add (entry);
							
							}
						
						}//end of if nute is is top 
				
					 
				}//end of if check dont gone dice1  and dice2 and dicesum 
				//---------------------------- dice 1 gone and dice2 dont gone --------------------------------------------
				else if ((Game_Controller.dice_number1_gone) && (!Game_Controller.dice_number2_gone)) {
					
					if (Game_Controller.Database [m, n].Nute_M.CompareTag ("white"))
					if (is_top (m, n)) {
						if (nute_have_move (Game_Controller.Database [m, n].Nute_M, Game_Controller.dice_Number2, m, n)) {
							Game_Controller.Database [m, n].Nute_M.GetComponent<Turn_on_off> ().turn_on ();
							Game_Controller.Database [m, n].Nute_M.GetComponent<Transparent_Of_Sprite> ().start_tranparecncy ();
							Game_Controller.Database [m, n].have_with_dice2_flag = true;

						//	Game_Controller.Database [m, n].Nute_M.GetComponent<Button> ().onClick.AddListener (() => Game_Controller.Database [m, n].Nute_M.GetComponent<Nute_Onclick> ().onclick (m, n, "white"));
									Game_Controller.Database [m, n].Nute_M.transform.GetChild(0).gameObject.AddComponent(typeof(EventTrigger));
									EventTrigger trigger =Game_Controller.Database [m, n].Nute_M.transform.GetChild(0).GetComponent<EventTrigger> ();
									EventTrigger.Entry entry = new EventTrigger.Entry ();
									entry.eventID = EventTriggerType.PointerClick;
									entry.callback.AddListener ((eventData) => Game_Controller.Database [m, n].Nute_M.transform.GetChild(0).GetComponent<Nute_Onclick> ().onclick (m, n, "white"));

									trigger.triggers.Add (entry);

						}//end of if (nute_have_move (Game_Controller.Database [m, n].Nute_M, Game_Controller.dice_Number2, m, n))
					}//end of if(is_top) of if ((Game_Controller.dice_number1_gone) && (!Game_Controller.dice_number2_gone)) 
				}//End of if dice1 gone and dice2 dont wont 

				//-----------------------------------dice1 dont gone and dice2 gone------------------------------------
				else if ((!Game_Controller.dice_number1_gone) && (Game_Controller.dice_number2_gone)) {
					
					if (Game_Controller.Database [m, n].Nute_M.CompareTag ("white"))
					if (is_top (m, n)) {
						if (nute_have_move (Game_Controller.Database [m, n].Nute_M, Game_Controller.dice_Number1, m, n)) {
							Game_Controller.Database [m, n].Nute_M.GetComponent<Turn_on_off> ().turn_on ();
							Game_Controller.Database [m, n].Nute_M.GetComponent<Transparent_Of_Sprite> ().start_tranparecncy ();
							Game_Controller.Database [m, n].have_with_dice1_flag = true;

						//Game_Controller.Database [m, n].Nute_M.GetComponent<Button> ().onClick.AddListener (() => Game_Controller.Database [m, n].Nute_M.GetComponent<Nute_Onclick> ().onclick (m, n, "white"));

									Game_Controller.Database [m, n].Nute_M.transform.GetChild(0).gameObject.AddComponent(typeof(EventTrigger));
									EventTrigger trigger =Game_Controller.Database [m, n].Nute_M.transform.GetChild(0).GetComponent<EventTrigger> ();
									EventTrigger.Entry entry = new EventTrigger.Entry ();
									entry.eventID = EventTriggerType.PointerClick;
									entry.callback.AddListener ((eventData) => Game_Controller.Database [m, n].Nute_M.transform.GetChild(0).GetComponent<Nute_Onclick> ().onclick (m, n, "white"));

									trigger.triggers.Add (entry);

						}//end of if (nute_have_move (Game_Controller.Database [m, n].Nute_M, Game_Controller.dice_Number2, m, n))
					}//end of if(is_top) of if ((Game_Controller.dice_number1_gone) && (!Game_Controller.dice_number2_gone)) 
				}//End of if dice1 gone and dice2 dont wont
					}//end of nute is white
				}//end of if check database house not null 	
				//-----------------------------------------------------------------------
			}//end of for 
	}//end of Turn_white_nute()
	//--------------------------------------------------
	public void  Turn_Red_nute() 
	{
		intfc_Need_Method_For_Game.check_flag_status ();
		byte i=0, j=0;
		for (i = 24; i >= 1; i--)
			for (j = 0; j < 15; j++) {
				
				if (Game_Controller.Database [i, j].Nute_M != null) {
					byte m, n;
					m = i;
					n = j;
					if (Game_Controller.Database [m, n].Nute_M.CompareTag ("red")) {
					if ((!Game_Controller.dice_number1_gone) && (!Game_Controller.dice_number2_gone) && (!Game_Controller.dice_sum_gone)) {

						

							if (is_top (m, n)) {
								int sum_of_dice = -(Game_Controller.dice_Number1 + Game_Controller.dice_Number2); 
								if (nute_have_move (Game_Controller.Database [i, j].Nute_M, -(Game_Controller.dice_Number1), m, n)) {
									Game_Controller.Database [m, n].Nute_M.GetComponent<Turn_on_off> ().turn_on ();
									Game_Controller.Database [m, n].Nute_M.GetComponent<Transparent_Of_Sprite> ().start_tranparecncy ();
									Game_Controller.Database [m, n].have_with_dice1_flag = true;

								//	Game_Controller.Database [m, n].Nute_M.GetComponent<Button> ().onClick.AddListener (() => Game_Controller.Database [m, n].Nute_M.GetComponent<Nute_Onclick> ().onclick (m, n, "red"));

									Game_Controller.Database [m, n].Nute_M.transform.GetChild(0).gameObject.AddComponent(typeof(EventTrigger));
									EventTrigger trigger =Game_Controller.Database [m, n].Nute_M.transform.GetChild(0).GetComponent<EventTrigger> ();
									EventTrigger.Entry entry = new EventTrigger.Entry ();
									entry.eventID = EventTriggerType.PointerClick;
									entry.callback.AddListener ((eventData) => Game_Controller.Database [m, n].Nute_M.transform.GetChild(0).GetComponent<Nute_Onclick> ().onclick (m, n, "red"));

									trigger.triggers.Add (entry);
								}//end of have nute move with dice1
								if (nute_have_move (Game_Controller.Database [m, n].Nute_M, -(Game_Controller.dice_Number2), m, n)) {
									Game_Controller.Database [m, n].Nute_M.GetComponent<Turn_on_off> ().turn_on ();
									Game_Controller.Database [m, n].Nute_M.GetComponent<Transparent_Of_Sprite> ().start_tranparecncy ();
									Game_Controller.Database [m, n].have_with_dice2_flag = true;

								//	Game_Controller.Database [m, n].Nute_M.GetComponent<Button> ().onClick.AddListener (() => Game_Controller.Database [m, n].Nute_M.GetComponent<Nute_Onclick> ().onclick (m, n, "red"));

									Game_Controller.Database [m, n].Nute_M.transform.GetChild(0).gameObject.AddComponent(typeof(EventTrigger));
									EventTrigger trigger =Game_Controller.Database [m, n].Nute_M.transform.GetChild(0).GetComponent<EventTrigger> ();
									EventTrigger.Entry entry = new EventTrigger.Entry ();
									entry.eventID = EventTriggerType.PointerClick;
									entry.callback.AddListener ((eventData) => Game_Controller.Database [m, n].Nute_M.transform.GetChild(0).GetComponent<Nute_Onclick> ().onclick (m, n, "red"));

									trigger.triggers.Add (entry);

								}
								if ((nute_have_move (Game_Controller.Database [m, n].Nute_M,-(Game_Controller.dice_Number2), m, n) || nute_have_move (Game_Controller.Database [m, n].Nute_M, -(Game_Controller.dice_Number1), m, n)) && (nute_have_move (Game_Controller.Database [m, n].Nute_M, sum_of_dice, m, n))) {
									Game_Controller.Database [m, n].Nute_M.GetComponent<Turn_on_off> ().turn_on ();
									Game_Controller.Database [m, n].Nute_M.GetComponent<Transparent_Of_Sprite> ().start_tranparecncy ();
									Game_Controller.Database [m, n].have_with_sum_dices_flag = true;

							//	Game_Controller.Database [m, n].Nute_M.GetComponent<Button> ().onClick.AddListener (() => Game_Controller.Database [m, n].Nute_M.GetComponent<Nute_Onclick> ().onclick (m, n, "red"));

									Game_Controller.Database [m, n].Nute_M.transform.GetChild(0).gameObject.AddComponent(typeof(EventTrigger));
									EventTrigger trigger =Game_Controller.Database [m, n].Nute_M.transform.GetChild(0).GetComponent<EventTrigger> ();
									EventTrigger.Entry entry = new EventTrigger.Entry ();
									entry.eventID = EventTriggerType.PointerClick;
									entry.callback.AddListener ((eventData) => Game_Controller.Database [m, n].Nute_M.transform.GetChild(0).GetComponent<Nute_Onclick> ().onclick (m, n, "red"));

									trigger.triggers.Add (entry);

								}

							}//end of if nute is is top 

						
					}//end of if check dont gone dice1  and dice2 and dicesum 
					//---------------------------- dice 1 gone and dice2 dont gone --------------------------------------------
					else if ((Game_Controller.dice_number1_gone) && (!Game_Controller.dice_number2_gone)) {

						if (Game_Controller.Database [m, n].Nute_M.CompareTag ("red"))
						if (is_top (m, n)) {
							if (nute_have_move (Game_Controller.Database [m, n].Nute_M, -Game_Controller.dice_Number2, m, n)) {
								Game_Controller.Database [m, n].Nute_M.GetComponent<Turn_on_off> ().turn_on ();
									Game_Controller.Database [m, n].Nute_M.GetComponent<Transparent_Of_Sprite> ().start_tranparecncy ();
								Game_Controller.Database [m, n].have_with_dice2_flag = true;

							//	Game_Controller.Database [m, n].Nute_M.GetComponent<Button> ().onClick.AddListener (() => Game_Controller.Database [m, n].Nute_M.GetComponent<Nute_Onclick> ().onclick (m, n, "red"));

									Game_Controller.Database [m, n].Nute_M.transform.GetChild(0).gameObject.AddComponent(typeof(EventTrigger));
									EventTrigger trigger =Game_Controller.Database [m, n].Nute_M.transform.GetChild(0).GetComponent<EventTrigger> ();
									EventTrigger.Entry entry = new EventTrigger.Entry ();
									entry.eventID = EventTriggerType.PointerClick;
									entry.callback.AddListener ((eventData) => Game_Controller.Database [m, n].Nute_M.transform.GetChild(0).GetComponent<Nute_Onclick> ().onclick (m, n, "red"));

									trigger.triggers.Add (entry);

							}//end of if (nute_have_move (Game_Controller.Database [m, n].Nute_M, Game_Controller.dice_Number2, m, n))
						}//end of if(is_top) of if ((Game_Controller.dice_number1_gone) && (!Game_Controller.dice_number2_gone)) 
					}//End of if dice1 gone and dice2 dont wont 

					//-----------------------------------dice1 dont gone and dice2 gone------------------------------------
					else if ((!Game_Controller.dice_number1_gone) && (Game_Controller.dice_number2_gone)) {

						if (Game_Controller.Database [m, n].Nute_M.CompareTag ("red"))
						if (is_top (m, n)) {
							if (nute_have_move (Game_Controller.Database [m, n].Nute_M, -Game_Controller.dice_Number1, m, n)) {
								Game_Controller.Database [m, n].Nute_M.GetComponent<Turn_on_off> ().turn_on ();
								Game_Controller.Database [m, n].Nute_M.GetComponent<Transparent_Of_Sprite> ().start_tranparecncy ();
								Game_Controller.Database [m, n].have_with_dice1_flag = true;

							//	Game_Controller.Database [m, n].Nute_M.GetComponent<Button> ().onClick.AddListener (() => Game_Controller.Database [m, n].Nute_M.GetComponent<Nute_Onclick> ().onclick (m, n, "red"));
									Game_Controller.Database [m, n].Nute_M.transform.GetChild(0).gameObject.AddComponent(typeof(EventTrigger));
									EventTrigger trigger =Game_Controller.Database [m, n].Nute_M.transform.GetChild(0).GetComponent<EventTrigger> ();
									EventTrigger.Entry entry = new EventTrigger.Entry ();
									entry.eventID = EventTriggerType.PointerClick;
									entry.callback.AddListener ((eventData) => Game_Controller.Database [m, n].Nute_M.transform.GetChild(0).GetComponent<Nute_Onclick> ().onclick (m, n, "red"));

									trigger.triggers.Add (entry);

							}//end of if (nute_have_move (Game_Controller.Database [m, n].Nute_M, Game_Controller.dice_Number2, m, n))
						}//end of if(is_top) of if ((Game_Controller.dice_number1_gone) && (!Game_Controller.dice_number2_gone)) 
					}//End of if dice1 gone and dice2 dont wont 
					}//end of nute is red
				}//end of if check database house not null 
				else break;
				//-----------------------------------------------------------------------
			}//end of for
		
	}
	//--------------------------------------------------
	public bool is_top(byte i,byte j )
	{
		bool m = false;
		//************************************

			j += 1;
			if (Game_Controller.Database [i, j].Nute_M != null)
				return false;
			else
				return true;
		


		return m;
	}
	//--------------------------------------------------

	//--------------------------------------------------
	bool is_open (int index_number )
	{
		byte counter =  0 ; 
		if (Game_Controller.P1Turn) {
			for (int y = 0; y < 15; y++) {
				if (Game_Controller.Database [index_number, y].Nute_M != null) {
					if (Game_Controller.Database [index_number, y].Nute_M.CompareTag ("red"))
						counter++;  
				}//end of if 
				else{break;}
			}//end of for  
			if (counter > 1)
				return false;
			else
				return true;
		
		}//end of if 
		else  {
			for (int y = 0; y < 15; y++) {
				if (Game_Controller.Database [index_number, y].Nute_M != null) {
					if (Game_Controller.Database [index_number, y].Nute_M.CompareTag ("white"))
						counter++;  
				}//end of if
				else {
					break;
				}//end of else
			}//end of for  
			if (counter > 1)
				return false;
			else
				return true;
			
		
		}//end of else if 
	}
	//---------------------------------------------------
	bool nute_have_move (GameObject this_nute,int dice_number,int m,int n) 
	{
		
		if (Game_Controller.P1Turn) {
			if ((m + dice_number) > 24)
				return false; 
		} else if (Game_Controller.P2Turn) {
			if ((m + dice_number) < 1)
				return false;
		}

		
		if (Game_Controller.P1Turn) {
			if (!is_open (m + dice_number))
				return false;
			else
				return true; 
		}//end of if (Game_Controller.P1Turn)
		else {
			if (!is_open (m + dice_number))
				return false;
			else
				return true;
		}//end of else 
	}//end of nute_have_move (GameObject this_nute,int dice_number,int m,int n)
}
