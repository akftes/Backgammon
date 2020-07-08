using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class guide_Onclick : MonoBehaviour {

	public GameObject Erth;
	public GameObject Button,start_Button;
	public GameObject Roldice1_p1,Roldice2_p1,Roldice1_p2,Roldice2_p2,Swapplayer;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}
	//************************************
	public void onclick(int guide_index,int Nute_index_i,int Nute_index_j ,int target1,int target2,int targetsum)
	{
		
		Game_Controller Game_Controller_intfc = new Game_Controller ();

		if (Game_Controller.P1Turn) {
			if (guide_index == target1) {
				Game_Controller.dice_number1_gone = true;
				Roldice1_p1.GetComponent<Visiblity_Dice> ().faint ();

			} else if (guide_index == target2) {
				Game_Controller.dice_number2_gone = true;
				Roldice2_p1.GetComponent<Visiblity_Dice> ().faint ();

			} else if (guide_index == targetsum) {
				Roldice1_p1.GetComponent<Visiblity_Dice> ().faint ();
				Roldice2_p1.GetComponent<Visiblity_Dice> ().faint ();
				Game_Controller.dice_sum_gone = true;
			}
		}// end if
		else {
			if (guide_index == target1) {
				Game_Controller.dice_number1_gone = true;
				Roldice1_p2.GetComponent<Visiblity_Dice> ().faint ();

			} else if (guide_index == target2) {
				Game_Controller.dice_number2_gone = true;
				Roldice2_p2.GetComponent<Visiblity_Dice> ().faint ();

			} else if (guide_index == targetsum) {
				Roldice1_p2.GetComponent<Visiblity_Dice> ().faint ();
				Roldice2_p2.GetComponent<Visiblity_Dice> ().faint ();
				Game_Controller.dice_sum_gone = true;
			}
		}

		move (Nute_index_i,Nute_index_j,guide_index,number_of_cloumn (guide_index));
		
	}
	//***************************************
	int number_of_cloumn(int get_index)
	{
		int counter = 0;
		for (int i = 0; i < 15; i++) 
			if (Game_Controller.Database [get_index, i].Nute_M != null)
				counter++;
		return counter;		
		
	}
	//**************************************
	void move (int source_index_i,int source_index_j,int destination_index_i,int destination_index_j)
	{
		
		float x,y,z;
		if (Game_Controller.Database [source_index_i, source_index_j].Nute_M != null) {
			Game_Controller.Database [source_index_i, source_index_j].Nute_M.AddComponent<NavMeshAgent> ();
			Game_Controller.Database [source_index_i, source_index_j].Nute_M.GetComponent<NavMeshAgent> ().acceleration = 5000000000;
			Game_Controller.Database [source_index_i, source_index_j].Nute_M.GetComponent<NavMeshAgent> ().speed = 20;
			x = Game_Controller.Database [destination_index_i, destination_index_j].Graphical_Position_M.x;
			y = Game_Controller.Database [destination_index_i, destination_index_j].Graphical_Position_M.y;
			z = Game_Controller.Database [destination_index_i, destination_index_j].Graphical_Position_M.z;
			Game_Controller.Database [source_index_i, source_index_j].Nute_M.GetComponent<Navmesh_move> ().move (x, y, z);
			Game_Controller.Database [destination_index_i, destination_index_j].Nute_M = Game_Controller.Database [source_index_i, source_index_j].Nute_M;
			Game_Controller.Database [source_index_i, source_index_j].Nute_M = null;
			detect_Continue_Game ();	
		}
	}
	//--------------------------------------
	public void Remove_Listener_and_color ()
	{
		Need_Method_For_Game intfc = new Need_Method_For_Game ();
	 	intfc.hide_guide ();
		intfc.Remove_all_Listener_from_Nutes ();
		intfc.turn_off_all_nute ();
		intfc.stop_transparency_of_all_nutes ();
		intfc.Refresh_Flag_Of_All_Nutes ();
		GameObject.Find ("Plane").GetComponent<Button> ().onClick.RemoveAllListeners ();
				

			
	}
	//----------------------------------------
	public void detect_Continue_Game ()
	{
		Remove_Listener_and_color ();
		Need_Method_For_Game Need_Method_For_Game_intfc = new Need_Method_For_Game();

		if (Game_Controller.dice_sum_gone) {
			Need_Method_For_Game_intfc.Refresh_Flag ();
			Need_Method_For_Game_intfc.check_flag_status ();
			Swapplayer.GetComponent<Swap_Player> ().swap_for_Player ();



			
		} //end of 		if (Game_Controller.dice_sum_gone) {

		else if (Game_Controller.dice_number1_gone && Game_Controller.dice_number2_gone) {
			Need_Method_For_Game_intfc.Refresh_Flag ();
			Need_Method_For_Game_intfc.check_flag_status ();
			Swapplayer.GetComponent<Swap_Player> ().swap_for_Player ();





				 

		}//end of else if (Game_Controller.dice_number1_gone && Game_Controller.dice_number2_gone) 
			 
		else {
			
			if (Game_Controller.P1Turn) {
				Detect_Movable_Nutes infc = new Detect_Movable_Nutes ();
				infc.Turn_white_nute ();
				infc = null;
			} else {
				Detect_Movable_Nutes infc = new Detect_Movable_Nutes ();
			infc.Turn_Red_nute ();
				infc = null;
			}
		}//end of else*/


	}//end of detect_Continue_Game()
}//end of public class guide_Onclick : MonoBehaviour 
