using UnityEngine;
using UnityEngine.SceneManagement;	
using System.Collections;
using System.Collections.Generic; 
using System.Runtime.Serialization.Formatters.Binary; 
using System.IO;

public class mainMenuManager : MonoBehaviour {

	SceneManager manageScene;
	string easyScene;
	int level = 0;



	// Use this for initialization
	void Start () {
		//save data
		easyScene = "EasyGame";
		if (PlayerPrefs.GetInt ("Level") < 1) {
			PlayerPrefs.SetInt ("Level", 1);
			PlayerPrefs.Save ();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Easy(){
		SceneManager.LoadScene(easyScene);
		PlayerPrefs.SetInt ("Level", PlayerPrefs.GetInt ("Level") + 1);
	}


}
