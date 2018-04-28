using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOver : MonoBehaviour {

	private bool isDead = false;
	public DeathMenu deathMenu;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (isDead) {
			return;
		}
	}

	public void OnDeath()
	{
		isDead = true;
		deathMenu.ToggleEndMenu ();
	}
	public void ToggleEndMenu()
	{
		gameObject.SetActive (true);
	}
}
