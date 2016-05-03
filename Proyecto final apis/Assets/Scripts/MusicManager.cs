using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;	

public class MusicManager : MonoBehaviour {

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
		if (SceneManager.GetActiveScene ().name == "Menu") {
			Destroy (gameObject);
		}
		if (SceneManager.GetActiveScene ().name == "Nivel1Victory4") {
			Destroy (gameObject);
		}
		if (SceneManager.GetActiveScene ().name == "Nivel2Victory4") {
			Destroy (gameObject);
		}
		if (SceneManager.GetActiveScene ().name == "Nivel3Victory4") {
			Destroy (gameObject);
		}
	}

}
