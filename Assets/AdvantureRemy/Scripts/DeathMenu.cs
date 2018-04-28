using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.SetActive (false);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayeAgain()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
	public void MainMenu()
	{
		SceneManager.LoadScene ("MainMenu");
	}

	public void ToggleEndMenu()
	{
		gameObject.SetActive (true);
	}
}
