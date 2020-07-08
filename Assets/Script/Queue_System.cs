using UnityEngine;
using System.Collections;

public class Queue_System : MonoBehaviour {
	public GameObject Player1,Player2;
	//-----------------------------------------------------
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	//-----------------------------------------------------
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

}
