using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class labelManager2 : MonoBehaviour {

	public Level2Manager Level2Manager;
	public Text myText;
	public int myID;

	// Use this for initialization
	void Start () {
		myText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void checkCorrect(){
		Level2Manager.checkCorrect (myID);
	}
}
