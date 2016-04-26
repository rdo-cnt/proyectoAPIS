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
	string Nivel1;
	string Nivel2;
	string Nivel3;
	int level = 0;
	int counter = 0;
	int maxcounter = 60;


	// Use this for initialization
	void Start () {
		counter = 0;
		easyScene = "EasyGame";
		Menu = "Menu";
		Nivel1 = "Nivel1";
		Nivel2 = "Nivel2";
		Nivel3 = "Nivel3";
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

	public void Nivel2Menu(){
		if (PlayerPrefs.GetInt ("Lvl2") >= 1) {
			if (counter >= maxcounter) {
				SceneManager.LoadScene (Nivel1);
			}
		}
	}

	public void Nivel3Menu(){
		if (PlayerPrefs.GetInt ("Lvl3") >= 1) {
			if (counter >= maxcounter) {
				SceneManager.LoadScene (Nivel3);
			}
		}
	}

	public void Nivel1Menu(){
		if (counter >= maxcounter) {
			SceneManager.LoadScene (Nivel1);
		}
	}

}
