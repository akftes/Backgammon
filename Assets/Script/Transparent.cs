using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using System;

public class Transparent : MonoBehaviour {
	
	/*private float duration =  .7f;
	DateTime time;
	bool isStopped=false;
	Thread thread;
	Color textureColor;
	AutoResetEvent resetevent;
	 // Update is called once per frame void 
	//----------------------------------------------
	public void start_transparency()
	{
	//	Debug.Log ("game in start tranparency");

//		textureColor = this.GetComponent<SpriteRenderer> ().material.color;
	//	thread = new Thread (run);
	//	thread.Start ();
	//	resetevent = new AutoResetEvent(false);

	//}
	//------------------------------------------------
	void blink() { 


		//textureColor.a = Mathf.PingPong(Time.time, duration) / duration; 
		//this.GetComponent<SpriteRenderer>().material.color = textureColor;
		// this could also be a condition indicating "alive or dead"
		resetevent.WaitOne();
		DateTime now = DateTime.Now;
		TimeSpan deltaTime = now - time;
		time = now;	
		textureColor.a = Mathf.PingPong ((float)deltaTime.TotalSeconds, duration) / duration; 

		//end of if(this.transform.childCount =0)

	}
	//------------------------------------------------
	void run()
	{
		while (!isStopped) {
		time = DateTime.Now;
		blink ();
		}

	}
	//------------------------------------------------
	private void Update()  
	{
		//resetevent.Set ();
		this.GetComponent<SpriteRenderer> ().material.color = textureColor;

	}
	//---------------------------------------------------
	private void OnDestroy()  
	{
		thread.Abort();
		isStopped = true;
	}
	//--------------------------------------------
	private void OnApplicationQuit()  
	{
		thread.Abort();
		isStopped = true;
	}

*/

		
	private float duration =  .7f;
	public float waitTime;
	IEnumerator co2;
	Color textureColor;
	// Update is called once per frame void 
	public void start_tranparecncy()
	{
		this.co2=this.blink();
		this.StartCoroutine (this.co2);
	}
	IEnumerator blink() { 

		//Color textureColor = this.transform.GetComponent<SpriteRenderer> ().material.color;
		 textureColor = this.GetComponent<Image>().color;

		//textureColor.a = Mathf.PingPong(Time.time, duration) / duration; 
		//this.GetComponent<SpriteRenderer>().material.color = textureColor;
		while (true) { // this could also be a condition indicating "alive or dead"
			// we scale all axis, so they will have the same value, 
			// so we can work with a float instead of comparing vectors
			textureColor.a=Mathf.PingPong (Time.time, duration) / duration;
			this.GetComponent<Image> ().color = textureColor;

			// reset the timer

			yield return new WaitForSeconds (waitTime);



		}
		//end of if(this.transform.childCount =0)

	}

	public void stop_Transparency () 
	{
		textureColor.a = 5;
		this.GetComponent<Image> ().color = textureColor;
		this.StopCoroutine (this.co2);

	}
}
