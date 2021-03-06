﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Transparent_Of_Sprite : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//----------------------------------------------------
	private float duration =  .7f;
	public float waitTime;
	Coroutine co2;
	Color textureColor;
	// Update is called once per frame void 
	public void start_tranparecncy()
	{
		co2 =  StartCoroutine(blink());

	}
	IEnumerator blink() { 

		//Color textureColor = this.transform.GetComponent<SpriteRenderer> ().material.color;
		//textureColor = this.transform.GetChild (0).GetComponent<SpriteRenderer>().material.color;
		textureColor=this.gameObject.GetComponentInChildren<SpriteRenderer>().material.color;

		//textureColor.a = Mathf.PingPong(Time.time, duration) / duration; 
		//this.GetComponent<SpriteRenderer>().material.color = textureColor;
		while (true) { // this could also be a condition indicating "alive or dead"
			// we scale all axis, so they will have the same value, 
			// so we can work with a float instead of comparing vectors
			textureColor.a=Mathf.PingPong (Time.time, duration) / duration;
			this.gameObject.GetComponentInChildren<SpriteRenderer>().material.color= textureColor;

			// reset the timer

			yield return new WaitForSeconds (waitTime);



		}
		//end of if(this.transform.childCount =0)

	}

	public void stop_Transparency () 
	{
		//textureColor.a = 0.5f;
		//this.transform.GetChild(0).GetComponent<SpriteRenderer> ().material.color = textureColor;

		StopAllCoroutines ();

	}
}
