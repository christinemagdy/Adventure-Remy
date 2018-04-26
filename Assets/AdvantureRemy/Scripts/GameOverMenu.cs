using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour {

	public Text EndCoinsScore;

	// Use this for initialization
	void Start () {
		gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ToggleEndMenu(float coinScore)
	{
		gameObject.SetActive (true);
		EndCoinsScore.text = ((int)coinScore).ToString ();
	}


	public void Restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

	public void Menu(){
		SceneManager.LoadScene("MainMenu");
	}
}
