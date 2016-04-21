using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic; 

public class LevelNumManager : MonoBehaviour {

	string levelNum;
	Text theText;

	// Use this for initialization
	void Start () {
		theText = GetComponent<Text> ();

	}
	
	// Update is called once per frame
	void Update () {
		theText.text = "" + PlayerPrefs.GetInt ("Level");
	}
}
