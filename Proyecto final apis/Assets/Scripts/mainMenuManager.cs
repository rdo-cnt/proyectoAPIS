using UnityEngine;
using UnityEngine.SceneManagement;	
using System.Collections;
using System.Collections.Generic; 
using System.Runtime.Serialization.Formatters.Binary; 
using System.IO;

public class mainMenuManager : MonoBehaviour {

	SceneManager manageScene;
	string easyScene;
	string FirstSceneNum1;
	string FirstSceneNum2;
	string Menu;
	int level = 0;
	int counter = 0;



	// Use this for initialization
	void Start () {
		int counter = 0;
		easyScene = "EasyGame";
		Menu = "Menu";
		FirstSceneNum1 = "FirstSceneNum1";
		FirstSceneNum2 = "FirstSceneNum2";
		if (PlayerPrefs.GetInt ("Level") < 1) {
			PlayerPrefs.SetInt ("Level", 1);
			PlayerPrefs.Save ();
		}
	}

	// Update is called once per frame
	void Update () {
		if (90 > counter) {
			counter++;
		}
	}

	public void Easy(){
		if (counter >= 90) {
			SceneManager.LoadScene (easyScene);
			PlayerPrefs.SetInt ("Level", PlayerPrefs.GetInt ("Level") + 1);
		}
	}

	public void IntroCutscene1(){
		if (counter >= 90) {
			SceneManager.LoadScene (FirstSceneNum1);
		}
	}

	public void IntroCutscene2(){
		if (counter >= 90) {
			SceneManager.LoadScene (FirstSceneNum2);
		}
	}

	public void IntroMenu(){
		if (counter >= 90) {
			SceneManager.LoadScene (Menu);
		}
	}


}
