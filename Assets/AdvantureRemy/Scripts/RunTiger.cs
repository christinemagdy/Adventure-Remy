using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunTiger : MonoBehaviour {
	public float speed;
	public float moveSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Input.GetAxis ("Horizontal") * Time.deltaTime * moveSpeed, 0, 1 * speed);
	}
}
