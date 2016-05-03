using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;	

public class MusicManager2 : MonoBehaviour {

	public GameObject musicPlayer;
	SceneManager manageScene;
	//public AudioSource elAudio;
	// Use this for initialization
	void Start () {
		//elAudio = GetComponent<AudioSource> ();
	}

	void Awake(){
		DontDestroyOnLoad (gameObject);
	}


	// Update is called once per frame
	void Update () {
		if (SceneManager.GetActiveScene ().name == "FirstSceneNum1") {
			Destroy (gameObject);
		}
		if (SceneManager.GetActiveScene ().name == "Nivel1") {
			Destroy (gameObject);
		}
		if (SceneManager.GetActiveScene ().name == "Nivel2") {
			Destroy (gameObject);
		}
		if (SceneManager.GetActiveScene ().name == "Nivel3") {
			Destroy (gameObject);
		}
	}

}
