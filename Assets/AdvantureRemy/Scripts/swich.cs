using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class swich : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frames
	void Update () {

		DateTime time = DateTime.Now;
		if (time.Hour <8) {
		
			this.GetComponent<Light> ().enabled = true;

		}

		else {
			this.GetComponent<Light>().enabled = false;

		}
		
	}
}
