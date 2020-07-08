using UnityEngine;
using System.Collections;

public class Initialize_Database : MonoBehaviour {

	// Use this for initialization
	public void initialize_of_Database () {
		int k, m;
		float deltay1;
		float orgx, orgy,orgz;
		deltay1 = 0.61f;
		orgx = 6.1f;
		orgy = 0.06f;
		orgz = -4.21f;
		//Set lights array 
		for (k = 0; k < 25; k++)
			Game_Controller.guide[k]=GameObject.Find("light"+k.ToString());

	


		//cycle of initial of graphical position of database row 1 to 6
		for (k = 1; k <= 6; k++) {
			
			for (m = 0; m <= 14; m++) {

				Game_Controller.Database [k, m].Graphical_Position_M = new Vector3((orgx+(m * 0.03f)),orgy,orgz);
				orgz += deltay1;
			}
			orgx -= 1.021f;
			orgy = 0.06f;
			orgz = -4.21f;
		}
		//cycle of initial of graphical position of database row 7 to 12
		orgx = -0.79f;
		orgy = -0.06f;
		orgz = -4.21f;
		for (k = 7; k <= 12; k++) {

			for (m = 0; m <= 14; m++) {
				Game_Controller.Database [k, m].Graphical_Position_M = new Vector3((orgx-(m * 0.03f)),orgy,orgz);
				orgz += deltay1;

			}

			orgx -= 1.03f;
			orgy = 0.06f;
			orgz = -4.21f;
		}
		//cycle of initial of graphical position of database row 13 to 18
		orgx = -6.47f;
		orgy = 0.06f;
		orgz = 4.27f;
		for (k = 13; k <= 18; k++) {

			for (m = 0; m <= 14; m++) {
				Game_Controller.Database [k, m].Graphical_Position_M = new Vector3((orgx+(m * 0.03f)),orgy,orgz);
				orgz -= deltay1;
			}
			orgx += 1.09f;
			orgy = 0.06f;
			orgz = 4.27f;
		}
		//cycle of initial of graphical position of database row 19 to 24
		orgx = 1.23f;
		orgy = 0.06f;
		orgz = 4.27f;
		for (k = 19; k <= 24; k++) {

			for (m = 0; m <= 14; m++) {
				Game_Controller.Database [k, m].Graphical_Position_M = new Vector3((orgx-(m * 0.02f)),orgy,orgz);
				orgz -= deltay1;
			}
			orgx += 1.08f;
			orgy = 0.06f;
			orgz = 4.27f;
		}
		//cycle of initial of  Horizonltal And Vertical  position of database row 1 to 24
		for (k = 0; k < 25; k++)
			for (m = 0; m <= 14; m++) {
				Game_Controller.Database [k, m].Horizontal_Coordinate_Matrix_M = k;
				Game_Controller.Database [k,m].Vertical_Coordinate_matrix_M = m;
			}	
	}
	
	// Set first Shape and position of nuts
	//------------------set have move with dices with flag----------------------------------
	public void set_defualt_move_flag () 
	{
		for (int i = 0; i < 26; i++)
			for (int j = 0; j < 16; j++) {
				Game_Controller.Database [i, j].have_with_dice1_flag = false;
				Game_Controller.Database [i, j].have_with_dice2_flag = false;
				Game_Controller.Database [i, j].have_with_sum_dices_flag = false;

			}
	}


}
