using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsRotater : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3 (25, 25, 0) * Time.deltaTime * 7);
	}
}
