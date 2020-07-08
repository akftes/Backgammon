using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class Turn_on_off : MonoBehaviour {
	//-------------------------------------------
	Material testmaterail ;
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

	}
	// ------------------------------------------
	public void turn_on()
	{
		foreach (Transform child in this.transform) {
			child.GetComponent<SpriteRenderer> ().material.color = new Color (0f, 1f, 0f);
			//this.gameObject.transform.GetChild (0).gameObject.GetComponent<SpriteRenderer> ().material.color = new Color (0f, 1f, 0f);
		}
	}
	//------------------------------------------
	public void turn_off()
	{
		
		foreach (Transform child in this.transform) {
			child.GetComponent<SpriteRenderer> ().material.color = new Color (1f, 1f, 1f);
			//this.gameObject.transform.GetChild (0).gameObject.GetComponent<SpriteRenderer> ().material.color = new Color (0f, 1f, 0f);
		}
	}
	public void turn_on_gameobject()
	{
		this.gameObject.GetComponent<MeshRenderer>().material.color=new Color (0f, 1f, 0f);
	}
}
