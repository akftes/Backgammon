using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.EventSystems;
public  class Game_Controller : MonoBehaviour {

// Use this for initialization
	public GameObject [] white_Nutes = new GameObject[16];
	public  GameObject [] red_Nutes = new GameObject[16];
	public  static GameObject [] guide = new GameObject[25];
	public static Struct_Of_Saving_nuts[,]  Database = new Struct_Of_Saving_nuts[26,15];	
	public GameObject initialator,button,Begining_Button,Roldice1_p1,Roldice2_p1,Roldice1_p2,Roldice2_p2,Player1,Player2;
	public GameObject Q_System;

	public static  bool Different_numbers_on_the_dice_flag=false;
	public static  bool pairs_number_of_dice=false;
	public static  bool pairs_gone1 = false ;
	public static  bool pairs_gone2 = false ;
	public static  bool pairs_gone3 = false ;
	public static  bool pairs_gone4 = false ;
	public static  bool P1Turn=false,P2Turn=false;


	public static byte dice_Number1, dice_Number2;
	public static byte Player1_First_Number_Get=0,Player2_Frist_Number_Get=0;
	public static bool Player1_First_throws_true=false,Player2_First_throws_true=false;
	public static bool dice_number1_gone=false, dice_number2_gone=false,dice_sum_gone=false ;
	public GameObject throw_text_p1,throw_text_p2;


//----------------------------------------------------------------------------------------------------
	void Start () {
		
		//Camera.main.orthographicSize = 6;
		//contin ();
		addPhysicsRaycaster();
		Roldice1_p1.gameObject.GetComponent<Visiblity_Dice>().faint();
		Roldice2_p1.GetComponent<Visiblity_Dice>().faint();
		Roldice1_p2.gameObject.GetComponent<Visiblity_Dice>().faint();
		Roldice2_p2.GetComponent<Visiblity_Dice>().faint();
		throw_text_p1.gameObject.GetComponent<Transparent> ().start_tranparecncy ();
		throw_text_p2.gameObject.GetComponent<Transparent> ().start_tranparecncy ();
		contin ();

		//test.GetComponent<Transparent>().start_transparency();
		//Transparent transparent_intfc = new Transparent ();
		//transparent_intfc.start_transparency (test);

		//test.GetComponent<Navmesh_move>().move(-10,0,0);
		//test.GetComponent<dice_Transparent>().Start();
	}
//----------------------------------------------------------------------------------------------------
	void addPhysicsRaycaster()
	{
		PhysicsRaycaster physicsRaycaster = GameObject.FindObjectOfType<PhysicsRaycaster>();
		if (physicsRaycaster == null)
		{
			Camera.main.gameObject.AddComponent<PhysicsRaycaster>();
		}
	}
//----------------------------------------------------------------------------------------------------
	void contin()
	{
		//Initialize of Database 
		initialator.GetComponent<Initialize_Database>().initialize_of_Database();
		//Set_Of_First_Position_Of_Nutes
		Set_Of_First_Position_Of_Nutes();
		//Penhan kardan Guide va lights
		hide_All_element();
		//ezafe kardan listener be throw text 
		throw_text_p1.GetComponent<Button> ().onClick.AddListener (() => throw_text_p1.GetComponent<Begin_Button_P1>().Onclick_of_begin());	
		throw_text_p2.GetComponent<Button> ().onClick.AddListener (() => throw_text_p2.GetComponent<Begin_Button_P2>().Onclick_of_begin());	

	}
//----------------------------------------------------------------------------------------------------
	public  void Continue_After_On_Click()
	{
		
		button.SetActive (true);
		white_Nutes [0].SetActive (false);

	}
	
//----------------------------------------------------------------------------------------------------





public struct Struct_Of_Saving_nuts
{

	private GameObject  nute;
	private  int Horizontal_Coordinate_Matrix;			
	private  int Vertical_Coordinate_matrix;
	Vector3 Graphical_Position ;
		private  bool have_move_with_sum_dices ;
		private bool have_move_with_dice1  ; 
		private bool have_move_with_dice2  ;
	
