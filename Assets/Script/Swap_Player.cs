using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class Swap_Player : MonoBehaviour {
	public GameObject Player1,Player2;
	public GameObject throw_text_p1,throw_text_p2;
	public GameObject dice1_p1, dice2_p1, dice1_p2,dice2_p2;
	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//--------------------------------------------------------------
	public void 	swap_for_Player()
	{
		if (Game_Controller.P1Turn) {
			throw_text_p2.SetActive (true);
			Player1.SetActive (false);
			Player2.SetActive (true);
			dice1_p2.SetActive (true);
			dice2_p2.SetActive (true);
			throw_text_p2.GetComponent<Button> ().onClick.AddListener (() => throw_text_p1.GetComponent<Continue_Button> ().onclick ());	
				
		} else {
			throw_text_p1.SetActive (true);
			Player2.SetActive (false);
			Player1.SetActive (true);
			dice1_p1.SetActive (true);
			dice2_p1.SetActive (true);
			throw_text_p1.GetComponent<Button> ().onClick.AddListener (() => throw_text_p1.GetComponent<Continue_Button> ().onclick ());	
		}

	}
	//---------------------------------------------------------------
	public void Show_Player()
	{


		if (Game_Controller.P1Turn) {
			Player1.SetActive (true); 
			Player1.GetComponent<Transparent_Of_Sprite> ().start_tranparecncy ();
			Detect_Movable_Nutes infc = new Detect_Movable_Nutes ();
			infc.Turn_white_nute ();
			infc=null;

		}
		else {
			Player2.SetActive(true);
			Player2.GetComponent<Transparent_Of_Sprite> ().start_tranparecncy ();
			Detect_Movable_Nutes infc2 = new Detect_Movable_Nutes ();
			infc2.Turn_Red_nute ();
			infc2=null;

		}//end of Else 
	}//End of showPlayermethod()
	//---------------------------------------------------------------
}
