﻿using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void PlayGame(){
		Application.LoadLevel("GameScene");
	}

	public void Exit(){
		Application.Quit();
	}

	public void ShowCredits(){

	}
}
