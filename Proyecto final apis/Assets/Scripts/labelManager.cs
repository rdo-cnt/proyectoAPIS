using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class labelManager : MonoBehaviour {

	public Level1Manager LevelManager;
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
		LevelManager.checkCorrect (myID);
	}
}