	//--------------------Set Value--------------------------
		public  bool have_with_sum_dices_flag
		{
			get
			{
				return have_move_with_sum_dices;
			}
			set
			{
				have_move_with_sum_dices=value;
			}			
		}
	//------------------------------------------------------
		public  bool have_with_dice1_flag
		{
			get
			{
				return have_move_with_dice1;
			}
			set
			{
				have_move_with_dice1=value;
			}			
		}
	//-----------------------------------------------------
		public  bool have_with_dice2_flag
		{
			get
			{
				return have_move_with_dice2;
			}
			set
			{
				have_move_with_dice2=value;
			}			
		}
	//-------------------------------------------------------
		public GameObject Nute_M
	{
		get
		{
			return nute;
		}
		set
		{
			nute=value;
		}
	}
	//-------------------------------------------------------
	public int Horizontal_Coordinate_Matrix_M
	{
		get
		{
			return Horizontal_Coordinate_Matrix;
		}
		set
		{
			Horizontal_Coordinate_Matrix=value;
		}
	}
	//-------------------------------------------------------
	public int Vertical_Coordinate_matrix_M
	{
		get
		{
			return Vertical_Coordinate_matrix;
		}
		set
		{
			Vertical_Coordinate_matrix=value;
		}
	}
	//--------------------------------------------------------
	public Vector3 Graphical_Position_M
	{
		get
		{
			return Graphical_Position;
		}
		set
		{
			Graphical_Position=value;
		}
	}
	
	}//End of struct Struct_Of_Saving_nuts
	//--------------------------------------------------------
	//Set_Of_First_Position_Of_Nutes
	public void Set_Of_First_Position_Of_Nutes()
	{
		Database [1, 0].Nute_M = white_Nutes [1];
		white_Nutes [1].transform.localPosition = Database [1, 0].Graphical_Position_M;
		Database [1,1].Nute_M =white_Nutes [2];
		white_Nutes [2].transform.localPosition = Database [1, 1].Graphical_Position_M;
		Database [12, 0].Nute_M = white_Nutes [3];
		white_Nutes [3].transform.localPosition = Database [12, 0].Graphical_Position_M;
		Database [12, 1].Nute_M = white_Nutes [4];
		white_Nutes [4].transform.localPosition = Database [12, 1].Graphical_Position_M;
		Database [12, 2].Nute_M = white_Nutes [5];
		white_Nutes [5].transform.localPosition = Database [12, 2].Graphical_Position_M;
		Database [12, 3].Nute_M = white_Nutes [6];
		white_Nutes [6].transform.localPosition = Database [12, 3].Graphical_Position_M;
		Database [12, 4].Nute_M = white_Nutes [7];
		white_Nutes [7].transform.localPosition = Database [12, 4].Graphical_Position_M;
		Database [17, 0].Nute_M = white_Nutes [8];
		white_Nutes [8].transform.localPosition = Database [17, 0].Graphical_Position_M;
		Database [17, 1].Nute_M = white_Nutes [9];
		white_Nutes [9].transform.localPosition = Database [17,1].Graphical_Position_M;
		Database [17, 2].Nute_M = white_Nutes [10];
		white_Nutes [10].transform.localPosition = Database [17, 2].Graphical_Position_M;
		Database [19, 0].Nute_M = white_Nutes [11];
		white_Nutes [11].transform.localPosition = Database [19, 0].Graphical_Position_M;
		Database [19, 1].Nute_M = white_Nutes [12];
		white_Nutes [12].transform.localPosition = Database [19, 1].Graphical_Position_M;
		Database [19, 2].Nute_M = white_Nutes [13];
		white_Nutes [13].transform.localPosition = Database [19, 2].Graphical_Position_M;
		Database [19, 3].Nute_M = white_Nutes [14];
		white_Nutes [14].transform.localPosition = Database [19, 3].Graphical_Position_M;
		Database [19, 4].Nute_M = white_Nutes [15];
		white_Nutes [15].transform.localPosition = Database [19, 4].Graphical_Position_M;
		//-----------------------------------RED NUTES------------------------------------------------
		Database [24, 0].Nute_M = red_Nutes [1];
		red_Nutes [1].transform.localPosition = Database [24, 0].Graphical_Position_M;
		Database [24, 1].Nute_M = red_Nutes [2];
		red_Nutes [2].transform.localPosition = Database [24, 1].Graphical_Position_M;
		Database [13,0].Nute_M = red_Nutes [3];
		red_Nutes [3].transform.localPosition = Database [13, 0].Graphical_Position_M;
		Database [13,1].Nute_M = red_Nutes [4];
		red_Nutes [4].transform.localPosition = Database [13,1].Graphical_Position_M;
		Database [13,2].Nute_M = red_Nutes [5];
		red_Nutes [5].transform.localPosition = Database [13,2].Graphical_Position_M;
		Database [13,3].Nute_M = red_Nutes [6];
		red_Nutes [6].transform.localPosition = Database [13,3].Graphical_Position_M;
		Database [13,4].Nute_M = red_Nutes [7];
		red_Nutes [7].transform.localPosition = Database [13,4].Graphical_Position_M;
		Database [8,0].Nute_M = red_Nutes [8];
		red_Nutes [8].transform.localPosition = Database [8,0].Graphical_Position_M;
		Database [8,1].Nute_M = red_Nutes [9];
		red_Nutes [9].transform.localPosition = Database [8,1].Graphical_Position_M;
		Database [8,2].Nute_M = red_Nutes [10];
		red_Nutes [10].transform.localPosition = Database [8,2].Graphical_Position_M;
		Database [6,0].Nute_M = red_Nutes [11];
		red_Nutes [11].transform.localPosition = Database [6,0].Graphical_Position_M;
		Database [6,1].Nute_M = red_Nutes [12];
		red_Nutes [12].transform.localPosition = Database [6,1].Graphical_Position_M;
		Database [6,2].Nute_M = red_Nutes [13];
		red_Nutes [13].transform.localPosition = Database [6,2].Graphical_Position_M;
		Database [6,3].Nute_M = red_Nutes [14];
		red_Nutes [14].transform.localPosition = Database [6,3].Graphical_Position_M;
		Database [6,4].Nute_M = red_Nutes [15];
		red_Nutes [15].transform.localPosition = Database [6,4].Graphical_Position_M;




	}//End of Set_Of_First_Position_Of_Nutes
//-----------------------------------------------------------------------------------------------------------------------------------------
	public void hide_All_element()
	{
		int i;
		//GameObject.Find ("Canvas").transform.GetChild (i).GetComponent<Image> ().enabled = false;
		//gameObject.transform.FindChild ("g"+ i.ToString ()).GetComponent<Image> ().enabled = false;
		//Find ("g" + i.ToString ()).GetComponent<Image> ().enabled = false;
		for (i = 0; i <26; i++) {


			GameObject light = GameObject.Find ("light" + i.ToString ());
			light.SetActive (false);
		}

		//hide dice
		//Roldice1.GetComponent<Visiblity_Dice>().hiding();
		//Roldice2.GetComponent<Visiblity_Dice>().hiding();
		Player1.SetActive (false);
		Player2.SetActive (false);
		//button.gameObject.SetActive (false);
	}
	//--------------------------------------------------------------------------------------



//-----------------------------------------------------------------------------------------------------------------------------------------

}//End of class Game_Controller
