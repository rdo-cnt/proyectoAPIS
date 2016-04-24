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
	int maxcounter = 75;


	// Use this for initialization
	void Start () {
		counter = 0;
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
		if (maxcounter > counter) {
			counter++;
		}
	}

	public void Easy(){
		if (counter >= maxcounter) {
			SceneManager.LoadScene (easyScene);
		}
	}

	public void IntroCutscene1(){
		if (counter >= maxcounter) {
			SceneManager.LoadScene (FirstSceneNum1);
		}
	}

	public void IntroCutscene2(){
		if (counter >= maxcounter) {
			SceneManager.LoadScene (FirstSceneNum2);
		}
	}

	public void IntroMenu(){
		if (counter >= maxcounter) {
			SceneManager.LoadScene (Menu);
		}
	}


}
