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
	string FirstSceneNum3;
	string Menu;
	string Nivel1;
	string Nivel2;
	string Nivel3;
	int counter = 0;
	public int maxcounter = 60;


	public AudioSource confirmationSound;


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
		FirstSceneNum3 = "FirstSceneNum3";
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

	public void Easy2(){
			SceneManager.LoadScene (easyScene);
	}

	public void IntroCutsceneFirst(){
		if (counter >= maxcounter) {
			SceneManager.LoadScene ("FirstSceneHalt");
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

	public void IntroCutscene3(){
		if (counter >= maxcounter) {
			SceneManager.LoadScene (FirstSceneNum3);
			PlayerPrefs.SetInt ("First", 1);
		}
	}

	public void IntroMenu(){
		if (counter >= maxcounter) {
			SceneManager.LoadScene (Menu);
			confirmationSound.Play ();
		}
	}

	public void Nivel2Menu(){
		if (PlayerPrefs.GetInt ("Lvl2") >= 1) {
			if (counter >= maxcounter) {
				SceneManager.LoadScene (Nivel2);
				confirmationSound.Play ();
			}
		}
	}

	public void Nivel3Menu(){
		if (PlayerPrefs.GetInt ("Lvl3") >= 1) {
			if (counter >= maxcounter) {
				SceneManager.LoadScene (Nivel3);
				confirmationSound.Play ();
			}
		}
	}

	public void Nivel1Menu(){
		if (counter >= maxcounter) {
			SceneManager.LoadScene (Nivel1);
			confirmationSound.Play ();
		}
	}


	public void Nivel1Victory(){
		if (counter >= maxcounter) {
			SceneManager.LoadScene ("Nivel1Victory2");
		}
	}

	public void Nivel1Victory2(){
		if (counter >= maxcounter) {
			SceneManager.LoadScene ("Nivel1Victory3");
		}
	}

	public void Nivel1Victory3(){
		if (counter >= maxcounter) {
			SceneManager.LoadScene ("Nivel1Victory4");
		}
	}

	public void Nivel2Victory(){
		if (counter >= maxcounter) {
			SceneManager.LoadScene ("Nivel2Victory2");
		}
	}

	public void Nivel2Victory2(){
		if (counter >= maxcounter) {
			SceneManager.LoadScene ("Nivel2Victory3");
		}
	}

	public void Nivel2Victory3(){
		if (counter >= maxcounter) {
			SceneManager.LoadScene ("Nivel2Victory4");
		}
	}

	public void Nivel3Victory(){
		if (counter >= maxcounter) {
			SceneManager.LoadScene ("Nivel3Victory2");
		}
	}

	public void Nivel3Victory2(){
		if (counter >= maxcounter) {
			SceneManager.LoadScene ("Nivel3Victory3");
		}
	}

	public void Nivel3Victory3(){
		if (counter >= maxcounter) {
			SceneManager.LoadScene ("Nivel3Victory4");
		}
	}


}
