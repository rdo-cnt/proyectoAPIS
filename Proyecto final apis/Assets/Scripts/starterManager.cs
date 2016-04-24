using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;	

public class starterManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetInt ("First") < 1) {
			PlayerPrefs.SetInt ("First", 1);
			SceneManager.LoadScene ("FirstSceneHalt");
		} else {
			SceneManager.LoadScene ("Menu");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
