using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dice_Transparent : MonoBehaviour {
	private float duration =  .7f;
	public float waitTime;
	IEnumerator co2;
	// Update is called once per frame void 
	public void Start_tranparecncy()
	{
		this.co2=this.dice_blink();
		this.StartCoroutine (this.co2);
	}
	IEnumerator dice_blink() { 

		Color textureColor0 = this.transform.GetChild (0).GetComponent<SpriteRenderer> ().material.color;
		Color textureColor1 = this.transform.GetChild (1).GetComponent<SpriteRenderer> ().material.color;
		Color textureColor2 = this.transform.GetChild (2).GetComponent<SpriteRenderer> ().material.color;
		Color textureColor3 = this.transform.GetChild (3).GetComponent<SpriteRenderer> ().material.color;
		Color textureColor4 = this.transform.GetChild (4).GetComponent<SpriteRenderer> ().material.color;
		Color textureColor5 = this.transform.GetChild (5).GetComponent<SpriteRenderer> ().material.color;
			
		//textureColor.a = Mathf.PingPong(Time.time, duration) / duration; 
		//this.GetComponent<SpriteRenderer>().material.color = textureColor;
		while (true) { // this could also be a condition indicating "alive or dead"
			// we scale all axis, so they will have the same value, 
			// so we can work with a float instead of comparing vectors
			textureColor0.a=Mathf.PingPong (Time.time, duration) / duration;
			textureColor1.a=Mathf.PingPong (Time.time, duration) / duration;
			textureColor2.a=Mathf.PingPong (Time.time, duration) / duration;
			textureColor3.a=Mathf.PingPong (Time.time, duration) / duration;
			textureColor4.a=Mathf.PingPong (Time.time, duration) / duration;
			textureColor5.a=Mathf.PingPong (Time.time, duration) / duration;
			this.transform.GetChild (0).GetComponent<SpriteRenderer> ().material.color = textureColor0;
			this.transform.GetChild (1).GetComponent<SpriteRenderer> ().material.color = textureColor1;
			this.transform.GetChild (2).GetComponent<SpriteRenderer> ().material.color = textureColor2;
			this.transform.GetChild (3).GetComponent<SpriteRenderer> ().material.color = textureColor3;
			this.transform.GetChild (4).GetComponent<SpriteRenderer> ().material.color = textureColor4;
			this.transform.GetChild (5).GetComponent<SpriteRenderer> ().material.color = textureColor5;

			// reset the timer

			yield return new WaitForSeconds (waitTime);



		}
		//end of if(this.transform.childCount =0)

	}

	void stop_Transparency () 
	{

		this.StopCoroutine (this.co2);

	}
}
